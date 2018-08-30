Imports System.Text

Public Class GlobalActionExpPedidoCompra
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

        If ExpertisApp.IsFormOpen("MPEDC") Then

            Dim idPedido As String = record.Rows(0)("idPedido").ToString
            Dim Pedido As String = record.Rows(0)("Npedido")
            Pedido = Pedido.Replace("/", "-")

            Dim strViewName As String = "vJMAExpPedidoCompra"
            Dim oFltr As New Filter
            oFltr.Add(New StringFilterItem("idPedido", FilterOperator.Equal, idPedido))

            Dim dtLineas As DataTable
            dtLineas = New BE.DataEngine().Filter(strViewName, oFltr, , "IDArticuloPadre")

            For i As Integer = 0 To dtLineas.Rows.Count - 1
                dtLineas.Rows(i)(0) = 0
            Next

            '''''''''Exportacion 
            Dim TEX As Object
            Dim Archivo As Object
            TEX = CreateObject("Scripting.FileSystemObject")
            '''Archivo = TEX.CreateTextFile("C:\Users\ea.guevara\Desktop\Importar.txt", True)
            Archivo = TEX.CreateTextFile(My.Computer.FileSystem.SpecialDirectories.Desktop + "\" + "Importar_" + Pedido.ToString + ".txt", True)

            For i As Integer = 0 To dtLineas.Rows.Count - 1
                Archivo.Writeline(dtLineas.Rows(i)(0).ToString + "," + dtLineas.Rows(i)(1).ToString + "," + dtLineas.Rows(i)(2).ToString + "," + CInt(dtLineas.Rows(i)(3).ToString).ToString)
            Next

            ExpertisApp.GenerateMessage("Archivo Generado Correctamente en el  Escritorio")

        End If
    End Sub

End Class