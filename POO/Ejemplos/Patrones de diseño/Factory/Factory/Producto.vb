
'*************** PRODUCT
Public Interface IMoto

    Function getRuedas() As Integer

End Interface

'************** CONCRETE PRODUCT

'clase AQUAMOTO
Public Class MotoAgua
    Implements IMoto

    'atributo
    Public ruedas As Integer

    'constructor
    Public Sub New(ByVal ruedas As Integer)
        Me.ruedas = ruedas
    End Sub

    'metodo por implementar de la interfaz
    Public Function getRuedas() As Integer Implements IMoto.getRuedas
        Return Me.ruedas
    End Function
End Class

'clase MOTOCROSS
Public Class MotoCampo
    Implements IMoto

    'atributo
    Public ruedas As Integer

    'constructor
    Public Sub New(ByVal ruedas As Integer)
        Me.ruedas = ruedas
    End Sub

    'metodo por implementar de la interfaz
    Public Function getRuedas() As Integer Implements IMoto.getRuedas
        Return Me.ruedas
    End Function
End Class

