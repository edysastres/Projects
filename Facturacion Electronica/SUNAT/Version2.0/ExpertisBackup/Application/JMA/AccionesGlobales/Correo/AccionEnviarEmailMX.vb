Imports System.Threading

Public Class AccionEnviarEmailMX

    Private mCampoID As String
    Public Property CampoID() As String
        Get
            Return mCampoID
        End Get
        Set(ByVal value As String)
            mCampoID = value
        End Set
    End Property

    Private mCampoDocumento As String
    Public Property CampoDocumento() As String
        Get
            Return mCampoDocumento
        End Get
        Set(ByVal value As String)
            mCampoDocumento = value
        End Set
    End Property

    Private mIDs As List(Of Integer)
    Public ReadOnly Property IDs() As List(Of Integer)
        Get
            Return mIDs
        End Get
    End Property

    Private mOrigenDatos As String
    Public Property OrigenDatos() As String
        Get
            Return mOrigenDatos
        End Get
        Set(ByVal value As String)
            mOrigenDatos = value
        End Set
    End Property

    Private mClaseDocumento As System.Type
    Public Property ClaseDocumento() As System.Type
        Get
            Return mClaseDocumento
        End Get
        Set(ByVal value As System.Type)
            mClaseDocumento = value
        End Set
    End Property

    Public Sub New()
        mIDs = New List(Of Integer)
    End Sub

    Private mThread1 As Thread
    Private mProcesoEnCurso As frmProcesoEnCurso

    Public Sub EnviarEmail()
        Dim errores1 As New List(Of ClassErrors)
        Dim lista_ficheros As New List(Of String)

        mThread1 = New Thread(AddressOf ProcesoEnCurso)
        mThread1.Start(ExpertisApp.Traslate("Generando informes para los documentos"))

        Dim data_engine As New DataEngine
        Dim emails As New List(Of DatosEmailMX)
        Try
            For Each ID As Integer In mIDs
                Dim datos As DataTable = data_engine.Filter(mOrigenDatos, New NumberFilterItem(mCampoID, ID))

                If datos.Rows.Count > 0 Then

                    Dim NDocumento As String = datos.Rows(0)(mCampoDocumento)

                    Dim objFactura = New DocumentoFacturaVenta(ID)
                    Dim header As DataRow = objFactura.HeaderRow

                    If Length(datos.Rows(0)("IDContador")) > 0 Then

                        Dim IDContador As String = datos.Rows(0)("IDContador")

                        Dim dtCli As DataTable = New Cliente().SelOnPrimaryKey(datos.Rows(0)("IDCliente"))
                        Dim strAsunto As String
                        Dim strMensaje As String
                      
                        strAsunto = datos.Rows(0)("Asunto")
                        strMensaje = datos.Rows(0)("Cuerpo")
                        Dim informes As DataTable = data_engine.Filter("vJMAfrmContadorReport", New StringFilterItem("IDContador", IDContador)) 'New JMAContadorReport().Filter(New StringFilterItem("IDContador", IDContador))
                        If informes.Rows.Count > 0 Then
                            If Length(datos.Rows(0)("Email")) = 0 Then
                                Dim [error] As New ClassErrors
                                [error].Elements = NDocumento
                                [error].MessageError = String.Format("El cliente {0} no tiene Email.", datos.Rows(0)("IDCliente"))
                                errores1.Add([error])
                            ElseIf Length(strAsunto) = 0 Then
                                Dim [error] As New ClassErrors
                                [error].Elements = NDocumento
                                [error].MessageError = String.Format("No hay definido un asunto para el contador {0}.", IDContador)
                                errores1.Add([error])
                            Else

                                Dim email As New DatosEmailMX
                                email.IDDocumento = ID
                                email.NumeroDocumento = NDocumento
                                email.ListaDestinatarios.Add(datos.Rows(0)("Email"))

                                Dim datos_formateo As New ParametrosFormatearTexto
                                datos_formateo.Valores = datos.Copy()

                                '//asunto
                                datos_formateo.Texto = strAsunto
                                email.Asunto = GestorCorreoMX.FormatearTexto(datos_formateo)
                                '//texto
                                datos_formateo.Texto = strMensaje
                                email.Mensaje = GestorCorreoMX.FormatearTexto(datos_formateo)

                                '//ficheros adjuntos
                                For Each informe As DataRow In informes.Rows
                                    Dim [alias] As String
                                    Dim DtRpt As DataTable
                                    If Not IsDBNull(informe("TipoDocumento")) AndAlso Length(informe("TipoDocumento")) > 0 Then
                                        If dtCli.Rows.Count > 0 AndAlso Not IsDBNull(dtCli.Rows(0)("IDIdioma")) Then
                                            Dim f As New Filter
                                            f.Add("IDIdioma", FilterOperator.Equal, dtCli.Rows(0)("IDIdioma"))
                                            f.Add("TipoDocumento", FilterOperator.Equal, informe("TipoDocumento"))
                                            DtRpt = New JMAFormatoDocumento().Filter(f)
                                            If DtRpt.Rows.Count = 0 OrElse IsDBNull(DtRpt.Rows(0)("Formato")) Then
                                                Dim fPred As New Filter
                                                fPred.Add("Predeterminado", FilterOperator.Equal, True)
                                                fPred.Add("TipoDocumento", FilterOperator.Equal, informe("TipoDocumento"))
                                                DtRpt = New JMAFormatoDocumento().Filter(fPred)
                                            End If
                                        Else
                                            Dim fPred As New Filter
                                            fPred.Add("Predeterminado", FilterOperator.Equal, True)
                                            fPred.Add("TipoDocumento", FilterOperator.Equal, informe("TipoDocumento"))
                                            DtRpt = New JMAFormatoDocumento().Filter(fPred)
                                        End If
                                        If DtRpt.Rows.Count > 0 Then
                                            [alias] = DtRpt.Rows(0)("Formato")
                                        Else
                                            Dim report As DataTable = New BE.DataEngine().Filter("xReport", New GuidFilterItem("IDInforme", informe("IDReport")), , , , True)
                                            If report.Rows.Count > 0 Then
                                                [alias] = report.Rows(0)("Alias")
                                            End If
                                        End If
                                    Else
                                        Dim report As DataTable = New BE.DataEngine().Filter("xReport", New GuidFilterItem("IDInforme", informe("IDReport")), , , , True)
                                        If report.Rows.Count > 0 Then
                                            [alias] = report.Rows(0)("Alias")
                                        End If
                                    End If
                                    If Length([alias]) > 0 Then
                                        Dim foldername As String = NDocumento.Replace("/", "-")
                                        If Length(informe("NombreFicheroAdjunto")) > 0 Then
                                            foldername = String.Format("{0}-{1}", informe("NombreFicheroAdjunto"), foldername)
                                        End If
                                        'filename = IO.Path.ChangeExtension(filename, ExportToDiskFileOptions.PDFExtension)

                                        Dim rpt As New Report([alias])
                                        If rpt.ReportType = ReportType.AssistantTable Then
                                            'If mClaseDocumento Is GetType(PedidoVentaCabecera) Then
                                            '    Dim auxTable As New ReportAuxiliarTable("PedidoVentaCabecera")
                                            '    auxTable.DataSource = New PedidoVentaCabecera().SelOnPrimaryKey(ID)
                                            '    rpt.DataSource = auxTable
                                            'ElseIf mClaseDocumento Is GetType(AlbaranVentaCabecera) Then
                                            '    Dim auxTable As New ReportAuxiliarTable("AlbaranVentaCabecera")
                                            '    auxTable.DataSource = New AlbaranVentaCabecera().SelOnPrimaryKey(ID)
                                            '    rpt.DataSource = auxTable
                                            'Else
                                            If mClaseDocumento Is GetType(FacturaVentaCabecera) Then
                                                Dim auxTable As New ReportAuxiliarTable("FacturaVentaCabecera")
                                                auxTable.DataSource = New FacturaVentaCabecera().SelOnPrimaryKey(ID)
                                                rpt.DataSource = auxTable
                                            End If
                                        Else
                                            rpt.Filter.Add(New NumberFilterItem(mCampoID, ID))
                                        End If

                                        Dim empresa As DataRow = New Solmicro.Expertis.Business.Negocio.DatosEmpresa().SelOnPrimaryKey(1).Rows(0)
                                        Dim contador As DataRow = New Contador().SelOnPrimaryKey(header("IDContador")).Rows(0)
                                        Dim NFactura As String = header("NFactura")
                                        Dim IDContadorF As String = contador("Texto")
                                        Dim correlativo As String = NFactura.Substring(IDContadorF.Length)
                                        'Filename:   RUC-<Tipo de comprobante(01 - Factura)>-<Serie F###>-<Numero Correlativo ########>.XML
                                        Dim groupFileName As String = String.Empty

                                        If IDContador.Contains("FACTURA") Then
                                            groupFileName = empresa("Cif") + "-" + "01" + "-" + "F" + header("IDCentroGestion") + "-" + correlativo
                                        ElseIf IDContador.Contains("BOLETA") Then
                                            groupFileName = empresa("Cif") + "-" + "03" + "-" + "B" + header("IDCentroGestion") + "-" + correlativo
                                        ElseIf IDContador.Contains("NTCREV") Then
                                            groupFileName = empresa("Cif") + "-07-" + ObtenerTipoDocumento(header("IDFacturaRectificada")) + header("IDCentroGestion") + "-" + ObtenerNoFactura(header("NFactura"))
                                        End If

                                        Dim xmlFileNameWithExtension = groupFileName + ".XML"
                                        'Dim filepath As String = IO.Path.Combine(ExpertisApp.ExecuteTask(Of Object, String)(AddressOf JMAParametro.DireccionDefectoInformes, Nothing), filename)

                                        Dim filePathApproved As String = JMAHelper.GetDocumentsPath(groupFileName, header("IDContador"), True, header("FechaTimbrado"))
                                        Dim filepathZip As String = filePathApproved + "\" + foldername

                                        If Not System.IO.Directory.Exists(filepathZip) Then
                                            Dim directoryInfo = System.IO.Directory.CreateDirectory(filepathZip)
                                        End If

                                        rpt.ExportOptions.ExportType = ReportExportDestinationType.DiskFile
                                        rpt.ExportOptions.FormatType = ReportExportFormatType.PDF
                                        rpt.ExportOptions.ExportToDiskFile.DiskFileName = filepathZip + "\" + foldername + ".pdf"
                                        ExpertisApp.OpenReport(rpt)

                                        If System.IO.File.Exists(filePathApproved + "\" + xmlFileNameWithExtension) Then
                                            System.IO.File.Move(filePathApproved + "\" + xmlFileNameWithExtension, filepathZip + "\" + foldername + ".xml")
                                        End If
                                        If System.IO.File.Exists(filePathApproved + "\" + "R-" + xmlFileNameWithExtension) Then
                                            System.IO.File.Move(filePathApproved + "\" + "R-" + xmlFileNameWithExtension, filepathZip + "\" + "R-" + foldername + ".xml")
                                        End If

                                        If System.IO.File.Exists(filepathZip + "\" + foldername + ".zip") Then
                                            System.IO.File.Delete(filepathZip + "\" + foldername + ".zip")
                                        End If
                                        JMAHelper.CompressDirectory(filepathZip, filepathZip, foldername + ".zip")

                                        'lista_ficheros.Add(filepath)

                                        email.FicherosAdjuntos.Add(filepathZip + "\" + foldername + ".zip")

                                    Else
                                        Dim [error] As New ClassErrors
                                        [error].Elements = NDocumento
                                        [error].MessageError = String.Format("El informe '{0}' no tiene alias.", informe("IDReport"))
                                        errores1.Add([error])
                                    End If
                                Next

                                emails.Add(email)
                            End If
                        Else
                            Dim [error] As New ClassErrors
                            [error].Elements = NDocumento
                            [error].MessageError = String.Format("El contador {0} no tiene asociado ningún informe.", IDContador)
                            errores1.Add([error])
                        End If

                    Else
                        Dim [error] As New ClassErrors
                        [error].Elements = NDocumento
                        [error].MessageError = String.Format("El pedido {0} no se ha generado con un contador.", NDocumento)
                        errores1.Add([error])
                    End If
                Else
                    Dim [error] As New ClassErrors
                    [error].Elements = ID
                    [error].MessageError = String.Format("El albaran no tiene datos.")
                    errores1.Add([error])
                End If
            Next

            If Not mThread1 Is Nothing AndAlso mThread1.IsAlive Then
                FinProceso()
            End If

        Catch ex As Exception
            If Not mThread1 Is Nothing AndAlso mThread1.IsAlive Then
                FinProceso()
            End If
            Dim [error] As New ClassErrors
            [error].Elements = ""
            If Not ex.InnerException Is Nothing Then
                [error].MessageError = ex.InnerException.Message
            Else
                [error].MessageError = ex.Message
            End If
            errores1.Add([error])
        End Try

        Try
            If emails.Count > 0 Then
                mThread1 = New Thread(AddressOf ProcesoEnCurso)
                mThread1.Start(ExpertisApp.Traslate("Enviando"))

                Try
                    Dim log As LogProcess = GestorCorreoMX.EnviarCorreos(emails)

                    Dim enviados As List(Of CreateElement) = log.CreatedElements.ToList()
                    Dim errores As List(Of ClassErrors) = log.Errors.ToList()
                    '//se añaden los errores previos que podia haber
                    errores.AddRange(errores1)

                    If enviados.Count > 0 Then
                        Dim ids_enviados As List(Of Integer) = (From element As CreateElement In enviados Select element.IDElement).ToList()

                        If mClaseDocumento Is GetType(PedidoVentaCabecera) Then
                            ExpertisApp.ExecuteTask(Of List(Of Integer))(AddressOf ExtensibilidadComercial.PedidosEnviadosEmail, ids_enviados)
                        ElseIf mClaseDocumento Is GetType(AlbaranVentaCabecera) Then
                            ExpertisApp.ExecuteTask(Of List(Of Integer))(AddressOf ExtensibilidadComercial.AlbaranesEnviadosEmail, ids_enviados)
                        ElseIf mClaseDocumento Is GetType(FacturaVentaCabecera) Then
                            ExpertisApp.ExecuteTask(Of List(Of Integer))(AddressOf ExtensibilidadComercial.FacturasEnviadosEmail, ids_enviados)
                        End If

                        If Not mThread1 Is Nothing AndAlso mThread1.IsAlive Then
                            FinProceso()
                        End If

                        If errores.Count > 0 Then
                            GestorCorreo.EscribirLogErrores(errores)
                            ExpertisApp.GenerateMessage("Algunos correos no han sido enviados al cliente. Consulte los errores en el fichero LogEnvioEmail.txt en el directorio de la aplicación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            ExpertisApp.GenerateMessage("Emails enviados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        GlobalInfo.ResultadoProceso = DialogResult.OK
                    Else
                        If Not mThread1 Is Nothing AndAlso mThread1.IsAlive Then
                            FinProceso()
                        End If

                        GlobalInfo.ResultadoProceso = DialogResult.Abort
                        GestorCorreo.EscribirLogErrores(errores)
                        ExpertisApp.GenerateMessage("Los emails no han sido enviados. Consulte los errores en el fichero LogEnvioEmail.txt en el directorio de la aplicación.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    If Not mThread1 Is Nothing AndAlso mThread1.IsAlive Then
                        FinProceso()
                    End If
                    Dim [error] As New ClassErrors
                    [error].Elements = "SMTP"
                    [error].MessageError = String.Format(ex.Message)
                    errores1.Add([error])
                    GestorCorreo.EscribirLogErrores(errores1)
                    Throw ex
                End Try
            Else
                GlobalInfo.ResultadoProceso = DialogResult.Abort
                GestorCorreo.EscribirLogErrores(errores1)
                ExpertisApp.GenerateMessage("Los emails no han sido enviados. Consulte los errores en el fichero LogEnvioEmail.txt en el directorio de la aplicación.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            '//eliminar ficheros
            'For Each fichero In lista_ficheros
            '    If IO.File.Exists(fichero) Then
            '        IO.File.SetAttributes(fichero, IO.FileAttributes.Normal)
            '        IO.File.Delete(fichero)
            '    End If
            'Next
        End Try
    End Sub

    Public Sub ProcesoEnCurso(ByVal prompt As String)
        mProcesoEnCurso = New frmProcesoEnCurso
        mProcesoEnCurso.Prompt = prompt
        mProcesoEnCurso.ShowInTaskbar = True
        mProcesoEnCurso.ShowDialog()
    End Sub

    Private Delegate Sub DelegadoEstadoFinProceso()

    Private Sub FinProceso()
        If Not mProcesoEnCurso Is Nothing Then
            If mProcesoEnCurso.InvokeRequired Then
                Dim d As New DelegadoEstadoFinProceso(AddressOf FinProceso)
                mProcesoEnCurso.Invoke(d)
            Else
                mProcesoEnCurso.Close()
                mProcesoEnCurso.Dispose()
            End If
        End If
    End Sub

    Public Function ObtenerTipoDocumento(ByVal IDDocumento As String) As String
        Dim DrDocumento As DataRow = New FacturaVentaCabecera().SelOnPrimaryKey(IDDocumento).Rows(0)
        If Not IsNothing(DrDocumento) Then
            If (DrDocumento.ToString().Contains("FACTURA")) Then
                Return "F"
            ElseIf (DrDocumento.ToString().Contains("BOLETA")) Then
                Return "B"
            End If
        Else
            ApplicationService.GenerateError("El documento rectificado indicado por esta nota de crédito no es válido o no existe en la base de datos. Favor de comprobarlo")
        End If
    End Function

    Public Function ObtenerNoFactura(ByVal NFactura As String) As String
        Dim Chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ/\-_.:;"
        Dim i As Integer = 0
        Dim arr As Char() = NFactura.ToCharArray()
        Dim c As Char = "A"
        While (Chars.Contains(c))
            c = arr(i)
            i += 1
        End While
        Return NFactura.Substring(i - 1)
    End Function

End Class
