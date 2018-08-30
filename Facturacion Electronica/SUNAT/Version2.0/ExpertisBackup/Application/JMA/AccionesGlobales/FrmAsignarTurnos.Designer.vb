<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarTurnos
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
        Me.CalendarBoxFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.CalendarBoxInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvSearchOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ButtonAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.ButtonCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.UnderLineLabelOperario = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.UnderLineLabelGrupoTurno = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.LabelFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.LabelFehaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvSearchGurpoTurno = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LabelOperacio = New Solmicro.Expertis.Engine.UI.Label
        Me.LabelTurno = New Solmicro.Expertis.Engine.UI.Label
        Me.LabelTurnoActual = New Solmicro.Expertis.Engine.UI.Label
        Me.SuspendLayout()
        '
        'CalendarBoxFin
        '
        Me.CalendarBoxFin.DisabledBackColor = System.Drawing.Color.White
        Me.CalendarBoxFin.Location = New System.Drawing.Point(247, 186)
        Me.CalendarBoxFin.Name = "CalendarBoxFin"
        Me.CalendarBoxFin.Size = New System.Drawing.Size(172, 21)
        Me.CalendarBoxFin.TabIndex = 0
        '
        'CalendarBoxInicio
        '
        Me.CalendarBoxInicio.DisabledBackColor = System.Drawing.Color.White
        Me.CalendarBoxInicio.Location = New System.Drawing.Point(27, 186)
        Me.CalendarBoxInicio.Name = "CalendarBoxInicio"
        Me.CalendarBoxInicio.Size = New System.Drawing.Size(172, 21)
        Me.CalendarBoxInicio.TabIndex = 1
        '
        'AdvSearchOperario
        '
        Me.AdvSearchOperario.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSearchOperario.EntityName = "operario"
        Me.AdvSearchOperario.Location = New System.Drawing.Point(12, 34)
        Me.AdvSearchOperario.Name = "AdvSearchOperario"
        Me.AdvSearchOperario.SecondaryDataFields = "IDoperario"
        Me.AdvSearchOperario.Size = New System.Drawing.Size(163, 23)
        Me.AdvSearchOperario.TabIndex = 3
        Me.AdvSearchOperario.ViewName = "advOperario"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(247, 226)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 4
        Me.ButtonAceptar.Text = "Aceptar"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(344, 226)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 5
        Me.ButtonCancelar.Text = "Cancelar"
        '
        'UnderLineLabelOperario
        '
        Me.UnderLineLabelOperario.Location = New System.Drawing.Point(178, 34)
        Me.UnderLineLabelOperario.Name = "UnderLineLabelOperario"
        Me.UnderLineLabelOperario.Size = New System.Drawing.Size(241, 23)
        Me.UnderLineLabelOperario.TabIndex = 7
        Me.UnderLineLabelOperario.UseMnemonic = False
        '
        'UnderLineLabelGrupoTurno
        '
        Me.UnderLineLabelGrupoTurno.Location = New System.Drawing.Point(181, 86)
        Me.UnderLineLabelGrupoTurno.Name = "UnderLineLabelGrupoTurno"
        Me.UnderLineLabelGrupoTurno.Size = New System.Drawing.Size(238, 23)
        Me.UnderLineLabelGrupoTurno.TabIndex = 8
        Me.UnderLineLabelGrupoTurno.UseMnemonic = False
        '
        'LabelFechaInicio
        '
        Me.LabelFechaInicio.Location = New System.Drawing.Point(72, 162)
        Me.LabelFechaInicio.Name = "LabelFechaInicio"
        Me.LabelFechaInicio.Size = New System.Drawing.Size(75, 13)
        Me.LabelFechaInicio.TabIndex = 9
        Me.LabelFechaInicio.Text = "Fecha Inicio"
        '
        'LabelFehaFin
        '
        Me.LabelFehaFin.Location = New System.Drawing.Point(302, 162)
        Me.LabelFehaFin.Name = "LabelFehaFin"
        Me.LabelFehaFin.Size = New System.Drawing.Size(60, 13)
        Me.LabelFehaFin.TabIndex = 10
        Me.LabelFehaFin.Text = "Fecha Fin"
        '
        'AdvSearchGurpoTurno
        '
        Me.AdvSearchGurpoTurno.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSearchGurpoTurno.EntityName = "JMAGrupoTurno"
        Me.AdvSearchGurpoTurno.Location = New System.Drawing.Point(12, 86)
        Me.AdvSearchGurpoTurno.Name = "AdvSearchGurpoTurno"
        Me.AdvSearchGurpoTurno.SecondaryDataFields = "NGrupoTurno"
        Me.AdvSearchGurpoTurno.Size = New System.Drawing.Size(163, 23)
        Me.AdvSearchGurpoTurno.TabIndex = 11
        '
        'LabelOperacio
        '
        Me.LabelOperacio.Location = New System.Drawing.Point(16, 13)
        Me.LabelOperacio.Name = "LabelOperacio"
        Me.LabelOperacio.Size = New System.Drawing.Size(57, 13)
        Me.LabelOperacio.TabIndex = 12
        Me.LabelOperacio.Text = "Operario"
        '
        'LabelTurno
        '
        Me.LabelTurno.Location = New System.Drawing.Point(16, 65)
        Me.LabelTurno.Name = "LabelTurno"
        Me.LabelTurno.Size = New System.Drawing.Size(39, 13)
        Me.LabelTurno.TabIndex = 13
        Me.LabelTurno.Text = "Turno"
        '
        'LabelTurnoActual
        '
        Me.LabelTurnoActual.Location = New System.Drawing.Point(16, 125)
        Me.LabelTurnoActual.Name = "LabelTurnoActual"
        Me.LabelTurnoActual.Size = New System.Drawing.Size(0, 13)
        Me.LabelTurnoActual.TabIndex = 14
        '
        'FrmAsignarTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 258)
        Me.Controls.Add(Me.LabelTurnoActual)
        Me.Controls.Add(Me.LabelTurno)
        Me.Controls.Add(Me.LabelOperacio)
        Me.Controls.Add(Me.AdvSearchGurpoTurno)
        Me.Controls.Add(Me.LabelFehaFin)
        Me.Controls.Add(Me.LabelFechaInicio)
        Me.Controls.Add(Me.UnderLineLabelGrupoTurno)
        Me.Controls.Add(Me.UnderLineLabelOperario)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.AdvSearchOperario)
        Me.Controls.Add(Me.CalendarBoxInicio)
        Me.Controls.Add(Me.CalendarBoxFin)
        Me.Name = "FrmAsignarTurnos"
        Me.Text = "Asignar Turnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CalendarBoxFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents CalendarBoxInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvSearchOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ButtonAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ButtonCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents UnderLineLabelOperario As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents UnderLineLabelGrupoTurno As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents LabelFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LabelFehaFin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvSearchGurpoTurno As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LabelOperacio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LabelTurno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LabelTurnoActual As Solmicro.Expertis.Engine.UI.Label
End Class
