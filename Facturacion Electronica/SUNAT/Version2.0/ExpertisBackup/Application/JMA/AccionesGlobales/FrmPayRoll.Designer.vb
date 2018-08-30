<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayRoll
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
        Dim cmbPeriodo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbAnio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbIDPeriodo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPayRoll))
        Me.ButtonCalcularPayRoll = New Solmicro.Expertis.Engine.UI.Button
        Me.LabelParametros = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.clbFechaCorte = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaCorte = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbPeriodo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LabelPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.LabelAño = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbAnio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cmbIDPeriodo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblIDPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1.suspendlayout()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbIDPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCalcularPayRoll
        '
        Me.ButtonCalcularPayRoll.Location = New System.Drawing.Point(51, 260)
        Me.ButtonCalcularPayRoll.Name = "ButtonCalcularPayRoll"
        Me.ButtonCalcularPayRoll.Size = New System.Drawing.Size(175, 23)
        Me.ButtonCalcularPayRoll.TabIndex = 2
        Me.ButtonCalcularPayRoll.Text = "Calcular Pay Roll"
        '
        'LabelParametros
        '
        Me.LabelParametros.Location = New System.Drawing.Point(79, 10)
        Me.LabelParametros.Name = "LabelParametros"
        Me.LabelParametros.Size = New System.Drawing.Size(73, 13)
        Me.LabelParametros.TabIndex = 12
        Me.LabelParametros.Text = "Pärametros"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.clbFechaCorte)
        Me.Panel1.Controls.Add(Me.lblFechaCorte)
        Me.Panel1.Controls.Add(Me.clbFechaFin)
        Me.Panel1.Controls.Add(Me.lblFechaFin)
        Me.Panel1.Controls.Add(Me.clbFechaInicio)
        Me.Panel1.Controls.Add(Me.lblFechaInicio)
        Me.Panel1.Controls.Add(Me.LabelParametros)
        Me.Panel1.Location = New System.Drawing.Point(12, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 118)
        Me.Panel1.TabIndex = 13
        '
        'clbFechaCorte
        '
        Me.TryDataBinding(clbFechaCorte, New System.Windows.Forms.Binding("BindableValue", Me, "", True))
        Me.clbFechaCorte.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaCorte.Location = New System.Drawing.Point(82, 95)
        Me.clbFechaCorte.Name = "clbFechaCorte"
        Me.clbFechaCorte.Size = New System.Drawing.Size(167, 21)
        Me.clbFechaCorte.TabIndex = 17
        '
        'lblFechaCorte
        '
        Me.lblFechaCorte.Location = New System.Drawing.Point(7, 99)
        Me.lblFechaCorte.Name = "lblFechaCorte"
        Me.lblFechaCorte.Size = New System.Drawing.Size(72, 13)
        Me.lblFechaCorte.TabIndex = 18
        Me.lblFechaCorte.Text = "FechaCorte"
        '
        'clbFechaFin
        '
        Me.TryDataBinding(clbFechaFin, New System.Windows.Forms.Binding("BindableValue", Me, "", True))
        Me.clbFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaFin.Enabled = False
        Me.clbFechaFin.Location = New System.Drawing.Point(82, 64)
        Me.clbFechaFin.Name = "clbFechaFin"
        Me.clbFechaFin.Size = New System.Drawing.Size(167, 21)
        Me.clbFechaFin.TabIndex = 15
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(20, 68)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(60, 13)
        Me.lblFechaFin.TabIndex = 16
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'clbFechaInicio
        '
        Me.TryDataBinding(clbFechaInicio, New System.Windows.Forms.Binding("BindableValue", Me, "", True))
        Me.clbFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaInicio.Enabled = False
        Me.clbFechaInicio.Location = New System.Drawing.Point(82, 33)
        Me.clbFechaInicio.Name = "clbFechaInicio"
        Me.clbFechaInicio.Size = New System.Drawing.Size(167, 21)
        Me.clbFechaInicio.TabIndex = 13
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(4, 37)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(75, 13)
        Me.lblFechaInicio.TabIndex = 14
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'cmbPeriodo
        '
        cmbPeriodo_DesignTimeLayout.LayoutString = resources.GetString("cmbPeriodo_DesignTimeLayout.LayoutString")
        Me.cmbPeriodo.DesignTimeLayout = cmbPeriodo_DesignTimeLayout
        Me.cmbPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.cmbPeriodo.Location = New System.Drawing.Point(105, 90)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.SelectedIndex = -1
        Me.cmbPeriodo.SelectedItem = Nothing
        Me.cmbPeriodo.Size = New System.Drawing.Size(156, 21)
        Me.cmbPeriodo.TabIndex = 14
        '
        'LabelPeriodo
        '
        Me.LabelPeriodo.Location = New System.Drawing.Point(41, 94)
        Me.LabelPeriodo.Name = "LabelPeriodo"
        Me.LabelPeriodo.Size = New System.Drawing.Size(50, 13)
        Me.LabelPeriodo.TabIndex = 16
        Me.LabelPeriodo.Text = "Periodo"
        '
        'LabelAño
        '
        Me.LabelAño.Location = New System.Drawing.Point(62, 16)
        Me.LabelAño.Name = "LabelAño"
        Me.LabelAño.Size = New System.Drawing.Size(29, 13)
        Me.LabelAño.TabIndex = 20
        Me.LabelAño.Text = "Año"
        '
        'cmbAnio
        '
        cmbAnio_DesignTimeLayout.LayoutString = resources.GetString("cmbAnio_DesignTimeLayout.LayoutString")
        Me.cmbAnio.DesignTimeLayout = cmbAnio_DesignTimeLayout
        Me.cmbAnio.DisabledBackColor = System.Drawing.Color.White
        Me.cmbAnio.Location = New System.Drawing.Point(105, 12)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.SelectedIndex = -1
        Me.cmbAnio.SelectedItem = Nothing
        Me.cmbAnio.Size = New System.Drawing.Size(156, 21)
        Me.cmbAnio.TabIndex = 19
        '
        'cmbIDPeriodo
        '
        Me.TryDataBinding(cmbIDPeriodo, New System.Windows.Forms.Binding("Value", Me, "", True))
        cmbIDPeriodo_DesignTimeLayout.LayoutString = resources.GetString("cmbIDPeriodo_DesignTimeLayout.LayoutString")
        Me.cmbIDPeriodo.DesignTimeLayout = cmbIDPeriodo_DesignTimeLayout
        Me.cmbIDPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.cmbIDPeriodo.EntityName = "PeriodosPagoNomina"
        Me.cmbIDPeriodo.Location = New System.Drawing.Point(105, 48)
        Me.cmbIDPeriodo.Name = "cmbIDPeriodo"
        Me.cmbIDPeriodo.SecondaryDataFields = "IDPeriodoPago"
        Me.cmbIDPeriodo.SelectedIndex = -1
        Me.cmbIDPeriodo.SelectedItem = Nothing
        Me.cmbIDPeriodo.Size = New System.Drawing.Size(156, 21)
        Me.cmbIDPeriodo.TabIndex = 21
        Me.cmbIDPeriodo.ValueMember = "IDPeriodoPago"
        Me.cmbIDPeriodo.ViewName = "vPeriodosPagoNomina"
        '
        'lblIDPeriodo
        '
        Me.lblIDPeriodo.Location = New System.Drawing.Point(9, 52)
        Me.lblIDPeriodo.Name = "lblIDPeriodo"
        Me.lblIDPeriodo.Size = New System.Drawing.Size(82, 13)
        Me.lblIDPeriodo.TabIndex = 22
        Me.lblIDPeriodo.Text = "Periodo pago"
        '
        'FrmPayRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 295)
        Me.Controls.Add(Me.cmbIDPeriodo)
        Me.Controls.Add(Me.lblIDPeriodo)
        Me.Controls.Add(Me.LabelAño)
        Me.Controls.Add(Me.cmbAnio)
        Me.Controls.Add(Me.LabelPeriodo)
        Me.Controls.Add(Me.cmbPeriodo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonCalcularPayRoll)
        Me.Name = "FrmPayRoll"
        Me.Text = "Pay Roll"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbIDPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCalcularPayRoll As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents LabelParametros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbPeriodo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LabelPeriodo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LabelAño As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbAnio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents clbFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaCorte As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaCorte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbIDPeriodo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblIDPeriodo As Solmicro.Expertis.Engine.UI.Label
End Class
