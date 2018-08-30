Public Class FrmRegistrosPendientes

    Private DtRegistrosPendientes As DataTable

    Public WriteOnly Property DtRegistros() As DataTable
        Set(ByVal value As DataTable)
            Me.DtRegistrosPendientes = value
        End Set
    End Property

    Dim EntRegistros As ControlPresencia
    Dim EntPendientes As ControlAsistenciasPendientes
    Dim DtAsistencias, DtPendientes, DtPendientesRestantes, DtPendientesMigradas As DataTable

    Private Sub FrmRegistrosPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.activeControl.DataSource = New BE.DataEngine().Filter("vControlAsistenciasPendientes", New Filter())
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Ignore
    End Sub

    Private Sub btnMoverRegistros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoverRegistros.Click
        'TODO: Acciones de validación para migrar los registros de una tabla a otra.
        EntRegistros = New ControlPresencia() 'Objeto de entidad de control presencia
        EntPendientes = New ControlAsistenciasPendientes()
        DtAsistencias = EntRegistros.Filter(New Filter()) 'Obtiene la tabla tbControlPresencia
        DtPendientes = EntPendientes.Filter(New Filter()) 'Obtiene la tabla de Asistencias Pendientes
        DtPendientesRestantes = DtPendientes.Clone
        DtPendientesMigradas = DtAsistencias.Clone
        Dim IDOperario As String = String.Empty
        Dim f As New Filter()
        For Each row As DataRow In DtPendientes.Rows() 'Recorre cada registro de las asistencias pendientes
            f.Clear() 'Limpia el registro de filtros para evitar errores
            f.Add("NumeroNonima", FilterOperator.Equal, row("IDOperario")) 'Añade un filtro para encontrar el ID de Operario
            If (New BE.DataEngine().Filter("vJMAMntoOperario", f, "IDOperario").Rows.Count > 0) Then 'Usa el filtro especificado para encontrar los datos del operario
                IDOperario = New BE.DataEngine().Filter("vJMAMntoOperario", f, "IDOperario").Rows(0)(0) 'Encuentra y establece el IDOperario
            End If
            If Not IDOperario.Equals(String.Empty) Then 'Si el IDOperario no está vacío entra a las siguientes tareas de validación
                f.Clear() 'Limpia los filtros para evitar errores
                f.Add("IDOperario", FilterOperator.Equal, IDOperario) 'Filtro para obtener datos del IDOperario encontrado
                f.Add("Fecha", FilterOperator.Equal, row("Fecha")) 'Filtro para obtener solo los registros de la fecha especificada
                Dim DrTurnoDia As DataRow
                If (New CalendarioOperario().Filter(f).Rows.Count > 0) Then 'Si existen datos con dicho filtro en tbCalendarioOperario
                    DrTurnoDia = New CalendarioOperario().Filter(f).Rows(0) 'Busca los datos por día
                    If Not DrTurnoDia("IDTipoTurno").GetType.Equals(GetType(DBNull)) Then 'Si el turno asignado al día no es nulo entra a la siguiente parte
                        f.Clear() 'Vuelve a limpiar filtros
                        f.Add("IDOperario", FilterOperator.Equal, IDOperario) 'Agrega filtro para hacer coincidir el registro de IDOperario en la tabla de CtrlPresencia con el IDOperario del registro actual
                        f.Add("Fecha", FilterOperator.Equal, row("Fecha")) 'Agrega filtro para encontrar los registros de la fecha especificada
                        Dim DtAsistenciasDia As DataTable = EntRegistros.Filter(f) 'Obtiene los datos filtrados para determinar el tipo de registro
                        Dim TipoRegistro As Boolean = False
                        Dim entradas As Integer = 0
                        Dim salidas As Integer = 0
                        'Proceso para validar si el registro actual es entrada o salida
                        For Each r As DataRow In DtAsistenciasDia.Rows()
                            If (r("Entrada")) Then
                                entradas += 1
                            Else
                                salidas += 1
                            End If
                        Next
                        If (entradas > salidas) Then
                            TipoRegistro = False
                        ElseIf (entradas = salidas) Then
                            TipoRegistro = True
                        ElseIf (salidas > entradas) Then
                            TipoRegistro = True
                        End If
                        row("Entrada") = TipoRegistro 'Establece si es entrada o salida
                        row("IDOperario") = IDOperario 'Cambia el IDOperario por el existente
                        'INSERTAR EN LA ENTIDAD
                        DtPendientesMigradas.ImportRow(row)
                    Else
                        DtPendientesRestantes.ImportRow(row)
                    End If
                Else
                    DtPendientesRestantes.ImportRow(row)
                End If
            Else
                DtPendientesRestantes.ImportRow(row)
            End If
        Next
        Try
            For Each Row As DataRow In DtPendientesMigradas.Rows
                Dim Registro As New Expertis.Business.AltunaMX.ControlPresenciaExt.Asistencia(Row)
                ExpertisApp.ExecuteTask(Of Expertis.Business.AltunaMX.ControlPresenciaExt.Asistencia)(AddressOf Expertis.Business.AltunaMX.ControlPresenciaExt.ImportarRegistro, Registro) 'Tarea para insertar registro por registro las asistencias migradas
            Next
            EntPendientes.Validate(DtPendientesMigradas) 'Valida la tabla de asistencias pendientes migradas, pero ahora contra la entidad de Asistencias Pendientes, para posteriormente eliminar esos registros
            EntPendientes.Delete(DtPendientesMigradas) 'Elimina los registros migrados
            EntPendientes.Validate(DtPendientesRestantes) 'Valida las asistencias pendientes que no se pudieron migrar
            EntPendientes.Update(DtPendientesRestantes) 'Y las inserta
            Me.DialogResult = Windows.Forms.DialogResult.OK 'Termina el formulario y regresa el flujo a GrdMntoControlPresencia
        Catch ex As Exception
            ApplicationService.GenerateError("Hubo un error al importar los registros: " & ex.Message)
        End Try

    End Sub
End Class