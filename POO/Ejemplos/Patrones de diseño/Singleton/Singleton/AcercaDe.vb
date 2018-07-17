Public Class AcercaDe

    Private Shared _intancia As AcercaDe = Nothing

    Public Shared Function GetInstancia() As AcercaDe
        If _intancia Is Nothing OrElse _intancia.IsDisposed Then
            _intancia = New AcercaDe
        End If
        Return _intancia
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class