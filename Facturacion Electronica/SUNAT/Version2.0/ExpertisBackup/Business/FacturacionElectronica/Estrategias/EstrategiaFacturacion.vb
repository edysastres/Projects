Public MustInherit Class EstrategiaFacturacion

    Public MustOverride Function CrearXML(ByVal documento As DocumentoFacturaVenta) As Boolean

    Public MustOverride Function Timbrar(ByVal EsCancelacion As Boolean) As Boolean

    Public MustOverride Function Cancelar(ByVal documento As DocumentoFacturaVenta) As Boolean

    Public MustOverride Function GetRespuesta() As String

    Public MustOverride Function GetRespuestaCancelacion() As String

    Public MustOverride Function RevisarCancelacion(ByVal documento As DocumentoFacturaVenta) As String

End Class
