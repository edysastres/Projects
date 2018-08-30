
Public Class frmCalendarioOperario
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

    Dim g As NeededData
    Dim g2 As NeededData

    '''''''''''''''''Modificado  Buscar Que usuario Abrio el expertis
    Dim OperarioActual As String = ExpertisApp.ExecuteTask(Of ClsProcesosRecursosHumanos, String)(AddressOf ClsProcesosRecursosHumanos.ObtenerOperario, Nothing)


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        InicializarNeededData()

    End Sub

    Private Sub InicializarNeededData() '''''''''''''Modificado
        Dim NOpe() As String = {"IDOperario"}
        g = New NeededData("tbCalendarioOperario", RelationMode.ChildMode, NOpe, NOpe)
        g.EntityName = "CalendarioOperario"
        Me.AddDataItem(g)
        g2 = New NeededData("tbTipoTurno", RelationMode.NoRelation, Nothing, Nothing)
        g2.EntityName = "TipoTurno"
        Me.AddDataItem(g2)
        '''''''''Colocar el usuaruio  que Abrio Expertis
        TextBox1.Text = OperarioActual

    End Sub
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TextBox1 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents PanelCalendar As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents PanelCentro As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents PanelCalen As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Calendar As Solmicro.Expertis.Application.ERP.XCalendar.Calendar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.TextBox1 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.PanelCalendar = New Solmicro.Expertis.Engine.UI.Panel
        Me.PanelCalen = New Solmicro.Expertis.Engine.UI.Panel
        Me.Calendar = New Solmicro.Expertis.Application.ERP.XCalendar.Calendar
        Me.PanelCentro = New Solmicro.Expertis.Engine.UI.Panel
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.PanelCalendar.suspendlayout()
        Me.PanelCalen.suspendlayout()
        Me.PanelCentro.suspendlayout()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(643, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'Delete
        '
        Me.Delete.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Cancel
        '
        '
        'Print
        '
        Me.Print.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'NewRow
        '
        Me.NewRow.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Requery
        '
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.PanelCalendar)
        Me.MainPanel.Size = New System.Drawing.Size(856, 541)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(310, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Operario"
        '
        'TextBox1
        '
        Me.TryDataBinding(TextBox1, New System.Windows.Forms.Binding("Text", Me, "IdOperario", True))
        Me.TextBox1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(372, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(157, 21)
        Me.TextBox1.TabIndex = 2
        '
        'PanelCalendar
        '
        Me.PanelCalendar.Controls.Add(Me.PanelCalen)
        Me.PanelCalendar.Controls.Add(Me.PanelCentro)
        Me.PanelCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCalendar.Location = New System.Drawing.Point(0, 0)
        Me.PanelCalendar.Name = "PanelCalendar"
        Me.PanelCalendar.Size = New System.Drawing.Size(856, 541)
        Me.PanelCalendar.TabIndex = 4
        '
        'PanelCalen
        '
        Me.PanelCalen.Controls.Add(Me.Calendar)
        Me.PanelCalen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCalen.Location = New System.Drawing.Point(0, 40)
        Me.PanelCalen.Name = "PanelCalen"
        Me.PanelCalen.Size = New System.Drawing.Size(856, 501)
        Me.PanelCalen.TabIndex = 5
        '
        'Calendar
        '
        Me.Calendar.AttributeTypeFieldName = "IDTipoTurno"
        Me.Calendar.ColorFieldName = "Color"
        Me.Calendar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Calendar.DateFieldName = "Fecha"
        Me.Calendar.DayBorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Calendar.DayColor = System.Drawing.Color.White
        Me.Calendar.DayTextForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Calendar.DayTypeFieldName = "TipoDia"
        Me.Calendar.DescFieldName = "DescTipoTurno"
        Me.Calendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Calendar.dsAttributes = Nothing
        Me.Calendar.dsCalendar = Nothing
        Me.Calendar.IDFieldName = "IDTipoTurno"
        Me.Calendar.KeyFieldName = "IdOperario"
        Me.Calendar.Location = New System.Drawing.Point(0, 0)
        Me.Calendar.MonthHeaderTextForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Calendar.Name = "Calendar"
        Me.Calendar.NormalAttributeColor = System.Drawing.Color.White
        Me.Calendar.SelectedDayColor = System.Drawing.Color.Gold
        Me.Calendar.Size = New System.Drawing.Size(856, 501)
        Me.Calendar.TabIndex = 4
        Me.Calendar.usrAttributesText = "Turnos"
        '
        'PanelCentro
        '
        Me.PanelCentro.Controls.Add(Me.TextBox1)
        Me.PanelCentro.Controls.Add(Me.Label1)
        Me.PanelCentro.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCentro.Location = New System.Drawing.Point(0, 0)
        Me.PanelCentro.Name = "PanelCentro"
        Me.PanelCentro.Size = New System.Drawing.Size(856, 40)
        Me.PanelCentro.TabIndex = 4
        '
        'frmCalendarioOperario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(864, 614)
        Me.EntityName = "Operario"
        Me.Name = "frmCalendarioOperario"
        Me.NavigationFields = "IDOperario"
        Me.Text = "frmCalendario"
        Me.ViewName = "tbMaestroOperario"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.PanelCalendar.ResumeLayout(False)
        Me.PanelCalen.ResumeLayout(False)
        Me.PanelCentro.ResumeLayout(False)
        Me.PanelCentro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Procesos Privados"

    Private Sub LoadFormActions()''''''''Modificado
        ' Me.FormActions.Add("Copiar Calendario Operario a otro Operario", AddressOf CopiarCalendarioOperario)
    End Sub

    Private Sub CopiarCalendarioOperario()
        Dim FrmCopia As New FrmCopiaCalendarioOperario
        FrmCopia.AñoCalendario = Calendar.MonthYear
        If FrmCopia.ShowDialog = DialogResult.OK Then
            Dim StrOperarioOrigen As String = FrmCopia.OperarioOrigen
            Dim StrOperarioDesde As String = FrmCopia.OperarioDesde
            Dim StrOperarioHasta As String = FrmCopia.OperarioHasta
            Dim StrOficio As String = FrmCopia.Oficio
            Dim StrCategoria As String = FrmCopia.Categoria
            Dim ClsCalen As New CalendarioOperario
            Dim StCalen As New CalendarioOperario.DatosCopiarCalenOper
            StCalen.IDOperarioOrigen = StrOperarioOrigen : StCalen.IDOperarioDesde = StrOperarioDesde
            StCalen.IDOperarioHasta = StrOperarioHasta : StCalen.IDOficio = StrOficio
            StCalen.IDCategoria = StrCategoria : StCalen.Año = Calendar.MonthYear
            ExpertisApp.ExecuteTask(Of CalendarioOperario.DatosCopiarCalenOper)(AddressOf CalendarioOperario.CopiarCalendarioOperarios, StCalen)
            ExpertisApp.GenerateMessage("Se ha copiado el Calendario del Operario: | en sus destinos.", MessageBoxButtons.OK, MessageBoxIcon.Information, StrOperarioOrigen)
            Me.Refresh()
        End If
    End Sub

#End Region

#Region " frmCalendarioOperario Events "
    ''''''''Modificado
    Private Sub frmCalendarioOperario_Navigated(ByVal sender As Object, ByVal e As Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated

        TextBox1.Text = OperarioActual

        Me.Calendar.Visible = False
        Me.Calendar.Activate = True
        If Me.Calendar.dsAttributes Is Nothing Then
            Me.Calendar.dsAttributes = g2.Data
        End If
        Me.Calendar.dsCalendar = g.Data
        Me.Calendar.Visible = True
        Me.Calendar.RefreshCalendar(g.Data, True)

        ''''''''Actualizar Registro
        frmCalendarioOperario_RecordUpdated(Nothing, Nothing)

        Calendar.PnlOptions.Hide()

        ''''''''''''''Precionar F10  para que puedan guardar sin problema
        System.Threading.Thread.Sleep(1000)
        SendKeys.SendWait("{F10}")

    End Sub

    Private Sub frmCalendarioOperario_Navigating(ByVal sender As Object, ByVal e As Engine.UI.NavigatingEventArgs) Handles MyBase.Navigating
        Dim ofilter As Filter = Me.Calendar.CreateMonthFilter()
        g.Filter = ofilter
    End Sub

    Private Sub frmCalendarioOperario_RecordUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordUpdating
        Try
            Dim oCalOperario As New CalendarioOperario
            Dim oTable As DataTable = Me.Calendar.ModifiedCalendar
            If Not oTable Is Nothing And oTable.Rows.Count > 0 Then
                oTable.TableName = "CalendarioOperario"
                oCalOperario.Update(oTable)
            End If
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frmCalendarioOperario_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated
        Dim ofilter As Filter = Me.Calendar.CreateMonthFilter(True)
        Dim oCalOperario As New CalendarioOperario
        g.Data = oCalOperario.Filter(ofilter)
        Me.Calendar.RefreshCalendar(g.Data, True)
    End Sub

    Private Sub frmCalendarioOperario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFormActions()
    End Sub

#End Region

#Region " Toolbar Events"
    Private Sub CargarCalendario(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles Cancel.Click, Requery.Click
        Me.Calendar.dsAttributes = g2.Data
        Me.Calendar.RefreshCalendar(g.Data, True)
    End Sub
#End Region

#Region " Calendar Events "

    Private Sub Calendar_CalendarNavigated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar.CalendarNavigated
        Dim ofilter As Filter = Me.Calendar.CreateMonthFilter(True)
        Dim oCalOperario As New CalendarioOperario
        g.Data = oCalOperario.Filter(ofilter)
        Me.Calendar.RefreshCalendar(g.Data)
    End Sub

    Private Sub Calendar_CalendarChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar.CalendarChanged
        'Me.Cancel.Enabled = Janus.Windows.UI.InheritableBoolean.True
        'Me.Ok.Enabled = Janus.Windows.UI.InheritableBoolean.True
        Me.RecordsState = RecordsState.Modified
    End Sub

#End Region

 
  
End Class