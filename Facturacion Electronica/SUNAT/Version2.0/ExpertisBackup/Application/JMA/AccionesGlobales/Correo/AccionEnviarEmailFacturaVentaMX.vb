Public Class AccionEnviarEmailFacturaVentaMX
    Public Shared Sub EnviarEmail(ByVal ids As List(Of Integer))
        Dim correo As New AccionEnviarEmailMX
        correo.CampoID = "IDFactura"
        correo.CampoDocumento = "NFactura"
        correo.IDs.AddRange(ids)
        correo.OrigenDatos = "vJMADatosEmailFacturaVenta"
        'correo.ClaseDocumento = GetType(DocumentoFacturaVenta)
        correo.ClaseDocumento = GetType(FacturaVentaCabecera)
        correo.EnviarEmail()
    End Sub
End Class
