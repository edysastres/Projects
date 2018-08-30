<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIImpEtiquetaArticulo
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIImpEtiquetaArticulo))
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.advArticuloPadre = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblOCCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtBoxOCCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblOrdenProduccion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtBoxOrdenFabricacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ntbNCopias = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblNCopias = New Solmicro.Expertis.Engine.UI.Label
        Me.cbImpresoraEspecifica = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cboImpresoras = New System.Windows.Forms.ComboBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.advArticuloPadre)
        Me.FilterPanel.Controls.Add(Me.lblfwiArticulo)
        Me.FilterPanel.Controls.Add(Me.lblfwiTipo)
        Me.FilterPanel.Controls.Add(Me.lblfwiFamilia)
        Me.FilterPanel.Controls.Add(Me.advArticulo)
        Me.FilterPanel.Controls.Add(Me.advTipo)
        Me.FilterPanel.Controls.Add(Me.advFamilia)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 322)
        Me.FilterPanel.Size = New System.Drawing.Size(721, 109)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(721, 322)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Articulo"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "IDArticulo"
        Me.Grid.Location = New System.Drawing.Point(0, 69)
        Me.Grid.Size = New System.Drawing.Size(721, 253)
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vJMAImprimirEtiquetaArticulo"
        '
        'CheckAll
        '
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
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
        Me.MainPanel.Size = New System.Drawing.Size(721, 431)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(721, 431)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(197, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Tag = "IdRec=4377;"
        Me.Label1.Text = "Art. Padre"
        '
        'advArticuloPadre
        '
        Me.advArticuloPadre.DisabledBackColor = System.Drawing.Color.White
        Me.advArticuloPadre.EntityName = "Articulo"
        Me.advArticuloPadre.Location = New System.Drawing.Point(268, 24)
        Me.advArticuloPadre.Name = "advArticuloPadre"
        Me.advArticuloPadre.PrimaryDataFields = "IDArticulo"
        Me.advArticuloPadre.SecondaryDataFields = "IDArticulo"
        Me.advArticuloPadre.Size = New System.Drawing.Size(112, 23)
        Me.advArticuloPadre.TabIndex = 27
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(8, 29)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 20
        Me.lblfwiArticulo.Tag = "IdRec=4377;"
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'lblfwiTipo
        '
        Me.lblfwiTipo.Location = New System.Drawing.Point(8, 55)
        Me.lblfwiTipo.Name = "lblfwiTipo"
        Me.lblfwiTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiTipo.TabIndex = 22
        Me.lblfwiTipo.Tag = "IdRec=4456;"
        Me.lblfwiTipo.Text = "Tipo"
        '
        'lblfwiFamilia
        '
        Me.lblfwiFamilia.Location = New System.Drawing.Point(8, 81)
        Me.lblfwiFamilia.Name = "lblfwiFamilia"
        Me.lblfwiFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiFamilia.TabIndex = 24
        Me.lblfwiFamilia.Tag = "IdRec=4454;"
        Me.lblfwiFamilia.Text = "Familia"
        '
        'advArticulo
        '
        Me.advArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advArticulo.EntityName = "Articulo"
        Me.advArticulo.Location = New System.Drawing.Point(64, 24)
        Me.advArticulo.Name = "advArticulo"
        Me.advArticulo.PrimaryDataFields = "IDArticulo"
        Me.advArticulo.SecondaryDataFields = "IDArticulo"
        Me.advArticulo.Size = New System.Drawing.Size(112, 23)
        Me.advArticulo.TabIndex = 21
        '
        'advTipo
        '
        Me.advTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advTipo.EntityName = "TipoArticulo"
        Me.advTipo.Location = New System.Drawing.Point(64, 50)
        Me.advTipo.Name = "advTipo"
        Me.advTipo.PrimaryDataFields = "IDTipo"
        Me.advTipo.SecondaryDataFields = "IDTipo"
        Me.advTipo.Size = New System.Drawing.Size(112, 23)
        Me.advTipo.TabIndex = 23
        '
        'advFamilia
        '
        Me.advFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advFamilia.EntityName = "Familia"
        Me.advFamilia.Location = New System.Drawing.Point(64, 76)
        Me.advFamilia.Name = "advFamilia"
        Me.advFamilia.PrimaryDataFields = "IDFamilia"
        Me.advFamilia.SecondaryDataFields = "IDFamilia"
        Me.advFamilia.Size = New System.Drawing.Size(112, 23)
        Me.advFamilia.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboImpresoras)
        Me.Panel1.Controls.Add(Me.cbImpresoraEspecifica)
        Me.Panel1.Controls.Add(Me.lblOCCliente)
        Me.Panel1.Controls.Add(Me.txtBoxOCCliente)
        Me.Panel1.Controls.Add(Me.lblOrdenProduccion)
        Me.Panel1.Controls.Add(Me.txtBoxOrdenFabricacion)
        Me.Panel1.Controls.Add(Me.ntbNCopias)
        Me.Panel1.Controls.Add(Me.lblNCopias)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 69)
        Me.Panel1.TabIndex = 1
        '
        'lblOCCliente
        '
        Me.lblOCCliente.Location = New System.Drawing.Point(371, 41)
        Me.lblOCCliente.Name = "lblOCCliente"
        Me.lblOCCliente.Size = New System.Drawing.Size(132, 13)
        Me.lblOCCliente.TabIndex = 5
        Me.lblOCCliente.Text = "O. Compra de Cliente"
        '
        'txtBoxOCCliente
        '
        Me.txtBoxOCCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtBoxOCCliente.Location = New System.Drawing.Point(506, 36)
        Me.txtBoxOCCliente.Name = "txtBoxOCCliente"
        Me.txtBoxOCCliente.Size = New System.Drawing.Size(118, 21)
        Me.txtBoxOCCliente.TabIndex = 3
        '
        'lblOrdenProduccion
        '
        Me.lblOrdenProduccion.Location = New System.Drawing.Point(119, 42)
        Me.lblOrdenProduccion.Name = "lblOrdenProduccion"
        Me.lblOrdenProduccion.Size = New System.Drawing.Size(126, 13)
        Me.lblOrdenProduccion.TabIndex = 3
        Me.lblOrdenProduccion.Text = "Orden de Producción"
        '
        'txtBoxOrdenFabricacion
        '
        Me.txtBoxOrdenFabricacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtBoxOrdenFabricacion.Location = New System.Drawing.Point(247, 37)
        Me.txtBoxOrdenFabricacion.Name = "txtBoxOrdenFabricacion"
        Me.txtBoxOrdenFabricacion.Size = New System.Drawing.Size(118, 21)
        Me.txtBoxOrdenFabricacion.TabIndex = 2
        '
        'ntbNCopias
        '
        Me.ntbNCopias.Cursor = System.Windows.Forms.Cursors.Default
        Me.ntbNCopias.DecimalDigits = 0
        Me.ntbNCopias.DisabledBackColor = System.Drawing.Color.White
        Me.ntbNCopias.Location = New System.Drawing.Point(78, 38)
        Me.ntbNCopias.Name = "ntbNCopias"
        Me.ntbNCopias.Size = New System.Drawing.Size(35, 21)
        Me.ntbNCopias.TabIndex = 1
        '
        'lblNCopias
        '
        Me.lblNCopias.Location = New System.Drawing.Point(8, 42)
        Me.lblNCopias.Name = "lblNCopias"
        Me.lblNCopias.Size = New System.Drawing.Size(64, 13)
        Me.lblNCopias.TabIndex = 0
        Me.lblNCopias.Text = "Nº Copias"
        '
        'cbImpresoraEspecifica
        '
        Me.cbImpresoraEspecifica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbImpresoraEspecifica.Location = New System.Drawing.Point(18, 4)
        Me.cbImpresoraEspecifica.Name = "cbImpresoraEspecifica"
        Me.cbImpresoraEspecifica.Size = New System.Drawing.Size(200, 31)
        Me.cbImpresoraEspecifica.TabIndex = 7
        Me.cbImpresoraEspecifica.Text = "Habilitar Impresora Especifica"
        '
        'cboImpresoras
        '
        Me.cboImpresoras.Enabled = False
        Me.cboImpresoras.FormattingEnabled = True
        Me.cboImpresoras.Location = New System.Drawing.Point(247, 10)
        Me.cboImpresoras.Name = "cboImpresoras"
        Me.cboImpresoras.Size = New System.Drawing.Size(377, 21)
        Me.cboImpresoras.TabIndex = 8
        '
        'CIImprimirEtiquetaArticulo
        '
        Me.ClientSize = New System.Drawing.Size(729, 519)
        Me.EntityName = "Articulo"
        Me.KeyField = "IDArticulo"
        Me.Name = "CIImprimirEtiquetaArticulo"
        Me.UseCheck = True
        Me.ViewName = "vJMAImprimirEtiquetaArticulo"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advArticuloPadre As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ntbNCopias As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblNCopias As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblOrdenProduccion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtBoxOrdenFabricacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblOCCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtBoxOCCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cbImpresoraEspecifica As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents cboImpresoras As System.Windows.Forms.ComboBox

End Class
