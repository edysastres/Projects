'CREATOR
Public Interface IFactory
    Function CreaMoto(ByVal tipo As String, ByVal ruedas As Integer) As IMoto

End Interface

'CONCRETE CREATOR
Public Class FactoryImp
    Implements IFactory


    Public AGUA As String = "agua"
    Public CAMPO As String = "campo"

    Public Function CreaMoto(ByVal tipo As String, ByVal ruedas As Integer) As IMoto Implements IFactory.CreaMoto
        Select Case tipo
            Case AGUA
                Return New MotoAgua(ruedas)
            Case CAMPO
                Return New MotoCampo(ruedas)
            Case Else
                Return Nothing
        End Select
    End Function
End Class

