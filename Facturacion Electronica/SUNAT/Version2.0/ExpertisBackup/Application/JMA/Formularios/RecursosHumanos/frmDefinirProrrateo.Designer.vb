<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefinirProrrateo
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
        Dim GrdProrrateo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDefinirProrrateo))
        Me.FrmDetalle = New Solmicro.Expertis.Engine.UI.Frame
        Me.GrdProrrateo = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnlGrupoTurno = New Solmicro.Expertis.Engine.UI.Panel
        Me.ULblDescClasif = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.TxtIDClasif = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblGrupoTurno = New Solmicro.Expertis.Engine.UI.Label
        Me.activeControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmDetalle.SuspendLayout()
        CType(Me.GrdProrrateo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGrupoTurno.suspendlayout()
        CType(Me.activeControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlButtons.suspendlayout()
        Me.SuspendLayout()
        '
        'FrmDetalle
        '
        Me.FrmDetalle.Controls.Add(Me.GrdProrrateo)
        Me.FrmDetalle.Controls.Add(Me.PnlGrupoTurno)
        Me.FrmDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmDetalle.Location = New System.Drawing.Point(0, 0)
        Me.FrmDetalle.Name = "FrmDetalle"
        Me.FrmDetalle.Size = New System.Drawing.Size(541, 322)
        Me.FrmDetalle.TabIndex = 0
        Me.FrmDetalle.TabStop = False
        Me.FrmDetalle.Text = "Prorrateo"
        '
        'GrdProrrateo
        '
        Me.GrdProrrateo.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCCPDestino", "ClasificacionCostoPersonal", "IDClasificacionCostoPersonal", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDClasificacionCostoPersonal", "IDCCPDestino")}), "vClasificacionCostoPersonal")})
        GrdProrrateo_DesignTimeLayout.LayoutString = resources.GetString("GrdProrrateo_DesignTimeLayout.LayoutString")
        Me.GrdProrrateo.DesignTimeLayout = GrdProrrateo_DesignTimeLayout
        Me.GrdProrrateo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdProrrateo.EntityName = "ProrrateoClasificacionCostoPersonal"
        Me.GrdProrrateo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrdProrrateo.Location = New System.Drawing.Point(3, 71)
        Me.GrdProrrateo.Name = "GrdProrrateo"
        Me.GrdProrrateo.PrimaryDataFields = Nothing
        Me.GrdProrrateo.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GrdProrrateo.RequeryManually = True
        Me.GrdProrrateo.SecondaryDataFields = Nothing
        Me.GrdProrrateo.Size = New System.Drawing.Size(535, 243)
        Me.GrdProrrateo.TabIndex = 1
        Me.GrdProrrateo.ViewName = "vProrrateoClasificacionCostoPersonal"
        '
        'PnlGrupoTurno
        '
        Me.PnlGrupoTurno.Controls.Add(Me.ULblDescClasif)
        Me.PnlGrupoTurno.Controls.Add(Me.TxtIDClasif)
        Me.PnlGrupoTurno.Controls.Add(Me.LblGrupoTurno)
        Me.PnlGrupoTurno.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlGrupoTurno.Location = New System.Drawing.Point(3, 17)
        Me.PnlGrupoTurno.Name = "PnlGrupoTurno"
        Me.PnlGrupoTurno.Size = New System.Drawing.Size(535, 48)
        Me.PnlGrupoTurno.TabIndex = 0
        '
        'ULblDescClasif
        '
        Me.ULblDescClasif.Location = New System.Drawing.Point(280, 9)
        Me.ULblDescClasif.Name = "ULblDescClasif"
        Me.ULblDescClasif.Size = New System.Drawing.Size(246, 23)
        Me.ULblDescClasif.TabIndex = 2
        Me.ULblDescClasif.UseMnemonic = False
        '
        'TxtIDClasif
        '
        Me.TxtIDClasif.DisabledBackColor = System.Drawing.Color.White
        Me.TxtIDClasif.Enabled = False
        Me.TxtIDClasif.Location = New System.Drawing.Point(152, 10)
        Me.TxtIDClasif.Name = "TxtIDClasif"
        Me.TxtIDClasif.Size = New System.Drawing.Size(122, 21)
        Me.TxtIDClasif.TabIndex = 1
        '
        'LblGrupoTurno
        '
        Me.LblGrupoTurno.Location = New System.Drawing.Point(9, 14)
        Me.LblGrupoTurno.Name = "LblGrupoTurno"
        Me.LblGrupoTurno.Size = New System.Drawing.Size(137, 13)
        Me.LblGrupoTurno.TabIndex = 0
        Me.LblGrupoTurno.Text = "Clasif. Costo Personal:"
        '
        'activeControl
        '
        Me.activeControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCCPDestino", "ClasificacionCostoPersonal", "IDClasificacionCostoPersonal", "vClasificacionCostoPersonal")})
        Me.activeControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.activeControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.activeControl.EntityName = "ProrrateoClasificacionCostoPersonal"
        Me.activeControl.Location = New System.Drawing.Point(3, 65)
        Me.activeControl.Name = "activeControl"
        Me.activeControl.PrimaryDataFields = Nothing
        Me.activeControl.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.activeControl.RequeryManually = True
        Me.activeControl.SecondaryDataFields = Nothing
        Me.activeControl.Size = New System.Drawing.Size(492, 252)
        Me.activeControl.TabIndex = 1
        Me.activeControl.ViewName = "vProrrateoClasificacionCostoPersonal"
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 322)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(541, 37)
        Me.PnlButtons.TabIndex = 1
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(283, 6)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(202, 6)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "Aceptar"
        '
        'frmDefinirrProrrateo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 359)
        Me.Controls.Add(Me.FrmDetalle)
        Me.Controls.Add(Me.PnlButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDefinirrProrrateo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definir prorrateo"
        Me.FrmDetalle.ResumeLayout(False)
        CType(Me.GrdProrrateo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGrupoTurno.ResumeLayout(False)
        Me.PnlGrupoTurno.PerformLayout()
        CType(Me.activeControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FrmDetalle As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents activeControl As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents PnlGrupoTurno As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ULblDescClasif As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents TxtIDClasif As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblGrupoTurno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GrdProrrateo As Solmicro.Expertis.Engine.UI.Grid
End Class
