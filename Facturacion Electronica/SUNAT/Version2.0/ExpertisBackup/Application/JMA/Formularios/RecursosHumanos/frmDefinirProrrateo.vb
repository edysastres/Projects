Public Class frmDefinirProrrateo

#Region "Propiedades Públicas"

    Private mDrDefinirProrrateo As DataRow

    Public WriteOnly Property DrProrrateo() As DataRow
        Set(ByVal value As DataRow)
            mDrDefinirProrrateo = value
        End Set
    End Property

    Public IDClasif As Integer

#End Region

#Region "Procesos/Funciones Privadas"

    Private Sub LoadData()
        If Not mDrDefinirProrrateo Is Nothing Then
            Me.TxtIDClasif.Text = Me.mDrDefinirProrrateo("IDClasificacionCostoPersonal")
            Me.ULblDescClasif.Text = Nz(Me.mDrDefinirProrrateo("DescClasificacion"), String.Empty)
            Me.GrdProrrateo.DataSource = New BE.DataEngine().Filter("vProrrateoClasificacionCostoPersonal", New FilterItem("IDClasificacionCostoPersonal", FilterOperator.Equal, Me.mDrDefinirProrrateo("IDClasificacionCostoPersonal")))
            'CType(Me.GrdProrrateo.DataSource, DataTable).TableName = "JMAGrupoTurnoLinea"
            Me.GrdProrrateo.ReQuery(New FilterItem("IDClasificacionCostoPersonal", FilterOperator.Equal, Me.mDrDefinirProrrateo("IDClasificacionCostoPersonal")))
            Me.GrdProrrateo.Columns("IDClasificacionCostoPersonal").DefaultValue = Me.mDrDefinirProrrateo("IDClasificacionCostoPersonal")
        End If
    End Sub

#End Region

#Region "Eventos Controles"

#Region "Eventos Formulario"

    Private Sub frmGrupoTurnoLinea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If mDrDefinirProrrateo("Prorratear") = False Then
            MessageBox.Show("No se especifico la clasificacion como prorrateable.")
            'ApplicationService.GenerateError("No se especifico la clasificacion como prorrateable.", Nothing)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        LoadData()
    End Sub

#End Region

#Region "Eventos Botones"

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        SaveData()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub SaveData()
        Dim EntProrrateo As New ProrrateoClasificacionCostoPersonal
        Dim DtAddUpd As DataTable = CType(Me.GrdProrrateo.DataSource, DataTable).GetChanges(DataRowState.Added Or DataRowState.Modified)
        If Not DtAddUpd Is Nothing AndAlso DtAddUpd.Rows.Count > 0 Then
            EntProrrateo.Validate(DtAddUpd)
            EntProrrateo.Update(DtAddUpd)
        End If

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region



#Region "Eventos DataGrid"

    ' Validar que definan clasificación y porcentaje
    Private Sub GrdProrrateo_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdProrrateo.AddingRecord
        Dim cont As Integer = 0
        For Each Dr As DataRow In CType(Me.GrdProrrateo.DataSource, DataTable).Rows
            If (Length(Dr("IDCCPDestino")) = 0) Then
                ApplicationService.GenerateError("La clasificación de destino en la fila | no puede estar vacía, favor de especificarla.", cont)

            ElseIf (Length(Dr("PorcentajeProrrateo")) = 0) Then
                ApplicationService.GenerateError("El porcentaje de prorrateo en la fila | no puede estar vacío, favor de especificarlo.", cont)
            End If
            cont = cont + 1
        Next
    End Sub

    Private Sub GrdProrrateo_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GrdProrrateo.EditingCell
        Select Case e.Column.Key
            Case "IDCCPDestino"
                If Me.GrdProrrateo.Row <> Me.GrdProrrateo.newTopRowPosition Then
                    e.Cancel = True
                End If
            Case "PorcentajeProrrateo"
                If Me.GrdProrrateo.Row <> Me.GrdProrrateo.newTopRowPosition Then
                    e.Cancel = True
                End If
        End Select
    End Sub

#End Region

#End Region

End Class