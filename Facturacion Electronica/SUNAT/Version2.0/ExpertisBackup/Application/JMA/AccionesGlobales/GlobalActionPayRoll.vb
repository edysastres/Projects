Public Class GlobalActionPayRoll
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

        Dim FrmAsignarTurnos As New FrmPayRoll()
        FrmAsignarTurnos.ShowDialog()

    End Sub

End Class