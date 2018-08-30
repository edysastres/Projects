Imports System.Xml

Public Class EstrategiaSAT
    Inherits EstrategiaFacturacion

    Public Overrides Function Cancelar(ByVal documento As DocumentoFacturaVenta) As Boolean
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo
        Return False
    End Function

    Public Overrides Function CrearXML(ByVal documento As DocumentoFacturaVenta) As Boolean
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo
        Return False
    End Function

    Public Overrides Function Timbrar(ByVal EsCancelacion As Boolean) As Boolean
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo
        Return False
    End Function

    Public Overrides Function GetRespuesta() As String
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo
        Return ""
    End Function

    Public Overrides Function GetRespuestaCancelacion() As String
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo
        Return ""
    End Function

    Public Overrides Function RevisarCancelacion(ByVal documento As DocumentoFacturaVenta) As String
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo
        Return ""
    End Function
End Class
