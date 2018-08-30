Public Class frmGrupoTurnoLinea

#Region "Propiedades Públicas"

    Private mDrGrupoTurno As DataRow

    Public WriteOnly Property DrGrupoTurno() As DataRow
        Set(ByVal value As DataRow)
            mDrGrupoTurno = value
        End Set
    End Property

#End Region

#Region "Procesos/Funciones Privadas"

    Private Sub LoadData()
        If Not mDrGrupoTurno Is Nothing Then
            Me.TxtGrupoTurno.Text = Me.mDrGrupoTurno("NGrupoTurno")
            Me.ULblDescGrupoTurno.Text = Nz(Me.mDrGrupoTurno("DescGrupoTurno"), String.Empty)
            'Me.GrdGrupoTurnoLinea.DataSource = New BE.DataEngine().Filter("vJMAGrupoTurnoLinea", New FilterItem("NGrupoTurno", FilterOperator.Equal, Me.mDrGrupoTurno("NGrupoTurno")))
            'CType(Me.GrdGrupoTurnoLinea.DataSource, DataTable).TableName = "JMAGrupoTurnoLinea"
            Me.GrdGrupoTurnoLinea.ReQuery(New FilterItem("NGrupoTurno", FilterOperator.Equal, Me.mDrGrupoTurno("NGrupoTurno")))
            Me.GrdGrupoTurnoLinea.Columns("NGrupoTurno").DefaultValue = Me.mDrGrupoTurno("NGrupoTurno")
            'EnumData.PopulateValueList("enumJMADiaSemana", Me.GrdGrupoTurnoLinea.Columns("DiaSemana"))
            Me.GrdGrupoTurnoLinea.Columns("DiaSemana").DropDown.SetDataBinding(EnumData.EnumView("enumJMADiaSemana"), Nothing)
        End If
    End Sub

#End Region

#Region "Eventos Controles"

#Region "Eventos Formulario"

    Private Sub frmGrupoTurnoLinea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
    End Sub

#End Region

#Region "Eventos Botones"

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        SaveData()

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub SaveData()
        Dim EntGrpTurLin As New JMAGrupoTurnoLinea

        ''''''' Actualizacion
        Dim DtAddUpd As DataTable = CType(Me.GrdGrupoTurnoLinea.DataSource, DataTable).GetChanges(DataRowState.Added Or DataRowState.Modified)
        If Not DtAddUpd Is Nothing Then
            If DtAddUpd.Rows.Count > 0 Then
                EntGrpTurLin.Validate(DtAddUpd)
                EntGrpTurLin.Update(DtAddUpd)
            End If
        End If


        ''''''''''''  NOTA COMENTARIO
        ''''''''''''  No borra 
        Dim DtDel As DataTable = CType(Me.GrdGrupoTurnoLinea.DataSource, DataTable).GetChanges(DataRowState.Deleted)
        If Not DtDel Is Nothing Then
            If DtDel.Rows.Count > 0 Then
                DtDel.RejectChanges()
                'DtDel.Columns.Remove("DescTipoTurno")
                'GrdGrupoTurnoLinea.Columns.Remove("DescTipoTurno")
                EntGrpTurLin.Delete(DtDel)
            End If
        End If

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region



#Region "Eventos DataGrid"

    '''''' Validar que no Metan Dias Repetidos
    Private Sub GrdGrupoTurnoLinea_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdGrupoTurnoLinea.AddingRecord
        Dim IntDias As Integer = (From Dr As DataRow In CType(Me.GrdGrupoTurnoLinea.DataSource, DataTable).Rows _
                                  Where Dr("DiaSemana") = Me.GrdGrupoTurnoLinea.GetValue("DiaSemana")).Count
        If IntDias > 0 Then
            ExpertisApp.GenerateMessage("El día de la semana | ya existe en el desglose del turno.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation, Me.GrdGrupoTurnoLinea.GetValue("DiaSemana"))
            e.Cancel = True
        End If
    End Sub

    ''''''' Validar que si pongan un dia de la semana
    Private Sub GrdGrupoTurnoLinea_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GrdGrupoTurnoLinea.EditingCell
        Select Case e.Column.Key
            Case "DiaSemana"
                If Me.GrdGrupoTurnoLinea.Row <> Me.GrdGrupoTurnoLinea.newTopRowPosition Then
                    e.Cancel = True
                End If
        End Select
    End Sub

#End Region

#End Region

End Class