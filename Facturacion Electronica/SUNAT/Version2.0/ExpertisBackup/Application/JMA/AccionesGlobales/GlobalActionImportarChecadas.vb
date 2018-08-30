Public Class GlobalActionImportarChecadas
    'Implementación necesaria de la Interfaz de IAction del Motor de Expertis
    Implements Solmicro.Expertis.Engine.IAction


    ''' <summary>
    ''' El método Execute es invocado al seleccionar un usuario la Acción Global.
    ''' No tiene disponible más procesos ni funciones la interfaz IAction
    ''' </summary>
    ''' <param name="entityName">Nombre de la Entidad que ha llamado a la acción Global</param>
    ''' <param name="programID">GUID del Programa que ha llamado a la acción Global</param>
    ''' <param name="record">Registro completo del formulario que ha llamado a la Acción Global</param>
    ''' <remarks></remarks>
    Public Sub Execute(ByVal entityName As String, ByVal programID As System.Guid, ByVal record As System.Data.DataTable) Implements Solmicro.Expertis.Engine.IAction.Execute
        Dim DtRegistro As New DataTable()
        DtRegistro.Columns.Add("IDLinea", GetType(Integer))
        DtRegistro.Columns.Add("IDOperario", GetType(String))
        DtRegistro.Columns.Add("FechaRegistro", GetType(Date))
        DtRegistro.Columns.Add("HoraRegistro", GetType(DateTime))
        DtRegistro.Columns.Add("TipoRegistro", GetType(Boolean))
        DtRegistro.Columns.Add("MotivoAusencia", GetType(String))
        DtRegistro.Columns.Add("FechaCreacionAudi", GetType(DateTime))
        DtRegistro.Columns.Add("FechaModificacionAudi", GetType(DateTime))
        DtRegistro.Columns.Add("UsuarioAudi", GetType(String))
        'Dim OpenFileDialog As New Windows.Forms.OpenFileDialog()
        'Dim Archivo As String = ""

        'OpenFileDialog.InitialDirectory = "C:\"
        'OpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        'OpenFileDialog.FilterIndex = 2
        'OpenFileDialog.RestoreDirectory = True


        'ExpertisApp.GenerateMessage("El Ahchivo debe de tener el siguiente formato por Linea(0,20171101,050200,3,12,?,40,40,40,40,40) En total 39 Caracteres y salto de Linea, ", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation)

        'If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Archivo = OpenFileDialog.FileName()
        'End If


        'Dim Parametros As New ClsChecador.ParametrosImportarChecadas()
        'Parametros.Ruta = Archivo

        '''''' Procediminto para meter las chacadas a tbcontrolprecencia 
        'ExpertisApp.ExecuteTask(Of ClsChecador.ParametrosImportarChecadas)(AddressOf ClsChecador.ImportarChecadas, Parametros)

        '''''' Procediminto para meter las checadas ya Calculadas a tbJMACalenrarioOperario
        'ExpertisApp.ExecuteTask(Of ClsChecador)(AddressOf ClsChecador.ValidarChecadas, Nothing)

        ''''' Procediminto para re validar las chacadas segunda validacion poner la Falta
        'ExpertisApp.ExecuteTask(Of ClsChecador)(AddressOf ClsChecador.ReValidarChecadas, Nothing)

        'Dim Dr

        Dim ofd As New OpenFileDialog()
        Dim filePath As String = String.Empty
        ofd.InitialDirectory = "C:\"
        ofd.Title = "Abrir archivo de registros de asistencias..."
        ofd.FileName = "registros.txt"

        ofd.CheckFileExists = True
        ofd.CheckPathExists = True

        ofd.DefaultExt = "txt"
        ofd.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de registro (*.log)|*.log|Todos los archivos (*.*)|*.*"
        ofd.FilterIndex = 1
        ofd.RestoreDirectory = True

        ofd.ReadOnlyChecked = True
        ofd.ShowReadOnly = True

        Dim Res As Boolean = True

        If (ofd.ShowDialog() = DialogResult.OK) Then
            filePath = ofd.FileName
            Dim line As String = String.Empty
            Dim file As New StreamReader(filePath)
            line = file.ReadLine()
            Dim cont As Integer = 0
            While (Not line = Nothing)
                If (line.Length > 0) Then
                    Try
                        Dim empleado As String = line.Substring(20, 2)
                        Dim d As New DateTime(Integer.Parse(line.Substring(2, 4)), Integer.Parse(line.Substring(6, 2)), Integer.Parse(line.Substring(8, 2)), Integer.Parse(line.Substring(11, 2)), Integer.Parse(line.Substring(13, 2)), Integer.Parse(line.Substring(15, 2)))
                        Dim auxDate As New DateTime(d.Year, d.Month, d.Day, 0, 0, 0)
                        DtRegistro.Rows.Add(Nothing, Integer.Parse(empleado), auxDate, d, True, DBNull.Value, DateTime.Now, DateTime.Now, DBNull.Value)

                        Dim oRegistroLog = New ClsChecador.RegistroLog()
                        oRegistroLog.IDOperario = empleado
                        oRegistroLog.FechaRegistro = auxDate
                        oRegistroLog.HoraRegistro = d

                        ExpertisApp.ExecuteTask(Of ClsChecador.RegistroLog)(AddressOf ClsChecador.ExtraerRegistrosLog, oRegistroLog)
                        cont = cont + 1
                    Catch ex As Exception
                        ApplicationService.GenerateError("El archivo seleccionado no se encuentra en el formato requerido, favor de verificarlo.")
                        Res = False
                    End Try
                End If
                line = file.ReadLine()
                If (line = Nothing) Then
                    Try
                        line = file.ReadLine()
                    Catch ex As Exception

                    End Try
                End If
            End While
        Else
            Res = False
        End If

        If (Res) Then
            ExpertisApp.GenerateMessage("Los registros se importaron exitosamente a la base de datos.", "Registros importados", MessageBoxButtons.OK, MessageBoxIcon.Information, New Object())
        End If

        ''''' Procediminto para meter las checadas ya Calculadas a tbJMACalenrarioOperario
        ExpertisApp.ExecuteTask(Of ClsChecador)(AddressOf ClsChecador.ValidarChecadas, Nothing)

        '''' Procediminto para re validar las chacadas segunda validacion poner la Falta
        'ExpertisApp.ExecuteTask(Of ClsChecador)(AddressOf ClsChecador.ReValidarChecadas, Nothing)

    End Sub

End Class