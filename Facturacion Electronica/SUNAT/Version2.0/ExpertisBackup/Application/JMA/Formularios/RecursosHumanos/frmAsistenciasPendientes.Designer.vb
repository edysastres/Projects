<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsistenciasPendientes
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
        Dim GrdRegistros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsistenciasPendientes))
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.GrdRegistros = New Solmicro.Expertis.Engine.UI.Grid
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.GrdRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(566, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No se pudo generar la nómina debido a que los siguientes registros están pendient" & _
            "es de revisión:"
        '
        'GrdRegistros
        '
        Me.GrdRegistros.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GrdRegistros_DesignTimeLayout.LayoutString = resources.GetString("GrdRegistros_DesignTimeLayout.LayoutString")
        Me.GrdRegistros.DesignTimeLayout = GrdRegistros_DesignTimeLayout
        Me.GrdRegistros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdRegistros.EntityName = Nothing
        Me.GrdRegistros.Location = New System.Drawing.Point(12, 59)
        Me.GrdRegistros.Name = "GrdRegistros"
        Me.GrdRegistros.PrimaryDataFields = Nothing
        Me.GrdRegistros.SecondaryDataFields = Nothing
        Me.GrdRegistros.Size = New System.Drawing.Size(575, 297)
        Me.GrdRegistros.TabIndex = 1
        Me.GrdRegistros.ViewName = "vJMACalendarioOperario"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        '
        'frmAsistenciasPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 402)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrdRegistros)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAsistenciasPendientes"
        Me.Text = "Registros pendientes"
        CType(Me.GrdRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GrdRegistros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
End Class
