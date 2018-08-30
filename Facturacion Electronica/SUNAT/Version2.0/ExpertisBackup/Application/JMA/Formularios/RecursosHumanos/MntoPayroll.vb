Public Class MntoPayroll

    Dim dt As New DataTable
    Dim DtCombo As New DataTable
    Dim foundRows() As DataRow
    Dim Year As Integer

    Private Sub MntoPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chbAplicado.Enabled = False
        If (chbAplicado.Checked) Then
            cttNPayroll.Enabled = False
            cmbIDPeriodo.Enabled = False
            cmbPeriodo.Enabled = False
            txtNPeriodo.Enabled = False
            cbAnio.Enabled = False
            clbFechaConsulta.Enabled = False
            clbFechaCorte.Enabled = False
            clbFechaFin.Enabled = False
            clbFechaInicio.Enabled = False
            Grid2.Enabled = False
        End If
        dt.Columns.Add("TipoPeriodo", GetType(String))
        dt.Columns.Add("Periodo", GetType(String))
        dt.Columns.Add("FechaInicio", GetType(Date))
        dt.Columns.Add("FechaFin", GetType(Date))
        dt.Columns.Add("DiasPeriodo", GetType(Integer))
        Dim DtYears As New DataTable
        DtYears.Columns.Add("Año", GetType(Integer))
        For i As Integer = 2010 To Date.Now.Year
            DtYears.Rows.Add(i)
        Next
        cbAnio.DataSource = DtYears
        cbAnio.Value = Date.Now.Year
        cmbIDPeriodo.DisplayMember = "DescPeriodoPago"
        Me.FormActions.Add("Generar Payroll con parámetros especificados", AddressOf ValidarPayroll)
        Me.FormActions.Add("Generar Reporte de nómina", AddressOf GenerarReporte)
        Me.AddSeparator()
        Me.FormActions.Add("Aplicar Payroll", AddressOf AplicarPayroll)
        Me.FormActions.Add("Desaplicar Payroll", AddressOf DesaplicarPayroll)
        'RefreshData()
        My.Computer.Keyboard.SendKeys(CStr(Keys.F5))
    End Sub

    Private Sub cmbNPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIDPeriodo.ValueChanged
        cmbPeriodo.Text = String.Empty
        cmbPeriodo.Value = String.Empty
        dt.Rows.Clear()
        DtCombo = New BE.DataEngine().Filter("vPeriodosPagoNomina", New FilterItem("DescPeriodoPago", FilterOperator.Equal, cmbIDPeriodo.Text))
        Dim per As String = cmbPeriodo.Text.ToString
        foundRows = DtCombo.Select("DescPeriodoPago Like '" + cmbIDPeriodo.Text + "'")
        If cbAnio.Text.Equals(String.Empty) Then
            Year = Date.Now.Year
        Else
            Year = CInt(cbAnio.Text.ToString)
        End If
        '''Periodos mensuales ->
        If (foundRows(0)(2) = 30 Or foundRows(0)(2) = 31) Then
            Dim i As Integer = 1
            While i < 13
                dt.Rows.Add(foundRows(0)(1), Year.ToString + "-M" + i.ToString, New Date(Year, i, 1), New Date(Year, i, Date.DaysInMonth(Year, i)), foundRows(0)(2))
                i = i + 1
            End While '''<-
            '''Periodos catorcenales->
        ElseIf (foundRows(0)(2) = 14 AndAlso CBool(foundRows(0)(7))) Then
            For i As Integer = 1 To 12
                dt.Rows.Add(foundRows(0)(1), Year.ToString + "-M" + i.ToString + "-P1", New Date(Year, i, 1), New Date(Year, i, 14), foundRows(0)(2))
                dt.Rows.Add(foundRows(0)(1), Year.ToString + "-M" + i.ToString + "-P2", New Date(Year, i, 15), New Date(Year, i, Date.DaysInMonth(Year, i)), foundRows(0)(2))
            Next
        ElseIf (foundRows(0)(2) = 14 AndAlso Not CBool(foundRows(0)(7))) Then
            Dim initDate, finalDate As Date
            initDate = GetFirstPeriodOfYear(Year, foundRows(0)(6), 14)
            finalDate = initDate.AddDays(13)
            Dim i As Integer = 1
            While finalDate.Year <= Year
                dt.Rows.Add(foundRows(0)(1), finalDate.Year.ToString + "-P" + i.ToString, initDate, finalDate, foundRows(0)(2))
                initDate = initDate.AddDays(CDbl(14))
                finalDate = finalDate.AddDays(CDbl(14))
                i = i + 1
            End While '''<-
            '''Periodos quincenales ->
        ElseIf (foundRows(0)(2) = 15 AndAlso CBool(foundRows(0)(7))) Then
            For i As Integer = 1 To 12
                dt.Rows.Add(foundRows(0)(1), Year.ToString + "-M" + i.ToString + "-P1", New Date(Year, i, 1), New Date(Year, i, 15), foundRows(0)(2))
                dt.Rows.Add(foundRows(0)(1), Year.ToString + "-M" + i.ToString + "-P2", New Date(Year, i, 16), New Date(Year, i, Date.DaysInMonth(Year, i)), foundRows(0)(2))
            Next
        ElseIf (foundRows(0)(2) = 15 AndAlso Not CBool(foundRows(0)(7))) Then
            Dim initDate, finalDate As Date
            initDate = GetFirstPeriodOfYear(Year, foundRows(0)(6), 15)
            finalDate = initDate.AddDays(14)
            Dim i As Integer = 1
            While finalDate.Year <= Year
                dt.Rows.Add(foundRows(0)(1), finalDate.Year.ToString + "-P" + i.ToString, initDate, finalDate, foundRows(0)(2))
                initDate = initDate.AddDays(CDbl(15))
                finalDate = finalDate.AddDays(CDbl(15))
                i = i + 1
            End While
            '''<-
            '''Periodos semanales ->
        ElseIf (foundRows(0)(2) = 7 AndAlso CBool(foundRows(0)(7))) Then
            Dim j As Integer
            For i As Integer = 1 To 12
                For j = 1 To 3
                    dt.Rows.Add(foundRows(0)(1), Year.ToString + "-M" + i.ToString + "-P" + j.ToString, New Date(Year, i, j), New Date(Year, i, j * 7), foundRows(0)(2))
                Next
                dt.Rows.Add(foundRows(0)(1), Year.ToString + "-M" + i.ToString + "-P" + j.ToString, New Date(Year, i, 22), New Date(Year, i, Date.DaysInMonth(Year, i)), foundRows(0)(2))
            Next
        ElseIf (foundRows(0)(2) = 7 AndAlso Not CBool(foundRows(0)(7))) Then
            Dim initDate, finalDate As Date
            initDate = GetFirstPeriodOfYear(Year, foundRows(0)(6), 7)
            finalDate = initDate.AddDays(6)
            Dim i As Integer = 0
            While finalDate.Year <= Year
                dt.Rows.Add(foundRows(0)(1), finalDate.Year.ToString + "-P" + (i + 1).ToString, initDate, finalDate, foundRows(0)(2))
                initDate = initDate.AddDays(CDbl(7))
                finalDate = finalDate.AddDays(CDbl(7))
                i = i + 1
            End While '''<-
        Else
            Dim initDate, finalDate As Date
            initDate = GetFirstPeriodOfYear(Year, foundRows(0)(6), foundRows(0)(2))
            finalDate = initDate.AddDays(foundRows(0)(2) - 1)
            Dim i As Integer = 0
            While finalDate.Year <= Year
                dt.Rows.Add(foundRows(0)(1), finalDate.Year.ToString + "-P" + (i + 1).ToString, initDate, finalDate, foundRows(0)(2))
                initDate = initDate.AddDays(CDbl(foundRows(0)(2)))
                finalDate = finalDate.AddDays(CDbl(foundRows(0)(2)))
                i = i + 1
            End While '''<-
        End If
        cmbPeriodo.DataSource = dt
        cmbPeriodo.ValueMember = "Periodo"
        cmbPeriodo.DisplayMember = "Periodo"
    End Sub

    Private Sub cmbPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPeriodo.ValueChanged
        Dim Periodo As String = cmbPeriodo.Text
        Dim v As String = cmbPeriodo.Value.ToString()
        Dim rows() As DataRow = dt.Select("Periodo Like '" + cmbPeriodo.Text + "'")
        clbFechaInicio.Value = CDate(rows(0)(2))
        clbFechaFin.Value = CDate(rows(0)(3))
        Dim FechaCorte As Date = CDate(rows(0)(2))
        clbFechaCorte.Value = CDate(FechaCorte.AddDays(CDbl(foundRows(0)(4) - 1)))
        clbFechaInicio.Enabled = False
        clbFechaFin.Enabled = False
        clbFechaConsulta.Enabled = False
        If (cmbPeriodo.Text.Length > 4 Or cmbPeriodo.Value.ToString.Length > 4) Then
            txtNPeriodo.Text = cmbPeriodo.Value.ToString 'cmbPeriodo.Text
        End If
    End Sub

    Private Function GetFirstPeriodOfYear(ByVal Year As Integer, ByVal RefDate As Date, ByVal PeriodDays As Integer) As Date
        If Year < RefDate.Year Then
            While RefDate.Year >= Year
                RefDate = RefDate.AddDays(0 - PeriodDays)
            End While
        ElseIf Year > RefDate.Year Then
            While RefDate.Year <= Year
                RefDate = RefDate.AddDays(PeriodDays)
            End While
        Else
            RefDate = RefDate.AddDays(0 - PeriodDays)
        End If
        Return RefDate.AddDays(1)
    End Function

    Private Sub ValidarPayroll()
        Dim f As New Filter
        f.Add(New FilterItem("Revisado", FilterOperator.Equal, False))
        f.Add(New FilterItem("Fecha", FilterOperator.GreaterThanOrEqual, CDate(clbFechaInicio.Value)))
        f.Add(New FilterItem("Fecha", FilterOperator.LessThanOrEqual, CDate(clbFechaFin.Value)))
        f.Add(New FilterItem("IDPeriodo", FilterOperator.Equal, CDate(cmbIDPeriodo.Value)))
        Dim DtPendientes As DataTable = New BE.DataEngine().Filter("vJMACalendarioOperario", f)
        If (DtPendientes.Rows.Count > 0) Then
            Dim frmPendientes As New frmAsistenciasPendientes
            frmPendientes.DtPendientes = DtPendientes
            frmPendientes.ShowDialog()
        Else
            Dim DrDatos As DataRow = New BE.DataEngine().Filter("vPayrollcabecera", New FilterItem("NPayroll", FilterOperator.Equal, cttNPayroll.Text)).Rows(0)
            Dim Datos As New Expertis.Business.AltunaMX.PayrollCabecera.DatosPayroll(DrDatos)
            ExpertisApp.ExecuteTask(Of Expertis.Business.AltunaMX.PayrollCabecera.DatosPayroll)(AddressOf PayrollCabecera.GenerarPayroll, Datos)
        End If
    End Sub

    Private Sub GenerarReporte()
        Dim RptPayroll As New Report("RPTPAYROLL")
        ExpertisApp.OpenReport(RptPayroll)
    End Sub

    Private Sub AplicarPayroll()
        If Not (chbAplicado.Checked) Then
            chbAplicado.Checked = True
            cttNPayroll.Enabled = False
            cmbIDPeriodo.Enabled = False
            cmbPeriodo.Enabled = False
            txtNPeriodo.Enabled = False
            cbAnio.Enabled = False
            clbFechaConsulta.Enabled = False
            clbFechaCorte.Enabled = False
            clbFechaFin.Enabled = False
            clbFechaInicio.Enabled = False
            Grid2.Enabled = False
            Dim f As New Filter
            Dim EntContPresencia As New ControlPresencia
            f.Add("Fecha", FilterOperator.GreaterThanOrEqual, CDate(clbFechaInicio.Value))
            f.Add("Fecha", FilterOperator.LessThanOrEqual, CDate(clbFechaFin.Value))
            f.Add("Revisado", FilterOperator.Equal, False)
            'f.Add("IDPeriodo", FilterOperator.Equal, cmbIDPeriodo.Value)
            Dim DtRegistros As DataTable = New BE.DataEngine().Filter("vJMACalendarioOperarioCtrlPresencia", f)
            For Each row As DataRow In DtRegistros.Rows
                row("Pagado") = True
            Next
            EntContPresencia.Validate(DtRegistros)
            EntContPresencia.Update(DtRegistros)
        Else
            ApplicationService.GenerateError("El Payroll no se puede aplicar nuevamente, ya se encuentra aplicado.")
        End If
    End Sub

    Private Sub DesaplicarPayroll()
        If (chbAplicado.Checked) Then
            chbAplicado.Checked = False
            cttNPayroll.Enabled = True
            cmbIDPeriodo.Enabled = True
            cmbPeriodo.Enabled = True
            txtNPeriodo.Enabled = True
            cbAnio.Enabled = True
            clbFechaConsulta.Enabled = True
            clbFechaCorte.Enabled = True
            clbFechaFin.Enabled = True
            clbFechaInicio.Enabled = True
            Grid2.Enabled = False
            Dim f As New Filter
            Dim EntContPresencia As New ControlPresencia
            f.Add("Fecha", FilterOperator.GreaterThanOrEqual, CDate(clbFechaInicio.Value))
            f.Add("Fecha", FilterOperator.LessThanOrEqual, CDate(clbFechaFin.Value))
            f.Add("Revisado", FilterOperator.Equal, True)
            'f.Add("IDPeriodo", FilterOperator.Equal, cmbIDPeriodo.Value)
            f.Add("Pagado", FilterOperator.Equal, True)
            Dim DtRegistros As DataTable = New BE.DataEngine().Filter("vJMACalendarioOperarioCtrlPresencia", f)
            For Each row As DataRow In DtRegistros.Rows
                row("Pagado") = False
            Next
            EntContPresencia.Validate(DtRegistros)
            EntContPresencia.Update(DtRegistros)
        Else
            ApplicationService.GenerateError("El Payroll no se puede desaplicar si no ha sido aplicado previamente.")
        End If
        
    End Sub

End Class