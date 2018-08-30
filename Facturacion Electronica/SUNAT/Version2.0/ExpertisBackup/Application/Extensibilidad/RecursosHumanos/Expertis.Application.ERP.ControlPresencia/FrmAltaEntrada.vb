Public Class FrmAltaEntrada

    Private mDrPersonaFecha As DataRow
    Private mDrControlPrecencia As DataTable


    Public WriteOnly Property DrPersonaFecha() As DataRow
        Set(ByVal value As DataRow)
            mDrPersonaFecha = value
        End Set
    End Property

    Public WriteOnly Property DrControlPre() As DataTable
        Set(ByVal value As DataTable)
            mDrControlPrecencia = value
        End Set
    End Property


    Private Sub LoadData()
        Me.ClbFechaEntrada.Value = mDrPersonaFecha("Fecha")
        Me.ClbFechaEntrada.Enabled=false
        Me.AdvOperario.Value = mDrPersonaFecha("IDOperario")
        me.AdvOperario.Enabled=false
    End Sub

    Private Function CheckData() As Boolean
        If Length(Me.AdvOperario.Value) = 0 Then
            ExpertisApp.GenerateMessage("El operario es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Length(Me.ClbFechaEntrada.Value) = 0 Then
            ExpertisApp.GenerateMessage("La fecha de entrada es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Length(Me.ClbHoraEntrada.Value) = 0 Then
            ExpertisApp.GenerateMessage("La hora de entrada es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Dim FilPresencia As New Filter
        FilPresencia.Add("IDOperario", FilterOperator.Equal, Me.AdvOperario.Value)
        FilPresencia.Add("Fecha", FilterOperator.Equal, Me.ClbFechaEntrada.Value)
        FilPresencia.Add("Hora", FilterOperator.Equal, Me.ClbHoraEntrada.Value)
        Dim DtPresencia As DataTable = New ControlPresencia().Filter(FilPresencia)
        If Not DtPresencia Is Nothing AndAlso DtPresencia.Rows.Count > 0 Then
            ExpertisApp.GenerateMessage("Existe ya una entrada para el operario | en la fecha |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Me.AdvOperario.Value, Me.ClbFechaEntrada.Value)
            Return False
        End If
        Return True
    End Function

    Private Sub SaveData()
        Dim ClsPresencia As New ControlPresencia
        Dim DtPresencia As DataTable = ClsPresencia.AddNewForm()
        DtPresencia.Rows(0)("IDOperario") = Me.AdvOperario.Value
        DtPresencia.Rows(0)("Fecha") = Me.ClbFechaEntrada.Value
        DtPresencia.Rows(0)("Hora") = Me.ClbHoraEntrada.Value

        '''''''' Revisar que tipo de entrada vamos a poner
        Dim dTemporal As DataTable = mDrControlPrecencia
        Dim Entradas As Integer = dTemporal.Select("Entrada=1").Count
        Dim Salidas As Integer = dTemporal.Select("Entrada=0").Count

        ''''''' Colocar la entrada Correcta
        If Entradas = Salidas Then
            DtPresencia.Rows(0)("Entrada") = 1
        ElseIf Entradas > Salidas Then
            DtPresencia.Rows(0)("Entrada") = 0
        ElseIf Entradas < Salidas Then
            DtPresencia.Rows(0)("Entrada") = 1
        End If

        'DtPresencia.Rows(0)("Entrada") = True
        ClsPresencia.Validate(DtPresencia)
        ClsPresencia.Update(DtPresencia)
    End Sub

    Private Sub FrmAltaEntrada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If CheckData() Then
            SaveData()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class