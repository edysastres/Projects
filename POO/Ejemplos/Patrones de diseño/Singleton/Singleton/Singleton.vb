Public Class Singleton

    Private Shared _instancia As Singleton

    Public Sub New()

    End Sub

    Public Shared ReadOnly Property Instancia() As Singleton
        Get
            If _instancia Is Nothing Then
                _instancia = New Singleton
            End If
            Return _instancia
        End Get
    End Property
End Class
