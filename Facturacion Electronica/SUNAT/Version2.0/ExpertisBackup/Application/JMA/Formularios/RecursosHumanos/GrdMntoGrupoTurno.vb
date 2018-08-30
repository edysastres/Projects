Public Class GrdMntoGrupoTurno

#Region "Eventos Controles"

#Region "Eventos DataGrid"

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Select Case e.Column.Key
            Case "NGrupoTurno"
                If Me.Grid.Row <> Me.Grid.newTopRowPosition Then
                    e.Cancel = True
                End If
            Case "DiasTrabajo", "DiasDescanso", "HorasTrabajadasDia", "NumeroCiclos"
                If Not Me.Grid.GetValue("Rotativo") Then
                    e.Cancel = True
                End If
        End Select
    End Sub

    Private Sub Grid_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord
        If Length(Me.Grid.GetValue("NGrupoTurno")) > 0 Then
            Dim IntGrupo As Integer = (From Dr As DataRow In CType(Me.Grid.DataSource, DataTable).Rows _
                                       Where Dr("NGrupoTurno") = Me.Grid.GetValue("NGrupoTurno")).Count
            If IntGrupo > 0 Then
                ExpertisApp.GenerateMessage("El grupo turno | ya existe en la base de datos.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation, Me.Grid.GetValue("NGrupoTurno"))
                e.Cancel = True
            End If
        Else
            ExpertisApp.GenerateMessage("El grupo turno es un dato obligatorio", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub Grid_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        Select Case e.Column.Key
            Case "BtnDetalle"
                If Me.RecordsState = Solmicro.Expertis.Engine.UI.RecordsState.Saved Then
                    If Me.Grid.Row <> -1 Then
                        'If Me.Grid.Row = 0 Then
                        Dim frmDetalle As New frmGrupoTurnoLinea
                        frmDetalle.DrGrupoTurno = CType(Me.Grid.GetRow.DataRow, DataRowView).Row
                        frmDetalle.ShowDialog()
                        'End If
                    End If

                End If
        End Select
    End Sub

#End Region

#End Region


End Class