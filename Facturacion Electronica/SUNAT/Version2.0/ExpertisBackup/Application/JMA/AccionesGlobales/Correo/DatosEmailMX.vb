Public Class DatosEmailMX
    Public IDDocumento As Integer
    Public NumeroDocumento As String
    Public ListaDestinatarios As List(Of String)
    Public ListaCC As List(Of String)
    Public ListaCCO As List(Of String)
    Public Asunto As String
    Public Mensaje As String
    Public FicherosAdjuntos As List(Of String)

    Public Sub New()
        ListaDestinatarios = New List(Of String)
        ListaCC = New List(Of String)
        ListaCCO = New List(Of String)
        FicherosAdjuntos = New List(Of String)
    End Sub
End Class
