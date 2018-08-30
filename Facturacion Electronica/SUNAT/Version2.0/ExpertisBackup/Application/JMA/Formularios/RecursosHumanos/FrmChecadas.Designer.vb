<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChecadas
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
        Me.components = New System.ComponentModel.Container
        Dim GrdControlPrecencia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChecadas))
        Me.GrdControlPrecencia = New Solmicro.Expertis.Engine.UI.Grid
        Me.LabelOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.LabelFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.TextBoxDescOperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TextBoxFecha = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ButtonAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.ButtonCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.TextBoxIdOperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ButtonAltaNuevaEntrada = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.GrdControlPrecencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrdControlPrecencia
        '
        GrdControlPrecencia_DesignTimeLayout.LayoutString = resources.GetString("GrdControlPrecencia_DesignTimeLayout.LayoutString")
        Me.GrdControlPrecencia.DesignTimeLayout = GrdControlPrecencia_DesignTimeLayout
        Me.GrdControlPrecencia.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdControlPrecencia.EntityName = "ControlPresencia"
        Me.GrdControlPrecencia.Location = New System.Drawing.Point(14, 93)
        Me.GrdControlPrecencia.Name = "GrdControlPrecencia"
        Me.GrdControlPrecencia.PrimaryDataFields = Nothing
        Me.GrdControlPrecencia.SecondaryDataFields = Nothing
        Me.GrdControlPrecencia.Size = New System.Drawing.Size(498, 252)
        Me.GrdControlPrecencia.TabIndex = 0
        Me.GrdControlPrecencia.ViewName = "vJMACIControlDedicacionOperario"
        '
        'LabelOperario
        '
        Me.LabelOperario.Location = New System.Drawing.Point(19, 27)
        Me.LabelOperario.Name = "LabelOperario"
        Me.LabelOperario.Size = New System.Drawing.Size(57, 13)
        Me.LabelOperario.TabIndex = 1
        Me.LabelOperario.Text = "Operario"
        '
        'LabelFecha
        '
        Me.LabelFecha.Location = New System.Drawing.Point(19, 59)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(40, 13)
        Me.LabelFecha.TabIndex = 2
        Me.LabelFecha.Text = "Fecha"
        '
        'TextBoxDescOperario
        '
        Me.TextBoxDescOperario.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxDescOperario.Location = New System.Drawing.Point(162, 23)
        Me.TextBoxDescOperario.Name = "TextBoxDescOperario"
        Me.TextBoxDescOperario.ReadOnly = True
        Me.TextBoxDescOperario.Size = New System.Drawing.Size(350, 21)
        Me.TextBoxDescOperario.TabIndex = 3
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxFecha.Location = New System.Drawing.Point(85, 55)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.ReadOnly = True
        Me.TextBoxFecha.Size = New System.Drawing.Size(140, 21)
        Me.TextBoxFecha.TabIndex = 4
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(14, 359)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 5
        Me.ButtonAceptar.Text = "Aceptar"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(95, 359)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 6
        Me.ButtonCancelar.Text = "Cancelar"
        '
        'TextBoxIdOperario
        '
        Me.TextBoxIdOperario.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxIdOperario.Location = New System.Drawing.Point(85, 23)
        Me.TextBoxIdOperario.Name = "TextBoxIdOperario"
        Me.TextBoxIdOperario.ReadOnly = True
        Me.TextBoxIdOperario.Size = New System.Drawing.Size(71, 21)
        Me.TextBoxIdOperario.TabIndex = 7
        '
        'ButtonAltaNuevaEntrada
        '
        Me.ButtonAltaNuevaEntrada.Location = New System.Drawing.Point(323, 359)
        Me.ButtonAltaNuevaEntrada.Name = "ButtonAltaNuevaEntrada"
        Me.ButtonAltaNuevaEntrada.Size = New System.Drawing.Size(189, 23)
        Me.ButtonAltaNuevaEntrada.TabIndex = 8
        Me.ButtonAltaNuevaEntrada.Text = "Nuevo Registro"
        '
        'FrmChecadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 402)
        Me.Controls.Add(Me.ButtonAltaNuevaEntrada)
        Me.Controls.Add(Me.TextBoxIdOperario)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.TextBoxFecha)
        Me.Controls.Add(Me.TextBoxDescOperario)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.LabelOperario)
        Me.Controls.Add(Me.GrdControlPrecencia)
        Me.EntityName = "ControlPresencia"
        Me.Name = "FrmChecadas"
        Me.Text = "Regitro de Asistencias"
        CType(Me.GrdControlPrecencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrdControlPrecencia As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents LabelOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LabelFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TextBoxDescOperario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TextBoxFecha As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ButtonAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ButtonCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents TextBoxIdOperario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ButtonAltaNuevaEntrada As Solmicro.Expertis.Engine.UI.Button
End Class
