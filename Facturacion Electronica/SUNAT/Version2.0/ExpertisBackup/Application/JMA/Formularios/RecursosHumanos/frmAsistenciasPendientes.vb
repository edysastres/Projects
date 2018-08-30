Public Class frmAsistenciasPendientes

#Region "Propiedades Públicas"

    Private mDtPendientes As DataTable

    Public WriteOnly Property DtPendientes() As DataTable
        Set(ByVal value As DataTable)
            mDtPendientes = value
        End Set
    End Property

#End Region

#Region "Procesos/Funciones Privadas"

    Private Sub LoadData()
        If (mDtPendientes.Rows.Count > 0) Then
            Me.GrdRegistros.DataSource = mDtPendientes
        End If
    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmAsistenciasPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class