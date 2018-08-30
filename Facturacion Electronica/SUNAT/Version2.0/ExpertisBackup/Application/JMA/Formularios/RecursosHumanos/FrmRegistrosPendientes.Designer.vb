<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrosPendientes
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
        Dim activeControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrosPendientes))
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.activeControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.btnMoverRegistros = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.activeControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(592, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Los registros mostrados están pendientes de tener un usuario asignado. Favor de a" & _
            "signar su operario."
        '
        'activeControl
        '
        Me.activeControl.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        activeControl_DesignTimeLayout.LayoutString = resources.GetString("activeControl_DesignTimeLayout.LayoutString")
        Me.activeControl.DesignTimeLayout = activeControl_DesignTimeLayout
        Me.activeControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.activeControl.EntityName = ""
        Me.activeControl.Location = New System.Drawing.Point(12, 37)
        Me.activeControl.Name = "activeControl"
        Me.activeControl.PrimaryDataFields = ""
        Me.activeControl.SecondaryDataFields = ""
        Me.activeControl.Size = New System.Drawing.Size(606, 376)
        Me.activeControl.TabIndex = 1
        Me.activeControl.ViewName = "vControlAsistenciasPendientes"
        '
        'btnMoverRegistros
        '
        Me.btnMoverRegistros.Location = New System.Drawing.Point(257, 420)
        Me.btnMoverRegistros.Name = "btnMoverRegistros"
        Me.btnMoverRegistros.Size = New System.Drawing.Size(113, 23)
        Me.btnMoverRegistros.TabIndex = 3
        Me.btnMoverRegistros.Text = "Migrar registros "
        '
        'FrmRegistrosPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMoverRegistros)
        Me.Controls.Add(Me.activeControl)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegistrosPendientes"
        Me.ShowInTaskbar = True
        Me.Text = "AVISO!!"
        CType(Me.activeControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GrdRegistros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents activeControl As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents btnMoverRegistros As Solmicro.Expertis.Engine.UI.Button
End Class
