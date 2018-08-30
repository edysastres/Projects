Imports Janus.Windows.GridEX
Imports RecogSys.RdrAccess

Public Class GrdMntoControlPresencia
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
#Region "Botones"

    Private Sub Grid_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        Select Case e.Column.Key
            Case "BtnChecadas"
                If Me.RecordsState = Solmicro.Expertis.Engine.UI.RecordsState.Saved Then
                    If Me.Grid.Row <> -1 Then
                        'If Me.Grid.Row = 0 Then
                        Dim frmDetalleChecadas As New FrmChecadas
                        frmDetalleChecadas.DrPersonaFecha = CType(Me.Grid.GetRow.DataRow, DataRowView).Row
                        frmDetalleChecadas.ShowDialog()
                        'End If
                    End If
                End If
        End Select
    End Sub


    Private Sub Grid_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellUpdated

        Dim BancoHoras As Double
        Dim HorasExtra As Double
        Dim BancoHorasReal As Double
        Dim HorasExtraReal As Double
        Dim Total As Double

        Total = Grid.CurrentRow.DataRow.row("BancoHoras") + Grid.CurrentRow.DataRow.row("HorasExtra")

        Select Case e.Column.Key
            Case "HorasExtra"
                BancoHoras = Grid.CurrentRow.DataRow.row("BancoHoras")
                HorasExtraReal = Grid.CurrentRow.DataRow.row("HorasExtra")
                HorasExtra = Grid.GetRow.Cells.Item("HorasExtra").Text
                If BancoHoras <= 0 And Total <= 0 Then
                    ExpertisApp.GenerateMessage("No Tienes Banco de Horas")
                    Grid.GetRow.Cells.Item("HorasExtra").Text = HorasExtraReal
                    Exit Select
                End If
                If BancoHoras < (HorasExtra - HorasExtraReal) Then
                    ExpertisApp.GenerateMessage("La Cantidad que Quieres mover No Cuadra con el Banco De Horas")
                    Grid.GetRow.Cells.Item("HorasExtra").Text = HorasExtraReal
                    Exit Select
                End If
                If BancoHoras >= (HorasExtra - HorasExtraReal) Then
                    Grid.CurrentRow.DataRow.row("BancoHoras") = BancoHoras - (HorasExtra - HorasExtraReal)
                    If HorasExtra = 0 Then
                        Grid.CurrentRow.DataRow.row("TipoRegistro") = "BH+"
                    Else
                        Grid.CurrentRow.DataRow.row("TipoRegistro") = "EX"
                    End If

                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'Case "BancoHoras"
                '    HorasExtra = Grid.CurrentRow.DataRow.row("HorasExtra")
                '    BancoHorasR = Grid.CurrentRow.DataRow.row("BancoHoras")
                '    BancoHoras = Grid.GetRow.Cells.Item("BancoHoras").Text
                '    If HorasExtra <= 0 Then
                '        ExpertisApp.GenerateMessage("No Tienes Horas Extras")
                '        Grid.GetRow.Cells.Item("BancoHoras").Text = BancoHorasR
                '        Exit Sub
                '    End If
                '    If BancoHoras > HorasExtra Then
                '        ExpertisApp.GenerateMessage("La Cantidad que Quieres mover No Cuadra con las Horas extras")
                '        Grid.GetRow.Cells.Item("BancoHoras").Text = BancoHorasR
                '        Exit Sub
                '    End If
                '    If BancoHoras <= HorasExtra Then
                '        Grid.CurrentRow.DataRow.row("HorasExtra") = HorasExtra - BancoHoras
                '        Grid.CurrentRow.DataRow.row("TipoRegistro") = "BH+"
                '    End If
        End Select
    End Sub
#End Region

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

#Region "Load"

    Public Shared Network As CRsiNetwork
    Public Shared Device As CRsiHandReader
    Public Shared Com As CRsiComWinsock

    Private Sub GrdMntoControlPrecencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
        '''''' Recalcular las entradas y salidas
        ExpertisApp.ExecuteTask(Of ClsChecador)(AddressOf ClsChecador.ValidarChecadas, Nothing)
        '''' Procediminto para re validar las chacadas segunda validacion poner la Falta
        '''' ExpertisApp.ExecuteTask(Of ClsChecador)(AddressOf ClsChecador.ReValidarChecadas, Nothing)
        Dim EntPendientes As New ControlAsistenciasPendientes
        Dim f As New Filter
        Dim DtPendientes As DataTable = EntPendientes.Filter(f)
        If (DtPendientes.Rows.Count > 0) Then
            If (New FrmRegistrosPendientes().ShowDialog() = Windows.Forms.DialogResult.OK) Then
                ExpertisApp.GenerateMessage("Los registros de los operarios activos fueron movidos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub LoadData()
        Dim F As New Filter
        Dim DtDatos = New DataEngine().RetrieveData("vJMATipoRegistro", "TipoRegistro,Tipo,DescTipoRegistro", F)
        Dim dropTipoRegistro As New GridEXDropDown
        dropTipoRegistro.SetDataBinding(DtDatos, String.Empty)
        dropTipoRegistro.DisplayMember = "TipoRegistro"
        dropTipoRegistro.ValueMember = "TipoRegistro"
        dropTipoRegistro.RetrieveStructure()
        Grid.Columns("TipoRegistro").EditType = EditType.MultiColumnCombo
        Grid.Columns("TipoRegistro").DropDown = dropTipoRegistro
        Conectar()
        ExtraerRegistrosChecador()
        Desconectar()
    End Sub

    Public Shared Sub Conectar()
        Try
            Network = New CRsiNetwork
            Device = New CRsiHandReader
            Com = New CRsiComWinsock
            If (Com.GetPort() <> 3001) Then
                Com.SetPortA(3001)
            End If
            Com.SetHost(New GrdMntoControlPresencia().RetrieveParameter("JMA_IPCHE", True))
            Network.SetCom(Com)
            If Com.Connect() = 0 Then
                Com.Disconnect()
                Com.ResetSocket()
                Com.Connect()
            End If
            Network.SetNetworkName("TCP/IP")
            If Network.IsConnected() = 0 Then
                Throw New Exception("No existe una conexión con el dispositivo.")
            End If
            Network.Attach(Device)
            Device.SetAddress(0)
            Device.SetName("HandPunch 2000")
            Device.CmdBeep(50, 3)
            If Device.IsConnected() = 0 Then
                Desconectar()
                Throw New Exception("Dispositivo desconectado")
            End If
        Catch ex As Exception
            ApplicationService.GenerateError(ex.Message)
        End Try
    End Sub

    Public Shared Sub Desconectar()
        Com.Disconnect()
        If Not Network.Equals(Nothing) Then
            Network.SetCom(Nothing)
            Network.Dispose()
            Network = Nothing
        End If
        If Not Com.Equals(Nothing) Then
            Com.Dispose()
            Com = Nothing
        End If
    End Sub

    Public Shared Sub ExtraerRegistrosChecador()
        Dim data As New RSI_DATALOG
        Dim done As Boolean = False
        Dim cont As Integer = 0
        Dim DtNuevosRegistros As New DataTable
        Dim DtPendientes As New DataTable
        DtNuevosRegistros.Columns.Add("IDControlPresencia", GetType(Long))
        DtNuevosRegistros.Columns.Add("IDOperario", GetType(String))
        DtNuevosRegistros.Columns.Add("Fecha", GetType(DateTime))
        DtNuevosRegistros.Columns.Add("Hora", GetType(DateTime))
        DtNuevosRegistros.Columns.Add("Entrada", GetType(Boolean))
        DtNuevosRegistros.Columns.Add("MotivoAusencia", GetType(String))

        While Not done
            Device.CmdGetDatalog(data)
            Dim year As Integer = Integer.Parse(data.pTimestamp.year.ToString()) + (DateTime.Now.Year - Integer.Parse(data.pTimestamp.year.ToString()))
            Dim month As Integer = Integer.Parse(data.pTimestamp.month.ToString())
            Dim day As Integer = Integer.Parse(data.pTimestamp.day.ToString())
            Dim hour As Integer = Integer.Parse(data.pTimestamp.hour.ToString())
            Dim minute As Integer = Integer.Parse(data.pTimestamp.minute.ToString())
            Dim second As Integer = Integer.Parse(data.pTimestamp.second.ToString())
            Dim employee As String = data.pOperand.GetID().Substring(data.pOperand.GetID().Length - 3)

            If day = 0 Then
                done = True
            End If

            If Not done Then
                Dim d As New DateTime(year, month, day, hour, minute, second)
                Dim auxDate As DateTime = New DateTime(d.Year, d.Month, d.Day, 0, 0, 0)
                If (data.format = RSI_DATALOG_FORMAT.RSI_DLF_IDENTITY_VERIFIED) Then
                    DtNuevosRegistros.Rows.Add(Nothing, employee, auxDate, d, Nothing, String.Empty)
                    Dim Registro As New Expertis.Business.AltunaMX.ControlPresenciaExt.RegistroAsistencia(DtNuevosRegistros.Rows(cont))
                    ExpertisApp.ExecuteTask(Of Expertis.Business.AltunaMX.ControlPresenciaExt.RegistroAsistencia)(AddressOf ControlPresenciaExt.ImportarChecadas, Registro)
                    cont += 1
                End If
            End If
        End While

    End Sub

    Private Function RetrieveParameter(ByVal IDParametro As String, ByVal MostrarMensaje As Boolean) As String
        Dim res As String = String.Empty
        Dim dt As DataTable = New Parametro().SelOnPrimaryKey(IDParametro)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            res = dt.Rows(0)("Valor") & String.Empty
        Else
            If MostrarMensaje Then
                ApplicationService.GenerateError("El parámetro {0} no existe", IDParametro)
            End If
        End If
        Return res
    End Function

#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class