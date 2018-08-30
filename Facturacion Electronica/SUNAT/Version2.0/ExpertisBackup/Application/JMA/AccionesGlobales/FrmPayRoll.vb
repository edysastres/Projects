Public Class FrmPayRoll

    Dim dt As New DataTable
    Dim DvCombo As DataView
    Dim DtCombo As DataTable
    Dim foundRows() As DataRow

    Private Sub FrmPayRoll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt.Columns.Add("TipoPeriodo", GetType(String))
        dt.Columns.Add("Periodo", GetType(String))
        dt.Columns.Add("FechaInicio", GetType(Date))
        dt.Columns.Add("FechaFin", GetType(Date))
        Dim DtYears As New DataTable
        DtYears.Columns.Add("Año", GetType(Integer))
        For i As Integer = 2010 To Date.Now.Year
            DtYears.Rows.Add(i)
        Next
        cmbAnio.DataSource = DtYears
        cmbAnio.Value = Date.Now.Year
        cmbIDPeriodo.DisplayMember = "DescPeriodoPago"
        cmbIDPeriodo.ValueMember = "IDPeriodoPago"
        DvCombo = cmbIDPeriodo.DataSource
        DtCombo = DvCombo.Table.Clone()
        For i As Integer = 0 To DvCombo.Table.Rows.Count - 1
            DtCombo.Rows.Add(DvCombo.Item(i).Row.ItemArray)
        Next
    End Sub

    Private Sub cmbIDPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIDPeriodo.ValueChanged
        cmbPeriodo.Text = String.Empty
        cmbPeriodo.Value = String.Empty
        Dim per As String = cmbPeriodo.Text.ToString
        foundRows = DtCombo.Select("DescPeriodoPago Like '" + cmbIDPeriodo.Text + "'")
        Dim Year As Integer
        If cmbAnio.Text.Equals(String.Empty) Then
            Year = Date.Now.Year
        Else
            Year = CInt(cmbAnio.Text.ToString)
        End If
        dt.Rows.Clear()
        Dim DaysInYear As Integer
        If (Year Mod 4) = 0 Then
            DaysInYear = 366
        Else
            DaysInYear = 365
        End If
        '''Periodos mensuales ->
        If (foundRows(0)(2) = 30 Or foundRows(0)(2) = 31) Then
            Dim i As Integer = 1
            Dim aux As New DateTime(Date.Now.Year, 1, 1)
            While aux.Year < Date.Now.Year Or aux.Year = Date.Now.Year
                dt.Rows.Add(foundRows(0)(1), Year.ToString + "-M" + i.ToString, New Date(Year, i, 1), New Date(Year, i, Date.DaysInMonth(Year, i)))
                i = i + 1
            End While '''<-
            '''Periodos catorcenales->
        ElseIf (foundRows(0)(2) = 14 AndAlso CBool(foundRows(0)(7))) Then
            For i As Integer = 1 To 12
                dt.Rows.Add(foundRows(0)(1), Year.ToString + "-" + i.ToString + "C1", New Date(Year, i, 1), New Date(Year, i, 14))
                dt.Rows.Add(foundRows(0)(1), Year.ToString + "-" + i.ToString + "C2", New Date(Year, i, 15), New Date(Year, i, Date.DaysInMonth(Year, i)))
            Next
        ElseIf (foundRows(0)(2) = 14 AndAlso Not CBool(foundRows(0)(7))) Then
            Dim init, final As Integer
            Dim initDate, finalDate As Date
            initDate = foundRows(0)(5)
            init = initDate.Day
            finalDate = foundRows(0)(6)
            final = finalDate.Day
            Dim i As Integer = 1
            While finalDate.Year < Date.Now.Year Or finalDate.Year = Date.Now.Year
                dt.Rows.Add(foundRows(0)(1), finalDate.Year.ToString + "-C" + i.ToString, initDate, finalDate)
                initDate = initDate.AddDays(CDbl(14))
                finalDate = finalDate.AddDays(CDbl(14))
                i = i + 1
            End While '''<-
            '''Periodos quincenales ->
        ElseIf (foundRows(0)(2) = 15 AndAlso CBool(foundRows(0)(7))) Then
                For i As Integer = 1 To 12
                    dt.Rows.Add(foundRows(0)(1), Year.ToString + "-" + i.ToString + "Q1", New Date(Year, i, 1), New Date(Year, i, 15))
                    dt.Rows.Add(foundRows(0)(1), Year.ToString + "-" + i.ToString + "Q2", New Date(Year, i, 16), New Date(Year, i, Date.DaysInMonth(Year, i)))
                Next
        ElseIf (foundRows(0)(2) = 15 AndAlso Not CBool(foundRows(0)(7))) Then
                Dim initDate, finalDate As Date
                initDate = foundRows(0)(5)
                finalDate = foundRows(0)(6)
            Dim i As Integer = 1
            While finalDate.Year < Date.Now.Year Or finalDate.Year = Date.Now.Year
                dt.Rows.Add(foundRows(0)(1), finalDate.Year.ToString + "-Q" + i.ToString, initDate, finalDate)
                initDate = initDate.AddDays(CDbl(15))
                finalDate = finalDate.AddDays(CDbl(15))
                i = i + 1
            End While
            '''<-
            '''Periodos semanales ->
        ElseIf (foundRows(0)(2) = 7 AndAlso CBool(foundRows(0)(7))) Then
                For i As Integer = 1 To 12
                    For j As Integer = 1 To 3
                        dt.Rows.Add(foundRows(0)(1), Year.ToString + "-" + i.ToString + "S" + j.ToString, New Date(Year, i, j), New Date(Year, i, j * 7))
                    Next
                    dt.Rows.Add(foundRows(0)(1), Year.ToString + "-" + i.ToString + "S4", New Date(Year, i, 22), New Date(Year, i, Date.DaysInMonth(Year, i)))
                Next
        ElseIf (foundRows(0)(2) = 7 AndAlso Not CBool(foundRows(0)(7))) Then
                Dim initDate, finalDate As Date
                initDate = foundRows(0)(5)
                finalDate = foundRows(0)(6)
            Dim i As Integer = 0
            While finalDate.Year < Date.Now.Year Or finalDate.Year = Date.Now.Year
                dt.Rows.Add(foundRows(0)(1), finalDate.Year.ToString + "-S" + (i + 1).ToString, initDate, finalDate)
                initDate = initDate.AddDays(CDbl(7))
                finalDate = finalDate.AddDays(CDbl(7))
                i = i + 1
            End While '''<-
        End If
        cmbPeriodo.DataSource = dt
        cmbPeriodo.ValueMember = "Periodo"
        cmbPeriodo.DisplayMember = "Periodo"
        cmbPeriodo.Value = dt(0)("Periodo")
        cmbPeriodo.Text = dt(0)("Periodo")
    End Sub

    Private Sub cmbPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPeriodo.ValueChanged
        Try
            Dim rows() As DataRow = dt.Select("Periodo Like '" + cmbPeriodo.Text + "'")
            clbFechaInicio.Value = CDate(rows(0)(2))
            clbFechaFin.Value = CDate(rows(0)(3))
            Dim FechaCorte As Date = CDate(rows(0)(2))
            clbFechaCorte.Value = CDate(FechaCorte.AddDays(CDbl(foundRows(0)(4) - 1)))
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try        
    End Sub

    Private Sub ButtonCalcularPayRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalcularPayRoll.Click

    End Sub

    Private Function ReturnDate(ByVal Day As Integer, ByVal Year As Integer) As Date
        If (Year Mod 4) = 0 Then
            If Day < 32 Then
                Return New Date(Year, 1, Day)
            ElseIf Day > 31 AndAlso Day < 61 Then
                Return New Date(Year, 2, Day - 31)
            ElseIf Day > 60 AndAlso Day < 92 Then
                Return New Date(Year, 3, Day - 60)
            ElseIf Day > 91 AndAlso Day < 122 Then
                Return New Date(Year, 4, Day - 91)
            ElseIf Day > 121 AndAlso Day < 153 Then
                Return New Date(Year, 5, Day - 121)
            ElseIf Day > 152 AndAlso Day < 183 Then
                Return New Date(Year, 6, Day - 152)
            ElseIf Day > 182 AndAlso Day < 214 Then
                Return New Date(Year, 7, Day - 182)
            ElseIf Day > 213 AndAlso Day < 245 Then
                Return New Date(Year, 8, Day - 213)
            ElseIf Day > 244 AndAlso Day < 275 Then
                Return New Date(Year, 9, Day - 244)
            ElseIf Day > 274 AndAlso Day < 306 Then
                Return New Date(Year, 10, Day - 274)
            ElseIf Day > 305 AndAlso Day < 336 Then
                Return New Date(Year, 11, Day - 305)
            ElseIf Day > 335 AndAlso Day < 367 Then
                Return New Date(Year, 12, Day - 335)
            ElseIf Day > 366 Then
                Return New Date(Year, 12, 31)
            End If
        Else
            If Day < 32 Then
                Return New Date(Year, 1, Day)
            ElseIf Day > 31 AndAlso Day < 60 Then
                Return New Date(Year, 2, Day - 31)
            ElseIf Day > 59 AndAlso Day < 91 Then
                Return New Date(Year, 3, Day - 59)
            ElseIf Day > 90 AndAlso Day < 121 Then
                Return New Date(Year, 4, Day - 90)
            ElseIf Day > 120 AndAlso Day < 152 Then
                Return New Date(Year, 5, Day - 120)
            ElseIf Day > 151 AndAlso Day < 182 Then
                Return New Date(Year, 6, Day - 151)
            ElseIf Day > 181 AndAlso Day < 213 Then
                Return New Date(Year, 7, Day - 181)
            ElseIf Day > 212 AndAlso Day < 244 Then
                Return New Date(Year, 8, Day - 212)
            ElseIf Day > 243 AndAlso Day < 274 Then
                Return New Date(Year, 9, Day - 243)
            ElseIf Day > 273 AndAlso Day < 305 Then
                Return New Date(Year, 10, Day - 273)
            ElseIf Day > 304 AndAlso Day < 335 Then
                Return New Date(Year, 11, Day - 304)
            ElseIf Day > 334 AndAlso Day < 366 Then
                Return New Date(Year, 12, Day - 334)
            ElseIf Day > 365 Then
                Return New Date(Year, 12, 31)
            End If
        End If
    End Function

End Class
