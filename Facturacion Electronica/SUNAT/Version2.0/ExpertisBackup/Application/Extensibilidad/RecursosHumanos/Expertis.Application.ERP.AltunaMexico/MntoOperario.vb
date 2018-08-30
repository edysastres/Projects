Public Class MntoOperario
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
    Public WithEvents PicFichaOperario As Solmicro.Expertis.Engine.UI.Panel

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Private WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents pnlFichaOperario As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents chkExterno As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkFacturacionObras As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents ulDescProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents FraCondEco As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents CmbCurriculum As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblCategoria As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIdProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblSucursal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtSucursal As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblDigitoControl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtDigitoControl As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblNCuenta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNCuenta As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescFormaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvIDFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblBanco As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescBanco As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advIDBanco As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDoperario As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtIDoperario As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtDescOperario As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFechaAlta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaAlta As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblDNI As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtDNI As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents ulDescCategoria As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvIDCategoria As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblOficio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescOficio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advIdOficio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblDepartamento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescDepartamento As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvIDDepartamento As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCurriculum As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCurriculum As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblUsuario As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxUsuario As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents GridOperarioHora As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents FraConfiguracion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblApellidos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtApellidos As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblNombre As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNombre As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblDescOperario As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraDatosContacto As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents ulDescPais As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advPoblacion As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents advCodPostal As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCP As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDPais As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents txtProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblDireccion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblPoblacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblProvincia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblIDPais As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtEmail As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtTelefono3 As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtTelefono2 As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtTelefono As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTelefono As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblEmail As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtFax As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFax As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents CmbTipoDocIdent As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents LblTipoDocIdent As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents chkVendedor As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents fraConfigBonos As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents chkBonosMantenimiento As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkBonosProduccion As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkBonosProyectos As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents FraPlanificacion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents chkProgVisible As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkProgramable As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents FrmTipoVendedor As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FrmPermisos As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents ChkVendedorTPV As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents TxtTarjetaControl As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents LblTarjeta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCodigoIBAN As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCodigoIBAN As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblSwift As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtSwift As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FraGestionTerceros As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblTercero As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTercero As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtCodigoNominPaq As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCodigoNominPaq As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDFormaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNumeroNonima As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNumeroNonima As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advTipoPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents chbPermisoGD As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim CmbTipoDocIdent_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoOperario))
        Dim GridOperarioHora_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxUsuario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PicFichaOperario = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlFichaOperario = New Solmicro.Expertis.Engine.UI.Panel
        Me.advTipoPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumeroNonima = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNumeroNonima = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodigoNominPaq = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodigoNominPaq = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtTarjetaControl = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblTarjeta = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbTipoDocIdent = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblTipoDocIdent = New Solmicro.Expertis.Engine.UI.Label
        Me.FraDatosContacto = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFax = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFax = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ulDescPais = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advPoblacion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advCodPostal = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCP = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDPais = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDireccion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPoblacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblProvincia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDPais = New Solmicro.Expertis.Engine.UI.Label
        Me.txtEmail = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtTelefono3 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtTelefono2 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtTelefono = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTelefono = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEmail = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDescOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.lblApellidos = New Solmicro.Expertis.Engine.UI.Label
        Me.txtApellidos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNombre = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNombre = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraConfiguracion = New Solmicro.Expertis.Engine.UI.Frame
        Me.FraGestionTerceros = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTercero = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTercero = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FrmPermisos = New Solmicro.Expertis.Engine.UI.Frame
        Me.chbPermisoGD = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkFacturacionObras = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FrmTipoVendedor = New Solmicro.Expertis.Engine.UI.Frame
        Me.ChkVendedorTPV = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVendedor = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fraConfigBonos = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkBonosMantenimiento = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkBonosProduccion = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkBonosProyectos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraPlanificacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkProgVisible = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkProgramable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkExterno = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.GridOperarioHora = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblCategoria = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIdProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FraCondEco = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblSwift = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSwift = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodigoIBAN = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodigoIBAN = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSucursal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSucursal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDigitoControl = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDigitoControl = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNCuenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNCuenta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescFormaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescBanco = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDBanco = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDoperario = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDoperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescOperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaAlta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAlta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblDNI = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDNI = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ulDescCategoria = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDCategoria = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblOficio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescOficio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIdOficio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblDepartamento = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescDepartamento = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDDepartamento = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.CmbCurriculum = New Solmicro.Expertis.Engine.UI.Button
        Me.lblCurriculum = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCurriculum = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblUsuario = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxUsuario = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.PicFichaOperario.suspendlayout()
        Me.pnlFichaOperario.suspendlayout()
        CType(Me.CmbTipoDocIdent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraDatosContacto.SuspendLayout()
        Me.FraConfiguracion.SuspendLayout()
        Me.FraGestionTerceros.SuspendLayout()
        Me.FrmPermisos.SuspendLayout()
        Me.FrmTipoVendedor.SuspendLayout()
        Me.fraConfigBonos.SuspendLayout()
        Me.FraPlanificacion.SuspendLayout()
        CType(Me.GridOperarioHora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraCondEco.SuspendLayout()
        CType(Me.cbxUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.PicFichaOperario)
        Me.MainPanel.Size = New System.Drawing.Size(796, 715)
        '
        'PicFichaOperario
        '
        Me.PicFichaOperario.Controls.Add(Me.txtTexto)
        Me.PicFichaOperario.Controls.Add(Me.pnlFichaOperario)
        Me.PicFichaOperario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicFichaOperario.Location = New System.Drawing.Point(0, 0)
        Me.PicFichaOperario.Name = "PicFichaOperario"
        Me.PicFichaOperario.Size = New System.Drawing.Size(796, 715)
        Me.PicFichaOperario.TabIndex = 1
        '
        'txtTexto
        '
        Me.txtTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtTexto, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Location = New System.Drawing.Point(8, 574)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(769, 133)
        Me.txtTexto.TabIndex = 0
        '
        'pnlFichaOperario
        '
        Me.pnlFichaOperario.Controls.Add(Me.advTipoPago)
        Me.pnlFichaOperario.Controls.Add(Me.lblIDFormaPago)
        Me.pnlFichaOperario.Controls.Add(Me.lblTexto)
        Me.pnlFichaOperario.Controls.Add(Me.txtNumeroNonima)
        Me.pnlFichaOperario.Controls.Add(Me.lblNumeroNonima)
        Me.pnlFichaOperario.Controls.Add(Me.txtCodigoNominPaq)
        Me.pnlFichaOperario.Controls.Add(Me.lblCodigoNominPaq)
        Me.pnlFichaOperario.Controls.Add(Me.TxtTarjetaControl)
        Me.pnlFichaOperario.Controls.Add(Me.LblTarjeta)
        Me.pnlFichaOperario.Controls.Add(Me.CmbTipoDocIdent)
        Me.pnlFichaOperario.Controls.Add(Me.LblTipoDocIdent)
        Me.pnlFichaOperario.Controls.Add(Me.FraDatosContacto)
        Me.pnlFichaOperario.Controls.Add(Me.lblDescOperario)
        Me.pnlFichaOperario.Controls.Add(Me.lblApellidos)
        Me.pnlFichaOperario.Controls.Add(Me.txtApellidos)
        Me.pnlFichaOperario.Controls.Add(Me.lblNombre)
        Me.pnlFichaOperario.Controls.Add(Me.txtNombre)
        Me.pnlFichaOperario.Controls.Add(Me.FraConfiguracion)
        Me.pnlFichaOperario.Controls.Add(Me.chkExterno)
        Me.pnlFichaOperario.Controls.Add(Me.GridOperarioHora)
        Me.pnlFichaOperario.Controls.Add(Me.lblCategoria)
        Me.pnlFichaOperario.Controls.Add(Me.AdvIdProveedor)
        Me.pnlFichaOperario.Controls.Add(Me.ulDescProveedor)
        Me.pnlFichaOperario.Controls.Add(Me.FraCondEco)
        Me.pnlFichaOperario.Controls.Add(Me.lblIDoperario)
        Me.pnlFichaOperario.Controls.Add(Me.txtIDoperario)
        Me.pnlFichaOperario.Controls.Add(Me.txtDescOperario)
        Me.pnlFichaOperario.Controls.Add(Me.lblFechaAlta)
        Me.pnlFichaOperario.Controls.Add(Me.cbxFechaAlta)
        Me.pnlFichaOperario.Controls.Add(Me.lblDNI)
        Me.pnlFichaOperario.Controls.Add(Me.txtDNI)
        Me.pnlFichaOperario.Controls.Add(Me.ulDescCategoria)
        Me.pnlFichaOperario.Controls.Add(Me.AdvIDCategoria)
        Me.pnlFichaOperario.Controls.Add(Me.lblOficio)
        Me.pnlFichaOperario.Controls.Add(Me.ulDescOficio)
        Me.pnlFichaOperario.Controls.Add(Me.advIdOficio)
        Me.pnlFichaOperario.Controls.Add(Me.lblDepartamento)
        Me.pnlFichaOperario.Controls.Add(Me.ulDescDepartamento)
        Me.pnlFichaOperario.Controls.Add(Me.AdvIDDepartamento)
        Me.pnlFichaOperario.Controls.Add(Me.CmbCurriculum)
        Me.pnlFichaOperario.Controls.Add(Me.lblCurriculum)
        Me.pnlFichaOperario.Controls.Add(Me.txtCurriculum)
        Me.pnlFichaOperario.Controls.Add(Me.lblUsuario)
        Me.pnlFichaOperario.Controls.Add(Me.cbxUsuario)
        Me.pnlFichaOperario.Controls.Add(Me.lblProveedor)
        Me.pnlFichaOperario.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFichaOperario.Location = New System.Drawing.Point(0, 0)
        Me.pnlFichaOperario.Name = "pnlFichaOperario"
        Me.pnlFichaOperario.Size = New System.Drawing.Size(796, 568)
        Me.pnlFichaOperario.TabIndex = 0
        '
        'advTipoPago
        '
        Me.TryDataBinding(advTipoPago, New System.Windows.Forms.Binding("Text", Me, "FomaPago", True))
        Me.advTipoPago.DisabledBackColor = System.Drawing.Color.White
        Me.advTipoPago.DisplayField = "IDPeriodoPago"
        Me.advTipoPago.EntityName = "PeriodosPagoNomina"
        Me.advTipoPago.Location = New System.Drawing.Point(629, 482)
        Me.advTipoPago.Name = "advTipoPago"
        Me.advTipoPago.PrimaryDataFields = "FomaPago"
        Me.advTipoPago.SecondaryDataFields = "IDPeriodoPago"
        Me.advTipoPago.Size = New System.Drawing.Size(141, 23)
        Me.advTipoPago.TabIndex = 128
        Me.advTipoPago.ViewName = "vPeriodosPagoNomina"
        '
        'lblIDFormaPago
        '
        Me.lblIDFormaPago.Location = New System.Drawing.Point(530, 487)
        Me.lblIDFormaPago.Name = "lblIDFormaPago"
        Me.lblIDFormaPago.Size = New System.Drawing.Size(93, 13)
        Me.lblIDFormaPago.TabIndex = 127
        Me.lblIDFormaPago.Text = "Forma de Pago"
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(343, 552)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(91, 13)
        Me.lblTexto.TabIndex = 99
        Me.lblTexto.Tag = "IdRec=5286;"
        Me.lblTexto.Text = "Observaciones"
        '
        'txtNumeroNonima
        '
        Me.TryDataBinding(txtNumeroNonima, New System.Windows.Forms.Binding("Text", Me, "NumeroNonima", True))
        Me.txtNumeroNonima.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumeroNonima.Location = New System.Drawing.Point(135, 513)
        Me.txtNumeroNonima.Name = "txtNumeroNonima"
        Me.txtNumeroNonima.Size = New System.Drawing.Size(121, 21)
        Me.txtNumeroNonima.TabIndex = 124
        '
        'lblNumeroNonima
        '
        Me.lblNumeroNonima.Location = New System.Drawing.Point(12, 517)
        Me.lblNumeroNonima.Name = "lblNumeroNonima"
        Me.lblNumeroNonima.Size = New System.Drawing.Size(117, 13)
        Me.lblNumeroNonima.TabIndex = 125
        Me.lblNumeroNonima.Text = "Numero de Nonima"
        '
        'txtCodigoNominPaq
        '
        Me.TryDataBinding(txtCodigoNominPaq, New System.Windows.Forms.Binding("Text", Me, "CodigoNominPaq", True))
        Me.txtCodigoNominPaq.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodigoNominPaq.Location = New System.Drawing.Point(135, 483)
        Me.txtCodigoNominPaq.Name = "txtCodigoNominPaq"
        Me.txtCodigoNominPaq.Size = New System.Drawing.Size(121, 21)
        Me.txtCodigoNominPaq.TabIndex = 122
        '
        'lblCodigoNominPaq
        '
        Me.lblCodigoNominPaq.Location = New System.Drawing.Point(12, 490)
        Me.lblCodigoNominPaq.Name = "lblCodigoNominPaq"
        Me.lblCodigoNominPaq.Size = New System.Drawing.Size(108, 13)
        Me.lblCodigoNominPaq.TabIndex = 123
        Me.lblCodigoNominPaq.Text = "Codigo NominPaq"
        '
        'TxtTarjetaControl
        '
        Me.TryDataBinding(TxtTarjetaControl, New System.Windows.Forms.Binding("Text", Me, "TarjetaControl", True))
        Me.TxtTarjetaControl.DisabledBackColor = System.Drawing.Color.White
        Me.TxtTarjetaControl.Location = New System.Drawing.Point(672, 28)
        Me.TxtTarjetaControl.MaxLength = 13
        Me.TxtTarjetaControl.Name = "TxtTarjetaControl"
        Me.TxtTarjetaControl.Size = New System.Drawing.Size(106, 21)
        Me.TxtTarjetaControl.TabIndex = 5
        '
        'LblTarjeta
        '
        Me.LblTarjeta.Location = New System.Drawing.Point(603, 32)
        Me.LblTarjeta.Name = "LblTarjeta"
        Me.LblTarjeta.Size = New System.Drawing.Size(47, 13)
        Me.LblTarjeta.TabIndex = 121
        Me.LblTarjeta.Text = "Tarjeta"
        '
        'CmbTipoDocIdent
        '
        Me.CmbTipoDocIdent.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(CmbTipoDocIdent, New System.Windows.Forms.Binding("Value", Me, "TipoDocIdentidad", True))
        CmbTipoDocIdent_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoDocIdent_DesignTimeLayout.LayoutString")
        Me.CmbTipoDocIdent.DesignTimeLayout = CmbTipoDocIdent_DesignTimeLayout
        Me.CmbTipoDocIdent.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoDocIdent.DisplayMember = "Text"
        Me.CmbTipoDocIdent.Location = New System.Drawing.Point(98, 52)
        Me.CmbTipoDocIdent.Name = "CmbTipoDocIdent"
        Me.CmbTipoDocIdent.SelectedIndex = -1
        Me.CmbTipoDocIdent.SelectedItem = Nothing
        Me.CmbTipoDocIdent.Size = New System.Drawing.Size(126, 21)
        Me.CmbTipoDocIdent.TabIndex = 6
        Me.CmbTipoDocIdent.ValueMember = "Value"
        '
        'LblTipoDocIdent
        '
        Me.LblTipoDocIdent.Location = New System.Drawing.Point(3, 56)
        Me.LblTipoDocIdent.Name = "LblTipoDocIdent"
        Me.LblTipoDocIdent.Size = New System.Drawing.Size(100, 13)
        Me.LblTipoDocIdent.TabIndex = 120
        Me.LblTipoDocIdent.Text = "Tipo Documento"
        '
        'FraDatosContacto
        '
        Me.FraDatosContacto.Controls.Add(Me.lblFax)
        Me.FraDatosContacto.Controls.Add(Me.txtFax)
        Me.FraDatosContacto.Controls.Add(Me.ulDescPais)
        Me.FraDatosContacto.Controls.Add(Me.advPoblacion)
        Me.FraDatosContacto.Controls.Add(Me.advCodPostal)
        Me.FraDatosContacto.Controls.Add(Me.lblCP)
        Me.FraDatosContacto.Controls.Add(Me.advIDPais)
        Me.FraDatosContacto.Controls.Add(Me.txtProvincia)
        Me.FraDatosContacto.Controls.Add(Me.txtDireccion)
        Me.FraDatosContacto.Controls.Add(Me.lblDireccion)
        Me.FraDatosContacto.Controls.Add(Me.lblPoblacion)
        Me.FraDatosContacto.Controls.Add(Me.lblProvincia)
        Me.FraDatosContacto.Controls.Add(Me.lblIDPais)
        Me.FraDatosContacto.Controls.Add(Me.txtEmail)
        Me.FraDatosContacto.Controls.Add(Me.txtTelefono3)
        Me.FraDatosContacto.Controls.Add(Me.txtTelefono2)
        Me.FraDatosContacto.Controls.Add(Me.txtTelefono)
        Me.FraDatosContacto.Controls.Add(Me.lblTelefono)
        Me.FraDatosContacto.Controls.Add(Me.lblEmail)
        Me.FraDatosContacto.Location = New System.Drawing.Point(5, 76)
        Me.FraDatosContacto.Name = "FraDatosContacto"
        Me.FraDatosContacto.Size = New System.Drawing.Size(776, 91)
        Me.FraDatosContacto.TabIndex = 10
        Me.FraDatosContacto.TabStop = False
        Me.FraDatosContacto.Text = "Datos Contacto"
        '
        'lblFax
        '
        Me.lblFax.Location = New System.Drawing.Point(338, 71)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(26, 13)
        Me.lblFax.TabIndex = 44
        Me.lblFax.Text = "Fax"
        '
        'txtFax
        '
        Me.TryDataBinding(txtFax, New System.Windows.Forms.Binding("Text", Me, "Fax", True))
        Me.txtFax.DisabledBackColor = System.Drawing.Color.White
        Me.txtFax.Location = New System.Drawing.Point(369, 67)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(95, 21)
        Me.txtFax.TabIndex = 8
        '
        'ulDescPais
        '
        Me.TryDataBinding(ulDescPais, New System.Windows.Forms.Binding("Text", Me.advIDPais, "DescPais", True))
        Me.ulDescPais.Location = New System.Drawing.Point(602, 18)
        Me.ulDescPais.Name = "ulDescPais"
        Me.ulDescPais.Size = New System.Drawing.Size(170, 24)
        Me.ulDescPais.TabIndex = 42
        Me.ulDescPais.UseMnemonic = False
        '
        'advPoblacion
        '
        Me.TryDataBinding(advPoblacion, New System.Windows.Forms.Binding("Text", Me, "Poblacion", True))
        Me.advPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.advPoblacion.EntityName = "Poblacion"
        Me.advPoblacion.Location = New System.Drawing.Point(185, 42)
        Me.advPoblacion.Name = "advPoblacion"
        Me.advPoblacion.PrimaryDataFields = "Poblacion"
        Me.advPoblacion.SecondaryDataFields = "DescPoblacion"
        Me.advPoblacion.Size = New System.Drawing.Size(279, 23)
        Me.advPoblacion.TabIndex = 3
        '
        'advCodPostal
        '
        Me.TryDataBinding(advCodPostal, New System.Windows.Forms.Binding("Text", Me, "CodPostal", True))
        Me.advCodPostal.DisabledBackColor = System.Drawing.Color.White
        Me.advCodPostal.EntityName = "Poblacion"
        Me.advCodPostal.Location = New System.Drawing.Point(44, 42)
        Me.advCodPostal.Name = "advCodPostal"
        Me.advCodPostal.PrimaryDataFields = "CodPostal"
        Me.advCodPostal.SecondaryDataFields = "CodPostal"
        Me.advCodPostal.Size = New System.Drawing.Size(66, 23)
        Me.advCodPostal.TabIndex = 2
        '
        'lblCP
        '
        Me.lblCP.Location = New System.Drawing.Point(7, 47)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(29, 13)
        Me.lblCP.TabIndex = 41
        Me.lblCP.Text = "C.P."
        '
        'advIDPais
        '
        Me.TryDataBinding(advIDPais, New System.Windows.Forms.Binding("Text", Me, "IDPais", True))
        Me.advIDPais.DisabledBackColor = System.Drawing.Color.White
        Me.advIDPais.EntityName = "Pais"
        Me.advIDPais.Location = New System.Drawing.Point(534, 19)
        Me.advIDPais.Name = "advIDPais"
        Me.advIDPais.PrimaryDataFields = "IDPais"
        Me.advIDPais.SecondaryDataFields = "IDPais"
        Me.advIDPais.Size = New System.Drawing.Size(64, 23)
        Me.advIDPais.TabIndex = 1
        '
        'txtProvincia
        '
        Me.TryDataBinding(txtProvincia, New System.Windows.Forms.Binding("Text", Me, "Provincia", True))
        Me.txtProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.txtProvincia.Location = New System.Drawing.Point(534, 44)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(238, 21)
        Me.txtProvincia.TabIndex = 4
        '
        'txtDireccion
        '
        Me.TryDataBinding(txtDireccion, New System.Windows.Forms.Binding("Text", Me, "Direccion", True))
        Me.txtDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccion.Location = New System.Drawing.Point(72, 19)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(392, 21)
        Me.txtDireccion.TabIndex = 0
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(7, 21)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccion.TabIndex = 37
        Me.lblDireccion.Text = "Dirección"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.Location = New System.Drawing.Point(120, 47)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(61, 13)
        Me.lblPoblacion.TabIndex = 38
        Me.lblPoblacion.Text = "Población"
        '
        'lblProvincia
        '
        Me.lblProvincia.Location = New System.Drawing.Point(470, 48)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(59, 13)
        Me.lblProvincia.TabIndex = 39
        Me.lblProvincia.Text = "Provincia"
        '
        'lblIDPais
        '
        Me.lblIDPais.Location = New System.Drawing.Point(470, 22)
        Me.lblIDPais.Name = "lblIDPais"
        Me.lblIDPais.Size = New System.Drawing.Size(30, 13)
        Me.lblIDPais.TabIndex = 40
        Me.lblIDPais.Text = "País"
        '
        'txtEmail
        '
        Me.TryDataBinding(txtEmail, New System.Windows.Forms.Binding("Text", Me, "Email", True))
        Me.txtEmail.DisabledBackColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(534, 67)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(238, 21)
        Me.txtEmail.TabIndex = 9
        '
        'txtTelefono3
        '
        Me.TryDataBinding(txtTelefono3, New System.Windows.Forms.Binding("Text", Me, "Telefono3", True))
        Me.txtTelefono3.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefono3.Location = New System.Drawing.Point(239, 67)
        Me.txtTelefono3.Name = "txtTelefono3"
        Me.txtTelefono3.Size = New System.Drawing.Size(95, 21)
        Me.txtTelefono3.TabIndex = 7
        '
        'txtTelefono2
        '
        Me.TryDataBinding(txtTelefono2, New System.Windows.Forms.Binding("Text", Me, "Telefono2", True))
        Me.txtTelefono2.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefono2.Location = New System.Drawing.Point(141, 67)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(95, 21)
        Me.txtTelefono2.TabIndex = 6
        '
        'txtTelefono
        '
        Me.TryDataBinding(txtTelefono, New System.Windows.Forms.Binding("Text", Me, "Telefono", True))
        Me.txtTelefono.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefono.Location = New System.Drawing.Point(43, 67)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(95, 21)
        Me.txtTelefono.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.Location = New System.Drawing.Point(7, 71)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(24, 13)
        Me.lblTelefono.TabIndex = 26
        Me.lblTelefono.Text = "Tlf."
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(470, 71)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail.TabIndex = 33
        Me.lblEmail.Text = "Email"
        '
        'lblDescOperario
        '
        Me.lblDescOperario.Location = New System.Drawing.Point(3, 32)
        Me.lblDescOperario.Name = "lblDescOperario"
        Me.lblDescOperario.Size = New System.Drawing.Size(93, 13)
        Me.lblDescOperario.TabIndex = 113
        Me.lblDescOperario.Tag = ""
        Me.lblDescOperario.Text = "Desc. Operario"
        '
        'lblApellidos
        '
        Me.lblApellidos.Location = New System.Drawing.Point(393, 8)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(58, 13)
        Me.lblApellidos.TabIndex = 111
        Me.lblApellidos.Text = "Apellidos"
        '
        'txtApellidos
        '
        Me.TryDataBinding(txtApellidos, New System.Windows.Forms.Binding("Text", Me, "Apellidos", True))
        Me.txtApellidos.DisabledBackColor = System.Drawing.Color.White
        Me.txtApellidos.Location = New System.Drawing.Point(455, 4)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(141, 21)
        Me.txtApellidos.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(193, 8)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(52, 13)
        Me.lblNombre.TabIndex = 112
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.TryDataBinding(txtNombre, New System.Windows.Forms.Binding("Text", Me, "Nombre", True))
        Me.txtNombre.DisabledBackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(249, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(141, 21)
        Me.txtNombre.TabIndex = 1
        '
        'FraConfiguracion
        '
        Me.FraConfiguracion.Controls.Add(Me.FraGestionTerceros)
        Me.FraConfiguracion.Controls.Add(Me.FrmPermisos)
        Me.FraConfiguracion.Controls.Add(Me.FrmTipoVendedor)
        Me.FraConfiguracion.Controls.Add(Me.fraConfigBonos)
        Me.FraConfiguracion.Controls.Add(Me.FraPlanificacion)
        Me.FraConfiguracion.Location = New System.Drawing.Point(5, 365)
        Me.FraConfiguracion.Name = "FraConfiguracion"
        Me.FraConfiguracion.Size = New System.Drawing.Size(773, 112)
        Me.FraConfiguracion.TabIndex = 19
        Me.FraConfiguracion.TabStop = False
        Me.FraConfiguracion.Text = "Configuración Operario"
        '
        'FraGestionTerceros
        '
        Me.FraGestionTerceros.Controls.Add(Me.lblTercero)
        Me.FraGestionTerceros.Controls.Add(Me.AdvIDTercero)
        Me.FraGestionTerceros.Location = New System.Drawing.Point(606, 64)
        Me.FraGestionTerceros.Name = "FraGestionTerceros"
        Me.FraGestionTerceros.Size = New System.Drawing.Size(161, 43)
        Me.FraGestionTerceros.TabIndex = 189
        Me.FraGestionTerceros.TabStop = False
        Me.FraGestionTerceros.Text = "Gestión de Terceros"
        '
        'lblTercero
        '
        Me.lblTercero.Location = New System.Drawing.Point(6, 18)
        Me.lblTercero.Name = "lblTercero"
        Me.lblTercero.Size = New System.Drawing.Size(50, 13)
        Me.lblTercero.TabIndex = 1
        Me.lblTercero.Text = "Tercero"
        '
        'AdvIDTercero
        '
        Me.TryDataBinding(AdvIDTercero, New System.Windows.Forms.Binding("Text", Me, "IdTercero", True))
        Me.AdvIDTercero.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTercero.EntityName = "LatTerceros"
        Me.AdvIDTercero.Location = New System.Drawing.Point(59, 14)
        Me.AdvIDTercero.Name = "AdvIDTercero"
        Me.AdvIDTercero.PrimaryDataFields = "IDTercero"
        Me.AdvIDTercero.SecondaryDataFields = "IDTercero"
        Me.AdvIDTercero.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDTercero.TabIndex = 0
        '
        'FrmPermisos
        '
        Me.FrmPermisos.Controls.Add(Me.chbPermisoGD)
        Me.FrmPermisos.Controls.Add(Me.chkFacturacionObras)
        Me.FrmPermisos.Location = New System.Drawing.Point(242, 64)
        Me.FrmPermisos.Name = "FrmPermisos"
        Me.FrmPermisos.Size = New System.Drawing.Size(358, 43)
        Me.FrmPermisos.TabIndex = 7
        Me.FrmPermisos.TabStop = False
        Me.FrmPermisos.Text = "Permisos"
        '
        'chbPermisoGD
        '
        Me.TryDataBinding(chbPermisoGD, New System.Windows.Forms.Binding("BindableValue", Me, "PermisoGD", True))
        Me.chbPermisoGD.Location = New System.Drawing.Point(11, 16)
        Me.chbPermisoGD.Name = "chbPermisoGD"
        Me.chbPermisoGD.Size = New System.Drawing.Size(200, 17)
        Me.chbPermisoGD.TabIndex = 8
        Me.chbPermisoGD.Text = "Permiso Gestión Documental"
        '
        'chkFacturacionObras
        '
        Me.TryDataBinding(chkFacturacionObras, New System.Windows.Forms.Binding("BindableValue", Me, "FacturacionObras", True))
        Me.chkFacturacionObras.Location = New System.Drawing.Point(212, 15)
        Me.chkFacturacionObras.Name = "chkFacturacionObras"
        Me.chkFacturacionObras.Size = New System.Drawing.Size(142, 19)
        Me.chkFacturacionObras.TabIndex = 9
        Me.chkFacturacionObras.Text = "Facturación Proyectos"
        '
        'FrmTipoVendedor
        '
        Me.FrmTipoVendedor.Controls.Add(Me.ChkVendedorTPV)
        Me.FrmTipoVendedor.Controls.Add(Me.chkVendedor)
        Me.FrmTipoVendedor.Location = New System.Drawing.Point(7, 64)
        Me.FrmTipoVendedor.Name = "FrmTipoVendedor"
        Me.FrmTipoVendedor.Size = New System.Drawing.Size(229, 43)
        Me.FrmTipoVendedor.TabIndex = 4
        Me.FrmTipoVendedor.TabStop = False
        Me.FrmTipoVendedor.Text = "Configuración CRM / TPV"
        '
        'ChkVendedorTPV
        '
        Me.TryDataBinding(ChkVendedorTPV, New System.Windows.Forms.Binding("BindableValue", Me, "VendedorTPV", True))
        Me.ChkVendedorTPV.Location = New System.Drawing.Point(120, 17)
        Me.ChkVendedorTPV.Name = "ChkVendedorTPV"
        Me.ChkVendedorTPV.Size = New System.Drawing.Size(105, 17)
        Me.ChkVendedorTPV.TabIndex = 6
        Me.ChkVendedorTPV.Text = "Vendedor TPV"
        '
        'chkVendedor
        '
        Me.TryDataBinding(chkVendedor, New System.Windows.Forms.Binding("BindableValue", Me, "Vendedor", True))
        Me.chkVendedor.Location = New System.Drawing.Point(10, 17)
        Me.chkVendedor.Name = "chkVendedor"
        Me.chkVendedor.Size = New System.Drawing.Size(105, 17)
        Me.chkVendedor.TabIndex = 5
        Me.chkVendedor.Text = "Comercial CRM"
        '
        'fraConfigBonos
        '
        Me.fraConfigBonos.Controls.Add(Me.chkBonosMantenimiento)
        Me.fraConfigBonos.Controls.Add(Me.chkBonosProduccion)
        Me.fraConfigBonos.Controls.Add(Me.chkBonosProyectos)
        Me.fraConfigBonos.Location = New System.Drawing.Point(242, 17)
        Me.fraConfigBonos.Name = "fraConfigBonos"
        Me.fraConfigBonos.Size = New System.Drawing.Size(471, 45)
        Me.fraConfigBonos.TabIndex = 3
        Me.fraConfigBonos.TabStop = False
        Me.fraConfigBonos.Text = "Configuración Bonos"
        '
        'chkBonosMantenimiento
        '
        Me.TryDataBinding(chkBonosMantenimiento, New System.Windows.Forms.Binding("BindableValue", Me, "BonosMantenimiento", True))
        Me.chkBonosMantenimiento.Location = New System.Drawing.Point(11, 20)
        Me.chkBonosMantenimiento.Name = "chkBonosMantenimiento"
        Me.chkBonosMantenimiento.Size = New System.Drawing.Size(159, 17)
        Me.chkBonosMantenimiento.TabIndex = 0
        Me.chkBonosMantenimiento.Text = "Bonos Mantenimiento"
        '
        'chkBonosProduccion
        '
        Me.TryDataBinding(chkBonosProduccion, New System.Windows.Forms.Binding("BindableValue", Me, "BonosProduccion", True))
        Me.chkBonosProduccion.Location = New System.Drawing.Point(195, 20)
        Me.chkBonosProduccion.Name = "chkBonosProduccion"
        Me.chkBonosProduccion.Size = New System.Drawing.Size(143, 17)
        Me.chkBonosProduccion.TabIndex = 1
        Me.chkBonosProduccion.Text = "Bonos Producción"
        '
        'chkBonosProyectos
        '
        Me.TryDataBinding(chkBonosProyectos, New System.Windows.Forms.Binding("BindableValue", Me, "BonosProyectos", True))
        Me.chkBonosProyectos.Location = New System.Drawing.Point(344, 20)
        Me.chkBonosProyectos.Name = "chkBonosProyectos"
        Me.chkBonosProyectos.Size = New System.Drawing.Size(132, 19)
        Me.chkBonosProyectos.TabIndex = 2
        Me.chkBonosProyectos.Text = "Bonos Proyectos"
        '
        'FraPlanificacion
        '
        Me.FraPlanificacion.Controls.Add(Me.chkProgVisible)
        Me.FraPlanificacion.Controls.Add(Me.chkProgramable)
        Me.FraPlanificacion.Location = New System.Drawing.Point(7, 17)
        Me.FraPlanificacion.Name = "FraPlanificacion"
        Me.FraPlanificacion.Size = New System.Drawing.Size(229, 45)
        Me.FraPlanificacion.TabIndex = 2
        Me.FraPlanificacion.TabStop = False
        Me.FraPlanificacion.Text = "Planificación Recursos"
        '
        'chkProgVisible
        '
        Me.TryDataBinding(chkProgVisible, New System.Windows.Forms.Binding("BindableValue", Me, "ProgVisible", True))
        Me.chkProgVisible.Location = New System.Drawing.Point(120, 20)
        Me.chkProgVisible.Name = "chkProgVisible"
        Me.chkProgVisible.Size = New System.Drawing.Size(72, 17)
        Me.chkProgVisible.TabIndex = 31
        Me.chkProgVisible.Text = "Visible"
        '
        'chkProgramable
        '
        Me.TryDataBinding(chkProgramable, New System.Windows.Forms.Binding("BindableValue", Me, "Programable", True))
        Me.chkProgramable.Location = New System.Drawing.Point(10, 20)
        Me.chkProgramable.Name = "chkProgramable"
        Me.chkProgramable.Size = New System.Drawing.Size(97, 17)
        Me.chkProgramable.TabIndex = 30
        Me.chkProgramable.Text = "Programable"
        '
        'chkExterno
        '
        Me.TryDataBinding(chkExterno, New System.Windows.Forms.Binding("BindableValue", Me, "Externo", True))
        Me.chkExterno.Location = New System.Drawing.Point(396, 55)
        Me.chkExterno.Name = "chkExterno"
        Me.chkExterno.Size = New System.Drawing.Size(64, 19)
        Me.chkExterno.TabIndex = 8
        Me.chkExterno.Text = "Externo"
        '
        'GridOperarioHora
        '
        Me.GridOperarioHora.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDHora", "Hora", "IDHora", "tbMaestroHora")})
        GridOperarioHora_DesignTimeLayout.LayoutString = resources.GetString("GridOperarioHora_DesignTimeLayout.LayoutString")
        Me.GridOperarioHora.DesignTimeLayout = GridOperarioHora_DesignTimeLayout
        Me.GridOperarioHora.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridOperarioHora.EntityName = "OperarioHora"
        Me.GridOperarioHora.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridOperarioHora.ImageList = Me.ImageList1
        Me.GridOperarioHora.Location = New System.Drawing.Point(559, 221)
        Me.GridOperarioHora.Name = "GridOperarioHora"
        Me.GridOperarioHora.PrimaryDataFields = "IDOperario"
        Me.GridOperarioHora.SecondaryDataFields = "IDOperario"
        Me.GridOperarioHora.Size = New System.Drawing.Size(218, 138)
        Me.GridOperarioHora.TabIndex = 22
        Me.GridOperarioHora.ViewName = "tbOperarioHora"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "book_blue.ico")
        '
        'lblCategoria
        '
        Me.lblCategoria.Location = New System.Drawing.Point(5, 174)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(63, 13)
        Me.lblCategoria.TabIndex = 108
        Me.lblCategoria.Tag = "IdRec=4619;"
        Me.lblCategoria.Text = "Categoría"
        '
        'AdvIdProveedor
        '
        Me.AdvIdProveedor.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescProveedor", ulDescProveedor)})
        Me.TryDataBinding(AdvIdProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor", True))
        Me.AdvIdProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIdProveedor.EntityName = "Proveedor"
        Me.AdvIdProveedor.Location = New System.Drawing.Point(540, 52)
        Me.AdvIdProveedor.MaxLength = 25
        Me.AdvIdProveedor.Name = "AdvIdProveedor"
        Me.AdvIdProveedor.PrimaryDataFields = "IDProveedor"
        Me.AdvIdProveedor.SecondaryDataFields = "IDProveedor"
        Me.AdvIdProveedor.Size = New System.Drawing.Size(104, 23)
        Me.AdvIdProveedor.TabIndex = 9
        Me.AdvIdProveedor.ViewName = "tbMaestroProveedor"
        Me.AdvIdProveedor.Visible = False
        '
        'ulDescProveedor
        '
        Me.TryDataBinding(ulDescProveedor, New System.Windows.Forms.Binding("Text", Me.AdvIdProveedor, "DescProveedor", True))
        Me.ulDescProveedor.Location = New System.Drawing.Point(647, 52)
        Me.ulDescProveedor.Name = "ulDescProveedor"
        Me.ulDescProveedor.Size = New System.Drawing.Size(130, 23)
        Me.ulDescProveedor.TabIndex = 107
        Me.ulDescProveedor.UseMnemonic = False
        Me.ulDescProveedor.Visible = False
        '
        'FraCondEco
        '
        Me.FraCondEco.Controls.Add(Me.lblSwift)
        Me.FraCondEco.Controls.Add(Me.txtSwift)
        Me.FraCondEco.Controls.Add(Me.lblCodigoIBAN)
        Me.FraCondEco.Controls.Add(Me.txtCodigoIBAN)
        Me.FraCondEco.Controls.Add(Me.lblSucursal)
        Me.FraCondEco.Controls.Add(Me.txtSucursal)
        Me.FraCondEco.Controls.Add(Me.lblDigitoControl)
        Me.FraCondEco.Controls.Add(Me.txtDigitoControl)
        Me.FraCondEco.Controls.Add(Me.lblNCuenta)
        Me.FraCondEco.Controls.Add(Me.txtNCuenta)
        Me.FraCondEco.Controls.Add(Me.lblFormaPago)
        Me.FraCondEco.Controls.Add(Me.ulDescFormaPago)
        Me.FraCondEco.Controls.Add(Me.AdvIDFormaPago)
        Me.FraCondEco.Controls.Add(Me.lblBanco)
        Me.FraCondEco.Controls.Add(Me.ulDescBanco)
        Me.FraCondEco.Controls.Add(Me.advIDBanco)
        Me.FraCondEco.Location = New System.Drawing.Point(5, 246)
        Me.FraCondEco.Name = "FraCondEco"
        Me.FraCondEco.Size = New System.Drawing.Size(549, 116)
        Me.FraCondEco.TabIndex = 17
        Me.FraCondEco.TabStop = False
        Me.FraCondEco.Text = "Condiciones Econonómicas"
        '
        'lblSwift
        '
        Me.lblSwift.Location = New System.Drawing.Point(349, 19)
        Me.lblSwift.Name = "lblSwift"
        Me.lblSwift.Size = New System.Drawing.Size(44, 13)
        Me.lblSwift.TabIndex = 42
        Me.lblSwift.Text = "SWIFT"
        '
        'txtSwift
        '
        Me.TryDataBinding(txtSwift, New System.Windows.Forms.Binding("Text", Me, "SWIFT", True))
        Me.txtSwift.DisabledBackColor = System.Drawing.Color.White
        Me.txtSwift.Location = New System.Drawing.Point(396, 15)
        Me.txtSwift.MaxLength = 11
        Me.txtSwift.Name = "txtSwift"
        Me.txtSwift.Size = New System.Drawing.Size(147, 21)
        Me.txtSwift.TabIndex = 1
        '
        'lblCodigoIBAN
        '
        Me.lblCodigoIBAN.Location = New System.Drawing.Point(7, 19)
        Me.lblCodigoIBAN.Name = "lblCodigoIBAN"
        Me.lblCodigoIBAN.Size = New System.Drawing.Size(80, 13)
        Me.lblCodigoIBAN.TabIndex = 40
        Me.lblCodigoIBAN.Text = "Código IBAN"
        '
        'txtCodigoIBAN
        '
        Me.TryDataBinding(txtCodigoIBAN, New System.Windows.Forms.Binding("Text", Me, "CodigoIBAN", True))
        Me.txtCodigoIBAN.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodigoIBAN.Location = New System.Drawing.Point(88, 15)
        Me.txtCodigoIBAN.MaxLength = 34
        Me.txtCodigoIBAN.Name = "txtCodigoIBAN"
        Me.txtCodigoIBAN.Size = New System.Drawing.Size(255, 21)
        Me.txtCodigoIBAN.TabIndex = 0
        '
        'lblSucursal
        '
        Me.lblSucursal.Location = New System.Drawing.Point(7, 92)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(56, 13)
        Me.lblSucursal.TabIndex = 0
        Me.lblSucursal.Tag = "IdRec=4606;"
        Me.lblSucursal.Text = "Sucursal"
        '
        'txtSucursal
        '
        Me.TryDataBinding(txtSucursal, New System.Windows.Forms.Binding("Text", Me, "Sucursal", True))
        Me.txtSucursal.DisabledBackColor = System.Drawing.Color.White
        Me.txtSucursal.Location = New System.Drawing.Point(88, 92)
        Me.txtSucursal.MaxLength = 4
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(96, 21)
        Me.txtSucursal.TabIndex = 4
        '
        'lblDigitoControl
        '
        Me.lblDigitoControl.Location = New System.Drawing.Point(198, 96)
        Me.lblDigitoControl.Name = "lblDigitoControl"
        Me.lblDigitoControl.Size = New System.Drawing.Size(33, 13)
        Me.lblDigitoControl.TabIndex = 27
        Me.lblDigitoControl.Tag = ""
        Me.lblDigitoControl.Text = "D.C."
        '
        'txtDigitoControl
        '
        Me.TryDataBinding(txtDigitoControl, New System.Windows.Forms.Binding("Text", Me, "DigitoControl", True))
        Me.txtDigitoControl.DisabledBackColor = System.Drawing.Color.White
        Me.txtDigitoControl.Location = New System.Drawing.Point(237, 92)
        Me.txtDigitoControl.MaxLength = 2
        Me.txtDigitoControl.Name = "txtDigitoControl"
        Me.txtDigitoControl.Size = New System.Drawing.Size(48, 21)
        Me.txtDigitoControl.TabIndex = 5
        '
        'lblNCuenta
        '
        Me.lblNCuenta.Location = New System.Drawing.Point(300, 96)
        Me.lblNCuenta.Name = "lblNCuenta"
        Me.lblNCuenta.Size = New System.Drawing.Size(82, 13)
        Me.lblNCuenta.TabIndex = 28
        Me.lblNCuenta.Tag = "IdRec=6986;"
        Me.lblNCuenta.Text = "Num. Cuenta"
        '
        'txtNCuenta
        '
        Me.TryDataBinding(txtNCuenta, New System.Windows.Forms.Binding("Text", Me, "NCuenta", True))
        Me.txtNCuenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtNCuenta.Location = New System.Drawing.Point(387, 92)
        Me.txtNCuenta.MaxLength = 10
        Me.txtNCuenta.Name = "txtNCuenta"
        Me.txtNCuenta.Size = New System.Drawing.Size(156, 21)
        Me.txtNCuenta.TabIndex = 6
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(7, 42)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblFormaPago.TabIndex = 29
        Me.lblFormaPago.Tag = ""
        Me.lblFormaPago.Text = "Forma Pago"
        '
        'ulDescFormaPago
        '
        Me.TryDataBinding(ulDescFormaPago, New System.Windows.Forms.Binding("Text", Me.AdvIDFormaPago, "DescFormaPago", True))
        Me.ulDescFormaPago.Location = New System.Drawing.Point(189, 40)
        Me.ulDescFormaPago.Name = "ulDescFormaPago"
        Me.ulDescFormaPago.Size = New System.Drawing.Size(354, 23)
        Me.ulDescFormaPago.TabIndex = 30
        Me.ulDescFormaPago.UseMnemonic = False
        '
        'AdvIDFormaPago
        '
        Me.AdvIDFormaPago.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescFormaPago", ulDescFormaPago)})
        Me.TryDataBinding(AdvIDFormaPago, New System.Windows.Forms.Binding("Text", Me, "IDFormaPago", True))
        Me.AdvIDFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDFormaPago.EntityName = "FormaPago"
        Me.AdvIDFormaPago.Location = New System.Drawing.Point(88, 40)
        Me.AdvIDFormaPago.MaxLength = 10
        Me.AdvIDFormaPago.Name = "AdvIDFormaPago"
        Me.AdvIDFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.AdvIDFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.AdvIDFormaPago.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDFormaPago.TabIndex = 2
        Me.AdvIDFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'lblBanco
        '
        Me.lblBanco.Location = New System.Drawing.Point(7, 66)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(42, 13)
        Me.lblBanco.TabIndex = 31
        Me.lblBanco.Tag = "IdRec=5834;"
        Me.lblBanco.Text = "Banco"
        '
        'ulDescBanco
        '
        Me.TryDataBinding(ulDescBanco, New System.Windows.Forms.Binding("Text", Me.advIDBanco, "DescBanco", True))
        Me.ulDescBanco.Location = New System.Drawing.Point(189, 66)
        Me.ulDescBanco.Name = "ulDescBanco"
        Me.ulDescBanco.Size = New System.Drawing.Size(354, 23)
        Me.ulDescBanco.TabIndex = 32
        Me.ulDescBanco.UseMnemonic = False
        '
        'advIDBanco
        '
        Me.advIDBanco.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescBanco", ulDescBanco)})
        Me.TryDataBinding(advIDBanco, New System.Windows.Forms.Binding("Text", Me, "IDBanco", True))
        Me.advIDBanco.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBanco.EntityName = "Banco"
        Me.advIDBanco.Location = New System.Drawing.Point(88, 66)
        Me.advIDBanco.MaxLength = 10
        Me.advIDBanco.Name = "advIDBanco"
        Me.advIDBanco.PrimaryDataFields = "IDBanco"
        Me.advIDBanco.SecondaryDataFields = "IDBanco"
        Me.advIDBanco.Size = New System.Drawing.Size(96, 23)
        Me.advIDBanco.TabIndex = 3
        Me.advIDBanco.ViewName = "tbMaestroBanco"
        '
        'lblIDoperario
        '
        Me.lblIDoperario.Location = New System.Drawing.Point(3, 8)
        Me.lblIDoperario.Name = "lblIDoperario"
        Me.lblIDoperario.Size = New System.Drawing.Size(57, 13)
        Me.lblIDoperario.TabIndex = 87
        Me.lblIDoperario.Tag = ""
        Me.lblIDoperario.Text = "Operario"
        '
        'txtIDoperario
        '
        Me.TryDataBinding(txtIDoperario, New System.Windows.Forms.Binding("Text", Me, "IDoperario", True))
        Me.txtIDoperario.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDoperario.Location = New System.Drawing.Point(98, 4)
        Me.txtIDoperario.MaxLength = 10
        Me.txtIDoperario.Name = "txtIDoperario"
        Me.txtIDoperario.Size = New System.Drawing.Size(91, 21)
        Me.txtIDoperario.TabIndex = 0
        '
        'txtDescOperario
        '
        Me.TryDataBinding(txtDescOperario, New System.Windows.Forms.Binding("Text", Me, "DescOperario", True))
        Me.txtDescOperario.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescOperario.Location = New System.Drawing.Point(98, 28)
        Me.txtDescOperario.MaxLength = 100
        Me.txtDescOperario.Name = "txtDescOperario"
        Me.txtDescOperario.Size = New System.Drawing.Size(498, 21)
        Me.txtDescOperario.TabIndex = 4
        '
        'lblFechaAlta
        '
        Me.lblFechaAlta.Location = New System.Drawing.Point(603, 5)
        Me.lblFechaAlta.Name = "lblFechaAlta"
        Me.lblFechaAlta.Size = New System.Drawing.Size(66, 13)
        Me.lblFechaAlta.TabIndex = 88
        Me.lblFechaAlta.Tag = "IdRec=4457;"
        Me.lblFechaAlta.Text = "Fecha Alta"
        '
        'cbxFechaAlta
        '
        Me.TryDataBinding(cbxFechaAlta, New System.Windows.Forms.Binding("BindableValue", Me, "FechaAlta", True))
        Me.cbxFechaAlta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAlta.Location = New System.Drawing.Point(672, 4)
        Me.cbxFechaAlta.Name = "cbxFechaAlta"
        Me.cbxFechaAlta.Size = New System.Drawing.Size(106, 21)
        Me.cbxFechaAlta.TabIndex = 3
        '
        'lblDNI
        '
        Me.lblDNI.Location = New System.Drawing.Point(230, 56)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(72, 13)
        Me.lblDNI.TabIndex = 97
        Me.lblDNI.Tag = ""
        Me.lblDNI.Text = "Documento"
        '
        'txtDNI
        '
        Me.TryDataBinding(txtDNI, New System.Windows.Forms.Binding("Text", Me, "DNI", True))
        Me.txtDNI.DisabledBackColor = System.Drawing.Color.White
        Me.txtDNI.Location = New System.Drawing.Point(308, 52)
        Me.txtDNI.MaxLength = 25
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(80, 21)
        Me.txtDNI.TabIndex = 7
        '
        'ulDescCategoria
        '
        Me.TryDataBinding(ulDescCategoria, New System.Windows.Forms.Binding("Text", Me.AdvIDCategoria, "DescCategoria", True))
        Me.ulDescCategoria.Location = New System.Drawing.Point(170, 170)
        Me.ulDescCategoria.Name = "ulDescCategoria"
        Me.ulDescCategoria.Size = New System.Drawing.Size(244, 23)
        Me.ulDescCategoria.TabIndex = 98
        Me.ulDescCategoria.UseMnemonic = False
        '
        'AdvIDCategoria
        '
        Me.AdvIDCategoria.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCategoria", ulDescCategoria)})
        Me.TryDataBinding(AdvIDCategoria, New System.Windows.Forms.Binding("Text", Me, "IDCategoria", True))
        Me.AdvIDCategoria.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCategoria.EntityName = "Categoria"
        Me.AdvIDCategoria.Location = New System.Drawing.Point(98, 170)
        Me.AdvIDCategoria.MaxLength = 10
        Me.AdvIDCategoria.Name = "AdvIDCategoria"
        Me.AdvIDCategoria.PrimaryDataFields = "IDCategoria"
        Me.AdvIDCategoria.SecondaryDataFields = "IDCategoria"
        Me.AdvIDCategoria.Size = New System.Drawing.Size(67, 23)
        Me.AdvIDCategoria.TabIndex = 11
        Me.AdvIDCategoria.ViewName = "tbMaestroCategoria"
        '
        'lblOficio
        '
        Me.lblOficio.Location = New System.Drawing.Point(420, 176)
        Me.lblOficio.Name = "lblOficio"
        Me.lblOficio.Size = New System.Drawing.Size(39, 13)
        Me.lblOficio.TabIndex = 100
        Me.lblOficio.Tag = "IdRec=7672;"
        Me.lblOficio.Text = "Oficio"
        '
        'ulDescOficio
        '
        Me.TryDataBinding(ulDescOficio, New System.Windows.Forms.Binding("Text", Me.advIdOficio, "DescOficio", True))
        Me.ulDescOficio.Location = New System.Drawing.Point(544, 172)
        Me.ulDescOficio.Name = "ulDescOficio"
        Me.ulDescOficio.Size = New System.Drawing.Size(233, 21)
        Me.ulDescOficio.TabIndex = 101
        Me.ulDescOficio.UseMnemonic = False
        '
        'advIdOficio
        '
        Me.advIdOficio.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescOficio", ulDescOficio)})
        Me.TryDataBinding(advIdOficio, New System.Windows.Forms.Binding("Text", Me, "IDOficio", True))
        Me.advIdOficio.DisabledBackColor = System.Drawing.Color.White
        Me.advIdOficio.EntityName = "Oficio"
        Me.advIdOficio.Location = New System.Drawing.Point(472, 170)
        Me.advIdOficio.MaxLength = 10
        Me.advIdOficio.Name = "advIdOficio"
        Me.advIdOficio.PrimaryDataFields = "IDOficio"
        Me.advIdOficio.SecondaryDataFields = "IDOficio"
        Me.advIdOficio.Size = New System.Drawing.Size(67, 23)
        Me.advIdOficio.TabIndex = 12
        Me.advIdOficio.ViewName = "tbMaestroOficio"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Location = New System.Drawing.Point(5, 200)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(89, 13)
        Me.lblDepartamento.TabIndex = 102
        Me.lblDepartamento.Tag = ""
        Me.lblDepartamento.Text = "Departamento"
        '
        'ulDescDepartamento
        '
        Me.TryDataBinding(ulDescDepartamento, New System.Windows.Forms.Binding("Text", Me.AdvIDDepartamento, "DescDepartamento", True))
        Me.ulDescDepartamento.Location = New System.Drawing.Point(170, 195)
        Me.ulDescDepartamento.Name = "ulDescDepartamento"
        Me.ulDescDepartamento.Size = New System.Drawing.Size(244, 23)
        Me.ulDescDepartamento.TabIndex = 103
        Me.ulDescDepartamento.UseMnemonic = False
        '
        'AdvIDDepartamento
        '
        Me.AdvIDDepartamento.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescDepartamento", ulDescDepartamento)})
        Me.TryDataBinding(AdvIDDepartamento, New System.Windows.Forms.Binding("Text", Me, "IDDepartamento", True))
        Me.AdvIDDepartamento.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDDepartamento.EntityName = "Departamento"
        Me.AdvIDDepartamento.Location = New System.Drawing.Point(98, 195)
        Me.AdvIDDepartamento.MaxLength = 10
        Me.AdvIDDepartamento.Name = "AdvIDDepartamento"
        Me.AdvIDDepartamento.PrimaryDataFields = "IDDepartamento"
        Me.AdvIDDepartamento.SecondaryDataFields = "IDDepartamento"
        Me.AdvIDDepartamento.Size = New System.Drawing.Size(67, 23)
        Me.AdvIDDepartamento.TabIndex = 13
        Me.AdvIDDepartamento.ViewName = "tbMaestroDepartamento"
        '
        'CmbCurriculum
        '
        Me.CmbCurriculum.ImageIndex = 0
        Me.CmbCurriculum.ImageList = Me.ImageList1
        Me.CmbCurriculum.Location = New System.Drawing.Point(533, 221)
        Me.CmbCurriculum.Name = "CmbCurriculum"
        Me.CmbCurriculum.Size = New System.Drawing.Size(21, 21)
        Me.CmbCurriculum.TabIndex = 16
        '
        'lblCurriculum
        '
        Me.lblCurriculum.Location = New System.Drawing.Point(5, 225)
        Me.lblCurriculum.Name = "lblCurriculum"
        Me.lblCurriculum.Size = New System.Drawing.Size(70, 13)
        Me.lblCurriculum.TabIndex = 104
        Me.lblCurriculum.Tag = "IdRec=7670;"
        Me.lblCurriculum.Text = "Curriculum"
        '
        'txtCurriculum
        '
        Me.TryDataBinding(txtCurriculum, New System.Windows.Forms.Binding("Text", Me, "Curriculum", True))
        Me.txtCurriculum.DisabledBackColor = System.Drawing.Color.White
        Me.txtCurriculum.Location = New System.Drawing.Point(98, 221)
        Me.txtCurriculum.MaxLength = 200
        Me.txtCurriculum.Name = "txtCurriculum"
        Me.txtCurriculum.Size = New System.Drawing.Size(433, 21)
        Me.txtCurriculum.TabIndex = 15
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(421, 199)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(50, 13)
        Me.lblUsuario.TabIndex = 105
        Me.lblUsuario.Tag = "IdRec=4362;"
        Me.lblUsuario.Text = "Usuario"
        '
        'cbxUsuario
        '
        Me.TryDataBinding(cbxUsuario, New System.Windows.Forms.Binding("Value", Me, "IDUsuario", True))
        cbxUsuario_DesignTimeLayout.LayoutString = resources.GetString("cbxUsuario_DesignTimeLayout.LayoutString")
        Me.cbxUsuario.DesignTimeLayout = cbxUsuario_DesignTimeLayout
        Me.cbxUsuario.DisabledBackColor = System.Drawing.Color.White
        Me.cbxUsuario.DisplayMember = "CUsuario"
        Me.cbxUsuario.Location = New System.Drawing.Point(472, 195)
        Me.cbxUsuario.Name = "cbxUsuario"
        Me.cbxUsuario.SelectedIndex = -1
        Me.cbxUsuario.SelectedItem = Nothing
        Me.cbxUsuario.Size = New System.Drawing.Size(305, 21)
        Me.cbxUsuario.TabIndex = 14
        Me.cbxUsuario.ValueMember = "IDUsuario"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = False
        Me.lblProveedor.Location = New System.Drawing.Point(468, 57)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(68, 17)
        Me.lblProveedor.TabIndex = 106
        Me.lblProveedor.Text = "Proveedor"
        Me.lblProveedor.Visible = False
        '
        'MntoOperario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(804, 788)
        Me.EntityName = "Operario"
        Me.Name = "MntoOperario"
        Me.NavigationFields = "IDOperario"
        Me.ViewName = "vJMAMntoOperario"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.PicFichaOperario.ResumeLayout(False)
        Me.PicFichaOperario.PerformLayout()
        Me.pnlFichaOperario.ResumeLayout(False)
        Me.pnlFichaOperario.PerformLayout()
        CType(Me.CmbTipoDocIdent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraDatosContacto.ResumeLayout(False)
        Me.FraDatosContacto.PerformLayout()
        Me.FraConfiguracion.ResumeLayout(False)
        Me.FraGestionTerceros.ResumeLayout(False)
        Me.FraGestionTerceros.PerformLayout()
        Me.FrmPermisos.ResumeLayout(False)
        Me.FrmTipoVendedor.ResumeLayout(False)
        Me.fraConfigBonos.ResumeLayout(False)
        Me.FraPlanificacion.ResumeLayout(False)
        CType(Me.GridOperarioHora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraCondEco.ResumeLayout(False)
        Me.FraCondEco.PerformLayout()
        CType(Me.cbxUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrProveedorContrata As String

#Region " Load "

    Private Sub MntoOperario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mstrProveedorContrata = New Parametro().TipoProvContrata
        cbxUsuario.DataSource = ExpertisApp.ExecuteTask(Of Filter, DataTable)(AddressOf DatosSistema.DevuelveUsuariosBD, New Filter)
        LoadToolBarActions()
        LoadEnums()
        LoadGridActions()
    End Sub

    Private Sub LoadToolBarActions()
        Me.FormActions.Add("Ver Calendario de Operario", AddressOf VerCalendarioOperario, ExpertisApp.GetIcon("calendar.ico"))
    End Sub

    Private Sub LoadEnums()
        Me.CmbTipoDocIdent.DataSource = New LatDocIdentidad().Filter
        Me.CmbTipoDocIdent.DataMember = "TipoDocIdentidad"
        Me.CmbTipoDocIdent.ValueMember = "TipoDocIdentidad"
        Me.CmbTipoDocIdent.DisplayMember = "DescDocIdentidad"
        'CmbTipoDocIdent.DataSource = EnumData.EnumView("enumTipoDocIdent")
    End Sub

    Private Sub LoadGridActions()
        Me.GridOperarioHora.Actions.Add("Abrir Histórico", AddressOf AccionAbrirHistorico, ExpertisApp.GetIcon("book_blue.ico"))
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub VerCalendarioOperario()
        Solmicro.Expertis.Engine.UI.ExpertisApp.OpenForm("CALOPERARIO", New FilterItem("IDOperario", Me.CurrentRow("IDOperario")))
    End Sub

#End Region

#Region "Grid Actions"

    Private Sub AccionAbrirHistorico()
        Dim FrmHist As New Solmicro.Expertis.Application.ERP.Operario.frmHistoricoHoraTasa
        FrmHist.IDOperario = Me.CurrentRow("IDOperario")
        FrmHist.DescOperario = Me.CurrentRow("DescOperario")
        FrmHist.IDHora = Me.GridOperarioHora.GetValue("IDHora")
        FrmHist.TasaHorariaA = Me.GridOperarioHora.GetValue("TasaHorariaA")
        FrmHist.ShowDialog()
    End Sub

#End Region

    Private Sub MntoOperario_Navigated(ByVal sender As Object, ByVal e As Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        MostrarExternoProveedor()
    End Sub

    Private Sub chkExterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExterno.CheckedChanged
        MostrarExternoProveedor()
    End Sub

    Private Sub MostrarExternoProveedor()
        lblProveedor.Visible = chkExterno.Checked
        AdvIdProveedor.Visible = chkExterno.Checked
        ulDescProveedor.Visible = chkExterno.Checked
    End Sub

    Private Sub AdvIdProveedor_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIdProveedor.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("IDTipoProveedor", FilterOperator.Equal, mstrProveedorContrata))
    End Sub

    Private Sub txtDNI_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDNI.Validating
        ValidaDocumentoIdentificativo()
    End Sub

    Private Sub advIDPais_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles advIDPais.Validating
        ValidaDocumentoIdentificativo()
    End Sub

    Private Sub CmbTipoDocIdent_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CmbTipoDocIdent.Validating
        ValidaDocumentoIdentificativo()
    End Sub

    Private Function ValidaDocumentoIdentificativo() As Boolean
        Dim blnOK As Boolean = True
        If Length(txtDNI.Text) > 0 Then
            Dim datos As New DataDocIdentificacion(txtDNI.Text, advIDPais.Text, CmbTipoDocIdent.Value)
            datos = ExpertisApp.ExecuteTask(Of DataDocIdentificacion, DataDocIdentificacion)(AddressOf Comunes.ValidarDocumentoIdentificativo, datos)
            If Not datos.EsCorrecto Then
                If Length(datos.DocumentoCorrecto) > 0 Then
                    txtDNI.Text = datos.DocumentoCorrecto
                Else
                    blnOK = False
                    ExpertisApp.GenerateMessage("El Documento introducido no es un '|'. Intoduzca uno correcto o cambie de tipo de documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, datos.TipoDocumento)
                End If
            End If
        End If
        Return blnOK


    End Function

    Private Sub advCodPostal_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advCodPostal.SetPredefinedFilter
        If Length(advIDPais.Text) > 0 Then e.Filter.Add(New StringFilterItem("IDPais", advIDPais.Text))
    End Sub

    Private Sub advCodPostal_NotInList(ByVal sender As Object, ByVal e As Engine.UI.NotInListEventArgs) Handles advCodPostal.NotInList
        e.Handled = True
        e.Cancel = False
    End Sub

    Private Sub advPoblacion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advPoblacion.SetPredefinedFilter
        If Length(advIDPais.Text) > 0 Then e.Filter.Add(New StringFilterItem("IDPais", advIDPais.Text))
        If Length(advCodPostal.Text) > 0 Then e.Filter.Add(New StringFilterItem("CodPostal", advCodPostal.Text))
    End Sub

    Private Sub advPoblacion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advPoblacion.SelectionChanged
        If Not e.Selected Is Nothing Then
            If Length(e.Selected.Rows(0)("IDPais")) > 0 Then advIDPais.Text = e.Selected.Rows(0)("IDPais")
            If Length(e.Selected.Rows(0)("CodPostal")) > 0 Then advCodPostal.Text = e.Selected.Rows(0)("CodPostal")
            If Length(e.Selected.Rows(0)("DescProvincia")) > 0 Then txtProvincia.Text = e.Selected.Rows(0)("DescProvincia")
        End If
    End Sub

    Private Sub advPoblacion_NotInList(ByVal sender As Object, ByVal e As Engine.UI.NotInListEventArgs) Handles advPoblacion.NotInList
        e.Handled = True
        e.Cancel = False
    End Sub

    Private Sub CmbCurriculum_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCurriculum.Click
        OpenFileDialog1.InitialDirectory = ExpertisApp.Path
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> String.Empty Then
            txtCurriculum.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Public Overrides Sub UpdateData(Optional ByVal EndCurrentEdit As Boolean = True)
        If Me.CurrentRow.RowState = DataRowState.Deleted Then
            MyBase.UpdateData(EndCurrentEdit)
            Me.GotoRecord(DataProviderActions.GoFirst)
        ElseIf ValidaDocumentoIdentificativo() Then
            MyBase.UpdateData(EndCurrentEdit)
        End If
    End Sub

    Private Sub GridOperarioHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridOperarioHora.Click
        Dim Hit As Janus.Windows.GridEX.GridArea = Me.GridOperarioHora.HitTest
        If Hit = Janus.Windows.GridEX.GridArea.Cell Then
            Dim c As Janus.Windows.GridEX.GridEXColumn = Me.GridOperarioHora.ColumnFromPoint()
            If Not IsNothing(c) Then
                Select Case c.Key
                    Case "BtnHistorico"
                        Dim FrmHistorico As New Solmicro.Expertis.Application.ERP.Operario.frmHistoricoHoraTasa
                        FrmHistorico.IDOperario = Me.CurrentRow("IDOperario")
                        FrmHistorico.DescOperario = Me.CurrentRow("DescOperario")
                        FrmHistorico.TasaHorariaA = Me.GridOperarioHora.GetValue("TasaHorariaA")
                        FrmHistorico.IDHora = Me.GridOperarioHora.GetValue("IDHora")
                        FrmHistorico.ShowDialog()
                End Select
            End If
        End If
    End Sub

    Private Sub GridOperarioHora_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridOperarioHora.UpdatingCell
        Select Case e.Column.Key
            Case "TasaHorariaA"
                If Me.GridOperarioHora.Row <> Me.GridOperarioHora.newTopRowPosition Then
                    If ExpertisApp.GenerateMessage("Si desea mantener la Tasa que tenía registrada, deberá insertar la información del periodo de vigencia para dicha tasa, ¿desea dar de alta el nuevo registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = Windows.Forms.DialogResult.Yes Then
                        Dim FrmHist As New Solmicro.Expertis.Application.ERP.Operario.frmHistoricoHoraTasa
                        FrmHist.IDOperario = Me.CurrentRow("IDOperario")
                        FrmHist.DescOperario = Me.CurrentRow("DescOperario")
                        FrmHist.IDHora = Me.GridOperarioHora.GetValue("IDHora")
                        FrmHist.TasaHorariaA = e.InitialValue
                        FrmHist.ShowDialog()
                    End If
                End If
        End Select
    End Sub

End Class
