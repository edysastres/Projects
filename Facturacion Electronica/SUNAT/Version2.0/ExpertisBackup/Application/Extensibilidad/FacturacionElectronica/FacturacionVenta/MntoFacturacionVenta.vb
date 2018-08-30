Public Class MntoFacturacionVenta
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtImporte.Value = System.DBNull.Value
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
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPeriodoFacturacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDAlbaranHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblAlbaranHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDAlbaranDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblAlbaranDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cbxAño As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblAño As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxPeriodoFacturacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvCentroGestion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblFechaFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbOperador As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents ClbFechaFactura As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxPeriodoFacturacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxAño_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbOperador_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoFacturacionVenta))
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxPeriodoFacturacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblPeriodoFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDAlbaranHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlbaranHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDAlbaranDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlbaranDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.ClbFechaFactura = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxAño = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblAño = New Solmicro.Expertis.Engine.UI.Label
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvCentroGestion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbOperador = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cmbEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxPeriodoFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        CType(Me.cbxAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOperador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cmbEstado)
        Me.FilterPanel.Controls.Add(Me.cbOperador)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.AdvCentroGestion)
        Me.FilterPanel.Controls.Add(Me.LblCentroGestion)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.lblPeriodoFacturacion)
        Me.FilterPanel.Controls.Add(Me.lblImporte)
        Me.FilterPanel.Controls.Add(Me.lblAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.lblAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.AdvIDObra)
        Me.FilterPanel.Controls.Add(Me.cbxPeriodoFacturacion)
        Me.FilterPanel.Controls.Add(Me.txtImporte)
        Me.FilterPanel.Controls.Add(Me.AdvIDAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.AdvIDAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.AdvIDCliente)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 251)
        Me.FilterPanel.Size = New System.Drawing.Size(624, 114)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(624, 251)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "AlbaranVentaCabecera"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDAlbaran"
        Me.Grid.Location = New System.Drawing.Point(0, 40)
        Me.Grid.Size = New System.Drawing.Size(624, 211)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "VFrmMntoFacturacionVenta"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(320, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(624, 365)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(624, 365)
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(309, 16)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(104, 23)
        Me.AdvIDObra.TabIndex = 3
        Me.AdvIDObra.ViewName = "tbObraCabecera"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(224, 16)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(35, 13)
        Me.lblObra.TabIndex = 0
        Me.lblObra.Text = "Obra"
        '
        'cbxPeriodoFacturacion
        '
        Me.TryDataBinding(cbxPeriodoFacturacion, New System.Windows.Forms.Binding("Value", Me, "PeriodoFacturacion", True))
        cbxPeriodoFacturacion_DesignTimeLayout.LayoutString = resources.GetString("cbxPeriodoFacturacion_DesignTimeLayout.LayoutString")
        Me.cbxPeriodoFacturacion.DesignTimeLayout = cbxPeriodoFacturacion_DesignTimeLayout
        Me.cbxPeriodoFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxPeriodoFacturacion.Location = New System.Drawing.Point(520, 40)
        Me.cbxPeriodoFacturacion.Name = "cbxPeriodoFacturacion"
        Me.cbxPeriodoFacturacion.SelectedIndex = -1
        Me.cbxPeriodoFacturacion.SelectedItem = Nothing
        Me.cbxPeriodoFacturacion.Size = New System.Drawing.Size(96, 21)
        Me.cbxPeriodoFacturacion.TabIndex = 7
        '
        'lblPeriodoFacturacion
        '
        Me.lblPeriodoFacturacion.Location = New System.Drawing.Point(429, 40)
        Me.lblPeriodoFacturacion.Name = "lblPeriodoFacturacion"
        Me.lblPeriodoFacturacion.Size = New System.Drawing.Size(50, 13)
        Me.lblPeriodoFacturacion.TabIndex = 4
        Me.lblPeriodoFacturacion.Text = "Periodo"
        '
        'txtImporte
        '
        Me.txtImporte.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporte.Location = New System.Drawing.Point(520, 16)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporte.Size = New System.Drawing.Size(96, 21)
        Me.txtImporte.TabIndex = 6
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(429, 16)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(66, 13)
        Me.lblImporte.TabIndex = 9
        Me.lblImporte.Text = "Importe >"
        '
        'AdvIDAlbaranHasta
        '
        Me.AdvIDAlbaranHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDAlbaranHasta.DisplayField = "NAlbaran"
        Me.AdvIDAlbaranHasta.EntityName = "AlbaranVentaCabecera"
        Me.AdvIDAlbaranHasta.Location = New System.Drawing.Point(112, 64)
        Me.AdvIDAlbaranHasta.Name = "AdvIDAlbaranHasta"
        Me.AdvIDAlbaranHasta.SecondaryDataFields = "NAlbaran"
        Me.AdvIDAlbaranHasta.Size = New System.Drawing.Size(104, 23)
        Me.AdvIDAlbaranHasta.TabIndex = 2
        Me.AdvIDAlbaranHasta.ViewName = "tbAlbaranVentaCabecera"
        '
        'lblAlbaranHasta
        '
        Me.lblAlbaranHasta.Location = New System.Drawing.Point(13, 64)
        Me.lblAlbaranHasta.Name = "lblAlbaranHasta"
        Me.lblAlbaranHasta.Size = New System.Drawing.Size(87, 13)
        Me.lblAlbaranHasta.TabIndex = 12
        Me.lblAlbaranHasta.Tag = "IdRec=5037;"
        Me.lblAlbaranHasta.Text = "Albaran Hasta"
        '
        'AdvIDAlbaranDesde
        '
        Me.AdvIDAlbaranDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDAlbaranDesde.DisplayField = "NAlbaran"
        Me.AdvIDAlbaranDesde.EntityName = "AlbaranVentaCabecera"
        Me.AdvIDAlbaranDesde.Location = New System.Drawing.Point(112, 40)
        Me.AdvIDAlbaranDesde.Name = "AdvIDAlbaranDesde"
        Me.AdvIDAlbaranDesde.SecondaryDataFields = "NAlbaran"
        Me.AdvIDAlbaranDesde.Size = New System.Drawing.Size(104, 23)
        Me.AdvIDAlbaranDesde.TabIndex = 1
        Me.AdvIDAlbaranDesde.ViewName = "tbAlbaranVentaCabecera"
        '
        'lblAlbaranDesde
        '
        Me.lblAlbaranDesde.Location = New System.Drawing.Point(13, 40)
        Me.lblAlbaranDesde.Name = "lblAlbaranDesde"
        Me.lblAlbaranDesde.Size = New System.Drawing.Size(91, 13)
        Me.lblAlbaranDesde.TabIndex = 14
        Me.lblAlbaranDesde.Text = "Albaran Desde"
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(112, 16)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(104, 23)
        Me.AdvIDCliente.TabIndex = 0
        Me.AdvIDCliente.ViewName = "tbMaestroCliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(13, 16)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 16
        Me.lblCliente.Tag = "IdRec=4365;"
        Me.lblCliente.Text = "Cliente"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(309, 64)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaHasta.TabIndex = 5
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(224, 64)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 18
        Me.lblFechaHasta.Tag = "IdRec=4641;"
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(309, 40)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaDesde.TabIndex = 4
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(224, 40)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 19
        Me.lblFechaDesde.Tag = "IdRec=4841;"
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ClbFechaFactura)
        Me.Panel1.Controls.Add(Me.LblFechaFactura)
        Me.Panel1.Controls.Add(Me.cbxAño)
        Me.Panel1.Controls.Add(Me.lblAño)
        Me.Panel1.Controls.Add(Me.lblContador)
        Me.Panel1.Controls.Add(Me.AdvIDContador)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 40)
        Me.Panel1.TabIndex = 5
        '
        'ClbFechaFactura
        '
        Me.ClbFechaFactura.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaFactura.Location = New System.Drawing.Point(308, 7)
        Me.ClbFechaFactura.Name = "ClbFechaFactura"
        Me.ClbFechaFactura.Size = New System.Drawing.Size(104, 21)
        Me.ClbFechaFactura.TabIndex = 104
        '
        'LblFechaFactura
        '
        Me.LblFechaFactura.Location = New System.Drawing.Point(212, 12)
        Me.LblFechaFactura.Name = "LblFechaFactura"
        Me.LblFechaFactura.Size = New System.Drawing.Size(85, 13)
        Me.LblFechaFactura.TabIndex = 103
        Me.LblFechaFactura.Text = "Fecha Factura"
        Me.LblFechaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxAño
        '
        Me.cbxAño.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxAño_DesignTimeLayout.LayoutString = resources.GetString("cbxAño_DesignTimeLayout.LayoutString")
        Me.cbxAño.DesignTimeLayout = cbxAño_DesignTimeLayout
        Me.cbxAño.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAño.DisplayMember = "Año"
        Me.cbxAño.Location = New System.Drawing.Point(538, 8)
        Me.cbxAño.MaxLength = 4
        Me.cbxAño.Name = "cbxAño"
        Me.cbxAño.SelectedIndex = -1
        Me.cbxAño.SelectedItem = Nothing
        Me.cbxAño.Size = New System.Drawing.Size(78, 21)
        Me.cbxAño.TabIndex = 9
        Me.cbxAño.ValueMember = "Año"
        '
        'lblAño
        '
        Me.lblAño.Location = New System.Drawing.Point(499, 12)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(29, 13)
        Me.lblAño.TabIndex = 102
        Me.lblAño.Tag = ""
        Me.lblAño.Text = "Año"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(8, 12)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 23
        Me.lblContador.Text = "Contador"
        Me.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvIDContador
        '
        Me.AdvIDContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDContador.EntityName = "EntidadContador"
        Me.AdvIDContador.Location = New System.Drawing.Point(72, 8)
        Me.AdvIDContador.Name = "AdvIDContador"
        Me.AdvIDContador.SecondaryDataFields = "IDContador"
        Me.AdvIDContador.Size = New System.Drawing.Size(78, 23)
        Me.AdvIDContador.TabIndex = 8
        Me.AdvIDContador.ViewName = "tbEntidadContador"
        '
        'LblCentroGestion
        '
        Me.LblCentroGestion.Location = New System.Drawing.Point(432, 64)
        Me.LblCentroGestion.Name = "LblCentroGestion"
        Me.LblCentroGestion.Size = New System.Drawing.Size(80, 13)
        Me.LblCentroGestion.TabIndex = 20
        Me.LblCentroGestion.Text = "Centro Gest."
        Me.LblCentroGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvCentroGestion
        '
        Me.AdvCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCentroGestion.DisplayField = "IDCentroGestion"
        Me.AdvCentroGestion.EntityName = "CentroGestion"
        Me.AdvCentroGestion.Location = New System.Drawing.Point(520, 64)
        Me.AdvCentroGestion.Name = "AdvCentroGestion"
        Me.AdvCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.AdvCentroGestion.Size = New System.Drawing.Size(96, 23)
        Me.AdvCentroGestion.TabIndex = 8
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(13, 92)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 22
        Me.lblEstado.Text = "Estado"
        '
        'cbOperador
        '
        cbOperador_DesignTimeLayout.LayoutString = resources.GetString("cbOperador_DesignTimeLayout.LayoutString")
        Me.cbOperador.DesignTimeLayout = cbOperador_DesignTimeLayout
        Me.cbOperador.DisabledBackColor = System.Drawing.Color.White
        Me.cbOperador.Location = New System.Drawing.Point(112, 88)
        Me.cbOperador.Name = "cbOperador"
        Me.cbOperador.SelectedIndex = -1
        Me.cbOperador.SelectedItem = Nothing
        Me.cbOperador.Size = New System.Drawing.Size(80, 21)
        Me.cbOperador.TabIndex = 9
        '
        'cmbEstado
        '
        cmbEstado_DesignTimeLayout.LayoutString = resources.GetString("cmbEstado_DesignTimeLayout.LayoutString")
        Me.cmbEstado.DesignTimeLayout = cmbEstado_DesignTimeLayout
        Me.cmbEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cmbEstado.Location = New System.Drawing.Point(198, 88)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.SelectedIndex = -1
        Me.cmbEstado.SelectedItem = Nothing
        Me.cmbEstado.Size = New System.Drawing.Size(100, 21)
        Me.cmbEstado.TabIndex = 23
        '
        'MntoFacturacionVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.EntityName = "AlbaranVentaCabecera"
        Me.KeyField = "IDAlbaran"
        Me.Name = "MntoFacturacionVenta"
        Me.UseCheck = True
        Me.ViewName = "VFrmMntoFacturacionVenta"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxPeriodoFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbxAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOperador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private BlnMarcarTodos As Boolean = False
    Private BlnMsgMostrar As Boolean = False

#Region " Load "

    Private Sub MntoFacturacionVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
            LoadToolBarActions()
            LoadGridActions()
            RellenarComboAños(cbxAño)
            'AdvIDContador.Text = LoadContadorPorDefecto()
            InitFilterCriteria()
            Me.txtImporte.Value = Nothing : Me.txtImporte.Text = String.Empty
            LoadParams()
        End If
    End Sub

    Private Sub LoadEnums()
        Dim dv As DataView = EnumData.EnumView("enumOperadores")
        dv.RowFilter = "Name = 'enumOperadores' AND Value <> 5 AND Value <> 6"
        cmbEstado.DataSource = dv
        cbxPeriodoFacturacion.DataSource = New EnumData("enummcPeriodoFacturacion")
        EnumData.PopulateValueList("enumavlestadofactura", Me.Grid.Columns("Estado"))
        cbOperador.DataSource = dv
        cmbEstado.DataSource = New EnumData("enumavlestadofactura")
    End Sub

    Private Sub LoadToolBarActions()
        Me.FormActions.Add("Facturar", AddressOf Facturacion, ExpertisApp.GetIcon("xFacturaVenta.ico"))
    End Sub

    Private Sub LoadGridActions()
        Grid.AddSeparator()
        Grid.Actions.Add("Ver Albarán", AddressOf AbrirAlbaran, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
    End Sub

    Private Sub InitFilterCriteria()
        txtImporte.Text = 0
    End Sub

    Private Sub LoadParams()
        If New Parametro().ExpertisSAAS Then Me.Grid.Columns("EntregasACuenta").Visible = False

        Dim FechaDelSistema As Boolean = ExpertisApp.ExecuteTask(Of Object, Boolean)(AddressOf JMAParametro.FechaFacturacionIgualFechaSistema, Nothing)
        If FechaDelSistema Then
            ClbFechaFactura.Value = Date.Today
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AbrirAlbaran()
        GeneralFacturacion.AbrirMntoAlbaran(Grid.Value("IdAlbaran"))
    End Sub

#End Region

#Region " Facturar "

    Protected Overridable Sub Facturacion()
        If Grid.CheckedRecordsCount > 0 Then


            If Length(ClbFechaFactura.Value) > 0 AndAlso ClbFechaFactura.Value > Today.Date Then
                If ExpertisApp.GenerateMessage("La fecha seleccionada es superior al día de hoy.|¿Desea cancelar el proceso y cambiar la fecha?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = Windows.Forms.DialogResult.Yes Then
                    Exit Sub
                End If
            End If
            If New Parametro().ValidarCambioFechaFacturas AndAlso Length(Me.AdvIDContador.Value) = 0 Then
                ExpertisApp.GenerateMessage("Debe seleccionar un contador para la generación de las facturas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If Length(ClbFechaFactura.Value) > 0 Then
                GeneralFacturacion.Facturar(Grid.CheckedRecords, AdvIDContador.Text, Me.Cursor, , ClbFechaFactura.Value)
            Else
                GeneralFacturacion.Facturar(Grid.CheckedRecords, AdvIDContador.Text, Me.Cursor)
            End If
            Me.UnCheckAllRecords()
            Me.Execute()
        Else : ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " QueryExecute "

    Private Sub MntoFacturacionVenta_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Text, FilterType.String)
        e.Filter.Add("NAlbaran", FilterOperator.GreaterThanOrEqual, AdvIDAlbaranDesde.Text, FilterType.String)
        e.Filter.Add("NAlbaran", FilterOperator.LessThanOrEqual, AdvIDAlbaranHasta.Text, FilterType.String)
        e.Filter.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("Importe", FilterOperator.GreaterThan, txtImporte.Text, FilterType.Numeric)
        e.Filter.Add("PeriodoFacturacion", FilterOperator.Equal, cbxPeriodoFacturacion.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IDCentroGestion", FilterOperator.Equal, AdvCentroGestion.Value)
        e.Filter.Add("AñoAlbaran", FilterOperator.Equal, cbxAño.Value)

        Select Case cbOperador.Text
            Case "Igual"
                e.Filter.Add("Estado", FilterOperator.Equal, Me.cmbEstado.Value)
            Case "Distinto"
                e.Filter.Add("Estado", FilterOperator.NotEqual, Me.cmbEstado.Value)
            Case "Mayor"
                e.Filter.Add("Estado", FilterOperator.GreaterThan, Me.cmbEstado.Value)
            Case "Mayor o igual"
                e.Filter.Add("Estado", FilterOperator.GreaterThanOrEqual, Me.cmbEstado.Value)
            Case "Menor"
                e.Filter.Add("Estado", FilterOperator.LessThan, Me.cmbEstado.Value)
            Case "Menor o igual"
                e.Filter.Add("Estado", FilterOperator.LessThanOrEqual, Me.cmbEstado.Value)
        End Select
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)
        InitFilterCriteria()
        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
        Me.txtImporte.Value = Nothing : Me.txtImporte.Text = String.Empty
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = Janus.Windows.GridEX.RowType.Record Then
            If CBool(e.Row.Cells("EntregasACuenta").Value) Then 'Entregas a Cuenta Cliente
                e.Row.Cells("EntregasACuenta").ImageIndex = GeneralFacturacion.IconIndex.ExistenEntregas
            End If
        End If
    End Sub

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        If Grid.HitTest = Janus.Windows.GridEX.GridArea.Cell Then
            Dim objCol As Janus.Windows.GridEX.GridEXColumn = Grid.ColumnFromPoint()
            If Not IsNothing(objCol) Then
                Select Case objCol.Key
                    Case "EntregasACuenta"
                        If Grid.Value(objCol.Key) Then
                            Dim frmVerEntregas As New frmVerEntregasACuenta
                            frmVerEntregas.AñadirEntregas = False
                            frmVerEntregas.CircuitoOrigen = Solmicro.Expertis.Business.BusinessEnum.Circuito.Ventas
                            frmVerEntregas.IDClienteProveedor = Grid.Value("IDCliente")
                            frmVerEntregas.DescClienteProveedor = Grid.Value("DescCliente")
                            frmVerEntregas.ShowDialog(Me)
                        End If
                End Select
            End If
        End If
    End Sub

    Private Sub Grid_CheckingRecord(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckingEventArgs) Handles Grid.CheckingRecord
        If e.CheckState = CheckStates.UnChecked Then
            If e.Row.Cells("NSERIECheck").Value Then
                If Not BlnMarcarTodos Then
                    ExpertisApp.GenerateMessage("El Albaran seleccionado tiene pendiente en sus lineas el desglose de los Numeros de Serie.|Por favor, revise los datos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine)
                Else
                    BlnMsgMostrar = True
                End If
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

    Private Sub AdvIDContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDContador.SetPredefinedFilter
        e.Filter.Add("Entidad", FilterOperator.Equal, GeneralFacturacion.cnEntidad)
    End Sub

    Private Sub MntoFacturacionVenta_CheckingAllRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingAllEventArgs) Handles MyBase.CheckingAllRecord
        BlnMarcarTodos = True
    End Sub

    Private Sub MntoFacturacionVenta_AllRecordChecked(ByVal sender As Object, ByVal e As Engine.UI.AllCheckedEventArgs) Handles MyBase.AllRecordChecked
        BlnMarcarTodos = False
        If BlnMsgMostrar Then
            ExpertisApp.GenerateMessage("Hay Albaranes que no se han permitido seleccionar: queda pendiente que se les hagan el desglose de los Numeros de Serie en sus lineas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BlnMsgMostrar = False
        End If
    End Sub

    Private Sub cbxAño_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxAño.ValueChanged
        If Length(cbxAño.Value) > 0 Then
            Dim f As New Filter
            f.Add("YEAR(FechaAlbaran)", cbxAño.Value)
            AdvIDAlbaranDesde.PredefinedFilter = f
            AdvIDAlbaranHasta.PredefinedFilter = f
        Else
            AdvIDAlbaranDesde.PredefinedFilter = Nothing
            AdvIDAlbaranHasta.PredefinedFilter = Nothing
        End If
    End Sub


End Class