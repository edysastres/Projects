Public Class GridMntoClasifCostoPersonal

    Private Sub Grid_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        Select e.Column.Key
            Case "DefinirProrrateo"
                If Me.RecordsState = Solmicro.Expertis.Engine.UI.RecordsState.Saved AndAlso Me.Grid.Row <> -1 Then
                    Dim frm As New frmDefinirProrrateo
                    frm.DrProrrateo = CType(Me.Grid.GetRow.DataRow, DataRowView).Row
                    frm.ShowDialog()
                End If
        End Select
    End Sub

End Class