Public Class MntoUdMedida
    Inherits Solmicro.Expertis.Engine.UI.GridMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoUdMedida))
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(465, 28)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 28)
        Me.MenuBar.Size = New System.Drawing.Size(544, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(512, 269)
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = False
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "UdMedida"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Size = New System.Drawing.Size(512, 269)
        Me.Grid.ViewName = "tbMaestroUdMedida"
        '
        'MntoUdMedida
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.EntityName = "UdMedida"
        Me.Name = "MntoUdMedida"
        Me.NavigationFields = "IDUdMedida"
        Me.ViewName = "tbMaestroUdMedida"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Select Case e.Column.Key
            Case "IDUdMedida"
                e.Cancel = Grid.Row <> Grid.newTopRowPosition
        End Select
    End Sub

    Private Sub MntoUdMedida_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.UiCommandManager1.CommandBars(0).Commands("ExecuteActions").Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.Grid.Columns("CodigoFacturae").DropDown.SetDataBinding(EnumData.EnumView("enumCodFacturaeUDMedida"), Nothing)
        Dim data As DataTable = New BE.DataEngine().Filter("tbEMCSCodigos", New FilterItem("TipoCodigo", CInt(enumTipoCodigoEMCS.TipoEmbalaje)))
        Grid.Columns("IDTipoEmbalaje").DropDown.SetDataBinding(data, String.Empty)
    End Sub

End Class
