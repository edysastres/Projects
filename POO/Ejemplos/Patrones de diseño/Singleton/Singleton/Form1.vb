Public Class Form1

    Private Sub AcecaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcecaDeToolStripMenuItem.Click
        AcercaDe.GetInstancia.Show()
        AcercaDe.GetInstancia.BringToFront()
    End Sub


    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim FrmAcercaDe2 As New AcerdaDE2
        FrmAcercaDe2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        AcercaDe.GetInstancia.Show()
        AcercaDe.GetInstancia.BringToFront()
    End Sub
End Class




'Dim frmacescade As New AcercaDe
'frmacescade.Show()