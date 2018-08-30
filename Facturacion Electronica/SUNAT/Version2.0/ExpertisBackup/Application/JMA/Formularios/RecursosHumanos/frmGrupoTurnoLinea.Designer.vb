<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupoTurnoLinea
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
        Dim GrdGrupoTurnoLinea_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupoTurnoLinea))
        Me.FrmDetalle = New Solmicro.Expertis.Engine.UI.Frame
        Me.GrdGrupoTurnoLinea = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnlGrupoTurno = New Solmicro.Expertis.Engine.UI.Panel
        Me.ULblDescGrupoTurno = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.TxtGrupoTurno = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblGrupoTurno = New Solmicro.Expertis.Engine.UI.Label
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmDetalle.SuspendLayout()
        CType(Me.GrdGrupoTurnoLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGrupoTurno.suspendlayout()
        Me.PnlButtons.suspendlayout()
        Me.SuspendLayout()
        '
        'FrmDetalle
        '
        Me.FrmDetalle.Controls.Add(Me.GrdGrupoTurnoLinea)
        Me.FrmDetalle.Controls.Add(Me.PnlGrupoTurno)
        Me.FrmDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmDetalle.Location = New System.Drawing.Point(0, 0)
        Me.FrmDetalle.Name = "FrmDetalle"
        Me.FrmDetalle.Size = New System.Drawing.Size(498, 320)
        Me.FrmDetalle.TabIndex = 0
        Me.FrmDetalle.TabStop = False
        Me.FrmDetalle.Text = "Detalle"
        '
        'GrdGrupoTurnoLinea
        '
        Me.GrdGrupoTurnoLinea.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoTurno", "TipoTurno", "IDTipoTurno", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTipoTurno", "DescTipoTurno")}))})
        GrdGrupoTurnoLinea_DesignTimeLayout.LayoutString = resources.GetString("GrdGrupoTurnoLinea_DesignTimeLayout.LayoutString")
        Me.GrdGrupoTurnoLinea.DesignTimeLayout = GrdGrupoTurnoLinea_DesignTimeLayout
        Me.GrdGrupoTurnoLinea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdGrupoTurnoLinea.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdGrupoTurnoLinea.EntityName = "JMAGrupoTurnoLinea"
        Me.GrdGrupoTurnoLinea.Location = New System.Drawing.Point(3, 65)
        Me.GrdGrupoTurnoLinea.Name = "GrdGrupoTurnoLinea"
        Me.GrdGrupoTurnoLinea.PrimaryDataFields = Nothing
        Me.GrdGrupoTurnoLinea.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GrdGrupoTurnoLinea.RequeryManually = True
        Me.GrdGrupoTurnoLinea.SecondaryDataFields = Nothing
        Me.GrdGrupoTurnoLinea.Size = New System.Drawing.Size(492, 252)
        Me.GrdGrupoTurnoLinea.TabIndex = 1
        Me.GrdGrupoTurnoLinea.ViewName = "vJMAGrupoTurnoLinea"
        '
        'PnlGrupoTurno
        '
        Me.PnlGrupoTurno.Controls.Add(Me.ULblDescGrupoTurno)
        Me.PnlGrupoTurno.Controls.Add(Me.TxtGrupoTurno)
        Me.PnlGrupoTurno.Controls.Add(Me.LblGrupoTurno)
        Me.PnlGrupoTurno.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlGrupoTurno.Location = New System.Drawing.Point(3, 17)
        Me.PnlGrupoTurno.Name = "PnlGrupoTurno"
        Me.PnlGrupoTurno.Size = New System.Drawing.Size(492, 48)
        Me.PnlGrupoTurno.TabIndex = 0
        '
        'ULblDescGrupoTurno
        '
        Me.ULblDescGrupoTurno.Location = New System.Drawing.Point(197, 9)
        Me.ULblDescGrupoTurno.Name = "ULblDescGrupoTurno"
        Me.ULblDescGrupoTurno.Size = New System.Drawing.Size(287, 23)
        Me.ULblDescGrupoTurno.TabIndex = 2
        Me.ULblDescGrupoTurno.UseMnemonic = False
        '
        'TxtGrupoTurno
        '
        Me.TxtGrupoTurno.DisabledBackColor = System.Drawing.Color.White
        Me.TxtGrupoTurno.Enabled = False
        Me.TxtGrupoTurno.Location = New System.Drawing.Point(93, 11)
        Me.TxtGrupoTurno.Name = "TxtGrupoTurno"
        Me.TxtGrupoTurno.Size = New System.Drawing.Size(100, 21)
        Me.TxtGrupoTurno.TabIndex = 1
        '
        'LblGrupoTurno
        '
        Me.LblGrupoTurno.Location = New System.Drawing.Point(9, 14)
        Me.LblGrupoTurno.Name = "LblGrupoTurno"
        Me.LblGrupoTurno.Size = New System.Drawing.Size(78, 13)
        Me.LblGrupoTurno.TabIndex = 0
        Me.LblGrupoTurno.Text = "Grupo Turno"
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 320)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(498, 37)
        Me.PnlButtons.TabIndex = 1
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(252, 7)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(171, 7)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "Aceptar"
        '
        'frmGrupoTurnoLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 357)
        Me.Controls.Add(Me.FrmDetalle)
        Me.Controls.Add(Me.PnlButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGrupoTurnoLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Grupo Turno"
        Me.FrmDetalle.ResumeLayout(False)
        CType(Me.GrdGrupoTurnoLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGrupoTurno.ResumeLayout(False)
        Me.PnlGrupoTurno.PerformLayout()
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FrmDetalle As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents GrdGrupoTurnoLinea As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents PnlGrupoTurno As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ULblDescGrupoTurno As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents TxtGrupoTurno As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblGrupoTurno As Solmicro.Expertis.Engine.UI.Label
End Class
