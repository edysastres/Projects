<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntoPayroll
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cmbPeriodo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbIDPeriodo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbAnio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoPayroll))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chbAplicado = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblAplicado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNPeriodo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cttNPayroll = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.lblNPayroll = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbPeriodo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cmbIDPeriodo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.cbAnio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaConsulta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaConsulta = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaCorte = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaCorte = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.Grid2 = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbIDPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Grid2)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Size = New System.Drawing.Size(1170, 595)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chbAplicado)
        Me.Panel1.Controls.Add(Me.lblAplicado)
        Me.Panel1.Controls.Add(Me.txtNPeriodo)
        Me.Panel1.Controls.Add(Me.cttNPayroll)
        Me.Panel1.Controls.Add(Me.lblNPayroll)
        Me.Panel1.Controls.Add(Me.cmbPeriodo)
        Me.Panel1.Controls.Add(Me.cmbIDPeriodo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbAnio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.clbFechaConsulta)
        Me.Panel1.Controls.Add(Me.lblFechaConsulta)
        Me.Panel1.Controls.Add(Me.clbFechaCorte)
        Me.Panel1.Controls.Add(Me.lblFechaCorte)
        Me.Panel1.Controls.Add(Me.clbFechaFin)
        Me.Panel1.Controls.Add(Me.lblFechaFin)
        Me.Panel1.Controls.Add(Me.clbFechaInicio)
        Me.Panel1.Controls.Add(Me.lblFechaInicio)
        Me.Panel1.Controls.Add(Me.lblPeriodo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1170, 115)
        Me.Panel1.TabIndex = 0
        '
        'chbAplicado
        '
        Me.TryDataBinding(chbAplicado, New System.Windows.Forms.Binding("BindableValue", Me, "Aplicado", True))
        Me.chbAplicado.Location = New System.Drawing.Point(1102, 65)
        Me.chbAplicado.Name = "chbAplicado"
        Me.chbAplicado.Size = New System.Drawing.Size(15, 15)
        Me.chbAplicado.TabIndex = 28
        '
        'lblAplicado
        '
        Me.lblAplicado.Location = New System.Drawing.Point(993, 66)
        Me.lblAplicado.Name = "lblAplicado"
        Me.lblAplicado.Size = New System.Drawing.Size(103, 13)
        Me.lblAplicado.TabIndex = 29
        Me.lblAplicado.Text = "Payroll Aplicado:"
        '
        'txtNPeriodo
        '
        Me.TryDataBinding(txtNPeriodo, New System.Windows.Forms.Binding("Text", Me, "NPeriodo", True))
        Me.txtNPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.txtNPeriodo.Location = New System.Drawing.Point(305, 62)
        Me.txtNPeriodo.Name = "txtNPeriodo"
        Me.txtNPeriodo.Size = New System.Drawing.Size(195, 21)
        Me.txtNPeriodo.TabIndex = 27
        '
        'cttNPayroll
        '
        Me.TryDataBinding(cttNPayroll, New System.Windows.Forms.Binding("Text", Me, "NPayroll", True))
        Me.cttNPayroll.DisabledBackColor = System.Drawing.Color.White
        Me.cttNPayroll.Location = New System.Drawing.Point(137, 20)
        Me.cttNPayroll.Name = "cttNPayroll"
        Me.cttNPayroll.Size = New System.Drawing.Size(142, 23)
        Me.cttNPayroll.TabIndex = 25
        '
        'lblNPayroll
        '
        Me.lblNPayroll.Location = New System.Drawing.Point(62, 26)
        Me.lblNPayroll.Name = "lblNPayroll"
        Me.lblNPayroll.Size = New System.Drawing.Size(69, 13)
        Me.lblNPayroll.TabIndex = 26
        Me.lblNPayroll.Text = "No. Payroll"
        '
        'cmbPeriodo
        '
        cmbPeriodo_DesignTimeLayout.LayoutString = resources.GetString("cmbPeriodo_DesignTimeLayout.LayoutString")
        Me.cmbPeriodo.DesignTimeLayout = cmbPeriodo_DesignTimeLayout
        Me.cmbPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.cmbPeriodo.Location = New System.Drawing.Point(363, 27)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.SelectedIndex = -1
        Me.cmbPeriodo.SelectedItem = Nothing
        Me.cmbPeriodo.Size = New System.Drawing.Size(137, 21)
        Me.cmbPeriodo.TabIndex = 24
        '
        'cmbIDPeriodo
        '
        Me.TryDataBinding(cmbIDPeriodo, New System.Windows.Forms.Binding("Value", Me, "IDPeriodo", True))
        cmbIDPeriodo_DesignTimeLayout.LayoutString = resources.GetString("cmbIDPeriodo_DesignTimeLayout.LayoutString")
        Me.cmbIDPeriodo.DesignTimeLayout = cmbIDPeriodo_DesignTimeLayout
        Me.cmbIDPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.cmbIDPeriodo.EntityName = "PeriodosPagoNomina"
        Me.cmbIDPeriodo.Location = New System.Drawing.Point(137, 50)
        Me.cmbIDPeriodo.Name = "cmbIDPeriodo"
        Me.cmbIDPeriodo.PrimaryDataFields = "IDPeriodo"
        Me.cmbIDPeriodo.SecondaryDataFields = "IDPeriodoPago"
        Me.cmbIDPeriodo.SelectedIndex = -1
        Me.cmbIDPeriodo.SelectedItem = Nothing
        Me.cmbIDPeriodo.Size = New System.Drawing.Size(142, 21)
        Me.cmbIDPeriodo.TabIndex = 21
        Me.cmbIDPeriodo.ValueMember = "IDPeriodoPago"
        Me.cmbIDPeriodo.ViewName = "vPeriodosPagoNomina"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(302, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Periodo:"
        '
        'cbAnio
        '
        cbAnio_DesignTimeLayout.LayoutString = resources.GetString("cbAnio_DesignTimeLayout.LayoutString")
        Me.cbAnio.DesignTimeLayout = cbAnio_DesignTimeLayout
        Me.cbAnio.DisabledBackColor = System.Drawing.Color.White
        Me.cbAnio.Location = New System.Drawing.Point(138, 79)
        Me.cbAnio.Name = "cbAnio"
        Me.cbAnio.SelectedIndex = -1
        Me.cbAnio.SelectedItem = Nothing
        Me.cbAnio.Size = New System.Drawing.Size(141, 21)
        Me.cbAnio.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(97, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Año:"
        '
        'clbFechaConsulta
        '
        Me.TryDataBinding(clbFechaConsulta, New System.Windows.Forms.Binding("BindableValue", Me, "FechaConsulta", True))
        Me.clbFechaConsulta.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaConsulta.Location = New System.Drawing.Point(853, 62)
        Me.clbFechaConsulta.Name = "clbFechaConsulta"
        Me.clbFechaConsulta.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaConsulta.TabIndex = 12
        '
        'lblFechaConsulta
        '
        Me.lblFechaConsulta.Location = New System.Drawing.Point(736, 67)
        Me.lblFechaConsulta.Name = "lblFechaConsulta"
        Me.lblFechaConsulta.Size = New System.Drawing.Size(114, 13)
        Me.lblFechaConsulta.TabIndex = 13
        Me.lblFechaConsulta.Text = "Fecha de consulta:"
        '
        'clbFechaCorte
        '
        Me.TryDataBinding(clbFechaCorte, New System.Windows.Forms.Binding("BindableValue", Me, "FechaCorte", True))
        Me.clbFechaCorte.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaCorte.Location = New System.Drawing.Point(609, 62)
        Me.clbFechaCorte.Name = "clbFechaCorte"
        Me.clbFechaCorte.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaCorte.TabIndex = 10
        '
        'lblFechaCorte
        '
        Me.lblFechaCorte.Location = New System.Drawing.Point(507, 67)
        Me.lblFechaCorte.Name = "lblFechaCorte"
        Me.lblFechaCorte.Size = New System.Drawing.Size(96, 13)
        Me.lblFechaCorte.TabIndex = 11
        Me.lblFechaCorte.Text = "Fecha de corte:"
        '
        'clbFechaFin
        '
        Me.TryDataBinding(clbFechaFin, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFin", True))
        Me.clbFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaFin.Location = New System.Drawing.Point(853, 28)
        Me.clbFechaFin.Name = "clbFechaFin"
        Me.clbFechaFin.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaFin.TabIndex = 8
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(787, 32)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(63, 13)
        Me.lblFechaFin.TabIndex = 9
        Me.lblFechaFin.Text = "Fecha fin:"
        '
        'clbFechaInicio
        '
        Me.TryDataBinding(clbFechaInicio, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicio", True))
        Me.clbFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaInicio.Location = New System.Drawing.Point(609, 28)
        Me.clbFechaInicio.Name = "clbFechaInicio"
        Me.clbFechaInicio.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaInicio.TabIndex = 6
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(525, 32)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(78, 13)
        Me.lblFechaInicio.TabIndex = 7
        Me.lblFechaInicio.Text = "Fecha inicio:"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(8, 54)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(123, 13)
        Me.lblPeriodo.TabIndex = 5
        Me.lblPeriodo.Text = "Frecuencia de pago:"
        '
        'Grid2
        '
        Grid2_DesignTimeLayout.LayoutString = resources.GetString("Grid2_DesignTimeLayout.LayoutString")
        Me.Grid2.DesignTimeLayout = Grid2_DesignTimeLayout
        Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid2.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid2.EntityName = "PayrollLinea"
        Me.Grid2.KeyField = "IDPayroll"
        Me.Grid2.Location = New System.Drawing.Point(0, 115)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.PrimaryDataFields = "IDPayroll"
        Me.Grid2.SecondaryDataFields = "IDPayroll"
        Me.Grid2.Size = New System.Drawing.Size(1170, 480)
        Me.Grid2.TabIndex = 2
        Me.Grid2.ViewName = "vPayrollLinea"
        '
        'MntoPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 668)
        Me.EntityName = "PayrollCabecera"
        Me.Name = "MntoPayroll"
        Me.NavigationFields = "IDPayroll"
        Me.Text = "MntoPayroll"
        Me.ViewName = "vPayrollCabecera"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbIDPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblPeriodo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Grid2 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents clbFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaCorte As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaCorte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaConsulta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaConsulta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbAnio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbIDPeriodo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cmbPeriodo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtNPeriodo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cttNPayroll As Solmicro.Expertis.Engine.UI.CounterTextBox
    Friend WithEvents lblNPayroll As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chbAplicado As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblAplicado As Solmicro.Expertis.Engine.UI.Label
End Class
