<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaEntrada
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
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmEntrada = New Solmicro.Expertis.Engine.UI.Frame
        Me.ClbHoraEntrada = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblHoraEntrada = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaEntrada = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaEntrada = New Solmicro.Expertis.Engine.UI.Label
        Me.ULblDescOperario = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.PnlButtons.suspendlayout()
        Me.FrmEntrada.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 112)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(389, 47)
        Me.PnlButtons.TabIndex = 4
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(203, 9)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(81, 28)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(104, 9)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(81, 28)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        '
        'FrmEntrada
        '
        Me.FrmEntrada.Controls.Add(Me.ClbHoraEntrada)
        Me.FrmEntrada.Controls.Add(Me.LblHoraEntrada)
        Me.FrmEntrada.Controls.Add(Me.ClbFechaEntrada)
        Me.FrmEntrada.Controls.Add(Me.LblFechaEntrada)
        Me.FrmEntrada.Controls.Add(Me.ULblDescOperario)
        Me.FrmEntrada.Controls.Add(Me.AdvOperario)
        Me.FrmEntrada.Controls.Add(Me.LblOperario)
        Me.FrmEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmEntrada.Location = New System.Drawing.Point(0, 0)
        Me.FrmEntrada.Name = "FrmEntrada"
        Me.FrmEntrada.Size = New System.Drawing.Size(389, 112)
        Me.FrmEntrada.TabIndex = 0
        Me.FrmEntrada.TabStop = False
        Me.FrmEntrada.Text = "Datos Entrada"
        '
        'ClbHoraEntrada
        '
        Me.ClbHoraEntrada.CustomFormat = "HH:mm"
        Me.ClbHoraEntrada.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        Me.ClbHoraEntrada.DisabledBackColor = System.Drawing.Color.White
        Me.ClbHoraEntrada.EditStyle = Janus.Windows.CalendarCombo.EditStyle.Masked
        Me.ClbHoraEntrada.Location = New System.Drawing.Point(94, 81)
        Me.ClbHoraEntrada.Name = "ClbHoraEntrada"
        Me.ClbHoraEntrada.ShowDropDown = False
        Me.ClbHoraEntrada.Size = New System.Drawing.Size(53, 21)
        Me.ClbHoraEntrada.TabIndex = 3
        '
        'LblHoraEntrada
        '
        Me.LblHoraEntrada.Location = New System.Drawing.Point(12, 81)
        Me.LblHoraEntrada.Name = "LblHoraEntrada"
        Me.LblHoraEntrada.Size = New System.Drawing.Size(67, 13)
        Me.LblHoraEntrada.TabIndex = 5
        Me.LblHoraEntrada.Text = "H. Entrada"
        '
        'ClbFechaEntrada
        '
        Me.ClbFechaEntrada.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaEntrada.Location = New System.Drawing.Point(94, 51)
        Me.ClbFechaEntrada.Name = "ClbFechaEntrada"
        Me.ClbFechaEntrada.Size = New System.Drawing.Size(100, 21)
        Me.ClbFechaEntrada.TabIndex = 2
        '
        'LblFechaEntrada
        '
        Me.LblFechaEntrada.Location = New System.Drawing.Point(12, 54)
        Me.LblFechaEntrada.Name = "LblFechaEntrada"
        Me.LblFechaEntrada.Size = New System.Drawing.Size(63, 13)
        Me.LblFechaEntrada.TabIndex = 3
        Me.LblFechaEntrada.Text = "F. Entrada"
        '
        'ULblDescOperario
        '
        Me.ULblDescOperario.Location = New System.Drawing.Point(200, 22)
        Me.ULblDescOperario.Name = "ULblDescOperario"
        Me.ULblDescOperario.Size = New System.Drawing.Size(183, 23)
        Me.ULblDescOperario.TabIndex = 2
        '
        'AdvOperario
        '
        Me.AdvOperario.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescOperario", ULblDescOperario)})
        Me.AdvOperario.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOperario.EntityName = "Operario"
        Me.AdvOperario.Location = New System.Drawing.Point(94, 22)
        Me.AdvOperario.Name = "AdvOperario"
        Me.AdvOperario.SecondaryDataFields = "IDOperario"
        Me.AdvOperario.Size = New System.Drawing.Size(100, 23)
        Me.AdvOperario.TabIndex = 1
        '
        'LblOperario
        '
        Me.LblOperario.Location = New System.Drawing.Point(12, 27)
        Me.LblOperario.Name = "LblOperario"
        Me.LblOperario.Size = New System.Drawing.Size(57, 13)
        Me.LblOperario.TabIndex = 0
        Me.LblOperario.Text = "Operario"
        '
        'FrmAltaEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 159)
        Me.Controls.Add(Me.FrmEntrada)
        Me.Controls.Add(Me.PnlButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAltaEntrada"
        Me.Text = "Alta Entrada"
        Me.PnlButtons.ResumeLayout(False)
        Me.FrmEntrada.ResumeLayout(False)
        Me.FrmEntrada.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FrmEntrada As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ClbHoraEntrada As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblHoraEntrada As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaEntrada As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblFechaEntrada As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ULblDescOperario As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblOperario As Solmicro.Expertis.Engine.UI.Label
End Class
