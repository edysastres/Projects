Imports Janus.Windows.GridEX
Imports Solmicro.Expertis
Imports Solmicro.Expertis.Application.ERP.FacturaVenta
Imports Solmicro.Expertis.Application.ERP.FactElecCorreo
Imports Solmicro.Expertis.Business.SEPA

Public Class MntoFacturaVenta
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        SettingNeededData()
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
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents FwiIDContador As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiTotalIva As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiTotalBaseImp As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiTotalBaseImp As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents ulDescCliente As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiCIF As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiFecFactura As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents fwiRazonSocial As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiTel As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiFax As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiDir As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiCodPostal As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiPoblacion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents FwiIdPais As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents fwiProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiFecVencimiento As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents fwiNFactura As Solmicro.Expertis.Engine.UI.CounterTextBox
    Public WithEvents LblSelloContabilizado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblNObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents TabFacturas As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents jngLineaFactura As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents FraRetencion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiDescMonedaA As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiDescMonedaB As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiCambioA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiCambioB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiIdMoneda As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdMoneda As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescMoneda As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiTipoAsiento As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblfwiTipoAsiento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCondPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiCondPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiCondPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIdDiaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdDiaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdDiaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIdClteBanco As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdClteBanco As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiFormaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiDescClteBanco As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiCambioB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiCambioA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpRetencionGar As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblFechaRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaRetencion As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtRetencion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTipoRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoRetencion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents fwiImpLineasEspecialesB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpLineasNormalesB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpLineasEspecialesA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpLineasNormalesA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpLineasB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpLineasA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpIVAA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpIVAB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpTotalA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpTotalB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpRetencionB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpReB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiBaseImpA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiBaseImpB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiRetencionA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpReA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpRecFinanA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpRecFinanB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiMonedaA As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiMonedaB As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents Line2 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line12 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line10 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents fwiImpLineasNormales As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpLineasEspeciales As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpTotalConRetencion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiDtoFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpRecFinan As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiRecFinan As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiRecFinan As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiIVA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpREMon As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiImpLinMon As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiBaseImpMon As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiDtoProntoPago As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiDtoProntoPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpRetencion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiPorcIRPF As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiDescMoneda As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiImpPuntoVerde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiTextoFactura As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiCGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents FwiTipoFactura As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblTipoFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblCentroCoste As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents CmbCentroCoste As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents fwiClienteIni As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblcfwiClienteIni As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents chbEnviadaEntidadAseguradora1 As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblDescAseguradora As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtDescAseguradora As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents chkFechaDeclManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents FwiFechaParaDeclaracion As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents fwiAñoDeclaracion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiNDeclaracion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents chkEnviar347 As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents jngConceptos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents fwiIdDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents Line19 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line18 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line15 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line3 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents PicCabecera As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents chbEnviadaEntidadAseguradora As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents TabPageDeclaraciones As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageLineas As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageDatosEconomicos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageSeguimiento As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageConceptos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicAnotaciones As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageTotales As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageImporteMonedas As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageVencimientos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageBasesIVA As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents lblImpPuntoVerde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblPorc3 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblPorc4 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblPorc As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblPorc2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCGestion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaParaDeclaracion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblNumDeclaracion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblAñoDeclaracion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents lblImpLineasEspecialesB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpLineasNormalesB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpLineasEspecialesA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpLineasNormalesA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpLineasB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpLineasA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpIVAA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpIVAB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpTotalA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpTotalB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpRetencionB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpReB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblBaseImpA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblBaseImpB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblRetencionA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpReA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpRecFinanA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpRecFinanB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lbIDContador As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalIva As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCIF As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFecVencimiento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFecFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblRazonSocial As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTelefono As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFax As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblDireccion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblNFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblPais As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents chkVencimientoManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkIVAManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents FraMonedasInternas As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraMoneda As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fraCondicionesEconomicas As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraImporteMonedas As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraPuntoVerde As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraRetenciones As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblImpRetencion2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblPorcIRPF As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraCalculoFactura As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblImpLineasNormales As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpLineasEspeciales As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpTotalConRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpRecFinan As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblIVA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpREMon As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpLinMon As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblBaseImpMon As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraMonedaFactura As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraClienteInicial As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblClienteIni As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraEDI As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents chkGeneradoFichero As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkEDI As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents fraEntidadAseguradora As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fraDeclaracionesIva As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblTotalImpVtos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents AdvFtaRectificada As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents cbxClaveOperacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblClaveOperacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFacturaRectificada As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbTipoOperIntra As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblTipoOperIntra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpRetencionAux As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpRetencionAux As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiDtoFactura As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents Line11 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents LbLFactPDFGenerado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LbLFactXMLGenerado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents TxtDirecCorreo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblDirecCorreo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ChkEnviar349 As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents ChkSectorServicios As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents jngBaseImponible As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlInsercionManualBaseImponible As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents jngVencimientos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlVencimientoManual As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents FraFactura As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fraCliente As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fraImportesFactura As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents pnlClienteImportes As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtTotalVtos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlEntregaCuenta As System.Windows.Forms.PictureBox
    Friend WithEvents FraContabilidad As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblEjercicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIDEjercicio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIDEjercicio As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiEstado As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlTopDatosFinancieros As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlRetencionGarantia As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents fraDocumentos As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents txtNumeroCopias As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblNumCopiasFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulAbreviaturaMoneda As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fraCentros As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents fraDireccionEnvioFactura As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents ulDirClienteFra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulFaxEnvioFra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulTelefonoEnvioFra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulProvinciaFra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulPoblacionFra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulCPClienteFra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulRazonSocialClienteFra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulCIFClienteFra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvDirecFra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents fraClaveIntracomunitaria As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fraClaveOperacion As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Panel3 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents PnlRiesgo As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTipMensajes As System.Windows.Forms.ToolTip
    Public WithEvents lblfwiBaseRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiBaseRetencion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiRetencionManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents ChkOpeTriangular As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents fraGestorCobro As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ulDescOperario As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents cbxFechaComunicacionGestorCobro As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents chkComunicadoGestorCobro As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblFechaComunicacionGestorCobro As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraSEPA As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblMandato As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advMandato As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NumericTextBox1 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NumericTextBox3 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NumericTextBox2 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FrmAdmonPublica As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ULblDescUnidadTramitadora As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvUnidadTramitadora As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblUnidadTramitadora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ULblDescOrganoGestor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvOrganoGestor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblOrganoGestor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ULblDescOficinaContable As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvOficinaContable As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblIDOficinaContable As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cboMotivoNoAsegurado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblMotivo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents chkEnviadoEmail As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents txtFechaEnvioEmail As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Panel4 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkOcultarComponentes As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblntbImpRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbRetencion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents nbxImpuestos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpuestos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulblDescClienteEnvio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents lblClienteEnvio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advClienteEnvio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents TabPageTimbrado As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Frame2 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents txtSelloFiscal As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblSelloFiscal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFolioFiscal As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFolioFiscal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaTimbrado As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaTimbrado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNotas As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNotas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCertificado As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCertificado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFolioFiscal1 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFolioFiscal1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Public WithEvents fraContabilizada As Solmicro.Expertis.Engine.UI.Frame
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngLineaFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngLineaFactura_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoFacturaVenta))
        Dim jngLineaFactura_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column11.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column19.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column20.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column21.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column27.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column31.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_7 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column36.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_8 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column39.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_9 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column41.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_10 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column46.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_11 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim jngBaseImponible_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngVencimientos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngVencimientos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim cbxTipoRetencion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiTipoAsiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiCGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbCentroCoste_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboMotivoNoAsegurado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbTipoOperIntra_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxClaveOperacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngConceptos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim FwiTipoFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TabFacturas = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageLineas = New Janus.Windows.UI.Tab.UITabPage
        Me.jngLineaFactura = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkOcultarComponentes = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.TabPageBasesIVA = New Janus.Windows.UI.Tab.UITabPage
        Me.jngBaseImponible = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlInsercionManualBaseImponible = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkIVAManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.TabPageVencimientos = New Janus.Windows.UI.Tab.UITabPage
        Me.jngVencimientos = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlVencimientoManual = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkVencimientoManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.TabPageDatosEconomicos = New Janus.Windows.UI.Tab.UITabPage
        Me.pnlRetencionGarantia = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraSEPA = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblMandato = New Solmicro.Expertis.Engine.UI.Label
        Me.advMandato = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fraGestorCobro = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbxFechaComunicacionGestorCobro = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.chkComunicadoGestorCobro = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblFechaComunicacionGestorCobro = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescOperario = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fraDocumentos = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtNumeroCopias = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblNumCopiasFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.FraRetencion = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblImpRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpRetencionGar = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFechaRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaRetencion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRetencion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTipoRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoRetencion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.pnlTopDatosFinancieros = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraContabilidad = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIDEjercicio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIDEjercicio = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiEstado = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTipoAsiento = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiTipoAsiento = New Solmicro.Expertis.Engine.UI.Label
        Me.fraCondicionesEconomicas = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiDescClteBanco = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblfwiCondPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiCondPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiCondPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdDiaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdDiaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdDiaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdClteBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiIdClteBanco = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiFormaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraMoneda = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiIdMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.FraMonedasInternas = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiCambioB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiCambioA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiDescMonedaA = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiDescMonedaB = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiCambioA = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiCambioB = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescMoneda = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdMoneda = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabPageImporteMonedas = New Janus.Windows.UI.Tab.UITabPage
        Me.fwiMonedaA = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiMonedaB = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Line2 = New Janus.Windows.EditControls.UIGroupBox
        Me.FraImporteMonedas = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.NumericTextBox3 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.NumericTextBox2 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpLineasEspecialesB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasEspecialesB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpLineasNormalesB = New Solmicro.Expertis.Engine.UI.Label
        Me.Line19 = New Janus.Windows.EditControls.UIGroupBox
        Me.fwiImpLineasNormalesB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Line3 = New Janus.Windows.EditControls.UIGroupBox
        Me.Line18 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblImpLineasEspecialesA = New Solmicro.Expertis.Engine.UI.Label
        Me.Line15 = New Janus.Windows.EditControls.UIGroupBox
        Me.fwiImpLineasEspecialesA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpLineasNormalesA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasNormalesA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpLineasB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpLineasA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpIVAA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpIVAA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpIVAB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpIVAB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpTotalA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpTotalA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpTotalB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpTotalB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpRetencionB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRetencionB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpReB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpReB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblBaseImpA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBaseImpA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblBaseImpB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBaseImpB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblRetencionA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRetencionA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpReA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpReA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpRecFinanA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRecFinanA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpRecFinanB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRecFinanB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageTotales = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.NumericTextBox1 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraPuntoVerde = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblImpPuntoVerde = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpPuntoVerde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraRetenciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiBaseRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBaseRetencion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiRetencionManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblPorc3 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpRetencion2 = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRetencion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcIRPF = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiPorcIRPF = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraMonedaFactura = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiDescMoneda = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraCalculoFactura = New Solmicro.Expertis.Engine.UI.Frame
        Me.Line11 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblImpRetencionAux = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRetencionAux = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorc4 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPorc = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPorc2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Line10 = New Janus.Windows.EditControls.UIGroupBox
        Me.Line12 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblImpLineasNormales = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasNormales = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpLineasEspeciales = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasEspeciales = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpTotalConRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpTotalConRetencion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiDtoFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDtoFactura = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpRecFinan = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRecFinan = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiRecFinan = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRecFinan = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiIVA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpREMon = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpREMon = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpLinMon = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLinMon = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblBaseImpMon = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBaseImpMon = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiDtoProntoPago = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDtoProntoPago = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageSeguimiento = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.FrmAdmonPublica = New Solmicro.Expertis.Engine.UI.Frame
        Me.ULblDescUnidadTramitadora = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvUnidadTramitadora = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblUnidadTramitadora = New Solmicro.Expertis.Engine.UI.Label
        Me.ULblDescOrganoGestor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvOrganoGestor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblOrganoGestor = New Solmicro.Expertis.Engine.UI.Label
        Me.ULblDescOficinaContable = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvOficinaContable = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblIDOficinaContable = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtDirecCorreo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblDirecCorreo = New Solmicro.Expertis.Engine.UI.Label
        Me.fraDireccionEnvioFactura = New Solmicro.Expertis.Engine.UI.Frame
        Me.AdvDirecFra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDirClienteFra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulFaxEnvioFra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulTelefonoEnvioFra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulProvinciaFra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulPoblacionFra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulCPClienteFra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulRazonSocialClienteFra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulCIFClienteFra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.fraCentros = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiCGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblCGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.LblCentroCoste = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbCentroCoste = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraEDI = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkGeneradoFichero = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraClienteInicial = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblClienteIni = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiClienteIni = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiClienteIni = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LbLFactXMLGenerado = New Solmicro.Expertis.Engine.UI.Label
        Me.LbLFactPDFGenerado = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPageDeclaraciones = New Janus.Windows.UI.Tab.UITabPage
        Me.fraEntidadAseguradora = New Solmicro.Expertis.Engine.UI.Frame
        Me.cboMotivoNoAsegurado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblMotivo = New Solmicro.Expertis.Engine.UI.Label
        Me.chbEnviadaEntidadAseguradora = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chbEnviadaEntidadAseguradora1 = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblDescAseguradora = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescAseguradora = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fraClaveIntracomunitaria = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmbTipoOperIntra = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblTipoOperIntra = New Solmicro.Expertis.Engine.UI.Label
        Me.fraClaveOperacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbxClaveOperacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFacturaRectificada = New Solmicro.Expertis.Engine.UI.Label
        Me.lblClaveOperacion = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFtaRectificada = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fraDeclaracionesIva = New Solmicro.Expertis.Engine.UI.Frame
        Me.ChkOpeTriangular = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkSectorServicios = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkEnviar349 = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkEnviar347 = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkFechaDeclManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblFechaParaDeclaracion = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaParaDeclaracion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblNumDeclaracion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiNDeclaracion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblAñoDeclaracion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiAñoDeclaracion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TabPageConceptos = New Janus.Windows.UI.Tab.UITabPage
        Me.jngConceptos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicAnotaciones = New Janus.Windows.UI.Tab.UITabPage
        Me.fwiTextoFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TabPageTimbrado = New Janus.Windows.UI.Tab.UITabPage
        Me.Frame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtCertificado = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCertificado = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaTimbrado = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaTimbrado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNotas = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNotas = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFolioFiscal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFolioFiscal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSelloFiscal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSelloFiscal = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiTipoFactura = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chkEDI = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiIdDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.PicCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlClienteImportes = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulblDescClienteEnvio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblClienteEnvio = New Solmicro.Expertis.Engine.UI.Label
        Me.advClienteEnvio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fraImportesFactura = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblntbImpRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbRetencion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.nbxImpuestos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpuestos = New Solmicro.Expertis.Engine.UI.Label
        Me.ulAbreviaturaMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalVtos = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTotalBaseImp = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotalImpVtos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotalIva = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTotalBaseImp = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiTotalIva = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fraCliente = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkEnviadoEmail = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.txtFechaEnvioEmail = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ulDescCliente = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblDireccion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTelefono = New Solmicro.Expertis.Engine.UI.Label
        Me.lblRazonSocial = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiIdPais = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPais = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiPoblacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fwiCodPostal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCIF = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCIF = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiDir = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiRazonSocial = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiFax = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiTel = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFax = New Solmicro.Expertis.Engine.UI.Label
        Me.fraContabilizada = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtFolioFiscal1 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFolioFiscal1 = New Solmicro.Expertis.Engine.UI.Label
        Me.PnlRiesgo = New System.Windows.Forms.PictureBox
        Me.pnlEntregaCuenta = New System.Windows.Forms.PictureBox
        Me.LblSelloContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblNObra = New Solmicro.Expertis.Engine.UI.Label
        Me.FraFactura = New Solmicro.Expertis.Engine.UI.Frame
        Me.FwiIDContador = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFecVencimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFecFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lblNFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFecFactura = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiNFactura = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.lbIDContador = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFecVencimiento = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTipMensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.TabFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFacturas.SuspendLayout()
        Me.TabPageLineas.SuspendLayout()
        CType(Me.jngLineaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.suspendlayout()
        Me.TabPageBasesIVA.SuspendLayout()
        CType(Me.jngBaseImponible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInsercionManualBaseImponible.suspendlayout()
        Me.TabPageVencimientos.SuspendLayout()
        CType(Me.jngVencimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVencimientoManual.suspendlayout()
        Me.TabPageDatosEconomicos.SuspendLayout()
        Me.pnlRetencionGarantia.suspendlayout()
        Me.FraSEPA.SuspendLayout()
        Me.fraGestorCobro.SuspendLayout()
        Me.fraDocumentos.SuspendLayout()
        Me.FraRetencion.SuspendLayout()
        CType(Me.cbxTipoRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopDatosFinancieros.suspendlayout()
        Me.FraContabilidad.SuspendLayout()
        CType(Me.fwiTipoAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraCondicionesEconomicas.SuspendLayout()
        Me.FraMoneda.SuspendLayout()
        Me.FraMonedasInternas.SuspendLayout()
        Me.TabPageImporteMonedas.SuspendLayout()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraImporteMonedas.SuspendLayout()
        CType(Me.Line19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageTotales.SuspendLayout()
        Me.Panel3.suspendlayout()
        Me.Frame1.SuspendLayout()
        Me.FraPuntoVerde.SuspendLayout()
        Me.FraRetenciones.SuspendLayout()
        Me.FraMonedaFactura.SuspendLayout()
        Me.FraCalculoFactura.SuspendLayout()
        CType(Me.Line11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSeguimiento.SuspendLayout()
        Me.Panel2.suspendlayout()
        Me.FrmAdmonPublica.SuspendLayout()
        Me.fraDireccionEnvioFactura.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.fraCentros.SuspendLayout()
        CType(Me.fwiCGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbCentroCoste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraEDI.SuspendLayout()
        Me.FraClienteInicial.SuspendLayout()
        Me.TabPageDeclaraciones.SuspendLayout()
        Me.fraEntidadAseguradora.SuspendLayout()
        CType(Me.cboMotivoNoAsegurado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraClaveIntracomunitaria.SuspendLayout()
        CType(Me.CmbTipoOperIntra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraClaveOperacion.SuspendLayout()
        CType(Me.cbxClaveOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDeclaracionesIva.SuspendLayout()
        Me.TabPageConceptos.SuspendLayout()
        CType(Me.jngConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicAnotaciones.SuspendLayout()
        Me.TabPageTimbrado.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.FwiTipoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PicCabecera.suspendlayout()
        Me.pnlClienteImportes.suspendlayout()
        Me.fraImportesFactura.SuspendLayout()
        Me.fraCliente.SuspendLayout()
        Me.fraContabilizada.SuspendLayout()
        CType(Me.PnlRiesgo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlEntregaCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraFactura.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'GoFirst
        '
        Me.GoFirst.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoPrevious
        '
        Me.GoPrevious.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoNext
        '
        Me.GoNext.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Delete
        '
        Me.Delete.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Ok
        '
        Me.Ok.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Cancel
        '
        Me.Cancel.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Print
        '
        Me.Print.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Search
        '
        Me.Search.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoLast
        '
        Me.GoLast.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'FindText
        '
        Me.FindText.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Find
        '
        Me.Find.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'NewRow
        '
        Me.NewRow.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Requery
        '
        Me.Requery.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabFacturas)
        Me.MainPanel.Controls.Add(Me.PicCabecera)
        Me.MainPanel.Size = New System.Drawing.Size(957, 541)
        '
        'TabFacturas
        '
        Me.TabFacturas.BackColor = System.Drawing.Color.White
        Me.TabFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFacturas.ItemSize = New System.Drawing.Size(125, 0)
        Me.TabFacturas.Location = New System.Drawing.Point(0, 218)
        Me.TabFacturas.Name = "TabFacturas"
        Me.TabFacturas.Size = New System.Drawing.Size(957, 323)
        Me.TabFacturas.TabIndex = 14
        Me.TabFacturas.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageLineas, Me.TabPageBasesIVA, Me.TabPageVencimientos, Me.TabPageDatosEconomicos, Me.TabPageImporteMonedas, Me.TabPageTotales, Me.TabPageSeguimiento, Me.TabPageDeclaraciones, Me.TabPageConceptos, Me.TabPagePicAnotaciones, Me.TabPageTimbrado})
        Me.TabFacturas.Text = "Agrupación de Conceptos"
        Me.TabFacturas.UseThemes = True
        '
        'TabPageLineas
        '
        Me.TabPageLineas.Controls.Add(Me.jngLineaFactura)
        Me.TabPageLineas.Controls.Add(Me.Panel4)
        Me.TabPageLineas.Key = "Lineas"
        Me.TabPageLineas.Location = New System.Drawing.Point(1, 21)
        Me.TabPageLineas.Name = "TabPageLineas"
        Me.TabPageLineas.Size = New System.Drawing.Size(955, 301)
        Me.TabPageLineas.TabStop = True
        Me.TabPageLineas.Text = "Líneas"
        '
        'jngLineaFactura
        '
        Me.jngLineaFactura.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", "advArticulo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUDMedida", "UdMedida", "IDUdMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUDInterna", "UdMedida", "IDUDMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObra", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("RefCliente", "ArticuloCliente", "RefCliente", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CContable", "PlanContable", "IDCContable", "tbPlanContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoLinea", "TipoLinea", "IDTipoLinea"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDconcepto", "Concepto", "IDconcepto", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescConcepto", "DescConcepto")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoIVA", "TipoIVA", "IDTipoIVA"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentroGestion", "CentroGestion", "IDCentroGestion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDInmueble", "InmueblesCabecera", "IDInmueble", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescInmueble", "DescInmueble")}))})
        jngLineaFactura_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_0.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_1.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_2.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_3.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_4.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_5.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_6.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_7.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_7.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_8.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_8.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_9.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_9.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_10.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_10.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_11.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_11.Instance"), Object)
        jngLineaFactura_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngLineaFactura_DesignTimeLayout_Reference_0, jngLineaFactura_DesignTimeLayout_Reference_1, jngLineaFactura_DesignTimeLayout_Reference_2, jngLineaFactura_DesignTimeLayout_Reference_3, jngLineaFactura_DesignTimeLayout_Reference_4, jngLineaFactura_DesignTimeLayout_Reference_5, jngLineaFactura_DesignTimeLayout_Reference_6, jngLineaFactura_DesignTimeLayout_Reference_7, jngLineaFactura_DesignTimeLayout_Reference_8, jngLineaFactura_DesignTimeLayout_Reference_9, jngLineaFactura_DesignTimeLayout_Reference_10, jngLineaFactura_DesignTimeLayout_Reference_11})
        jngLineaFactura_DesignTimeLayout.LayoutString = resources.GetString("jngLineaFactura_DesignTimeLayout.LayoutString")
        Me.jngLineaFactura.DesignTimeLayout = jngLineaFactura_DesignTimeLayout
        Me.jngLineaFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngLineaFactura.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngLineaFactura.EntityName = "FacturaVentaLinea"
        Me.jngLineaFactura.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngLineaFactura.FrozenColumns = 8
        Me.jngLineaFactura.ImageList = Me.ImageList1
        Me.jngLineaFactura.KeyField = "IDLineaFactura"
        Me.jngLineaFactura.Location = New System.Drawing.Point(0, 0)
        Me.jngLineaFactura.Name = "jngLineaFactura"
        Me.jngLineaFactura.PrimaryDataFields = "IDFactura"
        Me.jngLineaFactura.SecondaryDataFields = "IDFactura"
        Me.jngLineaFactura.Size = New System.Drawing.Size(955, 268)
        Me.jngLineaFactura.TabIndex = 15
        Me.jngLineaFactura.ViewName = "VFrmMntoFacturaVentaLineas"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "note_edit.ico")
        Me.ImageList1.Images.SetKeyName(1, "folders.ico")
        Me.ImageList1.Images.SetKeyName(2, "users4.ico")
        Me.ImageList1.Images.SetKeyName(3, "money2.ico")
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.chkOcultarComponentes)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 268)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(955, 33)
        Me.Panel4.TabIndex = 16
        '
        'chkOcultarComponentes
        '
        Me.chkOcultarComponentes.Checked = True
        Me.chkOcultarComponentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOcultarComponentes.Location = New System.Drawing.Point(12, 6)
        Me.chkOcultarComponentes.Name = "chkOcultarComponentes"
        Me.chkOcultarComponentes.Size = New System.Drawing.Size(169, 21)
        Me.chkOcultarComponentes.TabIndex = 82
        Me.chkOcultarComponentes.Text = "Ocultar Componentes"
        '
        'TabPageBasesIVA
        '
        Me.TabPageBasesIVA.Controls.Add(Me.jngBaseImponible)
        Me.TabPageBasesIVA.Controls.Add(Me.pnlInsercionManualBaseImponible)
        Me.TabPageBasesIVA.Key = "BaseImponible"
        Me.TabPageBasesIVA.Location = New System.Drawing.Point(1, 21)
        Me.TabPageBasesIVA.Name = "TabPageBasesIVA"
        Me.TabPageBasesIVA.Size = New System.Drawing.Size(878, 325)
        Me.TabPageBasesIVA.TabStop = True
        Me.TabPageBasesIVA.Text = "Base Imponible"
        '
        'jngBaseImponible
        '
        Me.jngBaseImponible.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngBaseImponible.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngBaseImponible_DesignTimeLayout.LayoutString = resources.GetString("jngBaseImponible_DesignTimeLayout.LayoutString")
        Me.jngBaseImponible.DesignTimeLayout = jngBaseImponible_DesignTimeLayout
        Me.jngBaseImponible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngBaseImponible.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngBaseImponible.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngBaseImponible.EntityName = "FacturaVentaBaseImponible"
        Me.jngBaseImponible.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngBaseImponible.Location = New System.Drawing.Point(0, 0)
        Me.jngBaseImponible.Name = "jngBaseImponible"
        Me.jngBaseImponible.PrimaryDataFields = "IDFactura"
        Me.jngBaseImponible.SecondaryDataFields = "IDFactura"
        Me.jngBaseImponible.Size = New System.Drawing.Size(878, 298)
        Me.jngBaseImponible.TabIndex = 18
        Me.jngBaseImponible.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngBaseImponible.ViewName = "VFrmMntoFacturaVentaBasesImponibles"
        '
        'pnlInsercionManualBaseImponible
        '
        Me.pnlInsercionManualBaseImponible.Controls.Add(Me.chkIVAManual)
        Me.pnlInsercionManualBaseImponible.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInsercionManualBaseImponible.Location = New System.Drawing.Point(0, 298)
        Me.pnlInsercionManualBaseImponible.Name = "pnlInsercionManualBaseImponible"
        Me.pnlInsercionManualBaseImponible.Size = New System.Drawing.Size(878, 27)
        Me.pnlInsercionManualBaseImponible.TabIndex = 17
        '
        'chkIVAManual
        '
        Me.chkIVAManual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(chkIVAManual, New System.Windows.Forms.Binding("BindableValue", Me, "IvaManual", True))
        Me.chkIVAManual.Location = New System.Drawing.Point(5, 4)
        Me.chkIVAManual.Name = "chkIVAManual"
        Me.chkIVAManual.Size = New System.Drawing.Size(368, 19)
        Me.chkIVAManual.TabIndex = 16
        Me.chkIVAManual.Text = "Inserción manual de importes"
        '
        'TabPageVencimientos
        '
        Me.TabPageVencimientos.Controls.Add(Me.jngVencimientos)
        Me.TabPageVencimientos.Controls.Add(Me.pnlVencimientoManual)
        Me.TabPageVencimientos.Key = "Vencimientos"
        Me.TabPageVencimientos.Location = New System.Drawing.Point(1, 21)
        Me.TabPageVencimientos.Name = "TabPageVencimientos"
        Me.TabPageVencimientos.Size = New System.Drawing.Size(878, 301)
        Me.TabPageVencimientos.TabStop = True
        Me.TabPageVencimientos.Text = "Vencimientos"
        '
        'jngVencimientos
        '
        Me.jngVencimientos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago")})
        Me.jngVencimientos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngVencimientos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngVencimientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngVencimientos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngVencimientos_DesignTimeLayout_Reference_0.Instance"), Object)
        jngVencimientos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngVencimientos_DesignTimeLayout_Reference_0})
        jngVencimientos_DesignTimeLayout.LayoutString = resources.GetString("jngVencimientos_DesignTimeLayout.LayoutString")
        Me.jngVencimientos.DesignTimeLayout = jngVencimientos_DesignTimeLayout
        Me.jngVencimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngVencimientos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngVencimientos.EntityName = "Cobro"
        Me.jngVencimientos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngVencimientos.Location = New System.Drawing.Point(0, 0)
        Me.jngVencimientos.Name = "jngVencimientos"
        Me.jngVencimientos.PrimaryDataFields = "IDFactura"
        Me.jngVencimientos.SecondaryDataFields = "IDFactura"
        Me.jngVencimientos.Size = New System.Drawing.Size(878, 274)
        Me.jngVencimientos.TabIndex = 19
        Me.jngVencimientos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngVencimientos.ViewName = "VFrmMntoFacturaVentaCobros"
        '
        'pnlVencimientoManual
        '
        Me.pnlVencimientoManual.Controls.Add(Me.chkVencimientoManual)
        Me.pnlVencimientoManual.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlVencimientoManual.Location = New System.Drawing.Point(0, 274)
        Me.pnlVencimientoManual.Name = "pnlVencimientoManual"
        Me.pnlVencimientoManual.Size = New System.Drawing.Size(878, 27)
        Me.pnlVencimientoManual.TabIndex = 18
        '
        'chkVencimientoManual
        '
        Me.chkVencimientoManual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(chkVencimientoManual, New System.Windows.Forms.Binding("BindableValue", Me, "VencimientosManuales", True))
        Me.chkVencimientoManual.Location = New System.Drawing.Point(5, 4)
        Me.chkVencimientoManual.Name = "chkVencimientoManual"
        Me.chkVencimientoManual.Size = New System.Drawing.Size(158, 19)
        Me.chkVencimientoManual.TabIndex = 17
        Me.chkVencimientoManual.Text = "Vencimiento Manual"
        '
        'TabPageDatosEconomicos
        '
        Me.TabPageDatosEconomicos.Controls.Add(Me.pnlRetencionGarantia)
        Me.TabPageDatosEconomicos.Controls.Add(Me.pnlTopDatosFinancieros)
        Me.TabPageDatosEconomicos.Key = "DatosEconomicos"
        Me.TabPageDatosEconomicos.Location = New System.Drawing.Point(1, 21)
        Me.TabPageDatosEconomicos.Name = "TabPageDatosEconomicos"
        Me.TabPageDatosEconomicos.Size = New System.Drawing.Size(878, 301)
        Me.TabPageDatosEconomicos.TabStop = True
        Me.TabPageDatosEconomicos.Text = "Datos Económicos"
        '
        'pnlRetencionGarantia
        '
        Me.pnlRetencionGarantia.Controls.Add(Me.FraSEPA)
        Me.pnlRetencionGarantia.Controls.Add(Me.fraGestorCobro)
        Me.pnlRetencionGarantia.Controls.Add(Me.fraDocumentos)
        Me.pnlRetencionGarantia.Controls.Add(Me.FraRetencion)
        Me.pnlRetencionGarantia.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRetencionGarantia.Location = New System.Drawing.Point(0, 165)
        Me.pnlRetencionGarantia.Name = "pnlRetencionGarantia"
        Me.pnlRetencionGarantia.Size = New System.Drawing.Size(878, 157)
        Me.pnlRetencionGarantia.TabIndex = 192
        '
        'FraSEPA
        '
        Me.FraSEPA.Controls.Add(Me.lblMandato)
        Me.FraSEPA.Controls.Add(Me.advMandato)
        Me.FraSEPA.Location = New System.Drawing.Point(2, 81)
        Me.FraSEPA.Name = "FraSEPA"
        Me.FraSEPA.Size = New System.Drawing.Size(312, 50)
        Me.FraSEPA.TabIndex = 4
        Me.FraSEPA.TabStop = False
        Me.FraSEPA.Text = "SEPA"
        '
        'lblMandato
        '
        Me.lblMandato.Location = New System.Drawing.Point(7, 25)
        Me.lblMandato.Name = "lblMandato"
        Me.lblMandato.Size = New System.Drawing.Size(55, 13)
        Me.lblMandato.TabIndex = 71
        Me.lblMandato.Tag = ""
        Me.lblMandato.Text = "Mandato"
        '
        'advMandato
        '
        Me.TryDataBinding(advMandato, New System.Windows.Forms.Binding("Value", Me, "IDMandato", True))
        Me.TryDataBinding(advMandato, New System.Windows.Forms.Binding("Text", Me, "NMandato", True))
        Me.advMandato.DisabledBackColor = System.Drawing.Color.White
        Me.advMandato.DisplayField = "NMandato"
        Me.advMandato.EntityName = "Mandato"
        Me.advMandato.Location = New System.Drawing.Point(65, 20)
        Me.advMandato.Name = "advMandato"
        Me.advMandato.PrimaryDataFields = "IDMandato"
        Me.advMandato.SecondaryDataFields = "IDMandato"
        Me.advMandato.Size = New System.Drawing.Size(140, 23)
        Me.advMandato.TabIndex = 70
        Me.advMandato.ViewName = "tbMaestroMandato"
        '
        'fraGestorCobro
        '
        Me.fraGestorCobro.Controls.Add(Me.cbxFechaComunicacionGestorCobro)
        Me.fraGestorCobro.Controls.Add(Me.chkComunicadoGestorCobro)
        Me.fraGestorCobro.Controls.Add(Me.lblFechaComunicacionGestorCobro)
        Me.fraGestorCobro.Controls.Add(Me.ulDescOperario)
        Me.fraGestorCobro.Controls.Add(Me.lblOperario)
        Me.fraGestorCobro.Controls.Add(Me.advIDOperario)
        Me.fraGestorCobro.Controls.Add(Me.ulDescProveedor)
        Me.fraGestorCobro.Controls.Add(Me.lblProveedor)
        Me.fraGestorCobro.Controls.Add(Me.advIDProveedor)
        Me.fraGestorCobro.Location = New System.Drawing.Point(318, 0)
        Me.fraGestorCobro.Name = "fraGestorCobro"
        Me.fraGestorCobro.Size = New System.Drawing.Size(289, 128)
        Me.fraGestorCobro.TabIndex = 2
        Me.fraGestorCobro.TabStop = False
        Me.fraGestorCobro.Text = "Gestor Cobro"
        '
        'cbxFechaComunicacionGestorCobro
        '
        Me.TryDataBinding(cbxFechaComunicacionGestorCobro, New System.Windows.Forms.Binding("BindableValue", Me, "FechaComunicacionGestorCobro", True))
        Me.cbxFechaComunicacionGestorCobro.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaComunicacionGestorCobro.Enabled = False
        Me.cbxFechaComunicacionGestorCobro.Location = New System.Drawing.Point(131, 98)
        Me.cbxFechaComunicacionGestorCobro.Name = "cbxFechaComunicacionGestorCobro"
        Me.cbxFechaComunicacionGestorCobro.Size = New System.Drawing.Size(102, 21)
        Me.cbxFechaComunicacionGestorCobro.TabIndex = 193
        '
        'chkComunicadoGestorCobro
        '
        Me.TryDataBinding(chkComunicadoGestorCobro, New System.Windows.Forms.Binding("BindableValue", Me, "ComunicadoGestorCobro", True))
        Me.chkComunicadoGestorCobro.Enabled = False
        Me.chkComunicadoGestorCobro.Location = New System.Drawing.Point(6, 75)
        Me.chkComunicadoGestorCobro.Name = "chkComunicadoGestorCobro"
        Me.chkComunicadoGestorCobro.Size = New System.Drawing.Size(175, 19)
        Me.chkComunicadoGestorCobro.TabIndex = 18
        Me.chkComunicadoGestorCobro.Text = "Comunicado Gestor"
        '
        'lblFechaComunicacionGestorCobro
        '
        Me.lblFechaComunicacionGestorCobro.Location = New System.Drawing.Point(3, 102)
        Me.lblFechaComunicacionGestorCobro.Name = "lblFechaComunicacionGestorCobro"
        Me.lblFechaComunicacionGestorCobro.Size = New System.Drawing.Size(124, 13)
        Me.lblFechaComunicacionGestorCobro.TabIndex = 7
        Me.lblFechaComunicacionGestorCobro.Text = "Fecha Comunicación"
        '
        'ulDescOperario
        '
        Me.TryDataBinding(ulDescOperario, New System.Windows.Forms.Binding("Text", Me.advIDOperario, "DescOperario", True))
        Me.ulDescOperario.Location = New System.Drawing.Point(175, 48)
        Me.ulDescOperario.Name = "ulDescOperario"
        Me.ulDescOperario.Size = New System.Drawing.Size(108, 23)
        Me.ulDescOperario.TabIndex = 5
        Me.ulDescOperario.UseMnemonic = False
        '
        'lblOperario
        '
        Me.lblOperario.Location = New System.Drawing.Point(3, 52)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(91, 13)
        Me.lblOperario.TabIndex = 4
        Me.lblOperario.Text = "Gestor Interno"
        '
        'advIDOperario
        '
        Me.TryDataBinding(advIDOperario, New System.Windows.Forms.Binding("Text", Me, "IDOperario", True))
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(77, 48)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.PrimaryDataFields = "IDOperario"
        Me.advIDOperario.SecondaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(95, 23)
        Me.advIDOperario.TabIndex = 3
        '
        'ulDescProveedor
        '
        Me.TryDataBinding(ulDescProveedor, New System.Windows.Forms.Binding("Text", Me.advIDProveedor, "DescProveedor", True))
        Me.ulDescProveedor.Location = New System.Drawing.Point(175, 22)
        Me.ulDescProveedor.Name = "ulDescProveedor"
        Me.ulDescProveedor.Size = New System.Drawing.Size(108, 23)
        Me.ulDescProveedor.TabIndex = 2
        Me.ulDescProveedor.UseMnemonic = False
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(3, 26)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(93, 13)
        Me.lblProveedor.TabIndex = 1
        Me.lblProveedor.Text = "Gestor Externo"
        '
        'advIDProveedor
        '
        Me.TryDataBinding(advIDProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor", True))
        Me.advIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIDProveedor.EntityName = "Proveedor"
        Me.advIDProveedor.Location = New System.Drawing.Point(77, 22)
        Me.advIDProveedor.Name = "advIDProveedor"
        Me.advIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.advIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIDProveedor.Size = New System.Drawing.Size(95, 23)
        Me.advIDProveedor.TabIndex = 0
        '
        'fraDocumentos
        '
        Me.fraDocumentos.Controls.Add(Me.txtNumeroCopias)
        Me.fraDocumentos.Controls.Add(Me.lblNumCopiasFactura)
        Me.fraDocumentos.Location = New System.Drawing.Point(611, 0)
        Me.fraDocumentos.Name = "fraDocumentos"
        Me.fraDocumentos.Size = New System.Drawing.Size(264, 77)
        Me.fraDocumentos.TabIndex = 3
        Me.fraDocumentos.TabStop = False
        Me.fraDocumentos.Text = "Documentos"
        '
        'txtNumeroCopias
        '
        Me.TryDataBinding(txtNumeroCopias, New System.Windows.Forms.Binding("Value", Me.AdvIDCliente, "NumeroCopias", True))
        Me.txtNumeroCopias.DecimalDigits = 0
        Me.txtNumeroCopias.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumeroCopias.Enabled = False
        Me.txtNumeroCopias.Location = New System.Drawing.Point(129, 27)
        Me.txtNumeroCopias.Name = "txtNumeroCopias"
        Me.txtNumeroCopias.Size = New System.Drawing.Size(70, 21)
        Me.txtNumeroCopias.TabIndex = 138
        Me.txtNumeroCopias.TabStop = False
        '
        'lblNumCopiasFactura
        '
        Me.lblNumCopiasFactura.Location = New System.Drawing.Point(9, 30)
        Me.lblNumCopiasFactura.Name = "lblNumCopiasFactura"
        Me.lblNumCopiasFactura.Size = New System.Drawing.Size(113, 13)
        Me.lblNumCopiasFactura.TabIndex = 137
        Me.lblNumCopiasFactura.Tag = ""
        Me.lblNumCopiasFactura.Text = "Nº. Copias Factura"
        '
        'FraRetencion
        '
        Me.FraRetencion.Controls.Add(Me.lblImpRetencion)
        Me.FraRetencion.Controls.Add(Me.txtImpRetencionGar)
        Me.FraRetencion.Controls.Add(Me.lblFechaRetencion)
        Me.FraRetencion.Controls.Add(Me.cbxFechaRetencion)
        Me.FraRetencion.Controls.Add(Me.lblRetencion)
        Me.FraRetencion.Controls.Add(Me.txtRetencion)
        Me.FraRetencion.Controls.Add(Me.lblTipoRetencion)
        Me.FraRetencion.Controls.Add(Me.cbxTipoRetencion)
        Me.FraRetencion.Location = New System.Drawing.Point(0, 0)
        Me.FraRetencion.Name = "FraRetencion"
        Me.FraRetencion.Size = New System.Drawing.Size(314, 77)
        Me.FraRetencion.TabIndex = 1
        Me.FraRetencion.TabStop = False
        Me.FraRetencion.Text = "Retención por garantía"
        '
        'lblImpRetencion
        '
        Me.lblImpRetencion.Location = New System.Drawing.Point(155, 50)
        Me.lblImpRetencion.Name = "lblImpRetencion"
        Me.lblImpRetencion.Size = New System.Drawing.Size(53, 13)
        Me.lblImpRetencion.TabIndex = 195
        Me.lblImpRetencion.Tag = ""
        Me.lblImpRetencion.Text = "Importe"
        '
        'txtImpRetencionGar
        '
        Me.TryDataBinding(txtImpRetencionGar, New System.Windows.Forms.Binding("Value", Me, "ImpRetencionGar", True))
        Me.txtImpRetencionGar.DecimalDigits = 5
        Me.txtImpRetencionGar.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRetencionGar.Enabled = False
        Me.txtImpRetencionGar.FormatString = "#,0.0####"
        Me.txtImpRetencionGar.Location = New System.Drawing.Point(212, 46)
        Me.txtImpRetencionGar.Name = "txtImpRetencionGar"
        Me.txtImpRetencionGar.Size = New System.Drawing.Size(93, 21)
        Me.txtImpRetencionGar.TabIndex = 193
        '
        'lblFechaRetencion
        '
        Me.lblFechaRetencion.Location = New System.Drawing.Point(9, 50)
        Me.lblFechaRetencion.Name = "lblFechaRetencion"
        Me.lblFechaRetencion.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaRetencion.TabIndex = 193
        Me.lblFechaRetencion.Tag = ""
        Me.lblFechaRetencion.Text = "Fecha"
        '
        'cbxFechaRetencion
        '
        Me.TryDataBinding(cbxFechaRetencion, New System.Windows.Forms.Binding("BindableValue", Me, "FechaRetencion", True))
        Me.cbxFechaRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaRetencion.Location = New System.Drawing.Point(51, 46)
        Me.cbxFechaRetencion.Name = "cbxFechaRetencion"
        Me.cbxFechaRetencion.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaRetencion.TabIndex = 192
        '
        'lblRetencion
        '
        Me.lblRetencion.AutoSize = False
        Me.lblRetencion.Location = New System.Drawing.Point(237, 24)
        Me.lblRetencion.Name = "lblRetencion"
        Me.lblRetencion.Size = New System.Drawing.Size(15, 17)
        Me.lblRetencion.TabIndex = 90
        Me.lblRetencion.Tag = ""
        Me.lblRetencion.Text = "%"
        '
        'txtRetencion
        '
        Me.TryDataBinding(txtRetencion, New System.Windows.Forms.Binding("Value", Me, "Retencion", True))
        Me.txtRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.txtRetencion.Location = New System.Drawing.Point(257, 21)
        Me.txtRetencion.Name = "txtRetencion"
        Me.txtRetencion.Size = New System.Drawing.Size(48, 21)
        Me.txtRetencion.TabIndex = 191
        '
        'lblTipoRetencion
        '
        Me.lblTipoRetencion.Location = New System.Drawing.Point(9, 25)
        Me.lblTipoRetencion.Name = "lblTipoRetencion"
        Me.lblTipoRetencion.Size = New System.Drawing.Size(35, 13)
        Me.lblTipoRetencion.TabIndex = 89
        Me.lblTipoRetencion.Tag = ""
        Me.lblTipoRetencion.Text = "Tipo "
        '
        'cbxTipoRetencion
        '
        Me.TryDataBinding(cbxTipoRetencion, New System.Windows.Forms.Binding("Value", Me, "TipoRetencion", True))
        cbxTipoRetencion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoRetencion_DesignTimeLayout.LayoutString")
        Me.cbxTipoRetencion.DesignTimeLayout = cbxTipoRetencion_DesignTimeLayout
        Me.cbxTipoRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoRetencion.DisplayMember = "Value"
        Me.cbxTipoRetencion.Location = New System.Drawing.Point(51, 21)
        Me.cbxTipoRetencion.Name = "cbxTipoRetencion"
        Me.cbxTipoRetencion.PrimaryDataFields = "Estado"
        Me.cbxTipoRetencion.SecondaryDataFields = "Value"
        Me.cbxTipoRetencion.SelectedIndex = -1
        Me.cbxTipoRetencion.SelectedItem = Nothing
        Me.cbxTipoRetencion.Size = New System.Drawing.Size(183, 21)
        Me.cbxTipoRetencion.TabIndex = 190
        '
        'pnlTopDatosFinancieros
        '
        Me.pnlTopDatosFinancieros.Controls.Add(Me.FraContabilidad)
        Me.pnlTopDatosFinancieros.Controls.Add(Me.fraCondicionesEconomicas)
        Me.pnlTopDatosFinancieros.Controls.Add(Me.FraMoneda)
        Me.pnlTopDatosFinancieros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopDatosFinancieros.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopDatosFinancieros.Name = "pnlTopDatosFinancieros"
        Me.pnlTopDatosFinancieros.Size = New System.Drawing.Size(878, 165)
        Me.pnlTopDatosFinancieros.TabIndex = 0
        '
        'FraContabilidad
        '
        Me.FraContabilidad.Controls.Add(Me.lblEjercicio)
        Me.FraContabilidad.Controls.Add(Me.lblcfwiIDEjercicio)
        Me.FraContabilidad.Controls.Add(Me.fwiIDEjercicio)
        Me.FraContabilidad.Controls.Add(Me.fwiEstado)
        Me.FraContabilidad.Controls.Add(Me.lblEstado)
        Me.FraContabilidad.Controls.Add(Me.fwiTipoAsiento)
        Me.FraContabilidad.Controls.Add(Me.lblfwiTipoAsiento)
        Me.FraContabilidad.Location = New System.Drawing.Point(318, 0)
        Me.FraContabilidad.Name = "FraContabilidad"
        Me.FraContabilidad.Size = New System.Drawing.Size(289, 161)
        Me.FraContabilidad.TabIndex = 1
        Me.FraContabilidad.TabStop = False
        Me.FraContabilidad.Text = "Contabilidad"
        '
        'lblEjercicio
        '
        Me.lblEjercicio.Location = New System.Drawing.Point(3, 55)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(55, 13)
        Me.lblEjercicio.TabIndex = 138
        Me.lblEjercicio.Tag = "IdRec=4467;"
        Me.lblEjercicio.Text = "Ejercicio"
        '
        'lblcfwiIDEjercicio
        '
        Me.TryDataBinding(lblcfwiIDEjercicio, New System.Windows.Forms.Binding("Text", Me, "DescEjercicio", True))
        Me.lblcfwiIDEjercicio.Location = New System.Drawing.Point(159, 51)
        Me.lblcfwiIDEjercicio.Name = "lblcfwiIDEjercicio"
        Me.lblcfwiIDEjercicio.Size = New System.Drawing.Size(124, 21)
        Me.lblcfwiIDEjercicio.TabIndex = 137
        Me.lblcfwiIDEjercicio.UseMnemonic = False
        '
        'fwiIDEjercicio
        '
        Me.TryDataBinding(fwiIDEjercicio, New System.Windows.Forms.Binding("Text", Me, "IDEjercicio", True))
        Me.fwiIDEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIDEjercicio.Enabled = False
        Me.fwiIDEjercicio.Location = New System.Drawing.Point(77, 51)
        Me.fwiIDEjercicio.Name = "fwiIDEjercicio"
        Me.fwiIDEjercicio.Size = New System.Drawing.Size(79, 21)
        Me.fwiIDEjercicio.TabIndex = 136
        Me.fwiIDEjercicio.TabStop = False
        '
        'fwiEstado
        '
        Me.fwiEstado.DisabledBackColor = System.Drawing.Color.White
        Me.fwiEstado.Location = New System.Drawing.Point(77, 27)
        Me.fwiEstado.Name = "fwiEstado"
        Me.fwiEstado.ReadOnly = True
        Me.fwiEstado.Size = New System.Drawing.Size(136, 21)
        Me.fwiEstado.TabIndex = 134
        Me.fwiEstado.TabStop = False
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(3, 31)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 135
        Me.lblEstado.Tag = "IdRec=4405;"
        Me.lblEstado.Text = "Estado"
        '
        'fwiTipoAsiento
        '
        Me.TryDataBinding(fwiTipoAsiento, New System.Windows.Forms.Binding("Value", Me, "IDTipoAsiento", True))
        fwiTipoAsiento_DesignTimeLayout.LayoutString = resources.GetString("fwiTipoAsiento_DesignTimeLayout.LayoutString")
        Me.fwiTipoAsiento.DesignTimeLayout = fwiTipoAsiento_DesignTimeLayout
        Me.fwiTipoAsiento.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTipoAsiento.Location = New System.Drawing.Point(77, 75)
        Me.fwiTipoAsiento.Name = "fwiTipoAsiento"
        Me.fwiTipoAsiento.PrimaryDataFields = "IDTipoAsiento"
        Me.fwiTipoAsiento.SecondaryDataFields = "Value"
        Me.fwiTipoAsiento.SelectedIndex = -1
        Me.fwiTipoAsiento.SelectedItem = Nothing
        Me.fwiTipoAsiento.Size = New System.Drawing.Size(206, 21)
        Me.fwiTipoAsiento.TabIndex = 23
        '
        'lblfwiTipoAsiento
        '
        Me.lblfwiTipoAsiento.Location = New System.Drawing.Point(3, 79)
        Me.lblfwiTipoAsiento.Name = "lblfwiTipoAsiento"
        Me.lblfwiTipoAsiento.Size = New System.Drawing.Size(77, 13)
        Me.lblfwiTipoAsiento.TabIndex = 0
        Me.lblfwiTipoAsiento.Tag = ""
        Me.lblfwiTipoAsiento.Text = "Tipo Asiento"
        '
        'fraCondicionesEconomicas
        '
        Me.fraCondicionesEconomicas.Controls.Add(Me.fwiDescClteBanco)
        Me.fraCondicionesEconomicas.Controls.Add(Me.lblfwiCondPago)
        Me.fraCondicionesEconomicas.Controls.Add(Me.lblcfwiCondPago)
        Me.fraCondicionesEconomicas.Controls.Add(Me.fwiCondPago)
        Me.fraCondicionesEconomicas.Controls.Add(Me.lblfwiIdDiaPago)
        Me.fraCondicionesEconomicas.Controls.Add(Me.lblcfwiIdDiaPago)
        Me.fraCondicionesEconomicas.Controls.Add(Me.fwiIdDiaPago)
        Me.fraCondicionesEconomicas.Controls.Add(Me.lblfwiIdClteBanco)
        Me.fraCondicionesEconomicas.Controls.Add(Me.fwiIdClteBanco)
        Me.fraCondicionesEconomicas.Controls.Add(Me.lblfwiBancoPropio)
        Me.fraCondicionesEconomicas.Controls.Add(Me.lblBancoPropio)
        Me.fraCondicionesEconomicas.Controls.Add(Me.fwiBancoPropio)
        Me.fraCondicionesEconomicas.Controls.Add(Me.lblfwiFormaPago)
        Me.fraCondicionesEconomicas.Controls.Add(Me.lblcfwiFormaPago)
        Me.fraCondicionesEconomicas.Controls.Add(Me.fwiFormaPago)
        Me.fraCondicionesEconomicas.Location = New System.Drawing.Point(0, 0)
        Me.fraCondicionesEconomicas.Name = "fraCondicionesEconomicas"
        Me.fraCondicionesEconomicas.Size = New System.Drawing.Size(314, 161)
        Me.fraCondicionesEconomicas.TabIndex = 0
        Me.fraCondicionesEconomicas.TabStop = False
        Me.fraCondicionesEconomicas.Text = "Condiciones económicas"
        '
        'fwiDescClteBanco
        '
        Me.TryDataBinding(fwiDescClteBanco, New System.Windows.Forms.Binding("Text", Me, "DescBanco", True))
        Me.fwiDescClteBanco.Location = New System.Drawing.Point(154, 102)
        Me.fwiDescClteBanco.Name = "fwiDescClteBanco"
        Me.fwiDescClteBanco.Size = New System.Drawing.Size(151, 23)
        Me.fwiDescClteBanco.TabIndex = 81
        Me.fwiDescClteBanco.UseMnemonic = False
        '
        'lblfwiCondPago
        '
        Me.lblfwiCondPago.Location = New System.Drawing.Point(9, 54)
        Me.lblfwiCondPago.Name = "lblfwiCondPago"
        Me.lblfwiCondPago.Size = New System.Drawing.Size(52, 13)
        Me.lblfwiCondPago.TabIndex = 63
        Me.lblfwiCondPago.Tag = "IdRec=4396;"
        Me.lblfwiCondPago.Text = "C. Pago"
        '
        'lblcfwiCondPago
        '
        Me.TryDataBinding(lblcfwiCondPago, New System.Windows.Forms.Binding("Text", Me.fwiCondPago, "DescCondicionPago", True))
        Me.lblcfwiCondPago.Location = New System.Drawing.Point(154, 50)
        Me.lblcfwiCondPago.Name = "lblcfwiCondPago"
        Me.lblcfwiCondPago.Size = New System.Drawing.Size(151, 23)
        Me.lblcfwiCondPago.TabIndex = 64
        Me.lblcfwiCondPago.UseMnemonic = False
        '
        'fwiCondPago
        '
        Me.TryDataBinding(fwiCondPago, New System.Windows.Forms.Binding("Text", Me, "IDCondicionPago", True))
        Me.fwiCondPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCondPago.EntityName = "CondicionPago"
        Me.fwiCondPago.Location = New System.Drawing.Point(96, 50)
        Me.fwiCondPago.Name = "fwiCondPago"
        Me.fwiCondPago.PrimaryDataFields = "IDCondicionPago"
        Me.fwiCondPago.SecondaryDataFields = "IDCondicionPago"
        Me.fwiCondPago.Size = New System.Drawing.Size(56, 23)
        Me.fwiCondPago.TabIndex = 19
        Me.fwiCondPago.ViewName = "tbMaestroCondicionPago"
        '
        'lblfwiIdDiaPago
        '
        Me.lblfwiIdDiaPago.Location = New System.Drawing.Point(9, 81)
        Me.lblfwiIdDiaPago.Name = "lblfwiIdDiaPago"
        Me.lblfwiIdDiaPago.Size = New System.Drawing.Size(58, 13)
        Me.lblfwiIdDiaPago.TabIndex = 65
        Me.lblfwiIdDiaPago.Tag = "IdRec=4681;"
        Me.lblfwiIdDiaPago.Text = "Día Pago"
        '
        'lblcfwiIdDiaPago
        '
        Me.TryDataBinding(lblcfwiIdDiaPago, New System.Windows.Forms.Binding("Text", Me.fwiIdDiaPago, "DescDiaPago", True))
        Me.lblcfwiIdDiaPago.Location = New System.Drawing.Point(154, 76)
        Me.lblcfwiIdDiaPago.Name = "lblcfwiIdDiaPago"
        Me.lblcfwiIdDiaPago.Size = New System.Drawing.Size(151, 23)
        Me.lblcfwiIdDiaPago.TabIndex = 66
        Me.lblcfwiIdDiaPago.UseMnemonic = False
        '
        'fwiIdDiaPago
        '
        Me.TryDataBinding(fwiIdDiaPago, New System.Windows.Forms.Binding("Text", Me, "IDDiaPago", True))
        Me.fwiIdDiaPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdDiaPago.EntityName = "DiaPago"
        Me.fwiIdDiaPago.Location = New System.Drawing.Point(96, 76)
        Me.fwiIdDiaPago.Name = "fwiIdDiaPago"
        Me.fwiIdDiaPago.PrimaryDataFields = "IDDiaPago"
        Me.fwiIdDiaPago.SecondaryDataFields = "IDDiaPago"
        Me.fwiIdDiaPago.Size = New System.Drawing.Size(56, 23)
        Me.fwiIdDiaPago.TabIndex = 20
        Me.fwiIdDiaPago.ViewName = "tbMaestroDiaPago"
        '
        'lblfwiIdClteBanco
        '
        Me.lblfwiIdClteBanco.Location = New System.Drawing.Point(9, 107)
        Me.lblfwiIdClteBanco.Name = "lblfwiIdClteBanco"
        Me.lblfwiIdClteBanco.Size = New System.Drawing.Size(86, 13)
        Me.lblfwiIdClteBanco.TabIndex = 67
        Me.lblfwiIdClteBanco.Tag = ""
        Me.lblfwiIdClteBanco.Text = "Banco Cliente"
        '
        'fwiIdClteBanco
        '
        Me.TryDataBinding(fwiIdClteBanco, New System.Windows.Forms.Binding("Value", Me, "IDClienteBanco", True))
        Me.TryDataBinding(fwiIdClteBanco, New System.Windows.Forms.Binding("Text", Me, "IDBanco", True))
        Me.fwiIdClteBanco.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdClteBanco.DisplayField = "IDClienteBanco"
        Me.fwiIdClteBanco.EntityName = "ClienteBanco"
        Me.fwiIdClteBanco.Location = New System.Drawing.Point(96, 102)
        Me.fwiIdClteBanco.Name = "fwiIdClteBanco"
        Me.fwiIdClteBanco.PrimaryDataFields = "IDClienteBanco"
        Me.fwiIdClteBanco.SecondaryDataFields = "IDClienteBanco"
        Me.fwiIdClteBanco.Size = New System.Drawing.Size(56, 23)
        Me.fwiIdClteBanco.TabIndex = 21
        Me.fwiIdClteBanco.ViewName = "tbClienteBanco"
        '
        'lblfwiBancoPropio
        '
        Me.lblfwiBancoPropio.Location = New System.Drawing.Point(9, 133)
        Me.lblfwiBancoPropio.Name = "lblfwiBancoPropio"
        Me.lblfwiBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblfwiBancoPropio.TabIndex = 69
        Me.lblfwiBancoPropio.Tag = "IdRec=4613;"
        Me.lblfwiBancoPropio.Text = "Banco Propio"
        '
        'lblBancoPropio
        '
        Me.TryDataBinding(lblBancoPropio, New System.Windows.Forms.Binding("Text", Me.fwiBancoPropio, "DescBancoPropio", True))
        Me.lblBancoPropio.Location = New System.Drawing.Point(154, 128)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(151, 23)
        Me.lblBancoPropio.TabIndex = 70
        Me.lblBancoPropio.UseMnemonic = False
        '
        'fwiBancoPropio
        '
        Me.TryDataBinding(fwiBancoPropio, New System.Windows.Forms.Binding("Text", Me, "IDBancoPropio", True))
        Me.fwiBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBancoPropio.EntityName = "BancoPropio"
        Me.fwiBancoPropio.Location = New System.Drawing.Point(96, 128)
        Me.fwiBancoPropio.Name = "fwiBancoPropio"
        Me.fwiBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.Size = New System.Drawing.Size(56, 23)
        Me.fwiBancoPropio.TabIndex = 22
        Me.fwiBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblfwiFormaPago
        '
        Me.lblfwiFormaPago.Location = New System.Drawing.Point(9, 29)
        Me.lblfwiFormaPago.Name = "lblfwiFormaPago"
        Me.lblfwiFormaPago.Size = New System.Drawing.Size(47, 13)
        Me.lblfwiFormaPago.TabIndex = 71
        Me.lblfwiFormaPago.Tag = "IdRec=4397;"
        Me.lblfwiFormaPago.Text = "F. Pago"
        '
        'lblcfwiFormaPago
        '
        Me.TryDataBinding(lblcfwiFormaPago, New System.Windows.Forms.Binding("Text", Me.fwiFormaPago, "DescFormaPago", True))
        Me.lblcfwiFormaPago.Location = New System.Drawing.Point(154, 24)
        Me.lblcfwiFormaPago.Name = "lblcfwiFormaPago"
        Me.lblcfwiFormaPago.Size = New System.Drawing.Size(151, 23)
        Me.lblcfwiFormaPago.TabIndex = 72
        Me.lblcfwiFormaPago.UseMnemonic = False
        '
        'fwiFormaPago
        '
        Me.TryDataBinding(fwiFormaPago, New System.Windows.Forms.Binding("Text", Me, "IDFormaPago", True))
        Me.fwiFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFormaPago.EntityName = "FormaPago"
        Me.fwiFormaPago.Location = New System.Drawing.Point(96, 24)
        Me.fwiFormaPago.Name = "fwiFormaPago"
        Me.fwiFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.fwiFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.fwiFormaPago.Size = New System.Drawing.Size(56, 23)
        Me.fwiFormaPago.TabIndex = 18
        Me.fwiFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'FraMoneda
        '
        Me.FraMoneda.Controls.Add(Me.lblfwiIdMoneda)
        Me.FraMoneda.Controls.Add(Me.FraMonedasInternas)
        Me.FraMoneda.Controls.Add(Me.ulDescMoneda)
        Me.FraMoneda.Controls.Add(Me.fwiIdMoneda)
        Me.FraMoneda.Location = New System.Drawing.Point(611, 0)
        Me.FraMoneda.Name = "FraMoneda"
        Me.FraMoneda.Size = New System.Drawing.Size(264, 161)
        Me.FraMoneda.TabIndex = 2
        Me.FraMoneda.TabStop = False
        Me.FraMoneda.Text = "Moneda"
        '
        'lblfwiIdMoneda
        '
        Me.lblfwiIdMoneda.Location = New System.Drawing.Point(9, 32)
        Me.lblfwiIdMoneda.Name = "lblfwiIdMoneda"
        Me.lblfwiIdMoneda.Size = New System.Drawing.Size(51, 13)
        Me.lblfwiIdMoneda.TabIndex = 0
        Me.lblfwiIdMoneda.Tag = "IdRec=4398;"
        Me.lblfwiIdMoneda.Text = "Moneda"
        '
        'FraMonedasInternas
        '
        Me.FraMonedasInternas.Controls.Add(Me.fwiCambioB)
        Me.FraMonedasInternas.Controls.Add(Me.fwiCambioA)
        Me.FraMonedasInternas.Controls.Add(Me.fwiDescMonedaA)
        Me.FraMonedasInternas.Controls.Add(Me.fwiDescMonedaB)
        Me.FraMonedasInternas.Controls.Add(Me.lblfwiCambioA)
        Me.FraMonedasInternas.Controls.Add(Me.lblfwiCambioB)
        Me.FraMonedasInternas.Location = New System.Drawing.Point(7, 64)
        Me.FraMonedasInternas.Name = "FraMonedasInternas"
        Me.FraMonedasInternas.Size = New System.Drawing.Size(253, 87)
        Me.FraMonedasInternas.TabIndex = 79
        Me.FraMonedasInternas.TabStop = False
        Me.FraMonedasInternas.Text = "Cambios"
        '
        'fwiCambioB
        '
        Me.TryDataBinding(fwiCambioB, New System.Windows.Forms.Binding("Value", Me, "CambioB", True))
        Me.fwiCambioB.DecimalDigits = 5
        Me.fwiCambioB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCambioB.Enabled = False
        Me.fwiCambioB.FormatString = "#,0.0####"
        Me.fwiCambioB.Location = New System.Drawing.Point(167, 52)
        Me.fwiCambioB.Name = "fwiCambioB"
        Me.fwiCambioB.Size = New System.Drawing.Size(78, 21)
        Me.fwiCambioB.TabIndex = 89
        '
        'fwiCambioA
        '
        Me.TryDataBinding(fwiCambioA, New System.Windows.Forms.Binding("Value", Me, "CambioA", True))
        Me.fwiCambioA.DecimalDigits = 5
        Me.fwiCambioA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCambioA.Enabled = False
        Me.fwiCambioA.FormatString = "#,0.0####"
        Me.fwiCambioA.Location = New System.Drawing.Point(167, 26)
        Me.fwiCambioA.Name = "fwiCambioA"
        Me.fwiCambioA.Size = New System.Drawing.Size(78, 21)
        Me.fwiCambioA.TabIndex = 88
        '
        'fwiDescMonedaA
        '
        Me.fwiDescMonedaA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescMonedaA.Enabled = False
        Me.fwiDescMonedaA.Location = New System.Drawing.Point(8, 26)
        Me.fwiDescMonedaA.Name = "fwiDescMonedaA"
        Me.fwiDescMonedaA.Size = New System.Drawing.Size(88, 21)
        Me.fwiDescMonedaA.TabIndex = 69
        Me.fwiDescMonedaA.TabStop = False
        '
        'fwiDescMonedaB
        '
        Me.fwiDescMonedaB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescMonedaB.Enabled = False
        Me.fwiDescMonedaB.Location = New System.Drawing.Point(8, 52)
        Me.fwiDescMonedaB.Name = "fwiDescMonedaB"
        Me.fwiDescMonedaB.Size = New System.Drawing.Size(88, 21)
        Me.fwiDescMonedaB.TabIndex = 70
        Me.fwiDescMonedaB.TabStop = False
        '
        'lblfwiCambioA
        '
        Me.lblfwiCambioA.Location = New System.Drawing.Point(101, 30)
        Me.lblfwiCambioA.Name = "lblfwiCambioA"
        Me.lblfwiCambioA.Size = New System.Drawing.Size(63, 13)
        Me.lblfwiCambioA.TabIndex = 71
        Me.lblfwiCambioA.Tag = "IdRec=4395;"
        Me.lblfwiCambioA.Text = "Cambio A"
        '
        'lblfwiCambioB
        '
        Me.lblfwiCambioB.Location = New System.Drawing.Point(101, 56)
        Me.lblfwiCambioB.Name = "lblfwiCambioB"
        Me.lblfwiCambioB.Size = New System.Drawing.Size(63, 13)
        Me.lblfwiCambioB.TabIndex = 75
        Me.lblfwiCambioB.Tag = "IdRec=4399;"
        Me.lblfwiCambioB.Text = "Cambio B"
        '
        'ulDescMoneda
        '
        Me.TryDataBinding(ulDescMoneda, New System.Windows.Forms.Binding("Text", Me.fwiIdMoneda, "DescMoneda", True))
        Me.ulDescMoneda.Location = New System.Drawing.Point(155, 27)
        Me.ulDescMoneda.Name = "ulDescMoneda"
        Me.ulDescMoneda.Size = New System.Drawing.Size(104, 23)
        Me.ulDescMoneda.TabIndex = 1
        Me.ulDescMoneda.UseMnemonic = False
        '
        'fwiIdMoneda
        '
        Me.TryDataBinding(fwiIdMoneda, New System.Windows.Forms.Binding("Text", Me, "IDMoneda", True))
        Me.fwiIdMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdMoneda.EntityName = "Moneda"
        Me.fwiIdMoneda.Location = New System.Drawing.Point(68, 27)
        Me.fwiIdMoneda.Name = "fwiIdMoneda"
        Me.fwiIdMoneda.PrimaryDataFields = "IDMoneda"
        Me.fwiIdMoneda.SecondaryDataFields = "IDMoneda"
        Me.fwiIdMoneda.Size = New System.Drawing.Size(82, 23)
        Me.fwiIdMoneda.TabIndex = 24
        Me.fwiIdMoneda.ViewName = "tbMaestroMoneda"
        '
        'TabPageImporteMonedas
        '
        Me.TabPageImporteMonedas.Controls.Add(Me.fwiMonedaA)
        Me.TabPageImporteMonedas.Controls.Add(Me.fwiMonedaB)
        Me.TabPageImporteMonedas.Controls.Add(Me.Line2)
        Me.TabPageImporteMonedas.Controls.Add(Me.FraImporteMonedas)
        Me.TabPageImporteMonedas.Key = "ImporteMonedas"
        Me.TabPageImporteMonedas.Location = New System.Drawing.Point(1, 21)
        Me.TabPageImporteMonedas.Name = "TabPageImporteMonedas"
        Me.TabPageImporteMonedas.Size = New System.Drawing.Size(878, 301)
        Me.TabPageImporteMonedas.TabStop = True
        Me.TabPageImporteMonedas.Text = "Importe Monedas"
        '
        'fwiMonedaA
        '
        Me.fwiMonedaA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiMonedaA.Enabled = False
        Me.fwiMonedaA.Location = New System.Drawing.Point(27, 0)
        Me.fwiMonedaA.Name = "fwiMonedaA"
        Me.fwiMonedaA.ReadOnly = True
        Me.fwiMonedaA.Size = New System.Drawing.Size(109, 21)
        Me.fwiMonedaA.TabIndex = 81
        Me.fwiMonedaA.TabStop = False
        Me.fwiMonedaA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'fwiMonedaB
        '
        Me.fwiMonedaB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiMonedaB.Enabled = False
        Me.fwiMonedaB.Location = New System.Drawing.Point(456, 0)
        Me.fwiMonedaB.Name = "fwiMonedaB"
        Me.fwiMonedaB.ReadOnly = True
        Me.fwiMonedaB.Size = New System.Drawing.Size(109, 21)
        Me.fwiMonedaB.TabIndex = 82
        Me.fwiMonedaB.TabStop = False
        Me.fwiMonedaB.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'Line2
        '
        Me.Line2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Line2.Location = New System.Drawing.Point(429, 0)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(2, 300)
        Me.Line2.TabIndex = 83
        '
        'FraImporteMonedas
        '
        Me.FraImporteMonedas.Controls.Add(Me.Label3)
        Me.FraImporteMonedas.Controls.Add(Me.NumericTextBox3)
        Me.FraImporteMonedas.Controls.Add(Me.Label2)
        Me.FraImporteMonedas.Controls.Add(Me.NumericTextBox2)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpLineasEspecialesB)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpLineasEspecialesB)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpLineasNormalesB)
        Me.FraImporteMonedas.Controls.Add(Me.Line19)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpLineasNormalesB)
        Me.FraImporteMonedas.Controls.Add(Me.Line3)
        Me.FraImporteMonedas.Controls.Add(Me.Line18)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpLineasEspecialesA)
        Me.FraImporteMonedas.Controls.Add(Me.Line15)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpLineasEspecialesA)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpLineasNormalesA)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpLineasNormalesA)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpLineasB)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpLineasB)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpLineasA)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpLineasA)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpIVAA)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpIVAA)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpIVAB)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpIVAB)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpTotalA)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpTotalA)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpTotalB)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpTotalB)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpRetencionB)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpRetencionB)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpReB)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpReB)
        Me.FraImporteMonedas.Controls.Add(Me.lblBaseImpA)
        Me.FraImporteMonedas.Controls.Add(Me.fwiBaseImpA)
        Me.FraImporteMonedas.Controls.Add(Me.lblBaseImpB)
        Me.FraImporteMonedas.Controls.Add(Me.fwiBaseImpB)
        Me.FraImporteMonedas.Controls.Add(Me.lblRetencionA)
        Me.FraImporteMonedas.Controls.Add(Me.fwiRetencionA)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpReA)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpReA)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpRecFinanA)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpRecFinanA)
        Me.FraImporteMonedas.Controls.Add(Me.lblImpRecFinanB)
        Me.FraImporteMonedas.Controls.Add(Me.fwiImpRecFinanB)
        Me.FraImporteMonedas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraImporteMonedas.Location = New System.Drawing.Point(0, 0)
        Me.FraImporteMonedas.Name = "FraImporteMonedas"
        Me.FraImporteMonedas.Size = New System.Drawing.Size(878, 301)
        Me.FraImporteMonedas.TabIndex = 83
        Me.FraImporteMonedas.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(480, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 144
        Me.Label3.Tag = "IdRec=5060;"
        Me.Label3.Text = "Impuestos"
        '
        'NumericTextBox3
        '
        Me.TryDataBinding(NumericTextBox3, New System.Windows.Forms.Binding("Value", Me, "ImpImpuestosB", True))
        Me.NumericTextBox3.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox3.Enabled = False
        Me.NumericTextBox3.Location = New System.Drawing.Point(589, 289)
        Me.NumericTextBox3.Name = "NumericTextBox3"
        Me.NumericTextBox3.Size = New System.Drawing.Size(97, 21)
        Me.NumericTextBox3.TabIndex = 143
        Me.NumericTextBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(43, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 142
        Me.Label2.Tag = "IdRec=5060;"
        Me.Label2.Text = "Impuestos"
        '
        'NumericTextBox2
        '
        Me.TryDataBinding(NumericTextBox2, New System.Windows.Forms.Binding("Value", Me, "ImpImpuestosA", True))
        Me.NumericTextBox2.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox2.Enabled = False
        Me.NumericTextBox2.Location = New System.Drawing.Point(152, 289)
        Me.NumericTextBox2.Name = "NumericTextBox2"
        Me.NumericTextBox2.Size = New System.Drawing.Size(97, 21)
        Me.NumericTextBox2.TabIndex = 141
        Me.NumericTextBox2.TabStop = False
        '
        'lblImpLineasEspecialesB
        '
        Me.lblImpLineasEspecialesB.Location = New System.Drawing.Point(480, 69)
        Me.lblImpLineasEspecialesB.Name = "lblImpLineasEspecialesB"
        Me.lblImpLineasEspecialesB.Size = New System.Drawing.Size(106, 13)
        Me.lblImpLineasEspecialesB.TabIndex = 0
        Me.lblImpLineasEspecialesB.Tag = "IdRec=11803;"
        Me.lblImpLineasEspecialesB.Text = "Líneas Especiales"
        '
        'fwiImpLineasEspecialesB
        '
        Me.fwiImpLineasEspecialesB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasEspecialesB.Enabled = False
        Me.fwiImpLineasEspecialesB.Location = New System.Drawing.Point(589, 65)
        Me.fwiImpLineasEspecialesB.Name = "fwiImpLineasEspecialesB"
        Me.fwiImpLineasEspecialesB.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasEspecialesB.TabIndex = 119
        Me.fwiImpLineasEspecialesB.TabStop = False
        '
        'lblImpLineasNormalesB
        '
        Me.lblImpLineasNormalesB.Location = New System.Drawing.Point(480, 45)
        Me.lblImpLineasNormalesB.Name = "lblImpLineasNormalesB"
        Me.lblImpLineasNormalesB.Size = New System.Drawing.Size(101, 13)
        Me.lblImpLineasNormalesB.TabIndex = 120
        Me.lblImpLineasNormalesB.Tag = "IdRec=11802;"
        Me.lblImpLineasNormalesB.Text = "Líneas Normales"
        '
        'Line19
        '
        Me.Line19.Location = New System.Drawing.Point(467, 212)
        Me.Line19.Name = "Line19"
        Me.Line19.Size = New System.Drawing.Size(245, 2)
        Me.Line19.TabIndex = 84
        '
        'fwiImpLineasNormalesB
        '
        Me.fwiImpLineasNormalesB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasNormalesB.Enabled = False
        Me.fwiImpLineasNormalesB.Location = New System.Drawing.Point(589, 41)
        Me.fwiImpLineasNormalesB.Name = "fwiImpLineasNormalesB"
        Me.fwiImpLineasNormalesB.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasNormalesB.TabIndex = 118
        Me.fwiImpLineasNormalesB.TabStop = False
        '
        'Line3
        '
        Me.Line3.Location = New System.Drawing.Point(467, 112)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(245, 2)
        Me.Line3.TabIndex = 87
        '
        'Line18
        '
        Me.Line18.Location = New System.Drawing.Point(26, 214)
        Me.Line18.Name = "Line18"
        Me.Line18.Size = New System.Drawing.Size(245, 2)
        Me.Line18.TabIndex = 85
        '
        'lblImpLineasEspecialesA
        '
        Me.lblImpLineasEspecialesA.Location = New System.Drawing.Point(43, 69)
        Me.lblImpLineasEspecialesA.Name = "lblImpLineasEspecialesA"
        Me.lblImpLineasEspecialesA.Size = New System.Drawing.Size(106, 13)
        Me.lblImpLineasEspecialesA.TabIndex = 121
        Me.lblImpLineasEspecialesA.Tag = "IdRec=11803;"
        Me.lblImpLineasEspecialesA.Text = "Líneas Especiales"
        '
        'Line15
        '
        Me.Line15.Location = New System.Drawing.Point(30, 112)
        Me.Line15.Name = "Line15"
        Me.Line15.Size = New System.Drawing.Size(245, 2)
        Me.Line15.TabIndex = 86
        '
        'fwiImpLineasEspecialesA
        '
        Me.fwiImpLineasEspecialesA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasEspecialesA.Enabled = False
        Me.fwiImpLineasEspecialesA.Location = New System.Drawing.Point(152, 65)
        Me.fwiImpLineasEspecialesA.Name = "fwiImpLineasEspecialesA"
        Me.fwiImpLineasEspecialesA.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasEspecialesA.TabIndex = 117
        Me.fwiImpLineasEspecialesA.TabStop = False
        '
        'lblImpLineasNormalesA
        '
        Me.lblImpLineasNormalesA.Location = New System.Drawing.Point(43, 45)
        Me.lblImpLineasNormalesA.Name = "lblImpLineasNormalesA"
        Me.lblImpLineasNormalesA.Size = New System.Drawing.Size(101, 13)
        Me.lblImpLineasNormalesA.TabIndex = 122
        Me.lblImpLineasNormalesA.Tag = "IdRec=11802;"
        Me.lblImpLineasNormalesA.Text = "Líneas Normales"
        '
        'fwiImpLineasNormalesA
        '
        Me.fwiImpLineasNormalesA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasNormalesA.Enabled = False
        Me.fwiImpLineasNormalesA.Location = New System.Drawing.Point(152, 41)
        Me.fwiImpLineasNormalesA.Name = "fwiImpLineasNormalesA"
        Me.fwiImpLineasNormalesA.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasNormalesA.TabIndex = 116
        Me.fwiImpLineasNormalesA.TabStop = False
        '
        'lblImpLineasB
        '
        Me.lblImpLineasB.Location = New System.Drawing.Point(480, 93)
        Me.lblImpLineasB.Name = "lblImpLineasB"
        Me.lblImpLineasB.Size = New System.Drawing.Size(43, 13)
        Me.lblImpLineasB.TabIndex = 123
        Me.lblImpLineasB.Tag = "IdRec=5057;"
        Me.lblImpLineasB.Text = "Líneas"
        '
        'fwiImpLineasB
        '
        Me.TryDataBinding(fwiImpLineasB, New System.Windows.Forms.Binding("Value", Me, "ImpLineasB", True))
        Me.fwiImpLineasB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasB.Enabled = False
        Me.fwiImpLineasB.Location = New System.Drawing.Point(589, 89)
        Me.fwiImpLineasB.Name = "fwiImpLineasB"
        Me.fwiImpLineasB.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasB.TabIndex = 35
        Me.fwiImpLineasB.TabStop = False
        '
        'lblImpLineasA
        '
        Me.lblImpLineasA.Location = New System.Drawing.Point(43, 93)
        Me.lblImpLineasA.Name = "lblImpLineasA"
        Me.lblImpLineasA.Size = New System.Drawing.Size(43, 13)
        Me.lblImpLineasA.TabIndex = 124
        Me.lblImpLineasA.Tag = "IdRec=5057;"
        Me.lblImpLineasA.Text = "Líneas"
        '
        'fwiImpLineasA
        '
        Me.TryDataBinding(fwiImpLineasA, New System.Windows.Forms.Binding("Value", Me, "ImpLineasA", True))
        Me.fwiImpLineasA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasA.Enabled = False
        Me.fwiImpLineasA.Location = New System.Drawing.Point(152, 89)
        Me.fwiImpLineasA.Name = "fwiImpLineasA"
        Me.fwiImpLineasA.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasA.TabIndex = 26
        Me.fwiImpLineasA.TabStop = False
        '
        'lblImpIVAA
        '
        Me.lblImpIVAA.Location = New System.Drawing.Point(43, 145)
        Me.lblImpIVAA.Name = "lblImpIVAA"
        Me.lblImpIVAA.Size = New System.Drawing.Size(28, 13)
        Me.lblImpIVAA.TabIndex = 125
        Me.lblImpIVAA.Tag = ""
        Me.lblImpIVAA.Text = "IVA"
        '
        'fwiImpIVAA
        '
        Me.TryDataBinding(fwiImpIVAA, New System.Windows.Forms.Binding("Value", Me, "ImpIvaA", True))
        Me.fwiImpIVAA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpIVAA.Enabled = False
        Me.fwiImpIVAA.Location = New System.Drawing.Point(152, 141)
        Me.fwiImpIVAA.Name = "fwiImpIVAA"
        Me.fwiImpIVAA.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpIVAA.TabIndex = 30
        Me.fwiImpIVAA.TabStop = False
        '
        'lblImpIVAB
        '
        Me.lblImpIVAB.Location = New System.Drawing.Point(480, 145)
        Me.lblImpIVAB.Name = "lblImpIVAB"
        Me.lblImpIVAB.Size = New System.Drawing.Size(28, 13)
        Me.lblImpIVAB.TabIndex = 126
        Me.lblImpIVAB.Tag = ""
        Me.lblImpIVAB.Text = "IVA"
        '
        'fwiImpIVAB
        '
        Me.TryDataBinding(fwiImpIVAB, New System.Windows.Forms.Binding("Value", Me, "ImpIvaB", True))
        Me.fwiImpIVAB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpIVAB.Enabled = False
        Me.fwiImpIVAB.Location = New System.Drawing.Point(589, 141)
        Me.fwiImpIVAB.Name = "fwiImpIVAB"
        Me.fwiImpIVAB.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpIVAB.TabIndex = 39
        Me.fwiImpIVAB.TabStop = False
        '
        'lblImpTotalA
        '
        Me.lblImpTotalA.Location = New System.Drawing.Point(43, 224)
        Me.lblImpTotalA.Name = "lblImpTotalA"
        Me.lblImpTotalA.Size = New System.Drawing.Size(46, 13)
        Me.lblImpTotalA.TabIndex = 127
        Me.lblImpTotalA.Tag = "IdRec=5058;"
        Me.lblImpTotalA.Text = "Total A"
        '
        'fwiImpTotalA
        '
        Me.TryDataBinding(fwiImpTotalA, New System.Windows.Forms.Binding("Value", Me, "ImpTotalA", True))
        Me.fwiImpTotalA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpTotalA.Enabled = False
        Me.fwiImpTotalA.Location = New System.Drawing.Point(152, 220)
        Me.fwiImpTotalA.Name = "fwiImpTotalA"
        Me.fwiImpTotalA.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpTotalA.TabIndex = 33
        Me.fwiImpTotalA.TabStop = False
        '
        'lblImpTotalB
        '
        Me.lblImpTotalB.Location = New System.Drawing.Point(480, 221)
        Me.lblImpTotalB.Name = "lblImpTotalB"
        Me.lblImpTotalB.Size = New System.Drawing.Size(46, 13)
        Me.lblImpTotalB.TabIndex = 128
        Me.lblImpTotalB.Tag = "IdRec=5059;"
        Me.lblImpTotalB.Text = "Total B"
        '
        'fwiImpTotalB
        '
        Me.TryDataBinding(fwiImpTotalB, New System.Windows.Forms.Binding("Value", Me, "ImpTotalB", True))
        Me.fwiImpTotalB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpTotalB.Enabled = False
        Me.fwiImpTotalB.Location = New System.Drawing.Point(589, 217)
        Me.fwiImpTotalB.Name = "fwiImpTotalB"
        Me.fwiImpTotalB.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpTotalB.TabIndex = 42
        Me.fwiImpTotalB.TabStop = False
        '
        'lblImpRetencionB
        '
        Me.lblImpRetencionB.Location = New System.Drawing.Point(480, 266)
        Me.lblImpRetencionB.Name = "lblImpRetencionB"
        Me.lblImpRetencionB.Size = New System.Drawing.Size(63, 13)
        Me.lblImpRetencionB.TabIndex = 129
        Me.lblImpRetencionB.Tag = "IdRec=5060;"
        Me.lblImpRetencionB.Text = "Retención"
        '
        'fwiImpRetencionB
        '
        Me.TryDataBinding(fwiImpRetencionB, New System.Windows.Forms.Binding("Value", Me, "ImpRetencionB", True))
        Me.fwiImpRetencionB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRetencionB.Enabled = False
        Me.fwiImpRetencionB.Location = New System.Drawing.Point(589, 262)
        Me.fwiImpRetencionB.Name = "fwiImpRetencionB"
        Me.fwiImpRetencionB.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpRetencionB.TabIndex = 43
        Me.fwiImpRetencionB.TabStop = False
        '
        'lblImpReB
        '
        Me.lblImpReB.Location = New System.Drawing.Point(480, 169)
        Me.lblImpReB.Name = "lblImpReB"
        Me.lblImpReB.Size = New System.Drawing.Size(30, 13)
        Me.lblImpReB.TabIndex = 132
        Me.lblImpReB.Tag = "IdRec=5062;"
        Me.lblImpReB.Text = "R.E."
        '
        'fwiImpReB
        '
        Me.TryDataBinding(fwiImpReB, New System.Windows.Forms.Binding("Value", Me, "ImpREB", True))
        Me.fwiImpReB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpReB.Enabled = False
        Me.fwiImpReB.Location = New System.Drawing.Point(589, 165)
        Me.fwiImpReB.Name = "fwiImpReB"
        Me.fwiImpReB.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpReB.TabIndex = 40
        Me.fwiImpReB.TabStop = False
        '
        'lblBaseImpA
        '
        Me.lblBaseImpA.Location = New System.Drawing.Point(43, 121)
        Me.lblBaseImpA.Name = "lblBaseImpA"
        Me.lblBaseImpA.Size = New System.Drawing.Size(96, 13)
        Me.lblBaseImpA.TabIndex = 135
        Me.lblBaseImpA.Tag = "IdRec=5044;"
        Me.lblBaseImpA.Text = "Base Imponible"
        '
        'fwiBaseImpA
        '
        Me.TryDataBinding(fwiBaseImpA, New System.Windows.Forms.Binding("Value", Me, "BaseImponibleA", True))
        Me.fwiBaseImpA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBaseImpA.Enabled = False
        Me.fwiBaseImpA.Location = New System.Drawing.Point(152, 117)
        Me.fwiBaseImpA.Name = "fwiBaseImpA"
        Me.fwiBaseImpA.Size = New System.Drawing.Size(119, 21)
        Me.fwiBaseImpA.TabIndex = 29
        Me.fwiBaseImpA.TabStop = False
        '
        'lblBaseImpB
        '
        Me.lblBaseImpB.Location = New System.Drawing.Point(480, 121)
        Me.lblBaseImpB.Name = "lblBaseImpB"
        Me.lblBaseImpB.Size = New System.Drawing.Size(96, 13)
        Me.lblBaseImpB.TabIndex = 136
        Me.lblBaseImpB.Tag = "IdRec=5044;"
        Me.lblBaseImpB.Text = "Base Imponible"
        '
        'fwiBaseImpB
        '
        Me.TryDataBinding(fwiBaseImpB, New System.Windows.Forms.Binding("Value", Me, "BaseImponibleB", True))
        Me.fwiBaseImpB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBaseImpB.Enabled = False
        Me.fwiBaseImpB.Location = New System.Drawing.Point(589, 117)
        Me.fwiBaseImpB.Name = "fwiBaseImpB"
        Me.fwiBaseImpB.Size = New System.Drawing.Size(119, 21)
        Me.fwiBaseImpB.TabIndex = 38
        Me.fwiBaseImpB.TabStop = False
        '
        'lblRetencionA
        '
        Me.lblRetencionA.Location = New System.Drawing.Point(43, 266)
        Me.lblRetencionA.Name = "lblRetencionA"
        Me.lblRetencionA.Size = New System.Drawing.Size(63, 13)
        Me.lblRetencionA.TabIndex = 137
        Me.lblRetencionA.Tag = "IdRec=5060;"
        Me.lblRetencionA.Text = "Retención"
        '
        'fwiRetencionA
        '
        Me.TryDataBinding(fwiRetencionA, New System.Windows.Forms.Binding("Value", Me, "ImpRetencionA", True))
        Me.fwiRetencionA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRetencionA.Enabled = False
        Me.fwiRetencionA.Location = New System.Drawing.Point(152, 262)
        Me.fwiRetencionA.Name = "fwiRetencionA"
        Me.fwiRetencionA.Size = New System.Drawing.Size(97, 21)
        Me.fwiRetencionA.TabIndex = 34
        Me.fwiRetencionA.TabStop = False
        '
        'lblImpReA
        '
        Me.lblImpReA.Location = New System.Drawing.Point(43, 169)
        Me.lblImpReA.Name = "lblImpReA"
        Me.lblImpReA.Size = New System.Drawing.Size(30, 13)
        Me.lblImpReA.TabIndex = 138
        Me.lblImpReA.Tag = "IdRec=5062;"
        Me.lblImpReA.Text = "R.E."
        '
        'fwiImpReA
        '
        Me.TryDataBinding(fwiImpReA, New System.Windows.Forms.Binding("Value", Me, "ImpREA", True))
        Me.fwiImpReA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpReA.Enabled = False
        Me.fwiImpReA.Location = New System.Drawing.Point(152, 165)
        Me.fwiImpReA.Name = "fwiImpReA"
        Me.fwiImpReA.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpReA.TabIndex = 31
        Me.fwiImpReA.TabStop = False
        '
        'lblImpRecFinanA
        '
        Me.lblImpRecFinanA.Location = New System.Drawing.Point(43, 193)
        Me.lblImpRecFinanA.Name = "lblImpRecFinanA"
        Me.lblImpRecFinanA.Size = New System.Drawing.Size(101, 13)
        Me.lblImpRecFinanA.TabIndex = 139
        Me.lblImpRecFinanA.Tag = ""
        Me.lblImpRecFinanA.Text = "Imp. Rec. Finan."
        Me.lblImpRecFinanA.Visible = False
        '
        'fwiImpRecFinanA
        '
        Me.TryDataBinding(fwiImpRecFinanA, New System.Windows.Forms.Binding("Value", Me, "ImpRecFinanA", True))
        Me.fwiImpRecFinanA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRecFinanA.Enabled = False
        Me.fwiImpRecFinanA.Location = New System.Drawing.Point(152, 189)
        Me.fwiImpRecFinanA.Name = "fwiImpRecFinanA"
        Me.fwiImpRecFinanA.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpRecFinanA.TabIndex = 32
        Me.fwiImpRecFinanA.TabStop = False
        Me.fwiImpRecFinanA.Visible = False
        '
        'lblImpRecFinanB
        '
        Me.lblImpRecFinanB.Location = New System.Drawing.Point(480, 193)
        Me.lblImpRecFinanB.Name = "lblImpRecFinanB"
        Me.lblImpRecFinanB.Size = New System.Drawing.Size(101, 13)
        Me.lblImpRecFinanB.TabIndex = 140
        Me.lblImpRecFinanB.Tag = ""
        Me.lblImpRecFinanB.Text = "Imp. Rec. Finan."
        Me.lblImpRecFinanB.Visible = False
        '
        'fwiImpRecFinanB
        '
        Me.TryDataBinding(fwiImpRecFinanB, New System.Windows.Forms.Binding("Value", Me, "ImpRecFinanB", True))
        Me.fwiImpRecFinanB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRecFinanB.Enabled = False
        Me.fwiImpRecFinanB.Location = New System.Drawing.Point(589, 189)
        Me.fwiImpRecFinanB.Name = "fwiImpRecFinanB"
        Me.fwiImpRecFinanB.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpRecFinanB.TabIndex = 41
        Me.fwiImpRecFinanB.TabStop = False
        Me.fwiImpRecFinanB.Visible = False
        '
        'TabPageTotales
        '
        Me.TabPageTotales.Controls.Add(Me.Panel3)
        Me.TabPageTotales.Controls.Add(Me.FraCalculoFactura)
        Me.TabPageTotales.Key = "Totales"
        Me.TabPageTotales.Location = New System.Drawing.Point(1, 21)
        Me.TabPageTotales.Name = "TabPageTotales"
        Me.TabPageTotales.Size = New System.Drawing.Size(878, 301)
        Me.TabPageTotales.TabStop = True
        Me.TabPageTotales.Text = "Totales"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Frame1)
        Me.Panel3.Controls.Add(Me.FraPuntoVerde)
        Me.Panel3.Controls.Add(Me.FraRetenciones)
        Me.Panel3.Controls.Add(Me.FraMonedaFactura)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(426, 301)
        Me.Panel3.TabIndex = 94
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.NumericTextBox1)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame1.Location = New System.Drawing.Point(0, 271)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(426, 64)
        Me.Frame1.TabIndex = 94
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Impuestos especiales"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "IdRec=47473;"
        Me.Label1.Text = "Impuestos"
        '
        'NumericTextBox1
        '
        Me.TryDataBinding(NumericTextBox1, New System.Windows.Forms.Binding("Value", Me, "ImpImpuestos", True))
        Me.NumericTextBox1.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox1.Enabled = False
        Me.NumericTextBox1.Location = New System.Drawing.Point(127, 24)
        Me.NumericTextBox1.Name = "NumericTextBox1"
        Me.NumericTextBox1.ReadOnly = True
        Me.NumericTextBox1.Size = New System.Drawing.Size(87, 21)
        Me.NumericTextBox1.TabIndex = 28
        '
        'FraPuntoVerde
        '
        Me.FraPuntoVerde.Controls.Add(Me.lblImpPuntoVerde)
        Me.FraPuntoVerde.Controls.Add(Me.fwiImpPuntoVerde)
        Me.FraPuntoVerde.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraPuntoVerde.Location = New System.Drawing.Point(0, 207)
        Me.FraPuntoVerde.Name = "FraPuntoVerde"
        Me.FraPuntoVerde.Size = New System.Drawing.Size(426, 64)
        Me.FraPuntoVerde.TabIndex = 93
        Me.FraPuntoVerde.TabStop = False
        Me.FraPuntoVerde.Text = "Punto Verde"
        '
        'lblImpPuntoVerde
        '
        Me.lblImpPuntoVerde.Location = New System.Drawing.Point(10, 28)
        Me.lblImpPuntoVerde.Name = "lblImpPuntoVerde"
        Me.lblImpPuntoVerde.Size = New System.Drawing.Size(107, 13)
        Me.lblImpPuntoVerde.TabIndex = 0
        Me.lblImpPuntoVerde.Tag = "IdRec=47473;"
        Me.lblImpPuntoVerde.Text = "Imp. Punto Verde"
        '
        'fwiImpPuntoVerde
        '
        Me.TryDataBinding(fwiImpPuntoVerde, New System.Windows.Forms.Binding("Value", Me, "ImpPuntoVerde", True))
        Me.fwiImpPuntoVerde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpPuntoVerde.Enabled = False
        Me.fwiImpPuntoVerde.Location = New System.Drawing.Point(127, 24)
        Me.fwiImpPuntoVerde.Name = "fwiImpPuntoVerde"
        Me.fwiImpPuntoVerde.ReadOnly = True
        Me.fwiImpPuntoVerde.Size = New System.Drawing.Size(87, 21)
        Me.fwiImpPuntoVerde.TabIndex = 28
        '
        'FraRetenciones
        '
        Me.FraRetenciones.Controls.Add(Me.lblfwiBaseRetencion)
        Me.FraRetenciones.Controls.Add(Me.fwiBaseRetencion)
        Me.FraRetenciones.Controls.Add(Me.fwiRetencionManual)
        Me.FraRetenciones.Controls.Add(Me.lblPorc3)
        Me.FraRetenciones.Controls.Add(Me.lblImpRetencion2)
        Me.FraRetenciones.Controls.Add(Me.fwiImpRetencion)
        Me.FraRetenciones.Controls.Add(Me.lblPorcIRPF)
        Me.FraRetenciones.Controls.Add(Me.fwiPorcIRPF)
        Me.FraRetenciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraRetenciones.Location = New System.Drawing.Point(0, 52)
        Me.FraRetenciones.Name = "FraRetenciones"
        Me.FraRetenciones.Size = New System.Drawing.Size(426, 155)
        Me.FraRetenciones.TabIndex = 92
        Me.FraRetenciones.TabStop = False
        Me.FraRetenciones.Text = "Retenciones"
        '
        'lblfwiBaseRetencion
        '
        Me.lblfwiBaseRetencion.Location = New System.Drawing.Point(38, 65)
        Me.lblfwiBaseRetencion.Name = "lblfwiBaseRetencion"
        Me.lblfwiBaseRetencion.Size = New System.Drawing.Size(95, 13)
        Me.lblfwiBaseRetencion.TabIndex = 106
        Me.lblfwiBaseRetencion.Text = "Base Retención"
        '
        'fwiBaseRetencion
        '
        Me.TryDataBinding(fwiBaseRetencion, New System.Windows.Forms.Binding("Value", Me, "BaseRetencion", True))
        Me.fwiBaseRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBaseRetencion.Enabled = False
        Me.fwiBaseRetencion.Location = New System.Drawing.Point(146, 65)
        Me.fwiBaseRetencion.Name = "fwiBaseRetencion"
        Me.fwiBaseRetencion.Size = New System.Drawing.Size(100, 21)
        Me.fwiBaseRetencion.TabIndex = 105
        '
        'fwiRetencionManual
        '
        Me.TryDataBinding(fwiRetencionManual, New System.Windows.Forms.Binding("BindableValue", Me, "RetencionManual", True))
        Me.fwiRetencionManual.Location = New System.Drawing.Point(13, 30)
        Me.fwiRetencionManual.Name = "fwiRetencionManual"
        Me.fwiRetencionManual.Size = New System.Drawing.Size(122, 19)
        Me.fwiRetencionManual.TabIndex = 102
        Me.fwiRetencionManual.Text = "Retención Manual"
        '
        'lblPorc3
        '
        Me.lblPorc3.Location = New System.Drawing.Point(204, 97)
        Me.lblPorc3.Name = "lblPorc3"
        Me.lblPorc3.Size = New System.Drawing.Size(19, 13)
        Me.lblPorc3.TabIndex = 65
        Me.lblPorc3.Text = "%"
        '
        'lblImpRetencion2
        '
        Me.lblImpRetencion2.Location = New System.Drawing.Point(38, 126)
        Me.lblImpRetencion2.Name = "lblImpRetencion2"
        Me.lblImpRetencion2.Size = New System.Drawing.Size(94, 13)
        Me.lblImpRetencion2.TabIndex = 0
        Me.lblImpRetencion2.Tag = "IdRec=5066;"
        Me.lblImpRetencion2.Text = "Imp. Retención"
        '
        'fwiImpRetencion
        '
        Me.TryDataBinding(fwiImpRetencion, New System.Windows.Forms.Binding("Value", Me, "ImpRetencion", True))
        Me.fwiImpRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRetencion.Enabled = False
        Me.fwiImpRetencion.Location = New System.Drawing.Point(146, 122)
        Me.fwiImpRetencion.Name = "fwiImpRetencion"
        Me.fwiImpRetencion.Size = New System.Drawing.Size(100, 21)
        Me.fwiImpRetencion.TabIndex = 27
        '
        'lblPorcIRPF
        '
        Me.lblPorcIRPF.Location = New System.Drawing.Point(38, 97)
        Me.lblPorcIRPF.Name = "lblPorcIRPF"
        Me.lblPorcIRPF.Size = New System.Drawing.Size(45, 13)
        Me.lblPorcIRPF.TabIndex = 64
        Me.lblPorcIRPF.Tag = "IdRec=5069;"
        Me.lblPorcIRPF.Text = "I.R.P.F."
        '
        'fwiPorcIRPF
        '
        Me.TryDataBinding(fwiPorcIRPF, New System.Windows.Forms.Binding("Value", Me, "RetencionIRPF", True))
        Me.fwiPorcIRPF.DisabledBackColor = System.Drawing.Color.White
        Me.fwiPorcIRPF.Location = New System.Drawing.Point(146, 93)
        Me.fwiPorcIRPF.Name = "fwiPorcIRPF"
        Me.fwiPorcIRPF.Size = New System.Drawing.Size(54, 21)
        Me.fwiPorcIRPF.TabIndex = 26
        '
        'FraMonedaFactura
        '
        Me.FraMonedaFactura.Controls.Add(Me.fwiDescMoneda)
        Me.FraMonedaFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraMonedaFactura.Location = New System.Drawing.Point(0, 0)
        Me.FraMonedaFactura.Name = "FraMonedaFactura"
        Me.FraMonedaFactura.Size = New System.Drawing.Size(426, 52)
        Me.FraMonedaFactura.TabIndex = 90
        Me.FraMonedaFactura.TabStop = False
        Me.FraMonedaFactura.Text = "Moneda Factura"
        '
        'fwiDescMoneda
        '
        Me.TryDataBinding(fwiDescMoneda, New System.Windows.Forms.Binding("Text", Me, "DescMoneda", True))
        Me.fwiDescMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescMoneda.Enabled = False
        Me.fwiDescMoneda.Location = New System.Drawing.Point(56, 25)
        Me.fwiDescMoneda.Name = "fwiDescMoneda"
        Me.fwiDescMoneda.Size = New System.Drawing.Size(120, 21)
        Me.fwiDescMoneda.TabIndex = 25
        Me.fwiDescMoneda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'FraCalculoFactura
        '
        Me.FraCalculoFactura.Controls.Add(Me.Line11)
        Me.FraCalculoFactura.Controls.Add(Me.lblImpRetencionAux)
        Me.FraCalculoFactura.Controls.Add(Me.fwiImpRetencionAux)
        Me.FraCalculoFactura.Controls.Add(Me.lblPorc4)
        Me.FraCalculoFactura.Controls.Add(Me.lblPorc)
        Me.FraCalculoFactura.Controls.Add(Me.lblPorc2)
        Me.FraCalculoFactura.Controls.Add(Me.Line10)
        Me.FraCalculoFactura.Controls.Add(Me.Line12)
        Me.FraCalculoFactura.Controls.Add(Me.lblImpLineasNormales)
        Me.FraCalculoFactura.Controls.Add(Me.fwiImpLineasNormales)
        Me.FraCalculoFactura.Controls.Add(Me.lblImpLineasEspeciales)
        Me.FraCalculoFactura.Controls.Add(Me.fwiImpLineasEspeciales)
        Me.FraCalculoFactura.Controls.Add(Me.lblImpTotalConRetencion)
        Me.FraCalculoFactura.Controls.Add(Me.fwiImpTotalConRetencion)
        Me.FraCalculoFactura.Controls.Add(Me.lblfwiDtoFactura)
        Me.FraCalculoFactura.Controls.Add(Me.fwiDtoFactura)
        Me.FraCalculoFactura.Controls.Add(Me.lblImpRecFinan)
        Me.FraCalculoFactura.Controls.Add(Me.fwiImpRecFinan)
        Me.FraCalculoFactura.Controls.Add(Me.lblfwiRecFinan)
        Me.FraCalculoFactura.Controls.Add(Me.fwiRecFinan)
        Me.FraCalculoFactura.Controls.Add(Me.lblIVA)
        Me.FraCalculoFactura.Controls.Add(Me.fwiIVA)
        Me.FraCalculoFactura.Controls.Add(Me.lblImpREMon)
        Me.FraCalculoFactura.Controls.Add(Me.fwiImpREMon)
        Me.FraCalculoFactura.Controls.Add(Me.lblImpTotal)
        Me.FraCalculoFactura.Controls.Add(Me.fwiImpTotal)
        Me.FraCalculoFactura.Controls.Add(Me.lblImpLinMon)
        Me.FraCalculoFactura.Controls.Add(Me.fwiImpLinMon)
        Me.FraCalculoFactura.Controls.Add(Me.lblBaseImpMon)
        Me.FraCalculoFactura.Controls.Add(Me.fwiBaseImpMon)
        Me.FraCalculoFactura.Controls.Add(Me.lblfwiDtoProntoPago)
        Me.FraCalculoFactura.Controls.Add(Me.fwiDtoProntoPago)
        Me.FraCalculoFactura.Dock = System.Windows.Forms.DockStyle.Right
        Me.FraCalculoFactura.Location = New System.Drawing.Point(426, 0)
        Me.FraCalculoFactura.Name = "FraCalculoFactura"
        Me.FraCalculoFactura.Size = New System.Drawing.Size(452, 301)
        Me.FraCalculoFactura.TabIndex = 91
        Me.FraCalculoFactura.TabStop = False
        Me.FraCalculoFactura.Text = "Cálculo Factura"
        '
        'Line11
        '
        Me.Line11.Location = New System.Drawing.Point(183, 82)
        Me.Line11.Name = "Line11"
        Me.Line11.Size = New System.Drawing.Size(245, 2)
        Me.Line11.TabIndex = 135
        '
        'lblImpRetencionAux
        '
        Me.lblImpRetencionAux.Location = New System.Drawing.Point(182, 253)
        Me.lblImpRetencionAux.Name = "lblImpRetencionAux"
        Me.lblImpRetencionAux.Size = New System.Drawing.Size(63, 13)
        Me.lblImpRetencionAux.TabIndex = 134
        Me.lblImpRetencionAux.Tag = "IdRec=5060;"
        Me.lblImpRetencionAux.Text = "Retención"
        '
        'fwiImpRetencionAux
        '
        Me.TryDataBinding(fwiImpRetencionAux, New System.Windows.Forms.Binding("Value", Me, "ImpRetencion", True))
        Me.fwiImpRetencionAux.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRetencionAux.Enabled = False
        Me.fwiImpRetencionAux.Location = New System.Drawing.Point(310, 249)
        Me.fwiImpRetencionAux.Name = "fwiImpRetencionAux"
        Me.fwiImpRetencionAux.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpRetencionAux.TabIndex = 133
        Me.fwiImpRetencionAux.TabStop = False
        '
        'lblPorc4
        '
        Me.lblPorc4.Location = New System.Drawing.Point(149, 194)
        Me.lblPorc4.Name = "lblPorc4"
        Me.lblPorc4.Size = New System.Drawing.Size(19, 13)
        Me.lblPorc4.TabIndex = 130
        Me.lblPorc4.Text = "%"
        '
        'lblPorc
        '
        Me.lblPorc.Location = New System.Drawing.Point(149, 121)
        Me.lblPorc.Name = "lblPorc"
        Me.lblPorc.Size = New System.Drawing.Size(19, 13)
        Me.lblPorc.TabIndex = 131
        Me.lblPorc.Text = "%"
        '
        'lblPorc2
        '
        Me.lblPorc2.Location = New System.Drawing.Point(149, 145)
        Me.lblPorc2.Name = "lblPorc2"
        Me.lblPorc2.Size = New System.Drawing.Size(19, 13)
        Me.lblPorc2.TabIndex = 132
        Me.lblPorc2.Text = "%"
        '
        'Line10
        '
        Me.Line10.Location = New System.Drawing.Point(185, 218)
        Me.Line10.Name = "Line10"
        Me.Line10.Size = New System.Drawing.Size(245, 2)
        Me.Line10.TabIndex = 3
        '
        'Line12
        '
        Me.Line12.Location = New System.Drawing.Point(185, 112)
        Me.Line12.Name = "Line12"
        Me.Line12.Size = New System.Drawing.Size(245, 2)
        Me.Line12.TabIndex = 2
        '
        'lblImpLineasNormales
        '
        Me.lblImpLineasNormales.Location = New System.Drawing.Point(149, 40)
        Me.lblImpLineasNormales.Name = "lblImpLineasNormales"
        Me.lblImpLineasNormales.Size = New System.Drawing.Size(151, 13)
        Me.lblImpLineasNormales.TabIndex = 0
        Me.lblImpLineasNormales.Tag = "IdRec=11799;"
        Me.lblImpLineasNormales.Text = "Importe Líneas Normales"
        '
        'fwiImpLineasNormales
        '
        Me.fwiImpLineasNormales.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasNormales.Enabled = False
        Me.fwiImpLineasNormales.Location = New System.Drawing.Point(309, 36)
        Me.fwiImpLineasNormales.Name = "fwiImpLineasNormales"
        Me.fwiImpLineasNormales.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasNormales.TabIndex = 115
        Me.fwiImpLineasNormales.TabStop = False
        '
        'lblImpLineasEspeciales
        '
        Me.lblImpLineasEspeciales.Location = New System.Drawing.Point(149, 64)
        Me.lblImpLineasEspeciales.Name = "lblImpLineasEspeciales"
        Me.lblImpLineasEspeciales.Size = New System.Drawing.Size(156, 13)
        Me.lblImpLineasEspeciales.TabIndex = 116
        Me.lblImpLineasEspeciales.Tag = "IdRec=11800;"
        Me.lblImpLineasEspeciales.Text = "Importe Líneas Especiales"
        '
        'fwiImpLineasEspeciales
        '
        Me.fwiImpLineasEspeciales.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasEspeciales.Enabled = False
        Me.fwiImpLineasEspeciales.Location = New System.Drawing.Point(309, 60)
        Me.fwiImpLineasEspeciales.Name = "fwiImpLineasEspeciales"
        Me.fwiImpLineasEspeciales.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasEspeciales.TabIndex = 114
        Me.fwiImpLineasEspeciales.TabStop = False
        '
        'lblImpTotalConRetencion
        '
        Me.lblImpTotalConRetencion.Location = New System.Drawing.Point(182, 277)
        Me.lblImpTotalConRetencion.Name = "lblImpTotalConRetencion"
        Me.lblImpTotalConRetencion.Size = New System.Drawing.Size(34, 13)
        Me.lblImpTotalConRetencion.TabIndex = 118
        Me.lblImpTotalConRetencion.Tag = "IdRec=4664;"
        Me.lblImpTotalConRetencion.Text = "Total"
        '
        'fwiImpTotalConRetencion
        '
        Me.fwiImpTotalConRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpTotalConRetencion.Enabled = False
        Me.fwiImpTotalConRetencion.Location = New System.Drawing.Point(310, 273)
        Me.fwiImpTotalConRetencion.Name = "fwiImpTotalConRetencion"
        Me.fwiImpTotalConRetencion.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpTotalConRetencion.TabIndex = 110
        Me.fwiImpTotalConRetencion.TabStop = False
        '
        'lblfwiDtoFactura
        '
        Me.lblfwiDtoFactura.Location = New System.Drawing.Point(13, 121)
        Me.lblfwiDtoFactura.Name = "lblfwiDtoFactura"
        Me.lblfwiDtoFactura.Size = New System.Drawing.Size(76, 13)
        Me.lblfwiDtoFactura.TabIndex = 119
        Me.lblfwiDtoFactura.Tag = "IdRec=5063;"
        Me.lblfwiDtoFactura.Text = "Dto. Factura"
        '
        'fwiDtoFactura
        '
        Me.TryDataBinding(fwiDtoFactura, New System.Windows.Forms.Binding("Value", Me, "DtoFactura", True))
        Me.fwiDtoFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDtoFactura.Location = New System.Drawing.Point(93, 121)
        Me.fwiDtoFactura.Name = "fwiDtoFactura"
        Me.fwiDtoFactura.Size = New System.Drawing.Size(50, 21)
        Me.fwiDtoFactura.TabIndex = 29
        '
        'lblImpRecFinan
        '
        Me.lblImpRecFinan.Location = New System.Drawing.Point(181, 198)
        Me.lblImpRecFinan.Name = "lblImpRecFinan"
        Me.lblImpRecFinan.Size = New System.Drawing.Size(101, 13)
        Me.lblImpRecFinan.TabIndex = 122
        Me.lblImpRecFinan.Tag = "IdRec=11801;"
        Me.lblImpRecFinan.Text = "Imp. Rec. Finan."
        '
        'fwiImpRecFinan
        '
        Me.TryDataBinding(fwiImpRecFinan, New System.Windows.Forms.Binding("Value", Me, "ImpRecFinan", True))
        Me.fwiImpRecFinan.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRecFinan.Enabled = False
        Me.fwiImpRecFinan.Location = New System.Drawing.Point(309, 194)
        Me.fwiImpRecFinan.Name = "fwiImpRecFinan"
        Me.fwiImpRecFinan.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpRecFinan.TabIndex = 66
        Me.fwiImpRecFinan.TabStop = False
        '
        'lblfwiRecFinan
        '
        Me.lblfwiRecFinan.Location = New System.Drawing.Point(13, 194)
        Me.lblfwiRecFinan.Name = "lblfwiRecFinan"
        Me.lblfwiRecFinan.Size = New System.Drawing.Size(70, 13)
        Me.lblfwiRecFinan.TabIndex = 123
        Me.lblfwiRecFinan.Tag = "IdRec=10600;"
        Me.lblfwiRecFinan.Text = "Rec. Finan."
        '
        'fwiRecFinan
        '
        Me.TryDataBinding(fwiRecFinan, New System.Windows.Forms.Binding("Value", Me, "RecFinan", True))
        Me.fwiRecFinan.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRecFinan.Location = New System.Drawing.Point(93, 194)
        Me.fwiRecFinan.Name = "fwiRecFinan"
        Me.fwiRecFinan.Size = New System.Drawing.Size(50, 21)
        Me.fwiRecFinan.TabIndex = 31
        '
        'lblIVA
        '
        Me.lblIVA.Location = New System.Drawing.Point(181, 150)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(28, 13)
        Me.lblIVA.TabIndex = 124
        Me.lblIVA.Tag = ""
        Me.lblIVA.Text = "IVA"
        '
        'fwiIVA
        '
        Me.TryDataBinding(fwiIVA, New System.Windows.Forms.Binding("Value", Me, "ImpIva", True))
        Me.fwiIVA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIVA.Enabled = False
        Me.fwiIVA.Location = New System.Drawing.Point(309, 146)
        Me.fwiIVA.Name = "fwiIVA"
        Me.fwiIVA.Size = New System.Drawing.Size(97, 21)
        Me.fwiIVA.TabIndex = 85
        Me.fwiIVA.TabStop = False
        '
        'lblImpREMon
        '
        Me.lblImpREMon.Location = New System.Drawing.Point(181, 174)
        Me.lblImpREMon.Name = "lblImpREMon"
        Me.lblImpREMon.Size = New System.Drawing.Size(30, 13)
        Me.lblImpREMon.TabIndex = 125
        Me.lblImpREMon.Tag = "IdRec=5062;"
        Me.lblImpREMon.Text = "R.E."
        '
        'fwiImpREMon
        '
        Me.TryDataBinding(fwiImpREMon, New System.Windows.Forms.Binding("Value", Me, "ImpRE", True))
        Me.fwiImpREMon.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpREMon.Enabled = False
        Me.fwiImpREMon.Location = New System.Drawing.Point(309, 170)
        Me.fwiImpREMon.Name = "fwiImpREMon"
        Me.fwiImpREMon.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpREMon.TabIndex = 86
        Me.fwiImpREMon.TabStop = False
        '
        'lblImpTotal
        '
        Me.lblImpTotal.Location = New System.Drawing.Point(182, 229)
        Me.lblImpTotal.Name = "lblImpTotal"
        Me.lblImpTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblImpTotal.TabIndex = 126
        Me.lblImpTotal.Tag = "IdRec=10601;"
        Me.lblImpTotal.Text = "SubTotal"
        '
        'fwiImpTotal
        '
        Me.TryDataBinding(fwiImpTotal, New System.Windows.Forms.Binding("Value", Me, "ImpTotal", True))
        Me.fwiImpTotal.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpTotal.Enabled = False
        Me.fwiImpTotal.Location = New System.Drawing.Point(310, 225)
        Me.fwiImpTotal.Name = "fwiImpTotal"
        Me.fwiImpTotal.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpTotal.TabIndex = 87
        Me.fwiImpTotal.TabStop = False
        '
        'lblImpLinMon
        '
        Me.lblImpLinMon.Location = New System.Drawing.Point(149, 92)
        Me.lblImpLinMon.Name = "lblImpLinMon"
        Me.lblImpLinMon.Size = New System.Drawing.Size(93, 13)
        Me.lblImpLinMon.TabIndex = 127
        Me.lblImpLinMon.Tag = "IdRec=5067;"
        Me.lblImpLinMon.Text = "Importe Líneas"
        '
        'fwiImpLinMon
        '
        Me.TryDataBinding(fwiImpLinMon, New System.Windows.Forms.Binding("Value", Me, "ImpLineas", True))
        Me.fwiImpLinMon.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLinMon.Enabled = False
        Me.fwiImpLinMon.Location = New System.Drawing.Point(309, 88)
        Me.fwiImpLinMon.Name = "fwiImpLinMon"
        Me.fwiImpLinMon.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLinMon.TabIndex = 88
        Me.fwiImpLinMon.TabStop = False
        '
        'lblBaseImpMon
        '
        Me.lblBaseImpMon.Location = New System.Drawing.Point(181, 126)
        Me.lblBaseImpMon.Name = "lblBaseImpMon"
        Me.lblBaseImpMon.Size = New System.Drawing.Size(96, 13)
        Me.lblBaseImpMon.TabIndex = 128
        Me.lblBaseImpMon.Tag = "IdRec=5044;"
        Me.lblBaseImpMon.Text = "Base Imponible"
        '
        'fwiBaseImpMon
        '
        Me.TryDataBinding(fwiBaseImpMon, New System.Windows.Forms.Binding("Value", Me, "BaseImponible", True))
        Me.fwiBaseImpMon.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBaseImpMon.Enabled = False
        Me.fwiBaseImpMon.Location = New System.Drawing.Point(309, 122)
        Me.fwiBaseImpMon.Name = "fwiBaseImpMon"
        Me.fwiBaseImpMon.Size = New System.Drawing.Size(119, 21)
        Me.fwiBaseImpMon.TabIndex = 89
        Me.fwiBaseImpMon.TabStop = False
        '
        'lblfwiDtoProntoPago
        '
        Me.lblfwiDtoProntoPago.Location = New System.Drawing.Point(13, 145)
        Me.lblfwiDtoProntoPago.Name = "lblfwiDtoProntoPago"
        Me.lblfwiDtoProntoPago.Size = New System.Drawing.Size(76, 13)
        Me.lblfwiDtoProntoPago.TabIndex = 129
        Me.lblfwiDtoProntoPago.Tag = "IdRec=5068;"
        Me.lblfwiDtoProntoPago.Text = "Pronto Pago"
        '
        'fwiDtoProntoPago
        '
        Me.TryDataBinding(fwiDtoProntoPago, New System.Windows.Forms.Binding("Value", Me, "DtoProntoPago", True))
        Me.fwiDtoProntoPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDtoProntoPago.Location = New System.Drawing.Point(93, 145)
        Me.fwiDtoProntoPago.Name = "fwiDtoProntoPago"
        Me.fwiDtoProntoPago.Size = New System.Drawing.Size(50, 21)
        Me.fwiDtoProntoPago.TabIndex = 30
        '
        'TabPageSeguimiento
        '
        Me.TabPageSeguimiento.Controls.Add(Me.Panel2)
        Me.TabPageSeguimiento.Controls.Add(Me.fraDireccionEnvioFactura)
        Me.TabPageSeguimiento.Controls.Add(Me.Panel1)
        Me.TabPageSeguimiento.Controls.Add(Me.LbLFactXMLGenerado)
        Me.TabPageSeguimiento.Controls.Add(Me.LbLFactPDFGenerado)
        Me.TabPageSeguimiento.Key = "Seguimiento"
        Me.TabPageSeguimiento.Location = New System.Drawing.Point(1, 21)
        Me.TabPageSeguimiento.Name = "TabPageSeguimiento"
        Me.TabPageSeguimiento.Size = New System.Drawing.Size(878, 301)
        Me.TabPageSeguimiento.TabStop = True
        Me.TabPageSeguimiento.Text = "Seguimiento"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FrmAdmonPublica)
        Me.Panel2.Controls.Add(Me.TxtDirecCorreo)
        Me.Panel2.Controls.Add(Me.LblDirecCorreo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 179)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(878, 102)
        Me.Panel2.TabIndex = 144
        '
        'FrmAdmonPublica
        '
        Me.FrmAdmonPublica.Controls.Add(Me.ULblDescUnidadTramitadora)
        Me.FrmAdmonPublica.Controls.Add(Me.AdvUnidadTramitadora)
        Me.FrmAdmonPublica.Controls.Add(Me.LblUnidadTramitadora)
        Me.FrmAdmonPublica.Controls.Add(Me.ULblDescOrganoGestor)
        Me.FrmAdmonPublica.Controls.Add(Me.AdvOrganoGestor)
        Me.FrmAdmonPublica.Controls.Add(Me.LblOrganoGestor)
        Me.FrmAdmonPublica.Controls.Add(Me.ULblDescOficinaContable)
        Me.FrmAdmonPublica.Controls.Add(Me.AdvOficinaContable)
        Me.FrmAdmonPublica.Controls.Add(Me.LblIDOficinaContable)
        Me.FrmAdmonPublica.Dock = System.Windows.Forms.DockStyle.Right
        Me.FrmAdmonPublica.Location = New System.Drawing.Point(468, 0)
        Me.FrmAdmonPublica.Name = "FrmAdmonPublica"
        Me.FrmAdmonPublica.Size = New System.Drawing.Size(410, 102)
        Me.FrmAdmonPublica.TabIndex = 116
        Me.FrmAdmonPublica.TabStop = False
        Me.FrmAdmonPublica.Text = "Administración Pública"
        '
        'ULblDescUnidadTramitadora
        '
        Me.TryDataBinding(ULblDescUnidadTramitadora, New System.Windows.Forms.Binding("Text", Me.AdvUnidadTramitadora, "DescUnidadTramitadora", True))
        Me.ULblDescUnidadTramitadora.Location = New System.Drawing.Point(255, 74)
        Me.ULblDescUnidadTramitadora.Name = "ULblDescUnidadTramitadora"
        Me.ULblDescUnidadTramitadora.Size = New System.Drawing.Size(146, 23)
        Me.ULblDescUnidadTramitadora.TabIndex = 8
        Me.ULblDescUnidadTramitadora.UseMnemonic = False
        '
        'AdvUnidadTramitadora
        '
        Me.AdvUnidadTramitadora.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescUnidadTramitadora", ULblDescUnidadTramitadora)})
        Me.TryDataBinding(AdvUnidadTramitadora, New System.Windows.Forms.Binding("Value", Me, "IDUnidadTramitadora", True))
        Me.AdvUnidadTramitadora.DisabledBackColor = System.Drawing.Color.White
        Me.AdvUnidadTramitadora.EntityName = "UnidadTramitadora"
        Me.AdvUnidadTramitadora.Location = New System.Drawing.Point(141, 74)
        Me.AdvUnidadTramitadora.Name = "AdvUnidadTramitadora"
        Me.AdvUnidadTramitadora.PrimaryDataFields = "IDUnidadTramitadora"
        Me.AdvUnidadTramitadora.SecondaryDataFields = "IDUnidadTramitadora"
        Me.AdvUnidadTramitadora.Size = New System.Drawing.Size(106, 23)
        Me.AdvUnidadTramitadora.TabIndex = 7
        '
        'LblUnidadTramitadora
        '
        Me.LblUnidadTramitadora.Location = New System.Drawing.Point(15, 77)
        Me.LblUnidadTramitadora.Name = "LblUnidadTramitadora"
        Me.LblUnidadTramitadora.Size = New System.Drawing.Size(119, 13)
        Me.LblUnidadTramitadora.TabIndex = 6
        Me.LblUnidadTramitadora.Text = "Unidad Tramitadora"
        '
        'ULblDescOrganoGestor
        '
        Me.TryDataBinding(ULblDescOrganoGestor, New System.Windows.Forms.Binding("Text", Me.AdvOrganoGestor, "DescOrganoGestor", True))
        Me.ULblDescOrganoGestor.Location = New System.Drawing.Point(256, 47)
        Me.ULblDescOrganoGestor.Name = "ULblDescOrganoGestor"
        Me.ULblDescOrganoGestor.Size = New System.Drawing.Size(145, 23)
        Me.ULblDescOrganoGestor.TabIndex = 5
        Me.ULblDescOrganoGestor.UseMnemonic = False
        '
        'AdvOrganoGestor
        '
        Me.AdvOrganoGestor.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescOrganoGestor", ULblDescOrganoGestor)})
        Me.TryDataBinding(AdvOrganoGestor, New System.Windows.Forms.Binding("Value", Me, "IDOrganoGestor", True))
        Me.AdvOrganoGestor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOrganoGestor.EntityName = "OrganoGestor"
        Me.AdvOrganoGestor.Location = New System.Drawing.Point(141, 47)
        Me.AdvOrganoGestor.Name = "AdvOrganoGestor"
        Me.AdvOrganoGestor.PrimaryDataFields = "IDOrganoGestor"
        Me.AdvOrganoGestor.SecondaryDataFields = "IDOrganoGestor"
        Me.AdvOrganoGestor.Size = New System.Drawing.Size(106, 23)
        Me.AdvOrganoGestor.TabIndex = 4
        '
        'LblOrganoGestor
        '
        Me.LblOrganoGestor.Location = New System.Drawing.Point(15, 52)
        Me.LblOrganoGestor.Name = "LblOrganoGestor"
        Me.LblOrganoGestor.Size = New System.Drawing.Size(91, 13)
        Me.LblOrganoGestor.TabIndex = 3
        Me.LblOrganoGestor.Text = "Órgano Gestor"
        '
        'ULblDescOficinaContable
        '
        Me.TryDataBinding(ULblDescOficinaContable, New System.Windows.Forms.Binding("Text", Me.AdvOficinaContable, "DescOficinaContable", True))
        Me.ULblDescOficinaContable.Location = New System.Drawing.Point(256, 21)
        Me.ULblDescOficinaContable.Name = "ULblDescOficinaContable"
        Me.ULblDescOficinaContable.Size = New System.Drawing.Size(145, 23)
        Me.ULblDescOficinaContable.TabIndex = 2
        Me.ULblDescOficinaContable.UseMnemonic = False
        '
        'AdvOficinaContable
        '
        Me.AdvOficinaContable.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescOficinaContable", ULblDescOficinaContable)})
        Me.TryDataBinding(AdvOficinaContable, New System.Windows.Forms.Binding("Value", Me, "IDOficinaContable", True))
        Me.AdvOficinaContable.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOficinaContable.EntityName = "OficinaContable"
        Me.AdvOficinaContable.Location = New System.Drawing.Point(141, 19)
        Me.AdvOficinaContable.Name = "AdvOficinaContable"
        Me.AdvOficinaContable.PrimaryDataFields = "IDOficinaContable"
        Me.AdvOficinaContable.SecondaryDataFields = "IDOficinaContable"
        Me.AdvOficinaContable.Size = New System.Drawing.Size(106, 23)
        Me.AdvOficinaContable.TabIndex = 1
        '
        'LblIDOficinaContable
        '
        Me.LblIDOficinaContable.Location = New System.Drawing.Point(15, 24)
        Me.LblIDOficinaContable.Name = "LblIDOficinaContable"
        Me.LblIDOficinaContable.Size = New System.Drawing.Size(101, 13)
        Me.LblIDOficinaContable.TabIndex = 0
        Me.LblIDOficinaContable.Text = "Oficina Contable"
        '
        'TxtDirecCorreo
        '
        Me.TryDataBinding(TxtDirecCorreo, New System.Windows.Forms.Binding("Text", Me, "Email", True))
        Me.TxtDirecCorreo.DisabledBackColor = System.Drawing.Color.White
        Me.TxtDirecCorreo.Enabled = False
        Me.TxtDirecCorreo.Location = New System.Drawing.Point(178, 5)
        Me.TxtDirecCorreo.Name = "TxtDirecCorreo"
        Me.TxtDirecCorreo.Size = New System.Drawing.Size(250, 21)
        Me.TxtDirecCorreo.TabIndex = 40
        '
        'LblDirecCorreo
        '
        Me.LblDirecCorreo.Location = New System.Drawing.Point(3, 9)
        Me.LblDirecCorreo.Name = "LblDirecCorreo"
        Me.LblDirecCorreo.Size = New System.Drawing.Size(170, 13)
        Me.LblDirecCorreo.TabIndex = 111
        Me.LblDirecCorreo.Text = "Dirección Correo Electrónico"
        '
        'fraDireccionEnvioFactura
        '
        Me.fraDireccionEnvioFactura.Controls.Add(Me.AdvDirecFra)
        Me.fraDireccionEnvioFactura.Controls.Add(Me.ulDirClienteFra)
        Me.fraDireccionEnvioFactura.Controls.Add(Me.ulFaxEnvioFra)
        Me.fraDireccionEnvioFactura.Controls.Add(Me.ulTelefonoEnvioFra)
        Me.fraDireccionEnvioFactura.Controls.Add(Me.ulProvinciaFra)
        Me.fraDireccionEnvioFactura.Controls.Add(Me.ulPoblacionFra)
        Me.fraDireccionEnvioFactura.Controls.Add(Me.ulCPClienteFra)
        Me.fraDireccionEnvioFactura.Controls.Add(Me.ulRazonSocialClienteFra)
        Me.fraDireccionEnvioFactura.Controls.Add(Me.ulCIFClienteFra)
        Me.fraDireccionEnvioFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraDireccionEnvioFactura.Location = New System.Drawing.Point(0, 83)
        Me.fraDireccionEnvioFactura.Name = "fraDireccionEnvioFactura"
        Me.fraDireccionEnvioFactura.Size = New System.Drawing.Size(878, 96)
        Me.fraDireccionEnvioFactura.TabIndex = 143
        Me.fraDireccionEnvioFactura.TabStop = False
        Me.fraDireccionEnvioFactura.Text = "Dirección de envío de la Factura"
        '
        'AdvDirecFra
        '
        Me.TryDataBinding(AdvDirecFra, New System.Windows.Forms.Binding("Value", Me, "IDDireccion", True))
        Me.AdvDirecFra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvDirecFra.EntityName = "ClienteDireccion"
        Me.AdvDirecFra.Location = New System.Drawing.Point(403, 98)
        Me.AdvDirecFra.Name = "AdvDirecFra"
        Me.AdvDirecFra.PrimaryDataFields = "IDDireccion"
        Me.AdvDirecFra.SecondaryDataFields = "IDDireccion"
        Me.AdvDirecFra.Size = New System.Drawing.Size(72, 23)
        Me.AdvDirecFra.TabIndex = 163
        '
        'ulDirClienteFra
        '
        Me.TryDataBinding(ulDirClienteFra, New System.Windows.Forms.Binding("Text", Me.AdvDirecFra, "Direccion", True))
        Me.ulDirClienteFra.Location = New System.Drawing.Point(8, 42)
        Me.ulDirClienteFra.Name = "ulDirClienteFra"
        Me.ulDirClienteFra.Size = New System.Drawing.Size(726, 21)
        Me.ulDirClienteFra.TabIndex = 63
        Me.ulDirClienteFra.UseMnemonic = False
        '
        'ulFaxEnvioFra
        '
        Me.TryDataBinding(ulFaxEnvioFra, New System.Windows.Forms.Binding("Text", Me.AdvDirecFra, "Fax", True))
        Me.ulFaxEnvioFra.Location = New System.Drawing.Point(740, 68)
        Me.ulFaxEnvioFra.Name = "ulFaxEnvioFra"
        Me.ulFaxEnvioFra.Size = New System.Drawing.Size(127, 21)
        Me.ulFaxEnvioFra.TabIndex = 68
        Me.ulFaxEnvioFra.UseMnemonic = False
        '
        'ulTelefonoEnvioFra
        '
        Me.TryDataBinding(ulTelefonoEnvioFra, New System.Windows.Forms.Binding("Text", Me.AdvDirecFra, "Telefono", True))
        Me.ulTelefonoEnvioFra.Location = New System.Drawing.Point(740, 42)
        Me.ulTelefonoEnvioFra.Name = "ulTelefonoEnvioFra"
        Me.ulTelefonoEnvioFra.Size = New System.Drawing.Size(126, 21)
        Me.ulTelefonoEnvioFra.TabIndex = 67
        Me.ulTelefonoEnvioFra.UseMnemonic = False
        '
        'ulProvinciaFra
        '
        Me.TryDataBinding(ulProvinciaFra, New System.Windows.Forms.Binding("Text", Me.AdvDirecFra, "Provincia", True))
        Me.ulProvinciaFra.Location = New System.Drawing.Point(502, 68)
        Me.ulProvinciaFra.Name = "ulProvinciaFra"
        Me.ulProvinciaFra.Size = New System.Drawing.Size(232, 21)
        Me.ulProvinciaFra.TabIndex = 66
        Me.ulProvinciaFra.UseMnemonic = False
        '
        'ulPoblacionFra
        '
        Me.TryDataBinding(ulPoblacionFra, New System.Windows.Forms.Binding("Text", Me.AdvDirecFra, "Poblacion", True))
        Me.ulPoblacionFra.Location = New System.Drawing.Point(95, 68)
        Me.ulPoblacionFra.Name = "ulPoblacionFra"
        Me.ulPoblacionFra.Size = New System.Drawing.Size(401, 21)
        Me.ulPoblacionFra.TabIndex = 65
        Me.ulPoblacionFra.UseMnemonic = False
        '
        'ulCPClienteFra
        '
        Me.TryDataBinding(ulCPClienteFra, New System.Windows.Forms.Binding("Text", Me.AdvDirecFra, "CodPostal", True))
        Me.ulCPClienteFra.Location = New System.Drawing.Point(8, 68)
        Me.ulCPClienteFra.Name = "ulCPClienteFra"
        Me.ulCPClienteFra.Size = New System.Drawing.Size(80, 21)
        Me.ulCPClienteFra.TabIndex = 64
        Me.ulCPClienteFra.UseMnemonic = False
        '
        'ulRazonSocialClienteFra
        '
        Me.TryDataBinding(ulRazonSocialClienteFra, New System.Windows.Forms.Binding("Text", Me.AdvDirecFra, "RazonSocial", True))
        Me.ulRazonSocialClienteFra.Location = New System.Drawing.Point(152, 16)
        Me.ulRazonSocialClienteFra.Name = "ulRazonSocialClienteFra"
        Me.ulRazonSocialClienteFra.Size = New System.Drawing.Size(714, 21)
        Me.ulRazonSocialClienteFra.TabIndex = 62
        Me.ulRazonSocialClienteFra.UseMnemonic = False
        '
        'ulCIFClienteFra
        '
        Me.TryDataBinding(ulCIFClienteFra, New System.Windows.Forms.Binding("Text", Me.AdvDirecFra, "CifCliente", True))
        Me.ulCIFClienteFra.Location = New System.Drawing.Point(8, 16)
        Me.ulCIFClienteFra.Name = "ulCIFClienteFra"
        Me.ulCIFClienteFra.Size = New System.Drawing.Size(136, 21)
        Me.ulCIFClienteFra.TabIndex = 61
        Me.ulCIFClienteFra.UseMnemonic = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.fraCentros)
        Me.Panel1.Controls.Add(Me.FraEDI)
        Me.Panel1.Controls.Add(Me.FraClienteInicial)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 83)
        Me.Panel1.TabIndex = 142
        '
        'fraCentros
        '
        Me.fraCentros.Controls.Add(Me.fwiCGestion)
        Me.fraCentros.Controls.Add(Me.lblCGestion)
        Me.fraCentros.Controls.Add(Me.LblCentroCoste)
        Me.fraCentros.Controls.Add(Me.CmbCentroCoste)
        Me.fraCentros.Location = New System.Drawing.Point(1, 0)
        Me.fraCentros.Name = "fraCentros"
        Me.fraCentros.Size = New System.Drawing.Size(480, 78)
        Me.fraCentros.TabIndex = 141
        Me.fraCentros.TabStop = False
        '
        'fwiCGestion
        '
        Me.TryDataBinding(fwiCGestion, New System.Windows.Forms.Binding("Value", Me, "IDCentroGestion", True))
        fwiCGestion_DesignTimeLayout.LayoutString = resources.GetString("fwiCGestion_DesignTimeLayout.LayoutString")
        Me.fwiCGestion.DesignTimeLayout = fwiCGestion_DesignTimeLayout
        Me.fwiCGestion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCGestion.DisplayMember = "DescCentroGestion"
        Me.fwiCGestion.EntityName = "CentroGestion"
        Me.fwiCGestion.Location = New System.Drawing.Point(99, 20)
        Me.fwiCGestion.Name = "fwiCGestion"
        Me.fwiCGestion.PrimaryDataFields = "IDCentroGestion"
        Me.fwiCGestion.SecondaryDataFields = "IDCentroGestion"
        Me.fwiCGestion.SelectedIndex = -1
        Me.fwiCGestion.SelectedItem = Nothing
        Me.fwiCGestion.Size = New System.Drawing.Size(375, 21)
        Me.fwiCGestion.TabIndex = 33
        Me.fwiCGestion.ValueMember = "IDCentroGestion"
        Me.fwiCGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblCGestion
        '
        Me.lblCGestion.Location = New System.Drawing.Point(3, 24)
        Me.lblCGestion.Name = "lblCGestion"
        Me.lblCGestion.Size = New System.Drawing.Size(93, 13)
        Me.lblCGestion.TabIndex = 130
        Me.lblCGestion.Text = "Centro Gestión"
        '
        'LblCentroCoste
        '
        Me.LblCentroCoste.Location = New System.Drawing.Point(3, 48)
        Me.LblCentroCoste.Name = "LblCentroCoste"
        Me.LblCentroCoste.Size = New System.Drawing.Size(83, 13)
        Me.LblCentroCoste.TabIndex = 137
        Me.LblCentroCoste.Text = "Centro Coste"
        '
        'CmbCentroCoste
        '
        Me.TryDataBinding(CmbCentroCoste, New System.Windows.Forms.Binding("Value", Me, "IDCentroCoste", True))
        CmbCentroCoste_DesignTimeLayout.LayoutString = resources.GetString("CmbCentroCoste_DesignTimeLayout.LayoutString")
        Me.CmbCentroCoste.DesignTimeLayout = CmbCentroCoste_DesignTimeLayout
        Me.CmbCentroCoste.DisabledBackColor = System.Drawing.Color.White
        Me.CmbCentroCoste.DisplayMember = "IDCentroCoste"
        Me.CmbCentroCoste.EntityName = "CentroCosteAnalitica"
        Me.CmbCentroCoste.Location = New System.Drawing.Point(99, 44)
        Me.CmbCentroCoste.Name = "CmbCentroCoste"
        Me.CmbCentroCoste.PrimaryDataFields = "IDCentroCoste"
        Me.CmbCentroCoste.SecondaryDataFields = "IDCentroCoste"
        Me.CmbCentroCoste.SelectedIndex = -1
        Me.CmbCentroCoste.SelectedItem = Nothing
        Me.CmbCentroCoste.Size = New System.Drawing.Size(375, 21)
        Me.CmbCentroCoste.TabIndex = 35
        Me.CmbCentroCoste.ValueMember = "IDCentroCoste"
        Me.CmbCentroCoste.ViewName = "tbMaestroCentroCosteAnalitica"
        '
        'FraEDI
        '
        Me.FraEDI.Controls.Add(Me.chkGeneradoFichero)
        Me.FraEDI.Location = New System.Drawing.Point(487, 39)
        Me.FraEDI.Name = "FraEDI"
        Me.FraEDI.Size = New System.Drawing.Size(387, 39)
        Me.FraEDI.TabIndex = 46
        Me.FraEDI.TabStop = False
        Me.FraEDI.Text = "EDI"
        '
        'chkGeneradoFichero
        '
        Me.TryDataBinding(chkGeneradoFichero, New System.Windows.Forms.Binding("BindableValue", Me, "GeneradoFichero", True))
        Me.chkGeneradoFichero.Location = New System.Drawing.Point(27, 15)
        Me.chkGeneradoFichero.Name = "chkGeneradoFichero"
        Me.chkGeneradoFichero.Size = New System.Drawing.Size(137, 21)
        Me.chkGeneradoFichero.TabIndex = 48
        Me.chkGeneradoFichero.Text = "Generado Fichero"
        '
        'FraClienteInicial
        '
        Me.FraClienteInicial.Controls.Add(Me.lblClienteIni)
        Me.FraClienteInicial.Controls.Add(Me.lblcfwiClienteIni)
        Me.FraClienteInicial.Controls.Add(Me.fwiClienteIni)
        Me.FraClienteInicial.Location = New System.Drawing.Point(487, 0)
        Me.FraClienteInicial.Name = "FraClienteInicial"
        Me.FraClienteInicial.Size = New System.Drawing.Size(387, 38)
        Me.FraClienteInicial.TabIndex = 44
        Me.FraClienteInicial.TabStop = False
        '
        'lblClienteIni
        '
        Me.lblClienteIni.Location = New System.Drawing.Point(5, 16)
        Me.lblClienteIni.Name = "lblClienteIni"
        Me.lblClienteIni.Size = New System.Drawing.Size(85, 13)
        Me.lblClienteIni.TabIndex = 0
        Me.lblClienteIni.Tag = "IdRec=5094;"
        Me.lblClienteIni.Text = "Cliente Inicial"
        '
        'lblcfwiClienteIni
        '
        Me.TryDataBinding(lblcfwiClienteIni, New System.Windows.Forms.Binding("Text", Me, "DescClienteInicial", True))
        Me.lblcfwiClienteIni.Location = New System.Drawing.Point(194, 12)
        Me.lblcfwiClienteIni.Name = "lblcfwiClienteIni"
        Me.lblcfwiClienteIni.Size = New System.Drawing.Size(186, 21)
        Me.lblcfwiClienteIni.TabIndex = 1
        Me.lblcfwiClienteIni.UseMnemonic = False
        '
        'fwiClienteIni
        '
        Me.TryDataBinding(fwiClienteIni, New System.Windows.Forms.Binding("Text", Me, "IDClienteInicial", True))
        Me.fwiClienteIni.DisabledBackColor = System.Drawing.Color.White
        Me.fwiClienteIni.Enabled = False
        Me.fwiClienteIni.Location = New System.Drawing.Point(93, 12)
        Me.fwiClienteIni.Name = "fwiClienteIni"
        Me.fwiClienteIni.Size = New System.Drawing.Size(97, 21)
        Me.fwiClienteIni.TabIndex = 45
        '
        'LbLFactXMLGenerado
        '
        Me.LbLFactXMLGenerado.AutoSize = False
        Me.LbLFactXMLGenerado.Location = New System.Drawing.Point(347, 297)
        Me.LbLFactXMLGenerado.Name = "LbLFactXMLGenerado"
        Me.LbLFactXMLGenerado.Size = New System.Drawing.Size(340, 23)
        Me.LbLFactXMLGenerado.TabIndex = 140
        Me.LbLFactXMLGenerado.Text = "Factura en XML (Facturae) Enviada"
        Me.LbLFactXMLGenerado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LbLFactXMLGenerado.Visible = False
        '
        'LbLFactPDFGenerado
        '
        Me.LbLFactPDFGenerado.AutoSize = False
        Me.LbLFactPDFGenerado.Location = New System.Drawing.Point(11, 297)
        Me.LbLFactPDFGenerado.Name = "LbLFactPDFGenerado"
        Me.LbLFactPDFGenerado.Size = New System.Drawing.Size(330, 23)
        Me.LbLFactPDFGenerado.TabIndex = 139
        Me.LbLFactPDFGenerado.Text = "Factura en PDF Enviada"
        Me.LbLFactPDFGenerado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LbLFactPDFGenerado.Visible = False
        '
        'TabPageDeclaraciones
        '
        Me.TabPageDeclaraciones.AllowClose = False
        Me.TabPageDeclaraciones.Controls.Add(Me.fraEntidadAseguradora)
        Me.TabPageDeclaraciones.Controls.Add(Me.fraClaveIntracomunitaria)
        Me.TabPageDeclaraciones.Controls.Add(Me.fraClaveOperacion)
        Me.TabPageDeclaraciones.Controls.Add(Me.fraDeclaracionesIva)
        Me.TabPageDeclaraciones.Key = "Declaraciones"
        Me.TabPageDeclaraciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPageDeclaraciones.Name = "TabPageDeclaraciones"
        Me.TabPageDeclaraciones.Size = New System.Drawing.Size(878, 301)
        Me.TabPageDeclaraciones.TabStop = True
        Me.TabPageDeclaraciones.Text = "Declaraciones"
        '
        'fraEntidadAseguradora
        '
        Me.fraEntidadAseguradora.Controls.Add(Me.cboMotivoNoAsegurado)
        Me.fraEntidadAseguradora.Controls.Add(Me.lblMotivo)
        Me.fraEntidadAseguradora.Controls.Add(Me.chbEnviadaEntidadAseguradora)
        Me.fraEntidadAseguradora.Controls.Add(Me.chbEnviadaEntidadAseguradora1)
        Me.fraEntidadAseguradora.Controls.Add(Me.lblDescAseguradora)
        Me.fraEntidadAseguradora.Controls.Add(Me.txtDescAseguradora)
        Me.fraEntidadAseguradora.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraEntidadAseguradora.Location = New System.Drawing.Point(0, 229)
        Me.fraEntidadAseguradora.Name = "fraEntidadAseguradora"
        Me.fraEntidadAseguradora.Size = New System.Drawing.Size(878, 48)
        Me.fraEntidadAseguradora.TabIndex = 11
        Me.fraEntidadAseguradora.TabStop = False
        Me.fraEntidadAseguradora.Text = "Entidad Aseguradora"
        '
        'cboMotivoNoAsegurado
        '
        Me.TryDataBinding(cboMotivoNoAsegurado, New System.Windows.Forms.Binding("Value", Me, "IDMotivoNoAsegurado", True))
        cboMotivoNoAsegurado_DesignTimeLayout.LayoutString = resources.GetString("cboMotivoNoAsegurado_DesignTimeLayout.LayoutString")
        Me.cboMotivoNoAsegurado.DesignTimeLayout = cboMotivoNoAsegurado_DesignTimeLayout
        Me.cboMotivoNoAsegurado.DisabledBackColor = System.Drawing.Color.White
        Me.cboMotivoNoAsegurado.DisplayMember = "DescMotivo"
        Me.cboMotivoNoAsegurado.EntityName = "MotivoNoAsegurado"
        Me.cboMotivoNoAsegurado.Location = New System.Drawing.Point(701, 22)
        Me.cboMotivoNoAsegurado.Name = "cboMotivoNoAsegurado"
        Me.cboMotivoNoAsegurado.PrimaryDataFields = "IDMotivoNoAsegurado"
        Me.cboMotivoNoAsegurado.SecondaryDataFields = "IDMotivo"
        Me.cboMotivoNoAsegurado.SelectedIndex = -1
        Me.cboMotivoNoAsegurado.SelectedItem = Nothing
        Me.cboMotivoNoAsegurado.Size = New System.Drawing.Size(171, 21)
        Me.cboMotivoNoAsegurado.TabIndex = 191
        Me.cboMotivoNoAsegurado.ValueMember = "IDMotivo"
        Me.cboMotivoNoAsegurado.ViewName = "tbMaestroMotivoNoAsegurado"
        '
        'lblMotivo
        '
        Me.lblMotivo.Location = New System.Drawing.Point(567, 26)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(128, 13)
        Me.lblMotivo.TabIndex = 190
        Me.lblMotivo.Tag = "IdRec=4705;"
        Me.lblMotivo.Text = "Motivo No Asegurado"
        '
        'chbEnviadaEntidadAseguradora
        '
        Me.TryDataBinding(chbEnviadaEntidadAseguradora, New System.Windows.Forms.Binding("BindableValue", Me, "EnviadaEntidadAseguradora", True))
        Me.chbEnviadaEntidadAseguradora.Location = New System.Drawing.Point(712, 46)
        Me.chbEnviadaEntidadAseguradora.Name = "chbEnviadaEntidadAseguradora"
        Me.chbEnviadaEntidadAseguradora.Size = New System.Drawing.Size(12, 23)
        Me.chbEnviadaEntidadAseguradora.TabIndex = 3
        '
        'chbEnviadaEntidadAseguradora1
        '
        Me.chbEnviadaEntidadAseguradora1.AutoSize = True
        Me.TryDataBinding(chbEnviadaEntidadAseguradora1, New System.Windows.Forms.Binding("BindableValue", Me, "EnviadaEntidadAseguradora", True))
        Me.chbEnviadaEntidadAseguradora1.Location = New System.Drawing.Point(30, 22)
        Me.chbEnviadaEntidadAseguradora1.Name = "chbEnviadaEntidadAseguradora1"
        Me.chbEnviadaEntidadAseguradora1.Size = New System.Drawing.Size(82, 18)
        Me.chbEnviadaEntidadAseguradora1.TabIndex = 13
        Me.chbEnviadaEntidadAseguradora1.Text = "Asegurada"
        '
        'lblDescAseguradora
        '
        Me.lblDescAseguradora.Location = New System.Drawing.Point(125, 26)
        Me.lblDescAseguradora.Name = "lblDescAseguradora"
        Me.lblDescAseguradora.Size = New System.Drawing.Size(126, 13)
        Me.lblDescAseguradora.TabIndex = 6
        Me.lblDescAseguradora.Text = "Entidad Aseguradora"
        '
        'txtDescAseguradora
        '
        Me.TryDataBinding(txtDescAseguradora, New System.Windows.Forms.Binding("Text", Me, "DescAseguradora", True))
        Me.txtDescAseguradora.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescAseguradora.Enabled = False
        Me.txtDescAseguradora.Location = New System.Drawing.Point(257, 22)
        Me.txtDescAseguradora.Name = "txtDescAseguradora"
        Me.txtDescAseguradora.Size = New System.Drawing.Size(288, 21)
        Me.txtDescAseguradora.TabIndex = 12
        '
        'fraClaveIntracomunitaria
        '
        Me.fraClaveIntracomunitaria.Controls.Add(Me.CmbTipoOperIntra)
        Me.fraClaveIntracomunitaria.Controls.Add(Me.LblTipoOperIntra)
        Me.fraClaveIntracomunitaria.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraClaveIntracomunitaria.Location = New System.Drawing.Point(0, 189)
        Me.fraClaveIntracomunitaria.Name = "fraClaveIntracomunitaria"
        Me.fraClaveIntracomunitaria.Size = New System.Drawing.Size(878, 40)
        Me.fraClaveIntracomunitaria.TabIndex = 114
        Me.fraClaveIntracomunitaria.TabStop = False
        '
        'CmbTipoOperIntra
        '
        Me.TryDataBinding(CmbTipoOperIntra, New System.Windows.Forms.Binding("Value", Me, "TipoOperIntra", True))
        CmbTipoOperIntra_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoOperIntra_DesignTimeLayout.LayoutString")
        Me.CmbTipoOperIntra.DesignTimeLayout = CmbTipoOperIntra_DesignTimeLayout
        Me.CmbTipoOperIntra.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoOperIntra.DisplayMember = "Text"
        Me.CmbTipoOperIntra.Location = New System.Drawing.Point(227, 13)
        Me.CmbTipoOperIntra.Name = "CmbTipoOperIntra"
        Me.CmbTipoOperIntra.SelectedIndex = -1
        Me.CmbTipoOperIntra.SelectedItem = Nothing
        Me.CmbTipoOperIntra.Size = New System.Drawing.Size(100, 21)
        Me.CmbTipoOperIntra.TabIndex = 2
        Me.CmbTipoOperIntra.ValueMember = "Value"
        '
        'LblTipoOperIntra
        '
        Me.LblTipoOperIntra.Location = New System.Drawing.Point(27, 17)
        Me.LblTipoOperIntra.Name = "LblTipoOperIntra"
        Me.LblTipoOperIntra.Size = New System.Drawing.Size(192, 13)
        Me.LblTipoOperIntra.TabIndex = 112
        Me.LblTipoOperIntra.Text = "Tipo Operación Intracomunitaria"
        '
        'fraClaveOperacion
        '
        Me.fraClaveOperacion.Controls.Add(Me.cbxClaveOperacion)
        Me.fraClaveOperacion.Controls.Add(Me.lblFacturaRectificada)
        Me.fraClaveOperacion.Controls.Add(Me.lblClaveOperacion)
        Me.fraClaveOperacion.Controls.Add(Me.AdvFtaRectificada)
        Me.fraClaveOperacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraClaveOperacion.Location = New System.Drawing.Point(0, 149)
        Me.fraClaveOperacion.Name = "fraClaveOperacion"
        Me.fraClaveOperacion.Size = New System.Drawing.Size(878, 40)
        Me.fraClaveOperacion.TabIndex = 113
        Me.fraClaveOperacion.TabStop = False
        '
        'cbxClaveOperacion
        '
        Me.TryDataBinding(cbxClaveOperacion, New System.Windows.Forms.Binding("Value", Me, "ClaveOperacion", True))
        cbxClaveOperacion_DesignTimeLayout.LayoutString = resources.GetString("cbxClaveOperacion_DesignTimeLayout.LayoutString")
        Me.cbxClaveOperacion.DesignTimeLayout = cbxClaveOperacion_DesignTimeLayout
        Me.cbxClaveOperacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxClaveOperacion.DisplayMember = "Text"
        Me.cbxClaveOperacion.Location = New System.Drawing.Point(135, 13)
        Me.cbxClaveOperacion.Name = "cbxClaveOperacion"
        Me.cbxClaveOperacion.SelectedIndex = -1
        Me.cbxClaveOperacion.SelectedItem = Nothing
        Me.cbxClaveOperacion.Size = New System.Drawing.Size(256, 21)
        Me.cbxClaveOperacion.TabIndex = 1
        Me.cbxClaveOperacion.ValueMember = "Value"
        '
        'lblFacturaRectificada
        '
        Me.lblFacturaRectificada.Location = New System.Drawing.Point(413, 17)
        Me.lblFacturaRectificada.Name = "lblFacturaRectificada"
        Me.lblFacturaRectificada.Size = New System.Drawing.Size(114, 13)
        Me.lblFacturaRectificada.TabIndex = 110
        Me.lblFacturaRectificada.Text = "Factura Rectificada"
        '
        'lblClaveOperacion
        '
        Me.lblClaveOperacion.Location = New System.Drawing.Point(27, 17)
        Me.lblClaveOperacion.Name = "lblClaveOperacion"
        Me.lblClaveOperacion.Size = New System.Drawing.Size(102, 13)
        Me.lblClaveOperacion.TabIndex = 111
        Me.lblClaveOperacion.Text = "Clave Operación"
        '
        'AdvFtaRectificada
        '
        Me.TryDataBinding(AdvFtaRectificada, New System.Windows.Forms.Binding("Value", Me, "IDFacturaRectificada", True))
        Me.AdvFtaRectificada.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFtaRectificada.DisplayField = "NFactura"
        Me.AdvFtaRectificada.EntityName = "FacturaVentaCabecera"
        Me.AdvFtaRectificada.Location = New System.Drawing.Point(532, 13)
        Me.AdvFtaRectificada.Name = "AdvFtaRectificada"
        Me.AdvFtaRectificada.PrimaryDataFields = "IDFacturaRectificada"
        Me.AdvFtaRectificada.SecondaryDataFields = "IDFactura"
        Me.AdvFtaRectificada.Size = New System.Drawing.Size(117, 23)
        Me.AdvFtaRectificada.TabIndex = 0
        '
        'fraDeclaracionesIva
        '
        Me.fraDeclaracionesIva.Controls.Add(Me.ChkOpeTriangular)
        Me.fraDeclaracionesIva.Controls.Add(Me.ChkSectorServicios)
        Me.fraDeclaracionesIva.Controls.Add(Me.ChkEnviar349)
        Me.fraDeclaracionesIva.Controls.Add(Me.chkEnviar347)
        Me.fraDeclaracionesIva.Controls.Add(Me.chkFechaDeclManual)
        Me.fraDeclaracionesIva.Controls.Add(Me.lblFechaParaDeclaracion)
        Me.fraDeclaracionesIva.Controls.Add(Me.FwiFechaParaDeclaracion)
        Me.fraDeclaracionesIva.Controls.Add(Me.lblNumDeclaracion)
        Me.fraDeclaracionesIva.Controls.Add(Me.fwiNDeclaracion)
        Me.fraDeclaracionesIva.Controls.Add(Me.lblAñoDeclaracion)
        Me.fraDeclaracionesIva.Controls.Add(Me.fwiAñoDeclaracion)
        Me.fraDeclaracionesIva.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraDeclaracionesIva.Location = New System.Drawing.Point(0, 0)
        Me.fraDeclaracionesIva.Name = "fraDeclaracionesIva"
        Me.fraDeclaracionesIva.Size = New System.Drawing.Size(878, 149)
        Me.fraDeclaracionesIva.TabIndex = 3
        Me.fraDeclaracionesIva.TabStop = False
        Me.fraDeclaracionesIva.Text = "Declaraciones de Impuestos"
        '
        'ChkOpeTriangular
        '
        Me.TryDataBinding(ChkOpeTriangular, New System.Windows.Forms.Binding("BindableValue", Me, "OpeTriangular", True))
        Me.ChkOpeTriangular.Location = New System.Drawing.Point(262, 114)
        Me.ChkOpeTriangular.Name = "ChkOpeTriangular"
        Me.ChkOpeTriangular.Size = New System.Drawing.Size(188, 24)
        Me.ChkOpeTriangular.TabIndex = 115
        Me.ChkOpeTriangular.Text = "Operación Triangular"
        '
        'ChkSectorServicios
        '
        Me.TryDataBinding(ChkSectorServicios, New System.Windows.Forms.Binding("BindableValue", Me, "Servicios349", True))
        Me.ChkSectorServicios.Location = New System.Drawing.Point(136, 114)
        Me.ChkSectorServicios.Name = "ChkSectorServicios"
        Me.ChkSectorServicios.Size = New System.Drawing.Size(120, 24)
        Me.ChkSectorServicios.TabIndex = 10
        Me.ChkSectorServicios.Text = "Servicios"
        '
        'ChkEnviar349
        '
        Me.TryDataBinding(ChkEnviar349, New System.Windows.Forms.Binding("BindableValue", Me, "Enviar349", True))
        Me.ChkEnviar349.Location = New System.Drawing.Point(27, 114)
        Me.ChkEnviar349.Name = "ChkEnviar349"
        Me.ChkEnviar349.Size = New System.Drawing.Size(104, 24)
        Me.ChkEnviar349.TabIndex = 9
        Me.ChkEnviar349.Text = "Enviar a 349"
        '
        'chkEnviar347
        '
        Me.TryDataBinding(chkEnviar347, New System.Windows.Forms.Binding("Checked", Me, "Enviar347", True))
        Me.chkEnviar347.Location = New System.Drawing.Point(27, 90)
        Me.chkEnviar347.Name = "chkEnviar347"
        Me.chkEnviar347.Size = New System.Drawing.Size(120, 24)
        Me.chkEnviar347.TabIndex = 8
        Me.chkEnviar347.Text = "Enviar a 347"
        '
        'chkFechaDeclManual
        '
        Me.TryDataBinding(chkFechaDeclManual, New System.Windows.Forms.Binding("BindableValue", Me, "FechaDeclaracionManual", True))
        Me.chkFechaDeclManual.Location = New System.Drawing.Point(310, 24)
        Me.chkFechaDeclManual.Name = "chkFechaDeclManual"
        Me.chkFechaDeclManual.Size = New System.Drawing.Size(208, 16)
        Me.chkFechaDeclManual.TabIndex = 6
        Me.chkFechaDeclManual.Text = "Fecha distinta de factura"
        '
        'lblFechaParaDeclaracion
        '
        Me.lblFechaParaDeclaracion.Location = New System.Drawing.Point(27, 24)
        Me.lblFechaParaDeclaracion.Name = "lblFechaParaDeclaracion"
        Me.lblFechaParaDeclaracion.Size = New System.Drawing.Size(141, 13)
        Me.lblFechaParaDeclaracion.TabIndex = 0
        Me.lblFechaParaDeclaracion.Tag = "IdRec=12893;"
        Me.lblFechaParaDeclaracion.Text = "Fecha para Declaración"
        '
        'FwiFechaParaDeclaracion
        '
        Me.TryDataBinding(FwiFechaParaDeclaracion, New System.Windows.Forms.Binding("BindableValue", Me, "FechaParaDeclaracion", True))
        Me.FwiFechaParaDeclaracion.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaParaDeclaracion.Location = New System.Drawing.Point(173, 21)
        Me.FwiFechaParaDeclaracion.Name = "FwiFechaParaDeclaracion"
        Me.FwiFechaParaDeclaracion.Size = New System.Drawing.Size(113, 21)
        Me.FwiFechaParaDeclaracion.TabIndex = 7
        '
        'lblNumDeclaracion
        '
        Me.lblNumDeclaracion.Location = New System.Drawing.Point(27, 69)
        Me.lblNumDeclaracion.Name = "lblNumDeclaracion"
        Me.lblNumDeclaracion.Size = New System.Drawing.Size(108, 13)
        Me.lblNumDeclaracion.TabIndex = 53
        Me.lblNumDeclaracion.Tag = "IdRec=10598;"
        Me.lblNumDeclaracion.Text = "Num. Declaración"
        '
        'fwiNDeclaracion
        '
        Me.TryDataBinding(fwiNDeclaracion, New System.Windows.Forms.Binding("Text", Me, "NDeclaracionIva", True))
        Me.fwiNDeclaracion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNDeclaracion.Enabled = False
        Me.fwiNDeclaracion.Location = New System.Drawing.Point(173, 69)
        Me.fwiNDeclaracion.Name = "fwiNDeclaracion"
        Me.fwiNDeclaracion.Size = New System.Drawing.Size(113, 21)
        Me.fwiNDeclaracion.TabIndex = 5
        '
        'lblAñoDeclaracion
        '
        Me.lblAñoDeclaracion.Location = New System.Drawing.Point(27, 45)
        Me.lblAñoDeclaracion.Name = "lblAñoDeclaracion"
        Me.lblAñoDeclaracion.Size = New System.Drawing.Size(100, 13)
        Me.lblAñoDeclaracion.TabIndex = 114
        Me.lblAñoDeclaracion.Tag = "IdRec=6853;"
        Me.lblAñoDeclaracion.Text = "Año Declaración"
        '
        'fwiAñoDeclaracion
        '
        Me.TryDataBinding(fwiAñoDeclaracion, New System.Windows.Forms.Binding("Text", Me, "AñoDeclaracionIva", True))
        Me.fwiAñoDeclaracion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiAñoDeclaracion.Enabled = False
        Me.fwiAñoDeclaracion.Location = New System.Drawing.Point(173, 45)
        Me.fwiAñoDeclaracion.Name = "fwiAñoDeclaracion"
        Me.fwiAñoDeclaracion.Size = New System.Drawing.Size(113, 21)
        Me.fwiAñoDeclaracion.TabIndex = 4
        '
        'TabPageConceptos
        '
        Me.TabPageConceptos.Controls.Add(Me.jngConceptos)
        Me.TabPageConceptos.Key = "Conceptos"
        Me.TabPageConceptos.Location = New System.Drawing.Point(1, 21)
        Me.TabPageConceptos.Name = "TabPageConceptos"
        Me.TabPageConceptos.Size = New System.Drawing.Size(878, 301)
        Me.TabPageConceptos.TabStop = True
        Me.TabPageConceptos.Text = "Conceptos"
        '
        'jngConceptos
        '
        Me.jngConceptos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngConceptos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngConceptos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngConceptos_DesignTimeLayout.LayoutString = resources.GetString("jngConceptos_DesignTimeLayout.LayoutString")
        Me.jngConceptos.DesignTimeLayout = jngConceptos_DesignTimeLayout
        Me.jngConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngConceptos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngConceptos.EntityName = "FacturaVentaLinea"
        Me.jngConceptos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngConceptos.Location = New System.Drawing.Point(0, 0)
        Me.jngConceptos.Name = "jngConceptos"
        Me.jngConceptos.PrimaryDataFields = "IDFactura"
        Me.jngConceptos.SecondaryDataFields = "IDFactura"
        Me.jngConceptos.Size = New System.Drawing.Size(878, 301)
        Me.jngConceptos.TabIndex = 131
        Me.jngConceptos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngConceptos.ViewName = "VCtlCIFacturaVentaPorConceptos"
        '
        'TabPagePicAnotaciones
        '
        Me.TabPagePicAnotaciones.Controls.Add(Me.fwiTextoFactura)
        Me.TabPagePicAnotaciones.Key = "Anotaciones"
        Me.TabPagePicAnotaciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicAnotaciones.Name = "TabPagePicAnotaciones"
        Me.TabPagePicAnotaciones.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPagePicAnotaciones.Size = New System.Drawing.Size(878, 301)
        Me.TabPagePicAnotaciones.TabStop = True
        Me.TabPagePicAnotaciones.Text = "Anotaciones"
        '
        'fwiTextoFactura
        '
        Me.TryDataBinding(fwiTextoFactura, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.fwiTextoFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTextoFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fwiTextoFactura.Location = New System.Drawing.Point(5, 5)
        Me.fwiTextoFactura.Multiline = True
        Me.fwiTextoFactura.Name = "fwiTextoFactura"
        Me.fwiTextoFactura.Size = New System.Drawing.Size(868, 291)
        Me.fwiTextoFactura.TabIndex = 32
        '
        'TabPageTimbrado
        '
        Me.TabPageTimbrado.Controls.Add(Me.Frame2)
        Me.TabPageTimbrado.Key = "Timbrado"
        Me.TabPageTimbrado.Location = New System.Drawing.Point(1, 21)
        Me.TabPageTimbrado.Name = "TabPageTimbrado"
        Me.TabPageTimbrado.Size = New System.Drawing.Size(878, 301)
        Me.TabPageTimbrado.TabStop = True
        Me.TabPageTimbrado.Text = "Timbrado"
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.txtCertificado)
        Me.Frame2.Controls.Add(Me.lblCertificado)
        Me.Frame2.Controls.Add(Me.clbFechaTimbrado)
        Me.Frame2.Controls.Add(Me.lblFechaTimbrado)
        Me.Frame2.Controls.Add(Me.txtNotas)
        Me.Frame2.Controls.Add(Me.lblNotas)
        Me.Frame2.Controls.Add(Me.txtFolioFiscal)
        Me.Frame2.Controls.Add(Me.lblFolioFiscal)
        Me.Frame2.Controls.Add(Me.txtSelloFiscal)
        Me.Frame2.Controls.Add(Me.lblSelloFiscal)
        Me.Frame2.Location = New System.Drawing.Point(51, 19)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(744, 234)
        Me.Frame2.TabIndex = 0
        Me.Frame2.TabStop = False
        '
        'txtCertificado
        '
        Me.TryDataBinding(txtCertificado, New System.Windows.Forms.Binding("Text", Me, "Certificado", True))
        Me.txtCertificado.DisabledBackColor = System.Drawing.Color.White
        Me.txtCertificado.Location = New System.Drawing.Point(74, 65)
        Me.txtCertificado.Multiline = True
        Me.txtCertificado.Name = "txtCertificado"
        Me.txtCertificado.ReadOnly = True
        Me.txtCertificado.Size = New System.Drawing.Size(664, 120)
        Me.txtCertificado.TabIndex = 10
        '
        'lblCertificado
        '
        Me.lblCertificado.Location = New System.Drawing.Point(0, 69)
        Me.lblCertificado.Name = "lblCertificado"
        Me.lblCertificado.Size = New System.Drawing.Size(69, 13)
        Me.lblCertificado.TabIndex = 11
        Me.lblCertificado.Text = "Certificado"
        '
        'clbFechaTimbrado
        '
        Me.TryDataBinding(clbFechaTimbrado, New System.Windows.Forms.Binding("BindableValue", Me, "FechaTimbrado", True))
        Me.clbFechaTimbrado.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaTimbrado.Location = New System.Drawing.Point(102, 207)
        Me.clbFechaTimbrado.Name = "clbFechaTimbrado"
        Me.clbFechaTimbrado.ReadOnly = True
        Me.clbFechaTimbrado.Size = New System.Drawing.Size(170, 21)
        Me.clbFechaTimbrado.TabIndex = 8
        '
        'lblFechaTimbrado
        '
        Me.lblFechaTimbrado.Location = New System.Drawing.Point(3, 211)
        Me.lblFechaTimbrado.Name = "lblFechaTimbrado"
        Me.lblFechaTimbrado.Size = New System.Drawing.Size(94, 13)
        Me.lblFechaTimbrado.TabIndex = 9
        Me.lblFechaTimbrado.Text = "FechaTimbrado"
        '
        'txtNotas
        '
        Me.TryDataBinding(txtNotas, New System.Windows.Forms.Binding("Text", Me, "Notas", True))
        Me.txtNotas.DisabledBackColor = System.Drawing.Color.White
        Me.txtNotas.Location = New System.Drawing.Point(350, 191)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ReadOnly = True
        Me.txtNotas.Size = New System.Drawing.Size(388, 38)
        Me.txtNotas.TabIndex = 6
        '
        'lblNotas
        '
        Me.lblNotas.Location = New System.Drawing.Point(306, 195)
        Me.lblNotas.Name = "lblNotas"
        Me.lblNotas.Size = New System.Drawing.Size(39, 13)
        Me.lblNotas.TabIndex = 7
        Me.lblNotas.Text = "Notas"
        '
        'txtFolioFiscal
        '
        Me.TryDataBinding(txtFolioFiscal, New System.Windows.Forms.Binding("Text", Me, "FolioFiscal", True))
        Me.txtFolioFiscal.DisabledBackColor = System.Drawing.Color.White
        Me.txtFolioFiscal.Location = New System.Drawing.Point(74, 38)
        Me.txtFolioFiscal.Multiline = True
        Me.txtFolioFiscal.Name = "txtFolioFiscal"
        Me.txtFolioFiscal.ReadOnly = True
        Me.txtFolioFiscal.Size = New System.Drawing.Size(664, 21)
        Me.txtFolioFiscal.TabIndex = 4
        '
        'lblFolioFiscal
        '
        Me.lblFolioFiscal.Location = New System.Drawing.Point(5, 43)
        Me.lblFolioFiscal.Name = "lblFolioFiscal"
        Me.lblFolioFiscal.Size = New System.Drawing.Size(64, 13)
        Me.lblFolioFiscal.TabIndex = 5
        Me.lblFolioFiscal.Text = "FolioFiscal"
        '
        'txtSelloFiscal
        '
        Me.TryDataBinding(txtSelloFiscal, New System.Windows.Forms.Binding("Text", Me, "SelloFiscal", True))
        Me.txtSelloFiscal.DisabledBackColor = System.Drawing.Color.White
        Me.txtSelloFiscal.Location = New System.Drawing.Point(74, 11)
        Me.txtSelloFiscal.Name = "txtSelloFiscal"
        Me.txtSelloFiscal.ReadOnly = True
        Me.txtSelloFiscal.Size = New System.Drawing.Size(664, 21)
        Me.txtSelloFiscal.TabIndex = 2
        '
        'lblSelloFiscal
        '
        Me.lblSelloFiscal.Location = New System.Drawing.Point(5, 15)
        Me.lblSelloFiscal.Name = "lblSelloFiscal"
        Me.lblSelloFiscal.Size = New System.Drawing.Size(66, 13)
        Me.lblSelloFiscal.TabIndex = 3
        Me.lblSelloFiscal.Text = "SelloFiscal"
        '
        'lblTipoFactura
        '
        Me.lblTipoFactura.Location = New System.Drawing.Point(10, 60)
        Me.lblTipoFactura.Name = "lblTipoFactura"
        Me.lblTipoFactura.Size = New System.Drawing.Size(76, 13)
        Me.lblTipoFactura.TabIndex = 129
        Me.lblTipoFactura.Text = "Tipo Factura"
        '
        'FwiTipoFactura
        '
        Me.TryDataBinding(FwiTipoFactura, New System.Windows.Forms.Binding("Value", Me, "TipoFactura", True))
        FwiTipoFactura_DesignTimeLayout.LayoutString = resources.GetString("FwiTipoFactura_DesignTimeLayout.LayoutString")
        Me.FwiTipoFactura.DesignTimeLayout = FwiTipoFactura_DesignTimeLayout
        Me.FwiTipoFactura.DisabledBackColor = System.Drawing.Color.White
        Me.FwiTipoFactura.DisplayMember = "Value"
        Me.FwiTipoFactura.Location = New System.Drawing.Point(10, 77)
        Me.FwiTipoFactura.Name = "FwiTipoFactura"
        Me.FwiTipoFactura.PrimaryDataFields = "TipoFactura"
        Me.FwiTipoFactura.SecondaryDataFields = "Value"
        Me.FwiTipoFactura.SelectedIndex = -1
        Me.FwiTipoFactura.SelectedItem = Nothing
        Me.FwiTipoFactura.Size = New System.Drawing.Size(120, 21)
        Me.FwiTipoFactura.TabIndex = 34
        '
        'chkEDI
        '
        Me.TryDataBinding(chkEDI, New System.Windows.Forms.Binding("BindableValue", Me, "EDI", True))
        Me.chkEDI.Location = New System.Drawing.Point(11, 149)
        Me.chkEDI.Name = "chkEDI"
        Me.chkEDI.Size = New System.Drawing.Size(47, 21)
        Me.chkEDI.TabIndex = 47
        Me.chkEDI.Text = "EDI"
        '
        'fwiIdDireccion
        '
        Me.TryDataBinding(fwiIdDireccion, New System.Windows.Forms.Binding("Text", Me, "IDDireccion", True))
        Me.fwiIdDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdDireccion.Location = New System.Drawing.Point(496, -28)
        Me.fwiIdDireccion.Name = "fwiIdDireccion"
        Me.fwiIdDireccion.Size = New System.Drawing.Size(47, 21)
        Me.fwiIdDireccion.TabIndex = 67
        '
        'PicCabecera
        '
        Me.PicCabecera.Controls.Add(Me.pnlClienteImportes)
        Me.PicCabecera.Controls.Add(Me.fraContabilizada)
        Me.PicCabecera.Controls.Add(Me.FraFactura)
        Me.PicCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PicCabecera.Name = "PicCabecera"
        Me.PicCabecera.Size = New System.Drawing.Size(957, 218)
        Me.PicCabecera.TabIndex = 1
        '
        'pnlClienteImportes
        '
        Me.pnlClienteImportes.Controls.Add(Me.ulblDescClienteEnvio)
        Me.pnlClienteImportes.Controls.Add(Me.lblClienteEnvio)
        Me.pnlClienteImportes.Controls.Add(Me.advClienteEnvio)
        Me.pnlClienteImportes.Controls.Add(Me.fraImportesFactura)
        Me.pnlClienteImportes.Controls.Add(Me.fraCliente)
        Me.pnlClienteImportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlClienteImportes.Location = New System.Drawing.Point(123, 0)
        Me.pnlClienteImportes.Name = "pnlClienteImportes"
        Me.pnlClienteImportes.Size = New System.Drawing.Size(694, 218)
        Me.pnlClienteImportes.TabIndex = 168
        '
        'ulblDescClienteEnvio
        '
        Me.TryDataBinding(ulblDescClienteEnvio, New System.Windows.Forms.Binding("Text", Me, "DescClienteVarios", True))
        Me.ulblDescClienteEnvio.Location = New System.Drawing.Point(201, 190)
        Me.ulblDescClienteEnvio.Name = "ulblDescClienteEnvio"
        Me.ulblDescClienteEnvio.Size = New System.Drawing.Size(192, 23)
        Me.ulblDescClienteEnvio.TabIndex = 192
        Me.ulblDescClienteEnvio.UseMnemonic = False
        Me.ulblDescClienteEnvio.Visible = False
        '
        'lblClienteEnvio
        '
        Me.lblClienteEnvio.Location = New System.Drawing.Point(5, 195)
        Me.lblClienteEnvio.Name = "lblClienteEnvio"
        Me.lblClienteEnvio.Size = New System.Drawing.Size(82, 13)
        Me.lblClienteEnvio.TabIndex = 191
        Me.lblClienteEnvio.Tag = ""
        Me.lblClienteEnvio.Text = "Cliente Envío"
        Me.lblClienteEnvio.Visible = False
        '
        'advClienteEnvio
        '
        Me.advClienteEnvio.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCliente", ulblDescClienteEnvio)})
        Me.TryDataBinding(advClienteEnvio, New System.Windows.Forms.Binding("Text", Me, "idClienteVarios", True))
        Me.advClienteEnvio.DisabledBackColor = System.Drawing.Color.White
        Me.advClienteEnvio.EntityName = "Cliente"
        Me.advClienteEnvio.Location = New System.Drawing.Point(84, 190)
        Me.advClienteEnvio.Name = "advClienteEnvio"
        Me.advClienteEnvio.PrimaryDataFields = "IDClienteVarios"
        Me.advClienteEnvio.SecondaryDataFields = "IDCliente"
        Me.advClienteEnvio.Size = New System.Drawing.Size(115, 23)
        Me.advClienteEnvio.TabIndex = 190
        Me.advClienteEnvio.ViewName = "tbMaestroCliente"
        Me.advClienteEnvio.Visible = False
        '
        'fraImportesFactura
        '
        Me.fraImportesFactura.Controls.Add(Me.lblntbImpRetencion)
        Me.fraImportesFactura.Controls.Add(Me.ntbRetencion)
        Me.fraImportesFactura.Controls.Add(Me.nbxImpuestos)
        Me.fraImportesFactura.Controls.Add(Me.lblImpuestos)
        Me.fraImportesFactura.Controls.Add(Me.ulAbreviaturaMoneda)
        Me.fraImportesFactura.Controls.Add(Me.txtTotalVtos)
        Me.fraImportesFactura.Controls.Add(Me.fwiTotal)
        Me.fraImportesFactura.Controls.Add(Me.lblTotal)
        Me.fraImportesFactura.Controls.Add(Me.lblfwiTotalBaseImp)
        Me.fraImportesFactura.Controls.Add(Me.lblTotalImpVtos)
        Me.fraImportesFactura.Controls.Add(Me.lblTotalIva)
        Me.fraImportesFactura.Controls.Add(Me.fwiTotalBaseImp)
        Me.fraImportesFactura.Controls.Add(Me.fwiTotalIva)
        Me.fraImportesFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraImportesFactura.Location = New System.Drawing.Point(0, 133)
        Me.fraImportesFactura.Name = "fraImportesFactura"
        Me.fraImportesFactura.Size = New System.Drawing.Size(694, 57)
        Me.fraImportesFactura.TabIndex = 166
        Me.fraImportesFactura.TabStop = False
        Me.fraImportesFactura.Text = "Importes"
        '
        'lblntbImpRetencion
        '
        Me.lblntbImpRetencion.Location = New System.Drawing.Point(212, 14)
        Me.lblntbImpRetencion.Name = "lblntbImpRetencion"
        Me.lblntbImpRetencion.Size = New System.Drawing.Size(76, 13)
        Me.lblntbImpRetencion.TabIndex = 173
        Me.lblntbImpRetencion.Tag = ""
        Me.lblntbImpRetencion.Text = "Retenciones"
        '
        'ntbRetencion
        '
        Me.TryDataBinding(ntbRetencion, New System.Windows.Forms.Binding("Value", Me, "ImpRetencion", True))
        Me.ntbRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.ntbRetencion.Enabled = False
        Me.ntbRetencion.Location = New System.Drawing.Point(290, 10)
        Me.ntbRetencion.Name = "ntbRetencion"
        Me.ntbRetencion.Size = New System.Drawing.Size(99, 21)
        Me.ntbRetencion.TabIndex = 172
        '
        'nbxImpuestos
        '
        Me.TryDataBinding(nbxImpuestos, New System.Windows.Forms.Binding("Value", Me, "ImpImpuestos", True))
        Me.nbxImpuestos.DisabledBackColor = System.Drawing.Color.White
        Me.nbxImpuestos.Enabled = False
        Me.nbxImpuestos.Location = New System.Drawing.Point(290, 33)
        Me.nbxImpuestos.Name = "nbxImpuestos"
        Me.nbxImpuestos.Size = New System.Drawing.Size(99, 21)
        Me.nbxImpuestos.TabIndex = 171
        '
        'lblImpuestos
        '
        Me.lblImpuestos.Location = New System.Drawing.Point(212, 37)
        Me.lblImpuestos.Name = "lblImpuestos"
        Me.lblImpuestos.Size = New System.Drawing.Size(67, 13)
        Me.lblImpuestos.TabIndex = 170
        Me.lblImpuestos.Tag = "IdRec=5045;"
        Me.lblImpuestos.Text = "Impuestos"
        '
        'ulAbreviaturaMoneda
        '
        Me.ulAbreviaturaMoneda.AutoSize = False
        Me.TryDataBinding(ulAbreviaturaMoneda, New System.Windows.Forms.Binding("Text", Me.fwiIdMoneda, "Abreviatura", True))
        Me.ulAbreviaturaMoneda.Location = New System.Drawing.Point(584, 14)
        Me.ulAbreviaturaMoneda.Name = "ulAbreviaturaMoneda"
        Me.ulAbreviaturaMoneda.Size = New System.Drawing.Size(27, 13)
        Me.ulAbreviaturaMoneda.TabIndex = 165
        Me.ulAbreviaturaMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalVtos
        '
        Me.txtTotalVtos.AutoSize = False
        Me.txtTotalVtos.Location = New System.Drawing.Point(509, 14)
        Me.txtTotalVtos.Name = "txtTotalVtos"
        Me.txtTotalVtos.Size = New System.Drawing.Size(72, 13)
        Me.txtTotalVtos.TabIndex = 164
        Me.txtTotalVtos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fwiTotal
        '
        Me.TryDataBinding(fwiTotal, New System.Windows.Forms.Binding("Value", Me, "ImpTotal", True))
        Me.fwiTotal.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTotal.Enabled = False
        Me.fwiTotal.Location = New System.Drawing.Point(475, 33)
        Me.fwiTotal.Name = "fwiTotal"
        Me.fwiTotal.Size = New System.Drawing.Size(83, 21)
        Me.fwiTotal.TabIndex = 124
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(437, 37)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 128
        Me.lblTotal.Tag = "IdRec=4664;"
        Me.lblTotal.Text = "Total"
        '
        'lblfwiTotalBaseImp
        '
        Me.lblfwiTotalBaseImp.Location = New System.Drawing.Point(5, 14)
        Me.lblfwiTotalBaseImp.Name = "lblfwiTotalBaseImp"
        Me.lblfwiTotalBaseImp.Size = New System.Drawing.Size(96, 13)
        Me.lblfwiTotalBaseImp.TabIndex = 127
        Me.lblfwiTotalBaseImp.Tag = "IdRec=5044;"
        Me.lblfwiTotalBaseImp.Text = "Base Imponible"
        '
        'lblTotalImpVtos
        '
        Me.lblTotalImpVtos.Location = New System.Drawing.Point(437, 14)
        Me.lblTotalImpVtos.Name = "lblTotalImpVtos"
        Me.lblTotalImpVtos.Size = New System.Drawing.Size(67, 13)
        Me.lblTotalImpVtos.TabIndex = 163
        Me.lblTotalImpVtos.Tag = ""
        Me.lblTotalImpVtos.Text = "Total Vtos."
        '
        'lblTotalIva
        '
        Me.lblTotalIva.Location = New System.Drawing.Point(5, 37)
        Me.lblTotalIva.Name = "lblTotalIva"
        Me.lblTotalIva.Size = New System.Drawing.Size(28, 13)
        Me.lblTotalIva.TabIndex = 8
        Me.lblTotalIva.Tag = ""
        Me.lblTotalIva.Text = "IVA"
        '
        'fwiTotalBaseImp
        '
        Me.TryDataBinding(fwiTotalBaseImp, New System.Windows.Forms.Binding("Value", Me, "BaseImponible", True))
        Me.fwiTotalBaseImp.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTotalBaseImp.Enabled = False
        Me.fwiTotalBaseImp.Location = New System.Drawing.Point(104, 10)
        Me.fwiTotalBaseImp.Name = "fwiTotalBaseImp"
        Me.fwiTotalBaseImp.Size = New System.Drawing.Size(71, 21)
        Me.fwiTotalBaseImp.TabIndex = 125
        '
        'fwiTotalIva
        '
        Me.TryDataBinding(fwiTotalIva, New System.Windows.Forms.Binding("Value", Me, "ImpIva", True))
        Me.fwiTotalIva.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTotalIva.Enabled = False
        Me.fwiTotalIva.Location = New System.Drawing.Point(104, 33)
        Me.fwiTotalIva.Name = "fwiTotalIva"
        Me.fwiTotalIva.Size = New System.Drawing.Size(57, 21)
        Me.fwiTotalIva.TabIndex = 126
        '
        'fraCliente
        '
        Me.fraCliente.Controls.Add(Me.chkEnviadoEmail)
        Me.fraCliente.Controls.Add(Me.txtFechaEnvioEmail)
        Me.fraCliente.Controls.Add(Me.ulDescCliente)
        Me.fraCliente.Controls.Add(Me.lblDireccion)
        Me.fraCliente.Controls.Add(Me.lblTelefono)
        Me.fraCliente.Controls.Add(Me.lblRazonSocial)
        Me.fraCliente.Controls.Add(Me.fwiProvincia)
        Me.fraCliente.Controls.Add(Me.FwiIdPais)
        Me.fraCliente.Controls.Add(Me.lblCliente)
        Me.fraCliente.Controls.Add(Me.lblPais)
        Me.fraCliente.Controls.Add(Me.fwiPoblacion)
        Me.fraCliente.Controls.Add(Me.AdvIDCliente)
        Me.fraCliente.Controls.Add(Me.fwiCodPostal)
        Me.fraCliente.Controls.Add(Me.lblCIF)
        Me.fraCliente.Controls.Add(Me.fwiCIF)
        Me.fraCliente.Controls.Add(Me.fwiDir)
        Me.fraCliente.Controls.Add(Me.fwiRazonSocial)
        Me.fraCliente.Controls.Add(Me.fwiFax)
        Me.fraCliente.Controls.Add(Me.fwiTel)
        Me.fraCliente.Controls.Add(Me.lblFax)
        Me.fraCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraCliente.Location = New System.Drawing.Point(0, 0)
        Me.fraCliente.Name = "fraCliente"
        Me.fraCliente.Size = New System.Drawing.Size(694, 133)
        Me.fraCliente.TabIndex = 165
        Me.fraCliente.TabStop = False
        '
        'chkEnviadoEmail
        '
        Me.chkEnviadoEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(chkEnviadoEmail, New System.Windows.Forms.Binding("BindableValue", Me, "EnviadoEmail", True))
        Me.chkEnviadoEmail.Enabled = False
        Me.chkEnviadoEmail.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.chkEnviadoEmail.Location = New System.Drawing.Point(451, 110)
        Me.chkEnviadoEmail.Name = "chkEnviadoEmail"
        Me.chkEnviadoEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkEnviadoEmail.Size = New System.Drawing.Size(98, 17)
        Me.chkEnviadoEmail.TabIndex = 188
        Me.chkEnviadoEmail.Text = "Email Enviado"
        Me.chkEnviadoEmail.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'txtFechaEnvioEmail
        '
        Me.txtFechaEnvioEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtFechaEnvioEmail, New System.Windows.Forms.Binding("Text", Me, "FechaEnvioEmail", True))
        Me.txtFechaEnvioEmail.DisabledBackColor = System.Drawing.Color.White
        Me.txtFechaEnvioEmail.Enabled = False
        Me.txtFechaEnvioEmail.Location = New System.Drawing.Point(552, 109)
        Me.txtFechaEnvioEmail.Name = "txtFechaEnvioEmail"
        Me.txtFechaEnvioEmail.ReadOnly = True
        Me.txtFechaEnvioEmail.Size = New System.Drawing.Size(134, 21)
        Me.txtFechaEnvioEmail.TabIndex = 187
        Me.txtFechaEnvioEmail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'ulDescCliente
        '
        Me.TryDataBinding(ulDescCliente, New System.Windows.Forms.Binding("Text", Me.AdvIDCliente, "DescCliente", True))
        Me.ulDescCliente.Location = New System.Drawing.Point(206, 11)
        Me.ulDescCliente.Name = "ulDescCliente"
        Me.ulDescCliente.Size = New System.Drawing.Size(193, 21)
        Me.ulDescCliente.TabIndex = 130
        Me.ulDescCliente.UseMnemonic = False
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(5, 65)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccion.TabIndex = 137
        Me.lblDireccion.Tag = ""
        Me.lblDireccion.Text = "Dirección"
        '
        'lblTelefono
        '
        Me.lblTelefono.Location = New System.Drawing.Point(5, 112)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(55, 13)
        Me.lblTelefono.TabIndex = 135
        Me.lblTelefono.Tag = ""
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.Location = New System.Drawing.Point(5, 40)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(80, 13)
        Me.lblRazonSocial.TabIndex = 134
        Me.lblRazonSocial.Tag = ""
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'fwiProvincia
        '
        Me.TryDataBinding(fwiProvincia, New System.Windows.Forms.Binding("Text", Me, "Provincia", True))
        Me.fwiProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.fwiProvincia.Location = New System.Drawing.Point(331, 85)
        Me.fwiProvincia.Name = "fwiProvincia"
        Me.fwiProvincia.Size = New System.Drawing.Size(151, 21)
        Me.fwiProvincia.TabIndex = 12
        '
        'FwiIdPais
        '
        Me.TryDataBinding(FwiIdPais, New System.Windows.Forms.Binding("Text", Me, "IDPais", True))
        Me.FwiIdPais.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIdPais.EntityName = "Pais"
        Me.FwiIdPais.Location = New System.Drawing.Point(520, 85)
        Me.FwiIdPais.Name = "FwiIdPais"
        Me.FwiIdPais.PrimaryDataFields = "IDPais"
        Me.FwiIdPais.SecondaryDataFields = "IDPais"
        Me.FwiIdPais.Size = New System.Drawing.Size(89, 23)
        Me.FwiIdPais.TabIndex = 13
        Me.FwiIdPais.ViewName = "tbMaestroPais"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(5, 15)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 129
        Me.lblCliente.Tag = ""
        Me.lblCliente.Text = "Cliente"
        '
        'lblPais
        '
        Me.lblPais.Location = New System.Drawing.Point(486, 90)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(30, 13)
        Me.lblPais.TabIndex = 141
        Me.lblPais.Tag = ""
        Me.lblPais.Text = "País"
        '
        'fwiPoblacion
        '
        Me.TryDataBinding(fwiPoblacion, New System.Windows.Forms.Binding("Text", Me, "Poblacion", True))
        Me.fwiPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiPoblacion.Location = New System.Drawing.Point(85, 85)
        Me.fwiPoblacion.Name = "fwiPoblacion"
        Me.fwiPoblacion.Size = New System.Drawing.Size(243, 21)
        Me.fwiPoblacion.TabIndex = 10
        '
        'AdvIDCliente
        '
        Me.TryDataBinding(AdvIDCliente, New System.Windows.Forms.Binding("Text", Me, "IDCliente", True))
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(85, 11)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.PrimaryDataFields = "IDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(115, 23)
        Me.AdvIDCliente.TabIndex = 4
        '
        'fwiCodPostal
        '
        Me.TryDataBinding(fwiCodPostal, New System.Windows.Forms.Binding("Text", Me, "CodPostal", True))
        Me.fwiCodPostal.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCodPostal.Location = New System.Drawing.Point(546, 61)
        Me.fwiCodPostal.Name = "fwiCodPostal"
        Me.fwiCodPostal.Size = New System.Drawing.Size(63, 21)
        Me.fwiCodPostal.TabIndex = 9
        '
        'lblCIF
        '
        Me.lblCIF.Location = New System.Drawing.Point(432, 16)
        Me.lblCIF.Name = "lblCIF"
        Me.lblCIF.Size = New System.Drawing.Size(72, 13)
        Me.lblCIF.TabIndex = 131
        Me.lblCIF.Tag = ""
        Me.lblCIF.Text = "Documento"
        '
        'fwiCIF
        '
        Me.TryDataBinding(fwiCIF, New System.Windows.Forms.Binding("Text", Me, "CifCliente", True))
        Me.fwiCIF.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCIF.Location = New System.Drawing.Point(509, 13)
        Me.fwiCIF.Name = "fwiCIF"
        Me.fwiCIF.Size = New System.Drawing.Size(100, 21)
        Me.fwiCIF.TabIndex = 5
        '
        'fwiDir
        '
        Me.TryDataBinding(fwiDir, New System.Windows.Forms.Binding("Text", Me, "Direccion", True))
        Me.fwiDir.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDir.Location = New System.Drawing.Point(85, 61)
        Me.fwiDir.Name = "fwiDir"
        Me.fwiDir.Size = New System.Drawing.Size(458, 21)
        Me.fwiDir.TabIndex = 7
        '
        'fwiRazonSocial
        '
        Me.TryDataBinding(fwiRazonSocial, New System.Windows.Forms.Binding("Text", Me, "RazonSocial", True))
        Me.fwiRazonSocial.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRazonSocial.Location = New System.Drawing.Point(85, 37)
        Me.fwiRazonSocial.Name = "fwiRazonSocial"
        Me.fwiRazonSocial.Size = New System.Drawing.Size(524, 21)
        Me.fwiRazonSocial.TabIndex = 6
        '
        'fwiFax
        '
        Me.TryDataBinding(fwiFax, New System.Windows.Forms.Binding("Text", Me, "Fax", True))
        Me.fwiFax.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFax.Enabled = False
        Me.fwiFax.Location = New System.Drawing.Point(246, 109)
        Me.fwiFax.Name = "fwiFax"
        Me.fwiFax.Size = New System.Drawing.Size(107, 21)
        Me.fwiFax.TabIndex = 11
        '
        'fwiTel
        '
        Me.TryDataBinding(fwiTel, New System.Windows.Forms.Binding("Text", Me, "Telefono", True))
        Me.fwiTel.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTel.Enabled = False
        Me.fwiTel.Location = New System.Drawing.Point(85, 109)
        Me.fwiTel.Name = "fwiTel"
        Me.fwiTel.Size = New System.Drawing.Size(107, 21)
        Me.fwiTel.TabIndex = 8
        '
        'lblFax
        '
        Me.lblFax.Location = New System.Drawing.Point(214, 112)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(26, 13)
        Me.lblFax.TabIndex = 136
        Me.lblFax.Tag = ""
        Me.lblFax.Text = "Fax"
        '
        'fraContabilizada
        '
        Me.fraContabilizada.Controls.Add(Me.txtFolioFiscal1)
        Me.fraContabilizada.Controls.Add(Me.lblFolioFiscal1)
        Me.fraContabilizada.Controls.Add(Me.PnlRiesgo)
        Me.fraContabilizada.Controls.Add(Me.pnlEntregaCuenta)
        Me.fraContabilizada.Controls.Add(Me.LblSelloContabilizado)
        Me.fraContabilizada.Controls.Add(Me.chkEDI)
        Me.fraContabilizada.Controls.Add(Me.AdvObra)
        Me.fraContabilizada.Controls.Add(Me.lblNObra)
        Me.fraContabilizada.Controls.Add(Me.FwiTipoFactura)
        Me.fraContabilizada.Controls.Add(Me.lblTipoFactura)
        Me.fraContabilizada.Dock = System.Windows.Forms.DockStyle.Right
        Me.fraContabilizada.Location = New System.Drawing.Point(817, 0)
        Me.fraContabilizada.Name = "fraContabilizada"
        Me.fraContabilizada.Size = New System.Drawing.Size(140, 218)
        Me.fraContabilizada.TabIndex = 167
        Me.fraContabilizada.TabStop = False
        '
        'txtFolioFiscal1
        '
        Me.TryDataBinding(txtFolioFiscal1, New System.Windows.Forms.Binding("Text", Me, "FolioFiscal", True))
        Me.txtFolioFiscal1.DisabledBackColor = System.Drawing.Color.White
        Me.txtFolioFiscal1.ForeColor = System.Drawing.Color.Blue
        Me.txtFolioFiscal1.Location = New System.Drawing.Point(3, 191)
        Me.txtFolioFiscal1.Name = "txtFolioFiscal1"
        Me.txtFolioFiscal1.ReadOnly = True
        Me.txtFolioFiscal1.Size = New System.Drawing.Size(133, 21)
        Me.txtFolioFiscal1.TabIndex = 162
        '
        'lblFolioFiscal1
        '
        Me.lblFolioFiscal1.Location = New System.Drawing.Point(33, 174)
        Me.lblFolioFiscal1.Name = "lblFolioFiscal1"
        Me.lblFolioFiscal1.Size = New System.Drawing.Size(64, 13)
        Me.lblFolioFiscal1.TabIndex = 163
        Me.lblFolioFiscal1.Text = "FolioFiscal"
        '
        'PnlRiesgo
        '
        Me.PnlRiesgo.BackColor = System.Drawing.Color.Transparent
        Me.PnlRiesgo.ErrorImage = CType(resources.GetObject("PnlRiesgo.ErrorImage"), System.Drawing.Image)
        Me.PnlRiesgo.Image = CType(resources.GetObject("PnlRiesgo.Image"), System.Drawing.Image)
        Me.PnlRiesgo.Location = New System.Drawing.Point(63, 29)
        Me.PnlRiesgo.Name = "PnlRiesgo"
        Me.PnlRiesgo.Size = New System.Drawing.Size(28, 28)
        Me.PnlRiesgo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PnlRiesgo.TabIndex = 161
        Me.PnlRiesgo.TabStop = False
        Me.ToolTipMensajes.SetToolTip(Me.PnlRiesgo, "Este Cliente ha superado el Riesgo")
        '
        'pnlEntregaCuenta
        '
        Me.pnlEntregaCuenta.BackColor = System.Drawing.Color.Transparent
        Me.pnlEntregaCuenta.ErrorImage = CType(resources.GetObject("pnlEntregaCuenta.ErrorImage"), System.Drawing.Image)
        Me.pnlEntregaCuenta.Image = CType(resources.GetObject("pnlEntregaCuenta.Image"), System.Drawing.Image)
        Me.pnlEntregaCuenta.Location = New System.Drawing.Point(29, 29)
        Me.pnlEntregaCuenta.Name = "pnlEntregaCuenta"
        Me.pnlEntregaCuenta.Size = New System.Drawing.Size(28, 28)
        Me.pnlEntregaCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pnlEntregaCuenta.TabIndex = 160
        Me.pnlEntregaCuenta.TabStop = False
        Me.ToolTipMensajes.SetToolTip(Me.pnlEntregaCuenta, "Este Cliente tiene Entregas a Cuenta Pendientes")
        '
        'LblSelloContabilizado
        '
        Me.LblSelloContabilizado.Location = New System.Drawing.Point(10, 13)
        Me.LblSelloContabilizado.Name = "LblSelloContabilizado"
        Me.LblSelloContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.LblSelloContabilizado.TabIndex = 146
        Me.LblSelloContabilizado.Tag = ""
        Me.LblSelloContabilizado.Text = "Contabilizada"
        Me.LblSelloContabilizado.Visible = False
        '
        'AdvObra
        '
        Me.TryDataBinding(AdvObra, New System.Windows.Forms.Binding("Value", Me, "IDObra", True))
        Me.AdvObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObra.DisplayField = "NObra"
        Me.AdvObra.EntityName = "Obracabecera"
        Me.AdvObra.Location = New System.Drawing.Point(10, 119)
        Me.AdvObra.Name = "AdvObra"
        Me.AdvObra.PrimaryDataFields = "IDObra"
        Me.AdvObra.SecondaryDataFields = "IDObra"
        Me.AdvObra.Size = New System.Drawing.Size(123, 23)
        Me.AdvObra.TabIndex = 14
        '
        'lblNObra
        '
        Me.lblNObra.Location = New System.Drawing.Point(10, 103)
        Me.lblNObra.Name = "lblNObra"
        Me.lblNObra.Size = New System.Drawing.Size(57, 13)
        Me.lblNObra.TabIndex = 159
        Me.lblNObra.Tag = ""
        Me.lblNObra.Text = "Proyecto"
        '
        'FraFactura
        '
        Me.FraFactura.Controls.Add(Me.FwiIDContador)
        Me.FraFactura.Controls.Add(Me.lblFecVencimiento)
        Me.FraFactura.Controls.Add(Me.lblFecFactura)
        Me.FraFactura.Controls.Add(Me.lblNFactura)
        Me.FraFactura.Controls.Add(Me.fwiFecFactura)
        Me.FraFactura.Controls.Add(Me.fwiNFactura)
        Me.FraFactura.Controls.Add(Me.lbIDContador)
        Me.FraFactura.Controls.Add(Me.fwiFecVencimiento)
        Me.FraFactura.Dock = System.Windows.Forms.DockStyle.Left
        Me.FraFactura.Location = New System.Drawing.Point(0, 0)
        Me.FraFactura.Name = "FraFactura"
        Me.FraFactura.Size = New System.Drawing.Size(123, 218)
        Me.FraFactura.TabIndex = 164
        Me.FraFactura.TabStop = False
        '
        'FwiIDContador
        '
        Me.TryDataBinding(FwiIDContador, New System.Windows.Forms.Binding("Text", Me, "IDContador", True))
        Me.FwiIDContador.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIDContador.Enabled = False
        Me.FwiIDContador.Location = New System.Drawing.Point(8, 77)
        Me.FwiIDContador.Name = "FwiIDContador"
        Me.FwiIDContador.Size = New System.Drawing.Size(105, 21)
        Me.FwiIDContador.TabIndex = 1
        '
        'lblFecVencimiento
        '
        Me.lblFecVencimiento.Location = New System.Drawing.Point(8, 148)
        Me.lblFecVencimiento.Name = "lblFecVencimiento"
        Me.lblFecVencimiento.Size = New System.Drawing.Size(113, 13)
        Me.lblFecVencimiento.TabIndex = 132
        Me.lblFecVencimiento.Tag = "IdRec=5088;"
        Me.lblFecVencimiento.Text = "Fecha Vencimiento"
        '
        'lblFecFactura
        '
        Me.lblFecFactura.Location = New System.Drawing.Point(8, 103)
        Me.lblFecFactura.Name = "lblFecFactura"
        Me.lblFecFactura.Size = New System.Drawing.Size(85, 13)
        Me.lblFecFactura.TabIndex = 133
        Me.lblFecFactura.Tag = "IdRec=5043;"
        Me.lblFecFactura.Text = "Fecha Factura"
        '
        'lblNFactura
        '
        Me.lblNFactura.Location = New System.Drawing.Point(8, 14)
        Me.lblNFactura.Name = "lblNFactura"
        Me.lblNFactura.Size = New System.Drawing.Size(82, 13)
        Me.lblNFactura.TabIndex = 140
        Me.lblNFactura.Tag = "IdRec=4763;"
        Me.lblNFactura.Text = "Núm. Factura"
        '
        'fwiFecFactura
        '
        Me.TryDataBinding(fwiFecFactura, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFactura", True))
        Me.fwiFecFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFecFactura.Location = New System.Drawing.Point(8, 120)
        Me.fwiFecFactura.Name = "fwiFecFactura"
        Me.fwiFecFactura.Size = New System.Drawing.Size(105, 21)
        Me.fwiFecFactura.TabIndex = 2
        '
        'fwiNFactura
        '
        Me.TryDataBinding(fwiNFactura, New System.Windows.Forms.Binding("Text", Me, "NFactura", True))
        Me.fwiNFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNFactura.Location = New System.Drawing.Point(8, 32)
        Me.fwiNFactura.Name = "fwiNFactura"
        Me.fwiNFactura.ReadOnly = True
        Me.fwiNFactura.Size = New System.Drawing.Size(105, 23)
        Me.fwiNFactura.TabIndex = 0
        '
        'lbIDContador
        '
        Me.lbIDContador.Location = New System.Drawing.Point(8, 59)
        Me.lbIDContador.Name = "lbIDContador"
        Me.lbIDContador.Size = New System.Drawing.Size(60, 13)
        Me.lbIDContador.TabIndex = 0
        Me.lbIDContador.Tag = "IdRec=4809;"
        Me.lbIDContador.Text = "Contador"
        '
        'fwiFecVencimiento
        '
        Me.TryDataBinding(fwiFecVencimiento, New System.Windows.Forms.Binding("BindableValue", Me, "FechaVencimiento", True))
        Me.fwiFecVencimiento.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFecVencimiento.Enabled = False
        Me.fwiFecVencimiento.Location = New System.Drawing.Point(8, 165)
        Me.fwiFecVencimiento.Name = "fwiFecVencimiento"
        Me.fwiFecVencimiento.Size = New System.Drawing.Size(105, 21)
        Me.fwiFecVencimiento.TabIndex = 3
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 300
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'BackgroundWorker1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'MntoFacturaVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(965, 614)
        Me.CreateTransaction = True
        Me.EntityName = "FacturaVentaCabecera"
        Me.FindTextField = "NFactura"
        Me.LastUsedDescFields = "NFactura"
        Me.Name = "MntoFacturaVenta"
        Me.NavigationFields = "FechaFactura;NFactura"
        Me.ShowInTaskbar = True
        Me.ViewName = "FrmMntoFacturaVenta"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.TabFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFacturas.ResumeLayout(False)
        Me.TabPageLineas.ResumeLayout(False)
        CType(Me.jngLineaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.TabPageBasesIVA.ResumeLayout(False)
        CType(Me.jngBaseImponible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInsercionManualBaseImponible.ResumeLayout(False)
        Me.TabPageVencimientos.ResumeLayout(False)
        CType(Me.jngVencimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVencimientoManual.ResumeLayout(False)
        Me.TabPageDatosEconomicos.ResumeLayout(False)
        Me.pnlRetencionGarantia.ResumeLayout(False)
        Me.FraSEPA.ResumeLayout(False)
        Me.FraSEPA.PerformLayout()
        Me.fraGestorCobro.ResumeLayout(False)
        Me.fraGestorCobro.PerformLayout()
        Me.fraDocumentos.ResumeLayout(False)
        Me.fraDocumentos.PerformLayout()
        Me.FraRetencion.ResumeLayout(False)
        Me.FraRetencion.PerformLayout()
        CType(Me.cbxTipoRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopDatosFinancieros.ResumeLayout(False)
        Me.FraContabilidad.ResumeLayout(False)
        Me.FraContabilidad.PerformLayout()
        CType(Me.fwiTipoAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraCondicionesEconomicas.ResumeLayout(False)
        Me.fraCondicionesEconomicas.PerformLayout()
        Me.FraMoneda.ResumeLayout(False)
        Me.FraMoneda.PerformLayout()
        Me.FraMonedasInternas.ResumeLayout(False)
        Me.FraMonedasInternas.PerformLayout()
        Me.TabPageImporteMonedas.ResumeLayout(False)
        Me.TabPageImporteMonedas.PerformLayout()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraImporteMonedas.ResumeLayout(False)
        Me.FraImporteMonedas.PerformLayout()
        CType(Me.Line19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageTotales.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.FraPuntoVerde.ResumeLayout(False)
        Me.FraPuntoVerde.PerformLayout()
        Me.FraRetenciones.ResumeLayout(False)
        Me.FraRetenciones.PerformLayout()
        Me.FraMonedaFactura.ResumeLayout(False)
        Me.FraMonedaFactura.PerformLayout()
        Me.FraCalculoFactura.ResumeLayout(False)
        Me.FraCalculoFactura.PerformLayout()
        CType(Me.Line11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSeguimiento.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FrmAdmonPublica.ResumeLayout(False)
        Me.FrmAdmonPublica.PerformLayout()
        Me.fraDireccionEnvioFactura.ResumeLayout(False)
        Me.fraDireccionEnvioFactura.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.fraCentros.ResumeLayout(False)
        Me.fraCentros.PerformLayout()
        CType(Me.fwiCGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbCentroCoste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraEDI.ResumeLayout(False)
        Me.FraClienteInicial.ResumeLayout(False)
        Me.FraClienteInicial.PerformLayout()
        Me.TabPageDeclaraciones.ResumeLayout(False)
        Me.fraEntidadAseguradora.ResumeLayout(False)
        Me.fraEntidadAseguradora.PerformLayout()
        CType(Me.cboMotivoNoAsegurado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraClaveIntracomunitaria.ResumeLayout(False)
        Me.fraClaveIntracomunitaria.PerformLayout()
        CType(Me.CmbTipoOperIntra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraClaveOperacion.ResumeLayout(False)
        Me.fraClaveOperacion.PerformLayout()
        CType(Me.cbxClaveOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDeclaracionesIva.ResumeLayout(False)
        Me.fraDeclaracionesIva.PerformLayout()
        Me.TabPageConceptos.ResumeLayout(False)
        CType(Me.jngConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicAnotaciones.ResumeLayout(False)
        Me.TabPagePicAnotaciones.PerformLayout()
        Me.TabPageTimbrado.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.FwiTipoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PicCabecera.ResumeLayout(False)
        Me.pnlClienteImportes.ResumeLayout(False)
        Me.pnlClienteImportes.PerformLayout()
        Me.fraImportesFactura.ResumeLayout(False)
        Me.fraImportesFactura.PerformLayout()
        Me.fraCliente.ResumeLayout(False)
        Me.fraCliente.PerformLayout()
        Me.fraContabilizada.ResumeLayout(False)
        Me.fraContabilizada.PerformLayout()
        CType(Me.PnlRiesgo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlEntregaCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraFactura.ResumeLayout(False)
        Me.FraFactura.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Delegate Sub GenerarFirmarEnviarFacturaPDF(ByVal DtDatos As DataTable, ByVal StrCampoPrimaryKey As String, ByVal StrCampoMail As String, ByVal StrCampoFactura As String, ByVal StrCampoFacturaElec As String, ByVal IntOpcion As Integer, ByVal AliasInforme As String)
    Protected Delegate Sub GenerarFirmarEnviarFacturaXML(ByVal DtDatos As DataTable, ByVal StrCampoPrimaryKey As String, ByVal StrCampoMail As String, ByVal StrCampoFactura As String, ByVal StrCampoFacturaElec As String, ByVal IntOpcion As Integer)

    Protected Const cnABRIRPEDIDOVENTA As String = "Abrir Pedido Venta"
    Protected Const cnABRIRALBARANVENTA As String = "Abrir Albarán Venta"
    Protected Const cnABRIROFERTA As String = "Abrir Oferta"
    Protected Const cnABRIROBRA As String = "Abrir Proyecto"
    Protected Const cnABRIROT As String = "Abrir Orden Trabajo"
    Protected Const cnABRIRPROMOCION As String = "Abrir Promoción"
    Protected Const cnABRIRALQUILER As String = "Abrir Alquiler"
    Protected Const cnABRIRALBARANRETORNO As String = "Abrir Albarán de Retorno"
    Protected Const cnABRIRORDENSERVICIO As String = "Abrir Orden Servicio"
    Protected Const cnINFOCHEQUE As String = "Ver/Modificar Información del Cheque"
    Protected Const cnINFOTARJETA As String = "Ver/Modificar Información de la Tarjeta"

    Protected mndEntregasACtaCliente As NeededData
    Protected mblnGestionAlquileres As Boolean
    Protected mblnAnalitica As Boolean
    Protected MBlnExpertisSAAS As Boolean
    Protected MBlnExpContabilidad As Boolean
    Protected mblnGaiaNetExchange As Boolean
    Protected MonInfoA As MonedaInfo
    Protected MonInfoB As MonedaInfo
    Protected IDTipoLineaPredeterminado As String

    Protected WithEvents sctOfertaComercial As AdvancedSearch
    Protected WithEvents FwSearchDireccion As AdvancedSearch

    '//Variables para el Configurador
    Protected mIDArticuloConfig As String : Protected mblnAbrirEvaluador As Boolean
    Protected mOriginalValueArticulo As String : Protected mOriginalValueCantidad As Integer
    Protected mintRow As Integer

    Protected mblnCambioPrecioManual As Boolean
    Protected mblnBodegas As Boolean
    Protected mPrecioAnterior As Double
    Protected mblnCambioDescuentos As Boolean
    Protected mDto1Anterior As Double
    Protected mDto2Anterior As Double
    Protected mDto3Anterior As Double

    Protected mblnValidatingClte As Boolean
    Protected mblnNavigating As Boolean
    Protected mblnStkDobleUnidad As Boolean
    Protected MIDArticuloRef As String

    Private ndImpuestos As ProviderNeededData
    Public mClienteVarios As String

#Region " Entregas a Cuenta "

    Private Sub SettingNeededData()
        mndEntregasACtaCliente = New NeededData("vEntregasACuentaGeneradas", RelationMode.ChildMode, New String() {"IDCliente"}, New String() {"IDCliente"})
        Me.AddDataItem(mndEntregasACtaCliente)
    End Sub

    Private Sub ComprobarEntregasACuenta()
        Me.pnlEntregaCuenta.Visible = (Not IsNothing(mndEntregasACtaCliente.Data) AndAlso mndEntregasACtaCliente.Data.Rows.Count > 0)
    End Sub

    Private Sub ComprobarRiesgoCliente()
        If Length(AdvIDCliente.Text) > 0 Then
            Dim objRiesgo As New CommonClasses.RiesgoCliente
            Dim Riesgo As Negocio.RiesgoCliente = objRiesgo.CompruebaRiesgo(AdvIDCliente.Value)
            PnlRiesgo.Visible = IIf(Not IsNothing(Riesgo) AndAlso Riesgo.SuperaRiesgo, True, False)
        End If
    End Sub

#End Region

#Region " Load "

    Private Sub MntoFacturaVenta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Me.RecordsState = RecordsState.Saved AndAlso Not IsNothing(Me.CurrentRow) AndAlso Length(Me.CurrentRow("IDFactura")) > 0 Then
            Dim objFilter As New Filter
            objFilter.Add(New NumberFilterItem("IDFactura", Me.CurrentRow("IDFactura")))
            Me.GotoRecord(DataProviderActions.GoRecord, objFilter, Me.CurrentRow.Table)
        End If
        Dim NewFnt As New Font("Verdana", 10, FontStyle.Bold)
        Me.LbLFactPDFGenerado.Font = NewFnt : Me.LbLFactXMLGenerado.Font = NewFnt
        Me.LbLFactPDFGenerado.ForeColor = Color.Blue : Me.LbLFactXMLGenerado.ForeColor = Color.Blue
        CheckGaiaNetParam()
    End Sub

    Private Sub MntoFacturaVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mClienteVarios = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf JMAParametro.ClienteVarios, Nothing)
        If Not Me.DesignMode Then
            LoadERPData()
            LoadAdvancedSearchSettings()
            LoadFormParams()
            LoadToolbarActions()
            LoadGridActions()
            LoadEnums()
            SettingDobleUnidad()
            LoadDecimalesControlesCambio()
            LoadNedeedDataImpuestos()
        End If
    End Sub

    Private Sub LoadDecimalesControlesCambio()
        Dim FormatoCambios As String = "#,##0.########"
        fwiCambioA.FormatString = FormatoCambios
        fwiCambioB.FormatString = FormatoCambios
    End Sub

    Private Sub SettingDobleUnidad()
        If Me.jngLineaFactura.Columns.Contains("IDUDInterna2") Then
            Me.jngLineaFactura.Columns("IDUDInterna2").Visible = mblnStkDobleUnidad
            Me.jngLineaFactura.Columns("IDUDInterna2").Position = Me.jngLineaFactura.Columns("IDUDInterna").Position + 1
        End If
        If Me.jngLineaFactura.Columns.Contains("QInterna2") Then
            Me.jngLineaFactura.Columns("QInterna2").Visible = mblnStkDobleUnidad
            Me.jngLineaFactura.Columns("QInterna2").Position = Me.jngLineaFactura.Columns("QInterna").Position + 1
        End If
    End Sub

    Private Sub LoadGridDefaultValues()
        If Not Me.CurrentRow Is Nothing Then
            With jngLineaFactura
                If Not Me.CurrentRow Is Nothing AndAlso Me.CurrentRow.RowState <> DataRowState.Deleted Then
                    .Columns("IDFactura").DefaultValue = Me.CurrentRow("IDFactura")
                    .Columns("IDCentroGestion").DefaultValue = Me.CurrentRow("IDCentroGestion")
                    .Columns("Dto").DefaultValue = Nz(Me.CurrentRow("DtoFactura"), 0)
                Else
                    .Columns("Dto").DefaultValue = 0
                End If
                .Columns("Cantidad").DefaultValue = 0
                .Columns("Factor").DefaultValue = 1
                .Columns("QInterna").DefaultValue = 0
                .Columns("QTiempo").DefaultValue = 1
                .Columns("UdValoracion").DefaultValue = 1
                .Columns("Precio").DefaultValue = 0
                .Columns("Importe").DefaultValue = 0
                .Columns("Dto1").DefaultValue = 0
                .Columns("Dto2").DefaultValue = 0
                .Columns("Dto3").DefaultValue = 0
                If Me.fwiDtoProntoPago.Value <> 0 Then
                    .Columns("DtoProntoPago").DefaultValue = Me.fwiDtoProntoPago.Value
                Else
                    .Columns("DtoProntoPago").DefaultValue = 0
                End If
                .Columns("Regalo").DefaultValue = False
                If Length(AdvObra.Value) > 0 Then
                    .Columns("IDObra").DefaultValue = AdvObra.Value
                    .Columns("NObra").DefaultValue = AdvObra.Text
                Else
                    .Columns("IDObra").DefaultValue = DBNull.Value
                    .Columns("NObra").DefaultValue = DBNull.Value
                End If
                .Columns("IDTipoLinea").DefaultValue = IDTipoLineaPredeterminado
            End With
        End If
    End Sub

    Private Sub LoadERPData()
        Dim ParamsFV As DataParamFacturaVenta = ExpertisApp.ExecuteTask(Of Object, DataParamFacturaVenta)(AddressOf FacturaVentaCabecera.GetParamsFacturaVenta, Nothing)
        mblnGestionAlquileres = ParamsFV.GestionAlquiler
        mblnAnalitica = ParamsFV.GestionAnalitica
        MBlnExpertisSAAS = ParamsFV.ExpertisSAAS
        MBlnExpContabilidad = ParamsFV.Contabilidad
        mblnGaiaNetExchange = ParamsFV.GAIANetExchange
        MonInfoA = ParamsFV.MonInfoA
        MonInfoB = ParamsFV.MonInfoB
        mblnStkDobleUnidad = ParamsFV.GestionDobleUnidad
        mblnBodegas = New Parametro().GestionBodegas

        If MBlnExpertisSAAS Then
            FraEDI.Visible = False
            Me.FraRetencion.Visible = False
            Me.TabPageConceptos.TabVisible = False
            Me.AdvObra.Visible = False : Me.lblNObra.Visible = False
        End If
        If Not MBlnExpContabilidad Then
            Me.fwiTipoAsiento.Visible = False : Me.lblfwiTipoAsiento.Visible = False
            Me.fwiIDEjercicio.Visible = False : Me.lblEjercicio.Visible = False : Me.lblcfwiIDEjercicio.Visible = False
        End If
        DescripcionMonedas()
    End Sub

    Private Sub LoadFormParams()
        Dim ht As Hashtable = Me.Params
        If Not IsNothing(ht) Then
            If Length(ht("IdFactura")) > 0 Then
                Dim objFilterCriteria As New Filter
                objFilterCriteria.Clear()
                objFilterCriteria.Add(New NumberFilterItem("IDFactura", ht("IdFactura")))
                GotoRecord(DataProviderActions.GoRecord, objFilterCriteria, Me.CurrentData)
            End If
        End If
    End Sub

    Private Sub DescripcionMonedas()
        fwiDescMonedaA.Text = MonInfoA.Texto
        fwiMonedaA.Text = fwiDescMonedaA.Text
        fwiDescMonedaB.Text = MonInfoB.Texto
        fwiMonedaB.Text = fwiDescMonedaB.Text
    End Sub

    Private Sub LoadAdvancedSearchSettings()
        sctOfertaComercial = New AdvancedSearch
        FwSearchDireccion = New AdvancedSearch : FwSearchDireccion.EntityName = "ClienteDireccion"
    End Sub

    Protected Overridable Sub LoadToolbarActions()
        'If MBlnExpContabilidad Then
        '    Me.FormActions.Add("Contabilizar Factura", AddressOf AccionContabilizar, ExpertisApp.GetIcon("import1.ico"))
        '    Me.FormActions.Add("Descontabilizar Factura", AddressOf AccionDescontabilizar, ExpertisApp.GetIcon("export1.ico"))
        '    Me.LblSelloContabilizado.Text = "Contabilizada"
        'Else
        '    Me.FormActions.Add("Validar Factura y crear Cobros en cartera", AddressOf AccionContabilizar, ExpertisApp.GetIcon("import1.ico"))
        '    Me.FormActions.Add("Modificar Factura y eliminar Cobros en cartera", AddressOf AccionDescontabilizar, ExpertisApp.GetIcon("export1.ico"))
        '    Me.LblSelloContabilizado.Text = "Validada"
        'End If
        Me.AddSeparator()
        Me.FormActions.Add("Dirección de Facturación", AddressOf AccionBuscarDireccion, ExpertisApp.GetIcon("find_again.ico"))
        Me.AddSeparator()
        If Not MBlnExpertisSAAS Then Me.FormActions.Add("Trazabilidad", AddressOf AccionTrazabilidad)
        Me.AddSeparator()
        'Me.FormActions.Add("Copiar Factura", AddressOf AccionCopiarFactura, ExpertisApp.GetIcon("copy.ico"))
        If Not MBlnExpertisSAAS Then
            Me.AddSeparator()
            ''Me.FormActions.Add("Calcular Seguros Alquiler", AddressOf AccionCalcularSeguros)
            Me.FormActions.Add("Ver / Añadir Entregas a Cuenta", AddressOf AccionVerAñadirEntregasACuenta)
            Me.FormActions.Add("Quitar Entregas a Cuenta", AddressOf AccionQuitarEntregasACuenta)
            Me.AddSeparator()
            Me.FormActions.Add("Calcular Precio Optimo", AddressOf AccionPrecioOptimo, ExpertisApp.GetIcon("calculator.ico"))
        End If
        Me.AddSeparator()
        Me.FormActions.Add("Generar / Firmar / Enviar Factura Electrónicas", AddressOf AccionFacturaElectronica, ExpertisApp.GetIcon("outbox_out.ico"))
        Me.FormActions.Add("Enviar Email Cliente", AddressOf AccionEnviarEmail, ExpertisApp.GetIcon("mail_forward.ico"))
        Me.FormActions.Add("Quitar Factura Electrónica", AddressOf AccionQuitarFacturaElectronica, ExpertisApp.GetIcon("inbox_into.ico"))
        Me.FormActions.Add("Imputación de gastos", AddressOf AccionImputacion)
        If mblnBodegas Then
            Me.AddSeparator()
            Me.FormActions.Add("Imprimir Documentación", AddressOf AccionImprimirDocumentacion, ExpertisApp.GetIcon("printer.ico"))
        End If
    End Sub

    Private Sub LoadGridActions()
        With jngLineaFactura
            .Actions.Add(cnABRIRPEDIDOVENTA, AddressOf CargarMantenimientoPedidoVenta, ExpertisApp.GetIcon("xPedidosVenta.ico"))
            .Actions.Add(cnABRIRALBARANVENTA, AddressOf CargarMantenimientoAlbaranVentaNormal, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
            .Actions.Add(cnABRIROFERTA, AddressOf CargarMantenimientoOfertas, ExpertisApp.GetIcon("xContratosComer.ico"))
            .Actions.Add(cnABRIROBRA, AddressOf CargarMantenimientoObra, ExpertisApp.GetIcon("xProyectos.ico"))
            .Actions.Add(cnABRIROT, AddressOf CargarMantenimientoOT, ExpertisApp.GetIcon("xOrdenFabricacion.ico"))
            .Actions.Add(cnABRIRPROMOCION, AddressOf CargarMantenimientoPromociones, ExpertisApp.GetIcon("xPromocionesTarifa.ico"))
            If mblnGestionAlquileres Then
                .Actions.Add(cnABRIRALQUILER, AddressOf CargarMantenimientoAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
                .Actions.Add(cnABRIRALBARANRETORNO, AddressOf CargarMantenimientoAlbaranVentaRetorno, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
                .Actions.Add(cnABRIRORDENSERVICIO, AddressOf CargarMantenimientoTrabajo, ExpertisApp.GetIcon("xPedidosVenta.ico"))
            End If
            .Actions.Add("Abrir Artículo", AddressOf CargarMantenimientoArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
            .Actions.Add("Abrir Inmueble", AddressOf CargarInmueble, ExpertisApp.GetIcon("server_client_exchange.ico"))
            .Actions.Add("Imputación de gastos", AddressOf AccionImputacionLinea)
            .Actions.Add("Ver detalle imputación de gastos", AddressOf AccionDetalleImputacion)
        End With


        jngVencimientos.AddSeparator()
        jngVencimientos.Actions.Add(cnINFOCHEQUE, AddressOf AccionGestionCheque)
        jngVencimientos.Actions.Add(cnINFOTARJETA, AddressOf AccionGestionTarjeta)


    End Sub

    Private Sub LoadEnums()
        fwiTipoAsiento.DataSource = New EnumData("enumTipoAsientoFV")
        FwiTipoFactura.DataSource = New EnumData("enumfvcTipoFactura")
        cbxTipoRetencion.DataSource = New EnumData("enumTipoRetencion")
        cbxClaveOperacion.DataSource = EnumData.EnumView("ClaveOperacion")
        EnumData.PopulateValueList(GetType(enumTipoFacturacionAlquiler), jngLineaFactura.Columns("TipoFactAlquiler"))
        Me.CmbTipoOperIntra.DataSource = New EnumData("enumTipoOperacionIntra")
    End Sub

    Private Sub CheckGaiaNetParam()
        If Not mblnGaiaNetExchange Then
            For i As Integer = 0 To Me.FormActions.Count - 1
                If Me.FormActions(i).ActionName = "Enviar Factura Gaia Net Exchange" Then
                    Me.UiCommandManager1.Commands(Me.FormActions(i).IDAction.ToString).Visible = Janus.Windows.UI.InheritableBoolean.False
                    Exit For
                End If
            Next
        End If
    End Sub

#End Region

#Region " Acciones Toolbar "

    Protected Overridable Sub AccionPrecioOptimo()
        Dim _filter As New Filter
        If Not Me.CurrentRow Is Nothing Then
            If IsNumeric(Me.CurrentRow("IDFactura")) Then
                Dim FrmFecha As New frmFechaCalcPrecioOptimo
                FrmFecha.Fecha = Me.CurrentRow("FechaFactura")
                If FrmFecha.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.Cursor = Cursors.WaitCursor
                    Dim StData As New FacturaVentaCabecera.DataPrecioOptimo(Me.CurrentRow("IDFactura"), FrmFecha.Fecha)
                    ExpertisApp.ExecuteTask(Of FacturaVentaCabecera.DataPrecioOptimo)(AddressOf FacturaVentaCabecera.PrecioOptimo, StData)
                    _filter.Add("IDFactura", CurrentRow.Item("idfactura"))
                    GotoRecord(DataProviderActions.Refresh, _filter)
                    Select Case TabFacturas.SelectedTab.Key
                        Case "Lineas"
                            jngLineaFactura.ReQuery()
                        Case "BaseImponible"
                            jngBaseImponible.ReQuery()
                        Case "Vencimientos"
                            jngVencimientos.ReQuery()
                    End Select
                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub AccionBuscarDireccion()
        FwSearchDireccion.Open()
    End Sub

    Protected Overridable Sub AccionTrazabilidad()
        Dim strParameters As String
        If Length(fwiNFactura.Text) > 0 Then
            strParameters = fwiNFactura.Text
            If ExpertisApp.IsFormOpen("TFV") Then ExpertisApp.CloseForm("TFV")
            ExpertisApp.OpenForm("TFV", , strParameters)
        End If
    End Sub

    'Private Sub AccionCalcularSeguros()
    '    MessageBox.Show("AccionCalcularSeguros")

    '    'Dim rcsFVL As Recordset
    '    'Dim rcsFVC As Recordset
    '    'Dim FwFVL As FacturaVentaLinea
    '    'Dim fwFVC As FacturaVentaCabecera
    '    'Dim IntLineas, IntGeneradas As Integer
    '    'Dim lngTipo As Long
    '    'Dim rcsSeguros As Recordset

    '    'If Not jngLineaFactura Is Nothing Then
    '    '    If jngLineaFactura.DataSource.RecordCount > 0 Then
    '    '        If verificarProceso() Then ' Proceso que verifica si se ha lanzado el proceso anteriormente
    '    '            If MessageBox.Show(12085, ExpertisApp.Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = vbOK Then
    '    '                If Not rcsFVL Is Nothing And Not rcsFVC Is Nothing Then
    '    '                    If rcsFVL.RecordCount > 0 And rcsFVC.RecordCount > 0 Then
    '    '                        Me.Cursor = Cursors.WaitCursor
    '    '                        IntLineas = rcsFVL.RecordCount

    '    '                        Me.Cursor = Cursors.Default
    '    '                        IntGeneradas = rcsSeguros.RecordCount - IntLineas
    '    '                        If IntGeneradas = 0 Then
    '    '                            GenerateMessage(9045, vbInformation, ExpertisApp.Title)
    '    '                        Else
    '    '                            GenerateMessage(12087, vbInformation, ExpertisApp.Title, IntGeneradas)
    '    '                        End If
    '    '                    End If
    '    '                End If
    '    '            End If
    '    '            jngLineaFactura.Refresh()
    '    '        Else
    '    '            GenerateMessage(12105, vbCritical, ExpertisApp.Title)
    '    '        End If
    '    '    End If
    '    'End If
    'End Sub

    Protected Overridable Sub AccionVerAñadirEntregasACuenta()
        Dim frmVerEntregas As New frmVerEntregasACuenta
        '//Si la factura está contabilizada No permitimos Añadir Entregas a la factura. 
        '//En este caso, sólo permitiremos visualizarlas.
        If Me.CurrentRow("Estado") = enumfvcEstado.fvcContabilizado Then
            frmVerEntregas.AñadirEntregas = False
        Else
            frmVerEntregas.AñadirEntregas = True
        End If
        frmVerEntregas.CircuitoOrigen = Circuito.Ventas
        frmVerEntregas.IDFactura = Me.CurrentRow("IDFactura")
        frmVerEntregas.IDClienteProveedor = Me.CurrentRow("IDCliente")
        frmVerEntregas.DescClienteProveedor = ulDescCliente.Text
        If frmVerEntregas.ShowDialog(Me) = DialogResult.OK AndAlso frmVerEntregas.AñadirEntregas Then
            Me.Requery.InvokeOnClick()
            CalcularTotalVencimientos()
        End If
    End Sub

    Public Sub AccionQuitarEntregasACuenta()
        Dim frmVerEntregas As New frmVerEntregasACuenta
        '//Si la factura está contabilizada No permitimos Quitar Entregas a la factura. 
        '//En este caso, sólo permitiremos visualizarlas.
        frmVerEntregas.CircuitoOrigen = Circuito.Ventas
        frmVerEntregas.IDFactura = Me.CurrentRow("IDFactura")
        frmVerEntregas.IDClienteProveedor = Me.CurrentRow("IDCliente")
        frmVerEntregas.DescClienteProveedor = ulDescCliente.Text
        If Me.CurrentRow("Estado") = enumfvcEstado.fvcContabilizado Then
            frmVerEntregas.EliminarEntregas = False
        Else
            frmVerEntregas.EliminarEntregas = True
        End If
        If frmVerEntregas.ShowDialog(Me) = DialogResult.OK AndAlso frmVerEntregas.EliminarEntregas Then
            Me.Requery.InvokeOnClick()
            CalcularTotalVencimientos()
        End If
    End Sub


    Protected Overridable Sub AccionFacturaElectronica()
        If Me.CurrentRow("FacturaElectronica") <> enumPermisoFactElec.Ninguno Then
            Dim FrmOpt As New FrmSelFactElec
            FrmOpt.TipoPermiso = Me.CurrentRow("FacturaElectronica")
            If FrmOpt.ShowDialog = Windows.Forms.DialogResult.OK Then
                Select Case FrmOpt.TipoPermiso
                    Case 0
                        'Seleccionado Generación en PDF
                        If Length(Me.CurrentRow("DirecFacturaPDF")) = 0 Then
                            Dim StrMsg As String = "La Generación de Pdfs / Gestion Doc. / Firma se está realizando."
                            Dim StrNomForm As String = "Lanzando Generación / Firma Pdfs"
                            Dim oFrmProc As New FrmProgresoProceso
                            Dim StartDelegate As New GenerarFirmarEnviarFacturaPDF(AddressOf FacturacionElectronica.GenerarFirmarEnviarFacturaPDF)
                            oFrmProc.Start(StartDelegate, New Object() {Me.CurrentData, "IDFactura", "EMail", "NFactura", "FacturaElectronica", FrmOpt.OpcionFichero, FrmOpt.AliasInforme}, StrMsg, StrNomForm)
                        Else : ExpertisApp.GenerateMessage("La Factura Actual ya se generó, firmó y envió por correo electrónico en Formato PDF.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Case 1
                        'Seleccionado Generación en XML
                        If Length(Me.CurrentRow("DirecFacturaXML")) = 0 Then
                            Dim StrMsg As String = "La Generación de XML / Gestión Doc. / Firma se está realizando."
                            Dim StrNomForm As String = "Lanzando Generación / Firma XML"
                            Dim oFrmProc As New FrmProgresoProceso
                            Dim StartDelegate As New GenerarFirmarEnviarFacturaXML(AddressOf FacturacionElectronica.GenerarFirmarEnviarFacturaXML)
                            oFrmProc.Start(StartDelegate, New Object() {Me.CurrentData, "IDFactura", "EMail", "NFactura", "FacturaElectronica", FrmOpt.OpcionFichero}, StrMsg, StrNomForm)
                        Else : ExpertisApp.GenerateMessage("La Factura Actual ya se generó, firmó y envió por correo electrónico en Formato XML (Facturae).", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                End Select
                Me.Requery.InvokeOnClick()
                ComprobarFacturasElectronicas()
            End If
        Else : ExpertisApp.GenerateMessage("El Cliente de la Factura actual no tiene permisos de generación de ficheros PDF ni de ficheros XML.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Protected Overridable Sub AccionQuitarFacturaElectronica()
        If Length(Me.CurrentRow("DirecFacturaPDF")) > 0 Then
            If ExpertisApp.GenerateMessage("¿Desea eliminar la factura electrónica generada?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'Proceso de eliminación del fichero fisico / de la gestión Documental / vaciar campo de facturas de venta.
                'Eliminamos el Fichero Fisico de la factura
                Dim StrFichero As String = Me.CurrentRow("DirecFacturaPDF")
                IO.File.Delete(StrFichero)
                'Eliminamos los datos de la Gestión Documental
                Dim FilDocEnt As New Filter
                FilDocEnt.Add("Entidad", FilterOperator.Equal, "FacturaVentaCabecera")
                FilDocEnt.Add("Campo1", FilterOperator.Equal, "IDFactura")
                FilDocEnt.Add("Valor1", FilterOperator.Equal, Me.CurrentRow("IDFactura"))
                Dim DtDocEnt As DataTable = New DcmDocumentoEntidad().Filter(FilDocEnt)
                If Not DtDocEnt Is Nothing AndAlso DtDocEnt.Rows.Count > 0 Then
                    Dim ClsDoc As New DcmMaestroDocumento
                    Dim DtDoc As DataTable = ClsDoc.SelOnPrimaryKey(DtDocEnt.Rows(0)("IDDocumento"))
                    ClsDoc.Delete(DtDoc)
                End If
                ExpertisApp.ExecuteTask(Of Integer)(AddressOf FacturaVentaCabecera.QuitarFacturaElectronica, Me.CurrentRow("IDFactura"))
                Me.Requery.InvokeOnClick()
                ExpertisApp.GenerateMessage("Se ha eliminado la factura electrónica asociada a la factura.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Dim StrDir As String = New Parametro().DirectorioFactElec & "\Pendientes\" & CDate(Me.CurrentRow("FechaFactura")).Year & "\"
            Dim StrFilePendEnvio As String = StrDir & Strings.Format(CDate(Me.CurrentRow("FechaFactura")), "ddMMyyyy") & "_" & Me.CurrentRow("NFactura") & "_S.pdf"
            Dim StrFilePendFirma As String = StrDir & Strings.Format(CDate(Me.CurrentRow("FechaFactura")), "ddMMyyyy") & "_" & Me.CurrentRow("NFactura") & ".pdf"
            If IO.File.Exists(StrFilePendEnvio) Then
                If ExpertisApp.GenerateMessage("¿Dese eliminar la factura electrónica pendiente de enviar: |?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, StrFilePendEnvio) = Windows.Forms.DialogResult.Yes Then
                    IO.File.Delete(StrFilePendEnvio)
                    Dim StrFiles() As String = IO.Directory.GetFiles(StrDir, "*.direc")
                    For Each StrFile As String In StrFiles
                        If Strings.Left(StrFile, StrFile.LastIndexOf("_")) = (StrDir & Strings.Format(CDate(Me.CurrentRow("FechaFactura")), "ddMMyyyy") & "_" & Me.CurrentRow("NFactura")) Then
                            IO.File.Delete(StrFile)
                            Exit For
                        End If
                    Next
                    ExpertisApp.GenerateMessage("Se ha eliminado el fichero pendiente de enviar: |", MessageBoxButtons.OK, MessageBoxIcon.Information, StrFilePendEnvio)
                End If
            ElseIf IO.File.Exists(StrFilePendFirma) Then
                If ExpertisApp.GenerateMessage("¿Desea eliminar la factura electrónica pendiente de firmar: |?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, StrFilePendFirma) = Windows.Forms.DialogResult.Yes Then
                    IO.File.Delete(StrFilePendFirma)
                    Dim StrFiles() As String = IO.Directory.GetFiles(StrDir, "*.direc")
                    For Each StrFile As String In StrFiles
                        If Strings.Left(StrFile, StrFile.LastIndexOf("_")) = (StrDir & Strings.Format(CDate(Me.CurrentRow("FechaFactura")), "ddMMyyyy") & "_" & Me.CurrentRow("NFactura")) Then
                            IO.File.Delete(StrFile)
                            Exit For
                        End If
                    Next
                    ExpertisApp.GenerateMessage("Se ha eliminado el fichero pendiente de firmar: |", MessageBoxButtons.OK, MessageBoxIcon.Information, StrFilePendFirma)
                End If
            End If
        End If
    End Sub

#End Region

#Region " Acciones Grid "

    Private Sub CargarMantenimientoPedidoVenta()
        With jngLineaFactura
            If Length(.Value("IDPedido")) > 0 Then
                ExpertisApp.OpenForm("MPED", New StringFilterItem("IDPedido", FilterOperator.Equal, .Value("IdPedido")))
            End If
        End With
    End Sub

    Private Sub CargarMantenimientoAlbaranVentaNormal()
        With jngLineaFactura
            If Length(.Value("IDAlbaran")) > 0 Then
                ExpertisApp.OpenForm("MALB", New StringFilterItem("IDAlbaran", FilterOperator.Equal, .Value("IDAlbaran")))
            End If
        End With
    End Sub

    Private Sub CargarMantenimientoOfertas()
        If Length(jngLineaFactura.GetValue("IDLineaOfertaDetalle")) > 0 Then
            Dim DtOferta As DataTable = New BE.DataEngine().Filter("tbOfertaComercialDetalle", New FilterItem("IDLineaOfertaDetalle", FilterOperator.Equal, jngLineaFactura.GetValue("IDLineaOfertaDetalle")))
            ExpertisApp.OpenForm("OFERCON", New FilterItem("IDOfertaComercial", FilterOperator.Equal, DtOferta.Rows(0)("IDOfertaComercial")))
        End If
    End Sub

    Private Sub CargarMantenimientoAlbaranVentaRetorno()
        With jngLineaFactura
            If Length(.Value("IDAlbaranRetorno")) > 0 Then
                ExpertisApp.OpenForm("MALB", New StringFilterItem("IDAlbaran", FilterOperator.Equal, .Value("IDAlbaranRetorno")))
            End If
        End With
    End Sub

    Private Sub CargarMantenimientoAlquiler()
        With jngLineaFactura
            If Length(.Value("IDObra")) > 0 Then
                ExpertisApp.OpenForm("OBALQUILER", New StringFilterItem("IDObra", .Value("IDObra")))
            End If
        End With
    End Sub

    Private Sub CargarMantenimientoObra()
        With jngLineaFactura
            If Length(.Value("IDObra")) > 0 Then
                ExpertisApp.OpenForm("MGEO", New StringFilterItem("IDObra", .Value("IDObra")))
            End If
        End With
    End Sub

    Private Sub CargarMantenimientoOT()
        With jngLineaFactura
            If Length(.Value("IDOT")) > 0 Then
                ExpertisApp.OpenForm("MNTOOT", New NumberFilterItem("IDOT", .Value("IDOT")))
            End If
        End With
    End Sub


    Private Sub CargarMantenimientoTrabajo()
        If mblnGestionAlquileres Then
            With jngLineaFactura
                If Length(.Value("IdTrabajo")) > 0 Then
                    ExpertisApp.OpenForm("MGEOTRALQ", New StringFilterItem("IdTrabajo", .Value("IdTrabajo")))
                End If
            End With
        End If
    End Sub

    Private Sub CargarMantenimientoPromociones()
        With jngLineaFactura
            If Length(.Value("IDPromocion")) > 0 Then
                ExpertisApp.OpenForm("PROM", New StringFilterItem("IDPromocion", .Value("IDPromocion")))
            End If
        End With
    End Sub

    Private Sub CargarMantenimientoArticulo()
        ExpertisApp.OpenForm("MARTICULO", New FilterItem("IDArticulo", FilterOperator.Equal, jngLineaFactura.GetValue("IDArticulo")))
    End Sub

    Private Sub CargarInmueble()
        ExpertisApp.OpenForm("INMCAB")
    End Sub
    Private Sub AccionImputacionLinea()
        If Length(jngLineaFactura.Value("IDLineaFactura")) > 0 Then
            Dim lst As New List(Of Object)

            lst.Add(jngLineaFactura.Value("IDLineaFactura"))

            Dim TipoOrigen As PartidaOrigen

            TipoOrigen = PartidaOrigen.FV
            Dim vPartida As New BE.DataEngine
            Dim dt As DataTable = vPartida.Filter("vPartidaFacturaVenta", New FilterItem("IDOrigen", FilterOperator.Equal, jngLineaFactura.Value("IDLineaFactura")))
            If dt.Rows.Count > 0 Then
                AccionDetalleImputacion()
            Else
                Dim frm As New Solmicro.Expertis.Application.ERP.Rentabilidad.frmRepartoRentabilidad
                frm.AbrirReparto(lst, TipoOrigen)
            End If

        End If
    End Sub

    Private Sub AccionDetalleImputacion()
        Dim TipoOrigen As PartidaOrigen

        TipoOrigen = PartidaOrigen.FV
        Dim frm As New Solmicro.Expertis.Application.ERP.Rentabilidad.frmDetalleReparto
        If Not Me.CurrentRow Is Nothing Then frm.IDCliente = Me.CurrentRow("IDCliente") & String.Empty
        frm.AbrirDetalle(jngLineaFactura.GetRow.DataRow.row, TipoOrigen)
    End Sub
#End Region
    Private Sub AccionImputacion()
        If jngLineaFactura.RecordCount > 0 Then
            Dim lst As New List(Of Object)
            Dim dtLineas As DataTable = jngLineaFactura.DataSource
            For Each dr As DataRow In dtLineas.Rows
                lst.Add(dr("IDLineaFactura"))
            Next

            Dim TipoOrigen As PartidaOrigen

            TipoOrigen = PartidaOrigen.FV


            Dim frm As New Solmicro.Expertis.Application.ERP.Rentabilidad.frmRepartoRentabilidad
            frm.AbrirReparto(lst, TipoOrigen)

        Else
            ExpertisApp.GenerateMessage("Debe seleccionar los registros a imputar.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AccionImprimirDocumentacion()
        Dim FrmPrint As New FrmImprimirDocs
        FrmPrint.IDProgram = Me.ProgramInfo.ProgramID
        FrmPrint.NFactura = Me.CurrentRow("NFactura")
        FrmPrint.IDFactura = Me.CurrentRow("IDFactura")
        FrmPrint.ShowDialog()
    End Sub

    Private Sub Imprimir(ByVal report_alias As String)
        ExpertisApp.GenerateMessage(report_alias)
    End Sub

    Public Property Contabilizado() As Boolean
        Get
            If Not IsNothing(Me.CurrentData) AndAlso Me.CurrentData.Rows.Count Then
                Return (Me.CurrentRow("estado") <> enumContabilizado.NoContabilizado)
            End If
        End Get
        Set(ByVal Value As Boolean)
            LblSelloContabilizado.Visible = Value
            LblSelloContabilizado.ForeColor = Color.Blue
            BloquearInformacion(Me.MainPanel, Value, fwiNFactura, fwiEstado, fwiCIF, fwiRazonSocial, fwiDir, fwiTel, fwiCodPostal, _
                                fwiPoblacion, fwiFax, fwiProvincia, FwiIdPais, fwiTextoFactura, chkEnviar347, ChkEnviar349, ChkSectorServicios, ChkOpeTriangular, chkEDI, _
                                chkGeneradoFichero, txtDescAseguradora, chbEnviadaEntidadAseguradora1, FwiIDContador, _
                                fwiTotalBaseImp, fwiTotalIva, fwiTotal, fwiDescMonedaA, fwiDescMonedaB, fwiImpRetencion, fwiBaseRetencion, _
                                fwiImpLinMon, fwiImpLineasNormales, fwiImpLineasEspeciales, fwiBaseImpMon, _
                                fwiIVA, fwiImpREMon, fwiImpRecFinan, fwiImpTotal, fwiImpRetencionAux, fwiImpTotalConRetencion, _
                                fwiClienteIni, fwiIDEjercicio, fwiAñoDeclaracion, _
                                fwiNDeclaracion, fwiImpLineasNormalesA, fwiImpLineasEspecialesA, fwiImpLineasA, _
                                fwiBaseImpA, fwiImpIVAA, fwiImpReA, fwiImpRecFinanA, fwiImpTotalA, fwiRetencionA, _
                                fwiImpLineasNormalesB, fwiImpLineasEspecialesB, fwiImpLineasB, fwiBaseImpB, _
                                fwiImpIVAB, fwiImpReB, fwiImpRecFinanB, fwiImpTotalB, fwiImpRetencionB, fwiMonedaA, fwiMonedaB, _
                                fwiDescMoneda, fwiImpRetencion, fwiImpRecFinan, TxtDirecCorreo, jngConceptos, txtNumeroCopias, AdvIDCliente, _
                                chkOcultarComponentes, ntbRetencion, nbxImpuestos)
            Me.AdvIDCliente.ReadOnly = Value
            ComprobarIVAVencManual()
        End Set
    End Property


    Private Sub MostrarEstadoContabilizacion()
        fwiEstado.Text = RecuperarDescripcionEnumerado("enumContabilizado", Me.CurrentRow("Estado"))
        LblSelloContabilizado.Text = fwiEstado.Text
        If Not MBlnExpContabilidad Then
            If Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado Then
                Me.fwiEstado.Text = "Validada"
            Else
                Me.fwiEstado.Text = "Pendiente de Validar"
            End If
        End If
        If (Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado) Then
            LblSelloContabilizado.Visible = True
        ElseIf Me.chkVencimientoManual.Checked OrElse Me.chkIVAManual.Checked Then
            LblSelloContabilizado.Visible = False
        Else
            LblSelloContabilizado.Visible = False
        End If
    End Sub

    Public Sub ComprobarDeclarado(ByVal BlnDeclarado As Boolean)
        BloquearInformacion(Me.MainPanel, BlnDeclarado, fwiNFactura, fwiEstado, fwiCIF, fwiRazonSocial, fwiDir, fwiTel, fwiCodPostal, _
                            fwiPoblacion, fwiFax, fwiProvincia, FwiIdPais, fwiTextoFactura, chkEnviar347, ChkEnviar349, ChkSectorServicios, ChkOpeTriangular, chkEDI, _
                            chkGeneradoFichero, txtDescAseguradora, chbEnviadaEntidadAseguradora1, FwiIDContador, _
                            fwiTotalBaseImp, fwiTotalIva, fwiTotal, fwiDescMonedaA, fwiDescMonedaB, fwiImpRetencion, fwiBaseRetencion, _
                            fwiImpLinMon, fwiImpLineasNormales, fwiImpLineasEspeciales, fwiBaseImpMon, _
                            fwiIVA, fwiImpREMon, fwiImpRecFinan, fwiImpTotal, fwiImpRetencionAux, fwiImpTotalConRetencion, _
                            fwiClienteIni, fwiIDEjercicio, fwiAñoDeclaracion, _
                            fwiNDeclaracion, fwiImpLineasNormalesA, fwiImpLineasEspecialesA, fwiImpLineasA, _
                            fwiBaseImpA, fwiImpIVAA, fwiImpReA, fwiImpRecFinanA, fwiImpTotalA, fwiRetencionA, _
                            fwiImpLineasNormalesB, fwiImpLineasEspecialesB, fwiImpLineasB, fwiBaseImpB, _
                            fwiImpIVAB, fwiImpReB, fwiImpRecFinanB, fwiImpTotalB, fwiImpRetencionB, fwiMonedaA, fwiMonedaB, _
                            fwiDescMoneda, fwiImpRetencion, fwiImpRecFinan, TxtDirecCorreo, jngConceptos, txtNumeroCopias, AdvIDCliente, _
                            chkOcultarComponentes, ntbRetencion, nbxImpuestos)
        Me.AdvIDCliente.ReadOnly = BlnDeclarado

        ComprobarIVAVencManual()
    End Sub

    Public Sub ComprobarFacturaElectronica(ByVal ExisteFactura As Boolean)
        If Not Me.Contabilizado Then
            If Length(Me.CurrentRow("AñoDeclaracionIva")) = 0 OrElse Length(Me.CurrentRow("NDeclaracionIva")) = 0 Then
                If Length(Me.cbxClaveOperacion.Value) > 0 Then
                    If (Me.cbxClaveOperacion.Value <> ClaveOperacion.Tickets AndAlso Me.cbxClaveOperacion.Value <> ClaveOperacion.ResumenTicket) Then
                        BloquearInformacion(Me.MainPanel, ExisteFactura, fwiNFactura, fwiEstado, fwiCIF, fwiRazonSocial, fwiDir, fwiTel, fwiCodPostal, _
                                        fwiPoblacion, fwiFax, fwiProvincia, FwiIdPais, fwiTextoFactura, chkEnviar347, ChkEnviar349, ChkSectorServicios, ChkOpeTriangular, chkEDI, _
                                        chkGeneradoFichero, txtDescAseguradora, chbEnviadaEntidadAseguradora1, FwiIDContador, _
                                        fwiTotalBaseImp, fwiTotalIva, fwiTotal, fwiDescMonedaA, fwiDescMonedaB, fwiImpRetencion, fwiBaseRetencion, _
                                        fwiImpLinMon, fwiImpLineasNormales, fwiImpLineasEspeciales, fwiBaseImpMon, _
                                        fwiIVA, fwiImpREMon, fwiImpRecFinan, fwiImpTotal, fwiImpRetencionAux, fwiImpTotalConRetencion, _
                                        fwiClienteIni, fwiIDEjercicio, fwiAñoDeclaracion, _
                                        fwiNDeclaracion, fwiImpLineasNormalesA, fwiImpLineasEspecialesA, fwiImpLineasA, _
                                        fwiBaseImpA, fwiImpIVAA, fwiImpReA, fwiImpRecFinanA, fwiImpTotalA, fwiRetencionA, _
                                        fwiImpLineasNormalesB, fwiImpLineasEspecialesB, fwiImpLineasB, fwiBaseImpB, _
                                        fwiImpIVAB, fwiImpReB, fwiImpRecFinanB, fwiImpTotalB, fwiImpRetencionB, fwiMonedaA, fwiMonedaB, _
                                        fwiDescMoneda, fwiImpRetencion, fwiImpRecFinan, TxtDirecCorreo, jngConceptos, txtNumeroCopias, chkOcultarComponentes, ntbRetencion, nbxImpuestos _
                                        )
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub ComprobarIVAVencManual()
        'Dim BlnBloquear As Boolean
        'If (Me.CurrentRow("Estado") = enumfvcEstado.fvcContabilizado) Then
        '    BlnBloquear = True
        'Else
        '    If chkVencimientoManual.Checked OrElse chkIVAManual.Checked Then
        '        BlnBloquear = True
        '    Else : BlnBloquear = False
        '    End If
        'End If
        'BloquearInformacion(Me.MainPanel, BlnBloquear, fwiNFactura, fwiEstado, fwiCIF, fwiRazonSocial, fwiDir, fwiTel, fwiCodPostal, _
        '     fwiPoblacion, fwiFax, fwiProvincia, FwiIdPais, fwiTextoFactura, chkEnviar347, chkEDI, _
        '     chkGeneradoFichero, txtDescAseguradora, chbEnviadaEntidadAseguradora1, FwiIDContador, _
        '     fwiTotalBaseImp, fwiTotalIva, fwiTotal, fwiDescMonedaA, fwiDescMonedaB, fwiImpRetencion, _
        '     fwiImpLinMon, fwiImpLineasNormales, fwiImpLineasEspeciales, fwiBaseImpMon, _
        '     fwiIVA, fwiImpREMon, fwiImpRecFinan, fwiImpTotal, fwiImpRetencionAux, fwiImpTotalConRetencion, _
        '     FwDirEnvio, FwIDirCompra, FwIAutofactura, fwiClienteIni, fwiIDEjercicio, fwiAñoDeclaracion, _
        '     fwiNDeclaracion, fwiImpLineasNormalesA, fwiImpLineasEspecialesA, fwiImpLineasA, _
        '     fwiBaseImpA, fwiImpIVAA, fwiImpReA, fwiImpRecFinanA, fwiImpTotalA, fwiRetencionA, _
        '     fwiImpLineasNormalesB, fwiImpLineasEspecialesB, fwiImpLineasB, fwiBaseImpB, _
        '     fwiImpIVAB, fwiImpReB, fwiImpRecFinanB, fwiImpTotalB, fwiImpRetencionB, fwiMonedaA, fwiMonedaB, _
        '     fwiDescMoneda, fwiImpRetencion, fwiImpRecFinan)

        If Me.CurrentRow Is Nothing Then Exit Sub

        If Me.CurrentRow("Estado") = enumContabilizado.NoContabilizado Then
            If Length(Me.CurrentRow("AñoDeclaracionIva")) > 0 AndAlso Length(Me.CurrentRow("NDeclaracionIva")) > 0 Then
                Me.chkIVAManual.Enabled = False
            Else : Me.chkIVAManual.Enabled = True
            End If
        Else : Me.chkIVAManual.Enabled = False
        End If
        If Me.chkIVAManual.Enabled AndAlso Me.chkIVAManual.Checked Then
            jngBaseImponible.AllowAddNew = InheritableBoolean.True
            jngBaseImponible.AllowEdit = InheritableBoolean.True
            jngBaseImponible.AllowDelete = InheritableBoolean.True
        Else
            jngBaseImponible.AllowAddNew = InheritableBoolean.False
            jngBaseImponible.AllowEdit = InheritableBoolean.False
            jngBaseImponible.AllowDelete = InheritableBoolean.False
        End If

        If Me.CurrentRow("Estado") = enumContabilizado.NoContabilizado Then
            If Length(Me.CurrentRow("AñoDeclaracionIva")) > 0 AndAlso Length(Me.CurrentRow("NDeclaracionIva")) > 0 Then
                Me.chkVencimientoManual.Enabled = False
            Else : Me.chkVencimientoManual.Enabled = True
            End If
        Else : Me.chkVencimientoManual.Enabled = False
        End If
        If Me.chkVencimientoManual.Enabled AndAlso Me.chkVencimientoManual.Checked Then
            jngVencimientos.AllowAddNew = InheritableBoolean.True
            jngVencimientos.AllowEdit = InheritableBoolean.True
            jngVencimientos.AllowDelete = InheritableBoolean.True
            jngVencimientos.Columns("IDFormaPago").ButtonStyle = ButtonStyle.Image
            fwiFormaPago.Enabled = False
        Else
            jngVencimientos.AllowAddNew = InheritableBoolean.False
            jngVencimientos.AllowEdit = InheritableBoolean.False
            jngVencimientos.AllowDelete = InheritableBoolean.False
            jngVencimientos.Columns("IDFormaPago").ButtonStyle = ButtonStyle.NoButton
            If Me.chkVencimientoManual.Checked Then
                fwiFormaPago.Enabled = False
            Else
                fwiFormaPago.Enabled = True
            End If
        End If
    End Sub

    Private Sub fwiRecFinan_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fwiRecFinan.Validating
        If fwiRecFinan.Value <> 0 And fwiRecFinan.Value <> vbNullString And fwiDtoProntoPago.Value <> 0 And fwiDtoProntoPago.Value <> vbNullString Then
            ExpertisApp.GenerateMessage("No se puede tener descuento pronto pago y recargo financiero a la vez.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub fwiDtoProntoPago_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fwiDtoProntoPago.Validating
        If fwiRecFinan.Value <> 0 And fwiRecFinan.Value <> vbNullString And fwiDtoProntoPago.Value <> 0 And fwiDtoProntoPago.Value <> vbNullString Then
            ExpertisApp.GenerateMessage("No se puede tener descuento pronto pago y recargo financiero a la vez.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
        If Me.fwiDtoProntoPago.Value > 100 Then
            ExpertisApp.GenerateMessage("El Descuentro introducido no puede ser superior a 100%.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub TabFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabFacturas.Click
        Select Case TabFacturas.SelectedTab.Key
            Case "Vencimientos"
                ComprobarIVAVencManual()
            Case "Totales"
                fwiImpTotalConRetencion.Value = fwiImpTotal.Value - fwiImpRetencionAux.Value
                DesglosarImporteLineas()
        End Select
    End Sub

    Private Sub ComprobarFacturasElectronicas()
        If Not Me.CurrentRow Is Nothing Then
            Me.LbLFactPDFGenerado.Visible = IIf(Length(Me.CurrentRow("DirecFacturaPDF")) > 0, True, False)
            If Length(Me.CurrentRow("DirecCorreoPDF")) > 0 Then
                Me.LbLFactPDFGenerado.Text = "Factura en PDF Generada y Enviada"
            Else : Me.LbLFactPDFGenerado.Text = "Factura en PDF Generada"
            End If
            Me.LbLFactXMLGenerado.Visible = IIf(Length(Me.CurrentRow("DirecFacturaXML")) > 0, True, False)
        End If
    End Sub

    Private Sub MntoFacturaVenta_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated
        mblnValidatingClte = False
        ComprobarRiesgoCliente()
        TabFacturas_Click(TabFacturas, New EventArgs)
        chkVencimientoManual.Enabled = True
        chkIVAManual.Enabled = True
        CalcularTotalVencimientos()
        DesglosarImporteLineas()
        LoadGridDefaultValues()
        CType(jngLineaFactura.DataSource, DataTable).DefaultView.RowFilter = FiltroComponentes.Compose(New AdoFilterComposer)
    End Sub

    Private Sub MntoFacturaVenta_RecordAdding(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordAdding
        Me.Contabilizado = False
        fwiEstado.Text = String.Empty
    End Sub

    Protected Overridable Sub MntoFacturaVenta_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        mblnNavigating = False
        If Not CurrentRow Is Nothing Then
            mblnValidatingClte = False
            If Me.RecordsState = RecordsState.Saved Then
                chkVencimientoManual.Enabled = True
                chkIVAManual.Enabled = True
                ValidarVencimientos()
                TabFacturas_Click(TabFacturas, New EventArgs)
                ComprobarEntregasACuenta()

                If Not MBlnExpertisSAAS Then
                    If CurrentRow.Item("Estado") <> enumContabilizado.NoContabilizado Then
                        Me.ExecuteActions.Commands("Calcular Precio Optimo").Enabled = Janus.Windows.UI.InheritableBoolean.False
                    Else
                        Me.ExecuteActions.Commands("Calcular Precio Optimo").Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                End If
                Me.Contabilizado = (Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado)
                fwiEstado.Text = RecuperarDescripcionEnumerado("enumfccEstado", Me.CurrentRow("Estado"))
                If Not MBlnExpContabilidad Then
                    If Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado Then
                        Me.fwiEstado.Text = "Validada"
                    Else : Me.fwiEstado.Text = "Pendiente de Validar"
                    End If
                End If
                If Length(Me.CurrentRow("AñoDeclaracionIva")) > 0 AndAlso Length(Me.CurrentRow("NDeclaracionIva")) > 0 Then
                    ComprobarDeclarado(True)
                Else : ComprobarDeclarado(False)
                End If
            End If
            MostrarEstadoContabilizacion()
            'End If
            'ConfiguracionVencimientoManual(Me.CurrentRow("VencimientosManuales"))
            'ConfiguracionIVAManual(Me.CurrentRow("IVAManual"))
            CalcularTotalVencimientos()

            BloquearPorTicket()
            ComprobarIVAVencManual()
            ComprobarFacturasElectronicas()
            ComprobarFacturaElectronica(IIf(Length(Me.CurrentRow("DirecFacturaPDF")) > 0, True, False))
            LoadGridDefaultValues()
            ComprobarDeclaracionManual()
            DesglosarImporteLineas()
            ComprobarRiesgoCliente()
        End If

        CType(jngLineaFactura.DataSource, DataTable).DefaultView.RowFilter = FiltroComponentes.Compose(New AdoFilterComposer)

        HabilitarClienteEnvio(False, Me.CurrentRow)
    End Sub

    Protected Overridable Sub MntoFacturaVenta_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordAdded
        chkVencimientoManual.Enabled = False
        chkIVAManual.Enabled = False
        BloquearPorTicket()
        If Me.PnlRiesgo.Visible Then Me.PnlRiesgo.Visible = False
    End Sub

#Region " Linea Factura "

    Private Sub jngLineaFactura_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngLineaFactura.ColumnButtonClick
        With jngLineaFactura
            Select Case e.Column.Index
                Case .Columns("NumOferta").Index
                    sctOfertaComercial.Open()
                Case .Columns("SeguimientoTarifa").Position
                    CargarSeguimientoTarifa(.Value(e.Column.Index) & String.Empty, .Columns(e.Column.Index).Caption)
            End Select
        End With

    End Sub
    Private Sub jngLineaFactura_AdvSearchSelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchSelectionChangedEventArgs) Handles jngLineaFactura.AdvSearchSelectionChanged
        If e.Key = "RefCliente" Then
            If Not e.Selected Is Nothing AndAlso e.Selected.Rows.Count > 0 Then
                MIDArticuloRef = e.Selected.Rows(0)("IDArticulo")
            End If
        End If
    End Sub
    Private Sub CargarSeguimientoTarifa(ByVal strTexto As String, ByVal strLabel As String)
        Dim frm As New FormularioTexto
        frm.Text = strLabel
        frm.SoloLectura = False
        frm.Texto = strTexto
        frm.ShowDialog()
    End Sub

    Private Sub jngLineaFactura_ColumnsFormatted() Handles jngLineaFactura.ColumnsFormatted

        'TODO: EL FORMATEO DE LAS COLUMNAS DEBE HACERSE DESPUES DE CARGAR CUALQUIER LAYOUT

        jngLineaFactura.Columns("BotonAnalitica").Visible = mblnAnalitica

    End Sub

    Private Sub jngLineaFactura_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles jngLineaFactura.KeyDown
        If e.KeyCode = Keys.F4 Then
            With jngLineaFactura
                Select Case .Col
                    Case .Columns("NumOferta").Position
                        sctOfertaComercial.Open()
                    Case .Columns("SeguimientoTarifa").Position
                        CargarSeguimientoTarifa(.Value(.Columns("SeguimientoTarifa").Position) & String.Empty, .Columns("SeguimientoTarifa").Caption)
                End Select
            End With
        End If
    End Sub

    Private Sub jngLineaFactura_RecordsLoaded() Handles jngLineaFactura.RecordsLoaded
        DesglosarImporteLineas()
    End Sub

    Private Sub jngLineaFactura_RecordsDeleted(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles jngLineaFactura.DeletingRecord
        DesglosarImporteLineas()
    End Sub

    Private Sub DesglosarImporteLineas()
        If Not jngLineaFactura.DataSource Is Nothing Then
            Dim dtLineas As DataTable = jngLineaFactura.DataSource.copy

            fwiImpLineasNormales.Value = 0
            fwiImpLineasNormalesA.Value = 0
            fwiImpLineasNormalesB.Value = 0

            fwiImpLineasEspeciales.Value = 0
            fwiImpLineasEspecialesA.Value = 0
            fwiImpLineasEspecialesB.Value = 0


            Dim ImportesNormales As New DataView(dtLineas, "Especial=0", Nothing, DataViewRowState.CurrentRows)
            If ImportesNormales.Count > 0 Then
                For Each drImportes As DataRowView In ImportesNormales
                    If drImportes.Row.RowState <> DataRowState.Deleted Then
                        fwiImpLineasNormales.Value += Nz(drImportes.Row("Importe"), 0)
                        fwiImpLineasNormalesA.Value += Nz(drImportes.Row("ImporteA"), 0)
                        fwiImpLineasNormalesB.Value += Nz(drImportes.Row("ImporteB"), 0)
                    End If
                Next
            End If


            Dim ImportesEspeciales As New DataView(dtLineas, "Especial=1", Nothing, DataViewRowState.CurrentRows)
            If ImportesEspeciales.Count > 0 Then
                For Each drImportes As DataRowView In ImportesEspeciales
                    If drImportes.Row.RowState <> DataRowState.Deleted Then
                        fwiImpLineasEspeciales.Value += Nz(drImportes.Row("Importe"), 0)
                        fwiImpLineasEspecialesA.Value += Nz(drImportes.Row("ImporteA"), 0)
                        fwiImpLineasEspecialesB.Value += Nz(drImportes.Row("ImporteB"), 0)
                    End If
                Next
            End If

            Dim intDecimalesMoneda As Integer = 2
            If Not fwiIdMoneda.SelectedRow Is Nothing Then
                intDecimalesMoneda = Nz(fwiIdMoneda.SelectedRow("NDecimalesImp"), 2)
            End If

            If Me.RecordsState = RecordsState.Modified AndAlso Not Me.CurrentRow Is Nothing Then
                fwiImpLinMon.Value = xRound(fwiImpLineasNormales.Value + fwiImpLineasEspeciales.Value, intDecimalesMoneda)
                fwiImpLineasA.Value = xRound(fwiImpLineasNormalesA.Value + fwiImpLineasEspecialesA.Value, MonInfoA.NDecimalesImporte)
                fwiImpLineasB.Value = xRound(fwiImpLineasNormalesB.Value + fwiImpLineasEspecialesB.Value, MonInfoB.NDecimalesImporte)
            End If
        End If
    End Sub

    Protected Overridable Sub jngLineaFactura_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles jngLineaFactura.AdvSearchSetPredefinedFilter
        With jngLineaFactura
            Select Case e.Key
                Case "IDArticulo"
                    Dim f As New CIMntoFilter
                    f.Add("Activo", FilterOperator.Equal, True, FilterType.Boolean)

                    Dim f1 As New CIMntoFilter
                    f1.InnerFilter.UnionOperator = FilterUnionOperator.Or
                    f1.Add("Venta", FilterOperator.Equal, True, FilterType.Boolean)
                    f1.Add("Especial", FilterOperator.Equal, True, FilterType.Boolean)
                    f.Add(f1.InnerFilter)

                    e.Filter.Add(f.InnerFilter)
                Case "RefCliente"
                    If Len(AdvIDCliente.Text) Then
                        e.Filter.Add(New StringFilterItem("IDCliente", FilterOperator.Equal, AdvIDCliente.Text))
                    End If
                Case "IDObra"
                    e.Filter.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumocEstado.ocTerminado))
                Case "CodTrabajo"
                    If IsNumeric(.Value("IDObra")) Then
                        e.Filter.Add(New NumberFilterItem("IDObra", FilterOperator.Equal, .Value("IDObra")))
                    End If
                Case "NObra"
                    If Len(AdvIDCliente.Text) > 0 And mblnGestionAlquileres Then
                        e.Filter.Add(New StringFilterItem("IDCliente", FilterOperator.Equal, AdvIDCliente.Text))
                    End If
                Case "IDLineaAlbaran"
                    If IsNumeric(.Value("IDAlbaran")) Then
                        e.Filter.Add(New NumberFilterItem("IdAlbaran", FilterOperator.Equal, .Value("IDAlbaran")))
                        If mblnGestionAlquileres Then
                            If IsNumeric(.Value("IdObra")) Then
                                e.Filter.Add(New NumberFilterItem("IdObra", FilterOperator.Equal, .Value("IdObra")))
                            End If
                            If IsNumeric(.Value("IdTrabajo")) Then
                                e.Filter.Add(New NumberFilterItem("IdTrabajo", FilterOperator.Equal, .Value("IdTrabajo")))
                            End If
                        End If
                    End If
                Case "CContable"
                    If Len(fwiIDEjercicio.Text) Then
                        e.Filter.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, fwiIDEjercicio.Text))
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub jngLineaFactura_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngLineaFactura.EditingCell
        'Dim contabilizado As Boolean
        If Not IsNothing(Me.CurrentData) AndAlso Me.CurrentData.Rows.Count Then
            Me.Contabilizado = (Me.CurrentRow("estado") = enumfvcEstado.fvcContabilizado)
        End If

        With jngLineaFactura
            If Not Contabilizado AndAlso Not Me.chkIVAManual.Checked AndAlso Not Me.chkVencimientoManual.Checked _
                            AndAlso Not (Length(.GetValue("IDPromocion")) > 0 And .GetValue("Regalo")) _
                            AndAlso Not (Length(.GetValue("IDPromocion")) > 0 And Length(.GetValue("IDLineaAlbaran")) > 0) Then
                If Length(.GetValue("IDAlbaran")) = 0 Then
                    Select Case e.Column.Key
                        Case "IDUDMedida", "IDTipoLinea", "CContable", "IDTipoIva", "IDUDInterna", "RefCliente", "IDCentroGestion", "IDConcepto"
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                        Case "NObra", "CodTrabajo"
                            If .Row = Grid.newTopRowPosition OrElse Length(.Value(e.Column.Key)) = 0 Then
                                e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                            End If
                        Case "SeguimientoTarifa"
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
                            e.Cancel = True
                        Case "Importe", "IDPedido", "IDAlbaran"
                            e.Cancel = True
                        Case "Dto", "DtoProntoPago"
                            e.Cancel = Nz(.Value("Especial"), 0)
                        Case "IDUDInterna", "IDUDInterna2"
                            e.Column.ButtonStyle = ButtonStyle.NoButton
                            e.Cancel = True
                        Case "IDArticulo"
                            If .Row <> .newTopRowPosition Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            Else
                                e.Column.ButtonStyle = ButtonStyle.Image
                                e.Column.EditType = EditType.TextBox
                            End If
                        Case "Factor"
                            e.Cancel = True
                    End Select
                Else
                    Select Case e.Column.Key
                        Case "IDArticulo"
                            e.Column.ButtonStyle = ButtonStyle.NoButton
                            e.Cancel = True
                        Case "NObra", "CodTrabajo"
                            If .Row = Grid.newTopRowPosition OrElse Length(.Value(e.Column.Key)) = 0 Then
                                e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                            End If
                        Case "SeguimientoTarifa"
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
                            e.Cancel = True
                        Case "Importe", "IDPedido", "IDAlbaran", "Cantidad", "QInterna", "QInterna2"
                            e.Cancel = True
                        Case "Dto", "DtoProntoPago"
                            e.Cancel = Nz(.Value("Especial"), 0)
                        Case "IDUDInterna", "IDUDInterna2", "IDUDMedida"
                            e.Column.ButtonStyle = ButtonStyle.NoButton
                            e.Cancel = True
                        Case "Factor"
                            e.Cancel = True
                    End Select
                End If
            ElseIf e.Column.Key <> "DescArticulo" And e.Column.Key <> "DescRefCliente" Then
                e.Cancel = True
                e.Column.ButtonStyle = ButtonStyle.NoButton
            End If
            'If e.Column.Key = "IDArticulo" AndAlso Me.jngLineaFactura.Row <> Grid.newTopRowPosition Then
            '    e.Column.ButtonStyle = ButtonStyle.NoButton
            '    e.Cancel = True
            'End If
        End With
    End Sub

    Private Sub jngLineaFactura_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngLineaFactura.AddingRecord
        e.Cancel = Not ValidarDatos(True)
    End Sub

    Private Function ValidarDatos(ByVal AddingRecord As Boolean) As Boolean
        ValidarDatos = True
        With jngLineaFactura

            'PRECIO CERO
            If Nz(.GetValue("Precio"), 0) = 0 And Not .GetValue("Regalo") Then
                ExpertisApp.GenerateMessage("El precio es 0, seleccione el tipo de línea correspondiente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)
            End If

            'PROMOCIONES
            If Length(.GetValue("IDPromocion")) > 0 AndAlso Length(.GetValue("IDLineaAlbaran")) = 0 Then
                Dim dv As New DataView(CType(.DataSource, DataTable).Copy)
                Dim f As New Filter
                f.Add(New StringFilterItem("IDPromocion", .Value("IDPromocion")))
                f.Add(New StringFilterItem("IdArticulo", .Value("IdArticulo")))
                'If .Row <> Grid.newTopRowPosition Then
                '    f.Add(New StringFilterItem("IDLineaFactura", FilterOperator.NotEqual, .Value("IDLineaFactura")))
                'End If
                Dim NumRegistros As Integer
                If AddingRecord Then : NumRegistros = 0
                Else : NumRegistros = 1
                End If
                dv.RowFilter = f.Compose(New AdoFilterComposer)
                If dv.Count > NumRegistros Then
                    ExpertisApp.GenerateMessage("No se puede promocionar dos veces el mismo Artículo en una misma Factura.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ValidarDatos = False
                End If
            End If
        End With
    End Function

    Protected Overridable Sub jngLineaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngLineaFactura.Click
        If Me.RecordsState = RecordsState.Saved Then
            Dim hit As GridArea
            With jngLineaFactura
                hit = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "BotonAnalitica"
                                Analitica()
                            Case "BotonRepresentante"
                                Representantes()
                            Case "CopiaLineaAlbaran"
                                CopiarLineaAlbaran()
                            Case "Texto"
                                FormularioObservaciones()
                            Case "Impuestos"
                                Dim blnSoloLectura As Boolean = (Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado)
                                blnSoloLectura = blnSoloLectura OrElse (Length(Me.CurrentRow("AñoDeclaracionIva")) > 0 AndAlso Length(Me.CurrentRow("NDeclaracionIva")) > 0)
                                CommonClasses.Impuestos(jngLineaFactura, Me.CurrentRow, ndImpuestos.Data, Circuito.Ventas, "FacturaVentaImpuesto", "vFrmMntoFacturaVentaImpuestos", "tbFacturaVentaLinea", "FechaFactura", "IDFactura", blnSoloLectura)
                        End Select
                    Else
                        Select Case c.Key
                            Case "Impuestos"
                                Dim blnSoloLectura As Boolean = (Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado)
                                blnSoloLectura = blnSoloLectura OrElse (Length(Me.CurrentRow("AñoDeclaracionIva")) > 0 AndAlso Length(Me.CurrentRow("NDeclaracionIva")) > 0)
                                If Length(Me.CurrentRow("IDFactura")) > 0 AndAlso Length(jngLineaFactura.Value("IDLineaFactura")) > 0 Then
                                    CommonClasses.Impuestos(jngLineaFactura, Me.CurrentRow, ndImpuestos.Data, Circuito.Ventas, "FacturaVentaImpuesto", "vFrmMntoFacturaVentaImpuestos", "tbFacturaVentaLinea", "FechaFactura", "IDFactura", blnSoloLectura)
                                End If
                        End Select
                    End If
                End If
            End With
        End If
    End Sub

    Public Sub Analitica()
        With jngLineaFactura
            If .Row <> Grid.newTopRowPosition And Length(.Value("IDArticulo")) > 0 AndAlso Length(.GetValue("CContable")) > 0 AndAlso Length(Me.CurrentRow("IDEjercicio")) > 0 Then
                If ComprobarAnaliticaCuentas(.GetValue("CContable"), Me.CurrentRow("IDEjercicio")) Then
                    Dim frm As New CommonClasses.Analitica
                    frm.EntityName = "FacturaVentaLinea"
                    frm.ViewName = "tbFacturaVentaLinea"
                    frm.jngAnalitica.EntityName = "FacturaVentaAnalitica"
                    frm.jngAnalitica.PrimaryDataFields = "IDLineaFactura"
                    frm.jngAnalitica.SecondaryDataFields = "IDLineaFactura"
                    frm.jngAnalitica.ViewName = "VfrmMntoFacturaVentaAnalitica"
                    frm.SoloLectura = Me.Contabilizado
                    frm.IDMoneda = Me.CurrentRow("IDMoneda")
                    frm.CambioA = Me.CurrentRow("CambioA")
                    frm.CambioB = Me.CurrentRow("CambioB")
                    frm.Fecha = Me.CurrentRow("FechaFactura")
                    frm.FilterCriteria = New NumberFilterItem("IDLineaFactura", FilterOperator.Equal, .Value("IDLineaFactura"))
                    frm.ShowDialog()
                    frm.Dispose()
                End If
            End If
        End With
    End Sub

    Public Sub Representantes()
        With jngLineaFactura
            If .Row <> Grid.newTopRowPosition And Len(.Value("IDArticulo") & String.Empty) Then
                Dim f As New BE.DataEngine
                Dim dt As DataTable
                dt = f.RetrieveData("vNegCaractArticulo", "Especial", New StringFilterItem("IDArticulo", FilterOperator.Equal, .Value("IDArticulo")))
                If Not IsNothing(dt) AndAlso dt.Rows.Count Then
                    If Not dt.Rows(0)("Especial") Then
                        Dim frm As New CommonClasses.Representantes
                        frm.EntityName = "FacturaVentaLinea"
                        frm.NavigationFields = "IDLineaFactura"
                        frm.ViewName = "tbFacturaVentaLinea"
                        frm.jngRepresentantes.EntityName = "FacturaVentaRepresentante"
                        frm.jngRepresentantes.PrimaryDataFields = "IDLineaFactura"
                        frm.jngRepresentantes.SecondaryDataFields = "IDLineaFactura"
                        frm.jngRepresentantes.ViewName = "VFrmMntoFacturaVentaRepresentante"
                        frm.IDCliente = Me.CurrentRow("IDCliente")
                        frm.SoloLectura = False 'Me.Contabilizado
                        frm.IDMoneda = Me.CurrentRow("IDMoneda")
                        frm.Fecha = Me.CurrentRow("FechaFactura")
                        frm.FilterCriteria = New NumberFilterItem("IDLineaFactura", FilterOperator.Equal, .Value("IDLineaFactura"))
                        frm.ShowDialog()
                        frm.Dispose()
                    End If
                End If
            End If
        End With
    End Sub

    Public Sub CopiarLineaAlbaran()
        ExpertisApp.GenerateMessage("CopiarLineaAlbaran")
    End Sub

    Public Sub FormularioObservaciones()
        With jngLineaFactura
            Dim frm As New FormularioTexto
            frm.Texto = .GetValue("Texto") & String.Empty
            If frm.ShowDialog = DialogResult.OK Then
                If .GetValue("Texto") & String.Empty <> frm.Texto Then
                    .SetValue("Texto", frm.Texto)
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub jngLineaFactura_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngLineaFactura.UpdatingCell
        With jngLineaFactura
            Select Case e.Column.Key
                Case "CContable"
                    Dim objNegEjercicio As New EjercicioContable
                    Dim strEjercicio As String = Me.CurrentRow("IDEjercicio")
                    Dim intDigitosAuxiliar As Integer = objNegEjercicio.GetNDigitosAuxiliar(strEjercicio)

                    e.Value = PuntoPorCero(Nz(e.Value, String.Empty), intDigitosAuxiliar, strEjercicio)
                Case "Dto1", "Dto2", "Dto3", "Dto", "DtoProntoPago"
                    If e.Value > 100 Then
                        ExpertisApp.GenerateMessage("El Descuento introducido no puede ser superior a 100%.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                    End If
            End Select
        End With
    End Sub

    Private Sub jngLineaFactura_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngLineaFactura.CellUpdated
        Select Case e.Column.Key
            Case "IDArticulo"
                If mblnAbrirEvaluador Then
                    If ExpertisApp.GenerateMessage("Este Artículo es configurable. ¿Desea realizar su configuración.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        mintRow = jngLineaFactura.Row
                        mOriginalValueArticulo = jngLineaFactura.Value("IDArticulo")
                        mOriginalValueCantidad = jngLineaFactura.Value("Cantidad")
                        mIDArticuloConfig = jngLineaFactura.Value("IDArticulo")
                        jngLineaFactura.UpdateOnLeave = False
                        Dim HT As New Hashtable
                        HT("IDArticulo") = jngLineaFactura.Value("IDArticulo")
                        Dim oFrm As Object = ExpertisApp.OpenForm("EVALUADOR", , HT)
                        AddHandler CType(oFrm, Form).Disposed, AddressOf FrmActionClosed
                    End If
                    mblnAbrirEvaluador = False
                End If
        End Select
    End Sub

    Private Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Disposed, AddressOf FrmActionClosed

        If Length(sender.IDArticuloConfigurado) > 0 Then
            mIDArticuloConfig = sender.IDArticuloConfigurado
        End If

        jngLineaFactura.Row = mintRow
        jngLineaFactura.InvokeBusinessRules("IDArticulo", mIDArticuloConfig, mOriginalValueArticulo)
        jngLineaFactura.InvokeBusinessRules("Cantidad", 1, mOriginalValueCantidad)
        Dim blnCancel As Boolean = Not ValidarDatos(jngLineaFactura.Row = Grid.newTopRowPosition)
        If Not blnCancel Then
            jngLineaFactura.UpdateOnLeave = True
            jngLineaFactura.UpdateData()
            mOriginalValueArticulo = String.Empty
            mOriginalValueCantidad = 0
        End If
    End Sub

    Private Sub jngLineaFactura_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngLineaFactura.RecordAdded, jngLineaFactura.RecordUpdated, jngLineaFactura.RecordsDeleted
        jngLineaFactura.DataSource = TratarOrdenesLinea(jngLineaFactura.DataSource, "IDOrdenLinea", True)
    End Sub

    Private Sub jngLineaFactura_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles jngLineaFactura.MouseUp
        With jngLineaFactura
            If e.Button = MouseButtons.Right Then
                If Not IsNothing(jngLineaFactura) AndAlso .RowCount > 0 Then
                    .UiCommandManager1.ContextMenus(2).Commands(cnABRIRPEDIDOVENTA).IsVisible = IIf(Length(.GetValue("IDPedido")) > 0, True, False)
                    .UiCommandManager1.ContextMenus(2).Commands(cnABRIRALBARANVENTA).IsVisible = IIf(Length(.GetValue("IDAlbaran")) > 0, True, False)
                    .UiCommandManager1.ContextMenus(2).Commands(cnABRIROFERTA).IsVisible = IIf(Length(.GetValue("IDLineaOfertaDetalle")) > 0, True, False)
                    .UiCommandManager1.ContextMenus(2).Commands(cnABRIROBRA).IsVisible = IIf(Length(.GetValue("IDObra")) > 0, True, False)
                    .UiCommandManager1.ContextMenus(2).Commands(cnABRIRPROMOCION).IsVisible = IIf(Length(.GetValue("IDPromocion")) > 0, True, False)
                    If mblnGestionAlquileres Then
                        .UiCommandManager1.ContextMenus(2).Commands(cnABRIRALQUILER).IsVisible = IIf(Length(.GetValue("IDObra")) > 0, True, False)
                        .UiCommandManager1.ContextMenus(2).Commands(cnABRIRALBARANRETORNO).IsVisible = IIf(Length(.GetValue("IDAlbaranRetorno")) > 0, True, False)
                        .UiCommandManager1.ContextMenus(2).Commands(cnABRIRORDENSERVICIO).IsVisible = IIf(Length(.GetValue("IdTrabajo")) > 0, True, False)
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub jngLineaFactura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngLineaFactura.GotFocus
        LoadGridDefaultValues()
    End Sub

#End Region

#Region " Lineas Vencimiento "

    Private Sub chkVencimientoManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVencimientoManual.Click
        If chkVencimientoManual.Checked Then
            Dim dtGridVtos As DataTable = jngVencimientos.DataSource
            Dim objFilter As New Filter
            objFilter.Add(New IsNullFilterItem("IDEntrega", False))
            Dim adr() As DataRow = dtGridVtos.Select(objFilter.Compose(New AdoFilterComposer))
            If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                ExpertisApp.GenerateMessage("Existen Vencimientos provenientes de Entregas a Cuenta.|" & _
                    "No es posible establecer los Vencimientos de forma automática.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                chkVencimientoManual.Checked = False
            End If
            jngVencimientos.Columns("IDProveedor").DefaultValue = advIDProveedor.Text
            jngVencimientos.Columns("IDOperario").DefaultValue = advIDOperario.Text
        End If
    End Sub

    'Private Sub ConfiguracionVencimientoManual(ByVal EsManual As Boolean)
    '    If Me.CurrentRow Is Nothing Then Exit Sub
    '    If EsManual AndAlso Me.CurrentRow("estado") = enumfvcEstado.fvcNoContabilizado Then
    '        jngVencimientos.AllowEdit = Janus.Windows.UI.InheritableBoolean.True
    '        jngVencimientos.AllowAddNew = Janus.Windows.UI.InheritableBoolean.True
    '        jngVencimientos.AllowDelete = Janus.Windows.UI.InheritableBoolean.True

    '        jngVencimientos.Columns("IDFormaPago").ButtonStyle = ButtonStyle.Image
    '    Else
    '        jngVencimientos.AllowEdit = Janus.Windows.UI.InheritableBoolean.False
    '        jngVencimientos.AllowAddNew = Janus.Windows.UI.InheritableBoolean.False
    '        jngVencimientos.AllowDelete = Janus.Windows.UI.InheritableBoolean.False

    '        jngVencimientos.Columns("IDFormaPago").ButtonStyle = ButtonStyle.NoButton
    '    End If
    'End Sub

    Private Function ComprobarVencimientos() As Double
        'Dim dblImporteFactura As Double
        If Not Me.CurrentRow Is Nothing Then
            If Me.CurrentData.Rows.Count > 0 Then
                If Me.CurrentRow("estado") <> enumfvcEstado.fvcContabilizado Then
                    If chkVencimientoManual.Checked Then
                        'dblImporteFactura = fwiTotal.Value - fwiImpRecFinan.Value - (fwiTotalBaseImp.Value * fwiPorcIRPF.Value / 100)
                        If jngVencimientos.RowCount > 0 Then
                            Dim jFilter As New GridEXFilterCondition(jngVencimientos.Columns("CobroCompensacion"), ConditionOperator.Equal, 0)
                            Dim dblTotal As Double = xRound(jngVencimientos.GetTotal(jngVencimientos.Columns("ImpVencimiento"), Janus.Windows.GridEX.AggregateFunction.Sum, jFilter), MonInfoA.NDecimalesImporte)
                            'dblTotal = dblTotal + jngVencimientos.GetTotal(jngVencimientos.Columns("RecargoFinanciero"), Janus.Windows.GridEX.AggregateFunction.Sum, jFilter)
                            ComprobarVencimientos = dblTotal - xRound(Me.CurrentRow("ImpTotal"), MonInfoA.NDecimalesImporte)
                        End If
                    End If
                End If
            End If
        End If
    End Function

    Private Sub ValidarVencimientos(Optional ByRef blnCancel As Boolean = False, Optional ByVal blnSelectTab As Boolean = True)
        Dim mdblDiff As Double = ComprobarVencimientos()
        If mdblDiff <> 0 Then
            ExpertisApp.GenerateMessage("La suma de los Vencimientos no coincide con el Importe de la Factura. Diferencia: |", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, mdblDiff)
            blnCancel = True
            If blnSelectTab Then If Not TabFacturas.TabPages("Vencimientos").Selected Then TabFacturas.TabPages("Vencimientos").Selected = True
            jngVencimientos.Focus()
            jngVencimientos.Col = jngVencimientos.Columns("ImpVencimiento").Index
            jngVencimientos.EditMode = Janus.Windows.GridEX.EditMode.EditOn
        End If
    End Sub

    Private Sub jngVencimientos_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngVencimientos.AddingRecord
        If Length(jngVencimientos.GetValue("FechaVencimiento")) > 0 Then jngVencimientos.SetValue("FechaVencimientoFactura", jngVencimientos.GetValue("FechaVencimiento"))
    End Sub

    Private Sub jngVencimientos_RecordUpdated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngVencimientos.RecordUpdated
        ValidarVencimientos()
    End Sub

    Private Sub jngVencimientos_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngVencimientos.GotFocus
        With jngVencimientos
            .Columns("IdFormaPago").DefaultValue = Me.CurrentRow("IDFormaPago")
            .Columns("RecargoFinanciero").DefaultValue = 0
            .Columns("IDMoneda").DefaultValue = Me.CurrentRow(("IDMoneda"))
            .Columns("IdClienteBanco").DefaultValue = Me.CurrentRow(("IdClienteBanco"))
            .Columns("IDBancoPropio").DefaultValue = Me.CurrentRow(("IDBancoPropio"))
            .Columns("NFactura").DefaultValue = Me.CurrentRow(("NFactura"))
            .Columns("IDFactura").DefaultValue = Me.CurrentRow(("IDFactura"))
            .Columns("CambioA").DefaultValue = Me.CurrentRow(("CambioA"))
            .Columns("CambioB").DefaultValue = Me.CurrentRow(("CambioB"))
            .Columns("IDCliente").DefaultValue = Me.CurrentRow(("IDCliente"))
            .Columns("Titulo").DefaultValue = Me.CurrentRow(("RazonSocial"))
            .Columns("CContable").DefaultValue = Me.CurrentRow("CCCliente")
            If Length(Me.CurrentRow("IDTipoAsiento")) > 0 Then
                Select Case CInt(Me.CurrentRow("IdTipoAsiento"))
                    Case enumTipoAsientoFV.taBancoSinCobro
                        .Columns("Contabilizado").DefaultValue = enumCobroContabilizado.CobroContabilizado
                        .Columns("Situacion").DefaultValue = enumCobroSituacion.Cobrado
                    Case enumTipoAsientoFV.taClienteConCobroNNyNC
                        .Columns("Contabilizado").DefaultValue = enumCobroContabilizado.CobroNoContabilizado
                        .Columns("Situacion").DefaultValue = enumCobroSituacion.NoNegociado
                    Case enumTipoAsientoFV.taClienteConCobroCyNC
                        .Columns("Contabilizado").DefaultValue = enumCobroContabilizado.CobroNoContabilizado
                        .Columns("Situacion").DefaultValue = enumCobroSituacion.Cobrado
                    Case enumTipoAsientoFV.taClienteSinCobro
                        .Columns("Contabilizado").DefaultValue = enumCobroContabilizado.CobroContabilizado
                        .Columns("Situacion").DefaultValue = enumCobroSituacion.Cobrado
                End Select
            End If
        End With
    End Sub

    Private Sub jngVencimientos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles jngVencimientos.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(jngVencimientos) AndAlso jngVencimientos.RowCount > 0 Then
                jngVencimientos.UiCommandManager1.Commands(cnINFOCHEQUE).Visible = InheritableBoolean.False
                jngVencimientos.UiCommandManager1.Commands(cnINFOTARJETA).Visible = InheritableBoolean.False

                If Nz(jngVencimientos.Value("ChequeTalon"), False) Then
                    jngVencimientos.UiCommandManager1.Commands(cnINFOCHEQUE).Visible = InheritableBoolean.True
                End If
                If Nz(jngVencimientos.Value("Tarjeta"), False) Then
                    jngVencimientos.UiCommandManager1.Commands(cnINFOTARJETA).Visible = InheritableBoolean.True
                End If
            End If
        End If
    End Sub

    Private Sub CalcularTotalVencimientos()
        txtTotalVtos.Text = Format(jngVencimientos.GetTotal(jngVencimientos.Columns("ImpVencimiento"), AggregateFunction.Sum), "#,##0.00")
        If CDbl(txtTotalVtos.Text) < 0 Then
            txtTotalVtos.ForeColor = Color.Red
        Else
            txtTotalVtos.ForeColor = Color.Blue
        End If
        ulAbreviaturaMoneda.ForeColor = txtTotalVtos.ForeColor
    End Sub

    Private Sub LoadNedeedDataImpuestos()
        ndImpuestos = New ProviderNeededData
        ndImpuestos.Name = "Impuestos"
        ndImpuestos.EntityName = "FacturaVentaImpuesto"
        Dim s(0) As String
        s(0) = "IDFactura"
        ndImpuestos.PrimaryDataFields = s
        ndImpuestos.SecondaryDataFields = s
        ndImpuestos.RelationMode = RelationMode.ChildMode
        ndImpuestos.ViewName = "vFrmMntoFacturaVentaImpuestos"
        ndImpuestos.UpdateOrder = -1

        Me.AddDataItem(ndImpuestos)
    End Sub
#End Region

#Region " Lineas IVA "

    Private Sub chkIVAManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIVAManual.CheckedChanged
        ComprobarIVAVencManual()
        'ConfiguracionIVAManual(chkIVAManual.Checked)
    End Sub

    'Private Sub ConfiguracionIVAManual(ByVal EsManual As Boolean)
    '    If Me.CurrentRow Is Nothing Then Exit Sub
    '    If EsManual AndAlso Me.CurrentRow("estado") = enumfvcEstado.fvcNoContabilizado Then
    '        jngBaseImponible.AllowEdit = Janus.Windows.UI.InheritableBoolean.True
    '        jngBaseImponible.AllowAddNew = Janus.Windows.UI.InheritableBoolean.True
    '        jngBaseImponible.AllowDelete = Janus.Windows.UI.InheritableBoolean.True
    '    Else
    '        jngBaseImponible.AllowEdit = Janus.Windows.UI.InheritableBoolean.False
    '        jngBaseImponible.AllowAddNew = Janus.Windows.UI.InheritableBoolean.False
    '        jngBaseImponible.AllowDelete = Janus.Windows.UI.InheritableBoolean.False
    '    End If
    'End Sub

#End Region

    Private Sub FwSearchDireccion_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles FwSearchDireccion.SelectionChanged
        AdvDirecFra.Value = e.Selected.Rows(0)("IDDireccion")
    End Sub

    Private Sub FwSearchDireccion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles FwSearchDireccion.SetPredefinedFilter
        'En el botón de búsqueda de direcciones de envio hacemos que únicamente salgan aquellas
        'correspondiente al cliente seleccionado, si dicho cliente tiene un grupo, las direcciones
        'que aparecerán serán las correspondientes a ese cliente-grupo.

        'Comprobamos si el cliene tiene grupo.
        Dim StData As New Cliente.DataGrupoCliente
        If ExpertisApp.ExecuteTask(Of String, String)(AddressOf ExtensibilidadProgramaCabecera.TipoCliente, AdvIDCliente.Text) <> ExpertisApp.ExecuteTask(Of Object, String)(AddressOf JMAParametro.ClienteVarios, Nothing) Then
            StData.IDCliente = AdvIDCliente.Text : StData.TipoGrupo = "Direccion"
        Else
            StData.IDCliente = advClienteEnvio.Text : StData.TipoGrupo = "Direccion"
        End If
        Dim strIDGrupoDireccion As String = ExpertisApp.ExecuteTask(Of Cliente.DataGrupoCliente, String)(AddressOf Cliente.Grupo, StData)

        If strIDGrupoDireccion <> String.Empty Then
            e.Filter.Add("idcliente", FilterOperator.Equal, strIDGrupoDireccion)
        Else
            e.Filter.Add("idcliente", FilterOperator.Equal, StData.IDCliente)
        End If
        e.Filter.Add(New BooleanFilterItem("Factura", FilterOperator.Equal, True))
        e.ForcePredefinedFilter = True
    End Sub

    Private Sub fwiIdClteBanco_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles fwiIdClteBanco.SelectionChanged
        If Not fwiIdClteBanco.SelectedRow Is Nothing Then
            ActualizarMandato(fwiIdClteBanco.SelectedRow("IDCliente") & String.Empty, Nz(fwiIdClteBanco.SelectedRow("IDClienteBanco"), 0), Nz(Me.CurrentRow("IDClienteBanco"), 0))
        End If
    End Sub


    Private Sub ActualizarMandato(ByVal IDCliente As String, ByVal IDClienteBanco As Integer, ByVal IDClienteBancoOld As Integer)
        If Length(IDCliente) > 0 AndAlso IDClienteBanco <> 0 Then
            ActualizarMandatoFactura(IDCliente, IDClienteBanco, IDClienteBancoOld)
        End If
    End Sub

    Private Sub ActualizarMandatoFactura(ByVal IDCliente As String, ByVal IDClienteBanco As Integer, ByVal IDClienteBancoOld As Integer)
        Dim blnNoMandato As Boolean
        Dim f As New Filter
        f.Add(New BooleanFilterItem("Predeterminado", True))
        f.Add(New NumberFilterItem("IDClienteBanco", IDClienteBanco))
        f.Add(New StringFilterItem("IDCliente", IDCliente))
        Dim dtMandatoPred As DataTable = New BE.DataEngine().Filter("tbMaestroMandato", f)
        If dtMandatoPred.Rows.Count > 0 Then
            If Nz(dtMandatoPred.Rows(0)("IDMandato"), 0) <> Nz(advMandato.Value, 0) Then
                If ExpertisApp.GenerateMessage("La Modificación del Banco del Cliente actualizará la información del Mandato ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If Nz(dtMandatoPred.Rows(0)("IDMandato"), 0) <> 0 Then
                        advMandato.Value = dtMandatoPred.Rows(0)("IDMandato")
                    Else
                        blnNoMandato = True
                    End If
                Else
                    fwiIdClteBanco.Value = IDClienteBancoOld
                    fwiIdClteBanco.Text = IDClienteBancoOld
                    Me.CurrentRow("IDClienteBanco") = IDClienteBancoOld
                End If
            End If
        Else
            blnNoMandato = True
        End If

        If blnNoMandato Then
            If ExpertisApp.GenerateMessage("El Banco del Cliente seleccionado no tiene un Mandato asociado ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                advMandato.Value = System.DBNull.Value
            Else
                fwiIdClteBanco.Value = IDClienteBancoOld
                fwiIdClteBanco.Text = IDClienteBancoOld
                Me.CurrentRow("IDClienteBanco") = IDClienteBancoOld
            End If
        End If
    End Sub

    Private Sub fwiIdClteBanco_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles fwiIdClteBanco.SetPredefinedFilter
        If Length(AdvIDCliente.Text) Then
            e.Filter.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Text, FilterType.String)
        End If
    End Sub

    Private Sub fwiTextoFactura_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiTextoFactura.DoubleClick
        Dim frm As New FormularioTexto
        frm.Texto = fwiTextoFactura.Text & String.Empty
        frm.CrearObservaciones = True
        Dim res As DialogResult
        res = frm.ShowDialog()
        If res = DialogResult.OK Then
            If fwiTextoFactura.Text & String.Empty <> frm.Texto Then
                fwiTextoFactura.Text = frm.Texto
            End If
        End If
    End Sub

    Private Sub chkFechaDeclManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaDeclManual.CheckedChanged
        ComprobarDeclaracionManual()
    End Sub


    Private Sub MntoFacturaVenta_RecordStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordStateChanged
        If Me.RecordsState = RecordsState.Saved Then
            ComprobarEntregasACuenta()
        ElseIf Me.RecordsState = RecordsState.[New] Then
            Me.ErrorProvider1.SetError(Me.lblCliente, String.Empty)
        End If
        LoadGridDefaultValues()
    End Sub

    Private Sub ComprobarDeclaracionManual()
        If Length(Me.CurrentRow("NDeclaracionIVA")) > 0 AndAlso Length(Me.CurrentRow("AñoDeclaracionIVA")) > 0 Then
            Me.chkFechaDeclManual.Enabled = False
            Me.FwiFechaParaDeclaracion.Enabled = False
        Else
            Me.chkFechaDeclManual.Enabled = True
            If chkFechaDeclManual.Checked Then
                FwiFechaParaDeclaracion.Enabled = True
                FwiFechaParaDeclaracion.ReadOnly = False
            Else
                FwiFechaParaDeclaracion.Enabled = False
                FwiFechaParaDeclaracion.ReadOnly = True
            End If
        End If

    End Sub

    Private Sub EstadoRetencion()
        If (Not IsNothing(Me.CurrentData)) AndAlso (Me.CurrentData.Rows.Count > 0) Then
            If Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado Then
                fwiBaseRetencion.Enabled = False
            Else
                fwiBaseRetencion.Enabled = fwiRetencionManual.Checked
            End If

        End If
    End Sub

#Region " Business Call "

    Private Sub MntoFacturaVenta_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        Select Case e.EntityName
            Case "FacturaVentaCabecera"
                If e.Data.NewData.Contains("FechaFactura") Then
                    Me.CurrentRow("IDEjercicio") = System.DBNull.Value
                ElseIf e.Data.NewData.Contains("IDCliente") Then
                    '//JMA control sobre el tipo de documento del cliente
                    If Length(e.Data.NewData("IDCliente")) > 0 Then
                        Dim IDContadorTipoDocumento4 As String = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf JMAParametro.IDContadorFacturaVentaTipoDocumento4, Nothing)
                        If Length(CurrentRow("IDContador")) > 0 Then
                            If CurrentRow("IDContador") = IDContadorTipoDocumento4 Then
                                Dim cliente As DataTable = New Cliente().SelOnPrimaryKey(e.Data.NewData("IDCliente"))
                                If cliente.Rows.Count > 0 Then
                                    If cliente.Rows(0)("TipoDocIdentidad") = enumTipoDocIdent.DocOficialPais Then
                                        If Length(cliente.Rows(0)("CifCliente")) = 0 Then
                                            AdvIDCliente.Text = Nothing
                                            e.Cancel = True
                                            ExpertisApp.GenerateMessage("El documento del cliente | no es válido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, e.Data.NewData("IDCliente"))
                                        End If
                                    Else
                                        AdvIDCliente.Text = Nothing
                                        e.Cancel = True
                                        ExpertisApp.GenerateMessage("El tipo de documento del cliente | no es el documento identificativo del país.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, e.Data.NewData("IDCliente"))
                                    End If
                                End If
                            End If
                        End If
                    End If
                    '//
                End If
                e.Data.Context.Add("EsFacturaVenta", True)
            Case jngLineaFactura.EntityName
                e.Data.Context = New BusinessData(Me.CurrentRow)
                e.Data.Context("IDCliente") = Me.CurrentRow("IDCliente")
                e.Data.Context("IDEjercicio") = Me.CurrentRow("IDEjercicio")
                e.Data.Context("Fecha") = Me.CurrentRow("FechaFactura")
                e.Data.Context("IDMoneda") = Me.CurrentRow("IDMoneda")
                e.Data.Context("CambioA") = Me.CurrentRow("CambioA")
                e.Data.Context("CambioB") = Me.CurrentRow("CambioB")
                e.Data.Context("ValidarBloqueoArticulo") = True
                If MIDArticuloRef <> String.Empty Then e.Data.Context("IDArticuloRef") = MIDArticuloRef
                mblnCambioPrecioManual = False
                mblnCambioDescuentos = False
                mPrecioAnterior = Nz(e.Data.CurrentData("Precio"), 0)
                If e.Data.NewData.Contains("Precio") Then
                    mblnCambioPrecioManual = True
                ElseIf (e.Data.NewData.Contains("Dto1") OrElse e.Data.NewData.Contains("Dto2") OrElse e.Data.NewData.Contains("Dto3")) Then
                    mblnCambioDescuentos = True
                End If
            Case ndImpuestos.EntityName
                e.Cancel = True
            Case jngBaseImponible.EntityName
                'Gestión cambio base imponible para ajustar facturas 
                e.Data.Context = New BusinessData(Me.CurrentRow)
        End Select
    End Sub

    Private Sub MntoFacturaVenta_BusinessCalled(ByVal sender As Object, ByVal e As Engine.UI.BusinessCalledEventArgs) Handles MyBase.BusinessCalled
        If Not IsNothing(e.Data) Then
            Select Case e.EntityName
                Case jngLineaFactura.EntityName
                    If e.Data.ContainsKey("Configurable") Then
                        mblnAbrirEvaluador = e.Data.Item("Configurable")
                    End If
                    If jngLineaFactura.Row <> Grid.newTopRowPosition AndAlso ((Not mblnCambioPrecioManual AndAlso mPrecioAnterior <> e.Data("Precio")) OrElse _
                                                                              (Not mblnCambioDescuentos AndAlso (mDto1Anterior <> e.Data("Dto1") OrElse _
                                                                                                                 mDto2Anterior <> e.Data("Dto2") OrElse _
                                                                                                                 mDto3Anterior <> e.Data("Dto3")))) Then
                        If ExpertisApp.GenerateMessage("Ha cambiado el precio y/o descuentos. ¿Desea mantener el precio/descuentos anterior/es?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            e.Data("Dto1") = mDto1Anterior
                            e.Data("Dto2") = mDto2Anterior
                            e.Data("Dto3") = mDto3Anterior
                            e.Data = New FacturaVentaLinea().ApplyBusinessRule("Precio", mPrecioAnterior, e.Data, New BusinessData(Me.CurrentRow))
                        End If
                    End If
                    MIDArticuloRef = String.Empty
            End Select
        End If
    End Sub

#End Region

#Region " Informes "

    Private Sub MntoFacturaVenta_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        Select Case e.Alias
            Case "FACTCERTDES", "FACTCERTSIMP"
                e.Filter.Add("IDFactura", FilterOperator.Equal, Me.CurrentRow("IDFactura"))
        End Select
    End Sub

    Private Sub MntoFacturaVenta_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        e.AuxiliarTableSettings.CopiesDefaultvalue = Me.CurrentRow("NumeroCopias")

    End Sub

    Protected Overridable Sub MntoFacturaVenta_SetReportOptions(ByVal sender As Object, ByVal e As Engine.UI.ReportExportOptionsEventArgs) Handles MyBase.SetReportExportOptions
        e.Options.PromptUser = True
        If Length(Me.CurrentRow("Email")) > 0 Then e.Options.ExportToMail.MailToList = Me.CurrentRow("Email")

        Dim DtRpt As DataTable
        Select Case e.Alias
            Case "JMAFV"
                Dim DtCli As DataTable = New Cliente().SelOnPrimaryKey(Me.CurrentRow("IDCliente"))
                If DtCli.Rows.Count > 0 AndAlso Not IsDBNull(DtCli.Rows(0)("IDIdioma")) Then
                    Dim f As New Filter
                    f.Add("IDIdioma", FilterOperator.Equal, DtCli.Rows(0)("IDIdioma"))
                    f.Add("TipoDocumento", FilterOperator.Equal, Solmicro.Expertis.Business.AltunaMexicoEnum.enumTipoDocumentoIdioma.Factura)
                    DtRpt = New JMAFormatoDocumento().Filter(f)
                    If DtRpt.Rows.Count = 0 AndAlso IsDBNull(DtRpt.Rows(0)("Formato")) Then
                        Dim fPred As New Filter
                        fPred.Add("Predeterminado", FilterOperator.Equal, True)
                        fPred.Add("TipoDocumento", FilterOperator.Equal, Solmicro.Expertis.Business.AltunaMexicoEnum.enumTipoDocumentoIdioma.Factura)
                        DtRpt = New JMAFormatoDocumento().Filter(fPred)
                    End If
                Else
                    Dim fPred As New Filter
                    fPred.Add("Predeterminado", FilterOperator.Equal, True)
                    fPred.Add("TipoDocumento", FilterOperator.Equal, Solmicro.Expertis.Business.AltunaMexicoEnum.enumTipoDocumentoIdioma.Factura)
                    DtRpt = New JMAFormatoDocumento().Filter(fPred)
                End If
                If DtRpt.Rows.Count = 0 Then
                    Exit Select
                End If
                e.Cancel = True
                Dim rpt As New Report(DtRpt.Rows(0)("Formato").ToString)
                rpt.ExportOptions.PromptUser = True
                If Length(Me.CurrentRow("Email")) > 0 Then rpt.ExportOptions.ExportToMail.MailToList = Me.CurrentRow("Email")
                Dim dtDatos As DataTable = New FacturaVentaCabecera().SelOnPrimaryKey(Me.CurrentRow("IDFactura"))
                Dim auxTable As New ReportAuxiliarTable("FacturaVentaCabecera")
                'auxTable.Settings.CopiesSource = Me.CurrentRow("NumeroCopias")
                auxTable.DataSource = dtDatos
                rpt.DataSource = auxTable

                ExpertisApp.OpenReport(rpt)
            Case "NOTACRED"
                Dim DtCli As DataTable = New Cliente().SelOnPrimaryKey(Me.CurrentRow("IDCliente"))
                If DtCli.Rows.Count > 0 AndAlso Not IsDBNull(DtCli.Rows(0)("IDIdioma")) Then
                    Dim f As New Filter
                    f.Add("IDIdioma", FilterOperator.Equal, DtCli.Rows(0)("IDIdioma"))
                    f.Add("TipoDocumento", FilterOperator.Equal, Solmicro.Expertis.Business.AltunaMexicoEnum.enumTipoDocumentoIdioma.NotaCredito)
                    DtRpt = New JMAFormatoDocumento().Filter(f)
                    If DtRpt.Rows.Count = 0 AndAlso IsDBNull(DtRpt.Rows(0)("Formato")) Then
                        Dim fPred As New Filter
                        fPred.Add("Predeterminado", FilterOperator.Equal, True)
                        fPred.Add("TipoDocumento", FilterOperator.Equal, Solmicro.Expertis.Business.AltunaMexicoEnum.enumTipoDocumentoIdioma.NotaCredito)
                        DtRpt = New JMAFormatoDocumento().Filter(fPred)
                    End If
                Else
                    Dim fPred As New Filter
                    fPred.Add("Predeterminado", FilterOperator.Equal, True)
                    fPred.Add("TipoDocumento", FilterOperator.Equal, Solmicro.Expertis.Business.AltunaMexicoEnum.enumTipoDocumentoIdioma.NotaCredito)
                    DtRpt = New JMAFormatoDocumento().Filter(fPred)
                End If
                If DtRpt.Rows.Count = 0 Then
                    Exit Select
                End If
                Dim rpt As New Report(DtRpt.Rows(0)("Formato").ToString)
                rpt.ExportOptions.PromptUser = True
                If Length(Me.CurrentRow("Email")) > 0 Then rpt.ExportOptions.ExportToMail.MailToList = Me.CurrentRow("Email")
                Dim dtDatos As DataTable = New FacturaVentaCabecera().SelOnPrimaryKey(Me.CurrentRow("IDFactura"))
                Dim auxTable As New ReportAuxiliarTable("FacturaVentaCabecera")
                'auxTable.Settings.CopiesSource = Me.CurrentRow("NumeroCopias")
                auxTable.DataSource = dtDatos
                rpt.DataSource = auxTable
                e.Cancel = True
                ExpertisApp.OpenReport(rpt)
            Case "JMAFVBOLETA"
                Dim DtCli As DataTable = New Cliente().SelOnPrimaryKey(Me.CurrentRow("IDCliente"))
                If DtCli.Rows.Count > 0 AndAlso Not IsDBNull(DtCli.Rows(0)("IDIdioma")) Then
                    Dim f As New Filter
                    f.Add("IDIdioma", FilterOperator.Equal, DtCli.Rows(0)("IDIdioma"))
                    f.Add("TipoDocumento", FilterOperator.Equal, Solmicro.Expertis.Business.AltunaMexicoEnum.enumTipoDocumentoIdioma.Boleta)
                    DtRpt = New JMAFormatoDocumento().Filter(f)
                    If DtRpt.Rows.Count = 0 AndAlso IsDBNull(DtRpt.Rows(0)("Formato")) Then
                        Dim fPred As New Filter
                        fPred.Add("Predeterminado", FilterOperator.Equal, True)
                        fPred.Add("TipoDocumento", FilterOperator.Equal, Solmicro.Expertis.Business.AltunaMexicoEnum.enumTipoDocumentoIdioma.Boleta)
                        DtRpt = New JMAFormatoDocumento().Filter(fPred)
                    End If
                Else
                    Dim fPred As New Filter
                    fPred.Add("Predeterminado", FilterOperator.Equal, True)
                    fPred.Add("TipoDocumento", FilterOperator.Equal, Solmicro.Expertis.Business.AltunaMexicoEnum.enumTipoDocumentoIdioma.Boleta)
                    DtRpt = New JMAFormatoDocumento().Filter(fPred)
                End If
                If DtRpt.Rows.Count = 0 Then
                    Exit Select
                End If
                Dim rpt As New Report(DtRpt.Rows(0)("Formato").ToString)
                rpt.ExportOptions.PromptUser = True
                If Length(Me.CurrentRow("Email")) > 0 Then rpt.ExportOptions.ExportToMail.MailToList = Me.CurrentRow("Email")
                Dim dtDatos As DataTable = New FacturaVentaCabecera().SelOnPrimaryKey(Me.CurrentRow("IDFactura"))
                Dim auxTable As New ReportAuxiliarTable("FacturaVentaCabecera")
                'auxTable.Settings.CopiesSource = Me.CurrentRow("NumeroCopias")
                auxTable.DataSource = dtDatos
                rpt.DataSource = auxTable
                e.Cancel = True
                ExpertisApp.OpenReport(rpt)
        End Select

    End Sub

#End Region

    Private Sub AdvIDCliente_OpenningAdvSearch(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles AdvIDCliente.OpenningAdvSearch
        If Me.Contabilizado Then e.Cancel = True
    End Sub

    Private Sub advIDCliente_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDCliente.SelectionChanged
        ValidarCambioCliente()
        mblnValidatingClte = True
        If ExpertisApp.ExecuteTask(Of Object, Boolean)(AddressOf JMAParametro.HabilitarNotasCliente, Nothing) = True Then
            Dim dtCli As DataTable = New Cliente().SelOnPrimaryKey(AdvIDCliente.Value)
            If Not IsDBNull(dtCli.Rows(0)("NotaFactura")) AndAlso Length(dtCli.Rows(0)("NotaFactura")) > 0 Then
                ExpertisApp.GenerateMessage("Nota de facturas del cliente: " & dtCli.Rows(0)("NotaFactura"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        HabilitarClienteEnvio(True, e.Selected.Rows(0))
    End Sub

    Private Sub AdvIDCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvIDCliente.Validated
        Dim DtVencManual As DataTable = Me.jngVencimientos.DataSource
        If Not DtVencManual Is Nothing AndAlso DtVencManual.Rows.Count > 0 Then
            For Each Dr As DataRow In DtVencManual.Select
                Dr("IDCliente") = AdvIDCliente.Value
            Next
            Me.jngVencimientos.DataSource = DtVencManual
        End If
        LoadGridDefaultValues()
        ComprobarRiesgoCliente()
    End Sub

    Protected Overridable Sub fwiDtoFactura_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fwiDtoFactura.Validating
        If fwiDtoFactura.Value > 100 Then
            ExpertisApp.GenerateMessage("El Descuento introducido no puede ser superior a 100%.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub fwiDtoFactura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiDtoFactura.ValueChanged
        If Me.RecordsState = RecordsState.Initialize OrElse mblnNavigating Then Exit Sub
        If Not Me.jngLineaFactura.DataSource Is Nothing AndAlso CType(jngLineaFactura.DataSource, DataTable).Rows.Count > 0 Then
            Dim FVL As New FacturaVentaLinea
            Dim context As New BusinessData(Me.CurrentRow)
            Dim f As New Filter
            f.Add(New BooleanFilterItem("Especial", False))
            For Each drLinea As DataRow In CType(jngLineaFactura.DataSource, DataTable).Select(f.Compose(New AdoFilterComposer))
                Dim Current As New BusinessData(drLinea)
                Current = FVL.ApplyBusinessRule("Dto", Nz(fwiDtoFactura.Value, 0), Current, context)
                For Each col As DataColumn In drLinea.Table.Columns
                    drLinea(col.ColumnName) = Current(col.ColumnName)
                Next
            Next
        End If
    End Sub

    Private Sub fwiDtoProntoPago_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiDtoProntoPago.ValueChanged
        If Me.RecordsState = RecordsState.Initialize OrElse mblnNavigating Then Exit Sub
        If Not Me.jngLineaFactura.DataSource Is Nothing AndAlso CType(jngLineaFactura.DataSource, DataTable).Rows.Count > 0 Then
            Dim FVL As New FacturaVentaLinea
            Dim context As New BusinessData(Me.CurrentRow)
            Dim f As New Filter
            f.Add(New BooleanFilterItem("Especial", False))
            For Each drLinea As DataRow In CType(jngLineaFactura.DataSource, DataTable).Select(f.Compose(New AdoFilterComposer))
                Dim Current As New BusinessData(drLinea)
                Current = FVL.ApplyBusinessRule("DtoProntoPago", Nz(fwiDtoProntoPago.Value, 0), Current, context)
                For Each col As DataColumn In drLinea.Table.Columns
                    drLinea(col.ColumnName) = Current(col.ColumnName)
                Next
            Next
        End If
    End Sub

    Private Sub cbxClaveOperacion_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxClaveOperacion.ValueChanged
        BloquearPorTicket()
    End Sub

    Public Sub BloquearPorTicket()
        If mblnNavigating Then Exit Sub
        If Length(Me.cbxClaveOperacion.Value) > 0 AndAlso (Me.cbxClaveOperacion.Value = ClaveOperacion.Tickets OrElse Me.cbxClaveOperacion.Value = ClaveOperacion.ResumenTicket) Then
            Me.jngLineaFactura.AllowDelete = InheritableBoolean.False
            Me.jngLineaFactura.AllowEdit = InheritableBoolean.False
            Me.jngLineaFactura.AllowAddNew = InheritableBoolean.False
            Me.fwiIdMoneda.Enabled = False
            Me.fwiFormaPago.Enabled = False
            Me.fwiCondPago.Enabled = False
            Me.fwiIdDiaPago.Enabled = False
            Me.fwiIdClteBanco.Enabled = False
            Me.fwiBancoPropio.Enabled = False
            Me.fwiTipoAsiento.Enabled = False
            Me.txtImpRetencionGar.Enabled = False
            Me.txtRetencion.Enabled = False
            Me.cbxFechaRetencion.Enabled = False
            Me.cbxTipoRetencion.Enabled = False
            Me.fwiDtoFactura.Enabled = False
            Me.fwiDtoProntoPago.Enabled = False
            Me.fwiRecFinan.Enabled = False
        Else
            Dim BlnBloquear As Boolean
            If Me.Contabilizado Then
                BlnBloquear = True
                Me.jngLineaFactura.AllowAddNew = InheritableBoolean.False
                Me.jngLineaFactura.AllowEdit = InheritableBoolean.False
                Me.jngLineaFactura.AllowDelete = InheritableBoolean.False
            Else
                If chkVencimientoManual.Checked OrElse chkIVAManual.Checked Then
                    BlnBloquear = True
                    Me.jngLineaFactura.AllowAddNew = InheritableBoolean.False
                    Me.jngLineaFactura.AllowEdit = InheritableBoolean.False
                    Me.jngLineaFactura.AllowDelete = InheritableBoolean.False
                Else
                    If Length(Me.CurrentRow("AñoDeclaracionIva")) > 0 AndAlso Length(Me.CurrentRow("NDeclaracionIva")) > 0 Then
                        BlnBloquear = True
                        Me.jngLineaFactura.AllowAddNew = InheritableBoolean.False
                        Me.jngLineaFactura.AllowEdit = InheritableBoolean.False
                        Me.jngLineaFactura.AllowDelete = InheritableBoolean.False
                    Else
                        BlnBloquear = False
                        Me.jngLineaFactura.AllowAddNew = InheritableBoolean.True
                        Me.jngLineaFactura.AllowEdit = InheritableBoolean.True
                        Me.jngLineaFactura.AllowDelete = InheritableBoolean.True
                    End If
                End If
            End If
            BloquearInformacion(Me.MainPanel, BlnBloquear, fwiNFactura, fwiEstado, fwiCIF, fwiRazonSocial, fwiDir, fwiTel, fwiCodPostal, _
                               fwiPoblacion, fwiFax, fwiProvincia, FwiIdPais, fwiTextoFactura, chkEnviar347, ChkEnviar349, ChkSectorServicios, ChkOpeTriangular, chkEDI, _
                               chkGeneradoFichero, txtDescAseguradora, chbEnviadaEntidadAseguradora1, FwiIDContador, _
                               fwiTotalBaseImp, fwiTotalIva, fwiTotal, fwiDescMonedaA, fwiDescMonedaB, fwiImpRetencion, fwiBaseRetencion, _
                               fwiImpLinMon, fwiImpLineasNormales, fwiImpLineasEspeciales, fwiBaseImpMon, _
                               fwiIVA, fwiImpREMon, fwiImpRecFinan, fwiImpTotal, fwiImpRetencionAux, fwiImpTotalConRetencion, _
                               fwiClienteIni, fwiIDEjercicio, fwiAñoDeclaracion, _
                               fwiNDeclaracion, fwiImpLineasNormalesA, fwiImpLineasEspecialesA, fwiImpLineasA, _
                               fwiBaseImpA, fwiImpIVAA, fwiImpReA, fwiImpRecFinanA, fwiImpTotalA, fwiRetencionA, _
                               fwiImpLineasNormalesB, fwiImpLineasEspecialesB, fwiImpLineasB, fwiBaseImpB, _
                               fwiImpIVAB, fwiImpReB, fwiImpRecFinanB, fwiImpTotalB, fwiImpRetencionB, fwiMonedaA, fwiMonedaB, _
                               fwiDescMoneda, fwiImpRetencion, fwiImpRecFinan, TxtDirecCorreo, jngConceptos, txtNumeroCopias, AdvIDCliente, _
                               chkOcultarComponentes, ntbRetencion, nbxImpuestos)
            Me.AdvIDCliente.ReadOnly = BlnBloquear
        End If
    End Sub

    Private Sub ChkEnviar349_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEnviar349.CheckedChanged
        ChkSectorServicios.Visible = ChkEnviar349.Checked
        ChkOpeTriangular.Visible = ChkEnviar349.Checked
    End Sub

    Private Sub fwiCondPago_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiCondPago.Validated
        LoadGridDefaultValues()
    End Sub

    Private Sub fwiFormaPago_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiFormaPago.Validated
        LoadGridDefaultValues()
    End Sub

    Private Sub jngLineaFactura_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngLineaFactura.UpdatingRecord
        e.Cancel = Not ValidarDatos(False)
    End Sub

    Protected Overridable Sub AdvFtaRectificada_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvFtaRectificada.SetPredefinedFilter
        Dim fClte As New Filter(FilterUnionOperator.Or)
        fClte.Add(New StringFilterItem("IDCliente", FilterOperator.Equal, Me.CurrentRow("IDCliente")))
        fClte.Add(New StringFilterItem("IDClienteInicial", FilterOperator.Equal, Me.CurrentRow("IDCliente")))
        e.Filter.Add(fClte)
    End Sub

    Private Sub ValidarCambioCliente()
        If Length(Me.CurrentRow("IDCliente")) > 0 AndAlso Not mblnValidatingClte Then
            If AdvIDCliente.Value & String.Empty <> Me.CurrentRow("IDCliente") & String.Empty AndAlso Me.jngLineaFactura.RowCount > 0 Then
                ExpertisApp.GenerateMessage("La modificación del cliente no afectará a la información de las líneas")
            End If
        End If
    End Sub

    Private Sub advIDCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles AdvIDCliente.Validating
        ValidarCambioCliente()
    End Sub



    Private Sub chkVencimientoManual_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkVencimientoManual.Validated
        ComprobarIVAVencManual()
    End Sub

    Private Sub MntoFacturaVenta_RecordDeleting(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.RecordDeleting
        If Me.Contabilizado Then
            ExpertisApp.GenerateMessage("No se puede eliminar la factura, está contabilizada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub fwiRetencionManual_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiRetencionManual.CheckedChanged
        If Not IsNothing(Me.CurrentRow) Then
            EstadoRetencion()
        End If
    End Sub

    Private Sub ChkOpeTriangular_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ChkOpeTriangular.Validating
        If Me.ChkOpeTriangular.Checked AndAlso Me.ChkSectorServicios.Checked Then
            ExpertisApp.GenerateMessage("La Factura es una operación de servicios. No puede ser a su vez una operación triangular.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub ChkSectorServicios_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ChkSectorServicios.Validating
        If Me.ChkOpeTriangular.Checked AndAlso Me.ChkSectorServicios.Checked Then
            ExpertisApp.GenerateMessage("La Factura es una operación triangular, no puede ser de servicios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub advIDProveedor_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDProveedor.SelectionChanged
        advIDOperario.Text = String.Empty
    End Sub
    Private Sub advIDOperario_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDOperario.SelectionChanged
        advIDProveedor.Text = String.Empty
    End Sub

    Private Sub MntoFacturaVenta_Navigating(ByVal sender As Object, ByVal e As Engine.UI.NavigatingEventArgs) Handles Me.Navigating
        mblnNavigating = True
    End Sub



    Private Sub AccionGestionCheque()
        Dim frm As New frmAddInformacionCheque
        If Length(jngVencimientos.Value("IDCheque")) > 0 Then
            frm.IDCheque = jngVencimientos.Value("IDCheque")
            frm.SoloLectura = (jngVencimientos.Value("Contabilizado") <> enumContabilizado.NoContabilizado)
        Else
            frm.SoloLectura = (jngVencimientos.Value("Contabilizado") <> enumContabilizado.NoContabilizado)
            ReDim Preserve frm.IDCobros(frm.IDCobros.Length)
            frm.IDCobros(frm.IDCobros.Length - 1) = jngVencimientos.Value("IDCobro")
        End If
        frm.ShowDialog()
    End Sub

    Private Sub AccionGestionTarjeta()
        Dim frm As New frmAddInformacionTarjeta
        If Length(jngVencimientos.Value("IDTarjeta")) > 0 Then
            frm.IDTarjeta = jngVencimientos.Value("IDTarjeta")
            frm.SoloLectura = (jngVencimientos.Value("Contabilizado") <> enumContabilizado.NoContabilizado)
        Else
            frm.SoloLectura = (jngVencimientos.Value("Contabilizado") <> enumContabilizado.NoContabilizado)
            ReDim Preserve frm.IDCobros(frm.IDCobros.Length)
            frm.IDCobros(frm.IDCobros.Length - 1) = jngVencimientos.Value("IDCobro")
        End If
        frm.ShowDialog()
    End Sub

    Private Sub advMandato_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advMandato.SetPredefinedFilter
        If Length(Me.fwiIdClteBanco.Value) > 0 Then
            e.Filter.Add(New NumberFilterItem("IDClienteBanco", fwiIdClteBanco.Value))
        End If
        If Length(AdvIDCliente.Value) > 0 Then
            e.Filter.Add(New StringFilterItem("IDCliente", AdvIDCliente.Value))
        End If

        e.Filter.Add(New BooleanFilterItem("Caducado", False))
        e.Filter.Add(New NumberFilterItem("Estado", CInt(BusinessEnum.MandatoEstado.Aceptado)))

        If Length(fwiFormaPago.Value) = 0 OrElse (Not fwiFormaPago.SelectedRow Is Nothing AndAlso Not Nz(fwiFormaPago.SelectedRow("CobroRemesable"), False)) Then
            e.Filter.Add(New NoRowsFilterItem)
        End If
    End Sub

    Private Sub AccionEnviarEmail()
        Dim ids As New List(Of Integer)
        ids.Add(CurrentRow("IDFactura"))
        AccionEnviarEmailFacturaVentaMX.EnviarEmail(ids)
        If GlobalInfo.ResultadoProceso = Windows.Forms.DialogResult.OK Then
            Requery.InvokeOnClick()
        End If
    End Sub

    Private Function FiltroComponentes() As Filter
        Dim f As New Filter
        If chkOcultarComponentes.Checked Then
            f.Add("IDLineaPadre", FilterOperator.Equal, DBNull.Value)
        End If
        Return f
    End Function

    Private Sub chkOcultarComponentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOcultarComponentes.CheckedChanged
        If Not jngLineaFactura.DataSource Is Nothing Then
            CType(jngLineaFactura.DataSource, DataTable).DefaultView.RowFilter = FiltroComponentes.Compose(New AdoFilterComposer)
        End If
    End Sub

    Private Sub advClienteEnvio_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advClienteEnvio.SetPredefinedFilter
        e.Filter.Add("IDTipoCliente", FilterOperator.NotEqual, mClienteVarios)
    End Sub

    Private Sub HabilitarClienteEnvio(ByVal marca As Boolean, ByVal fila As DataRow)
        If Not fila Is Nothing Then
            If Not IsDBNull(fila("IDTipoCliente")) AndAlso fila("IDTipoCliente") = mClienteVarios Then
                MostrarClienteEnvio(True, marca)
            Else
                MostrarClienteEnvio(False, marca)
                'If marca Then
                '    CurrentRow("IDClienteVarios") = DBNull.Value
                '    ulblDescClienteEnvio.Text = String.Empty
                '    If Length(AdvIDCliente.Value) > 0 Then
                '        Dim FacturaVentaCabecera As New FacturaVentaCabecera()
                '        Dim current As New BusinessData(Me.CurrentRow)
                '        FacturaVentaCabecera.ApplyBusinessRule("IDCliente", AdvIDCliente.Value, current)
                '    End If
                'End If
            End If
        End If
    End Sub

    Private Sub MostrarClienteEnvio(ByVal value As Boolean, ByVal marca As Boolean)
        advClienteEnvio.Visible = value
        ulblDescClienteEnvio.Visible = value
        lblClienteEnvio.Visible = value
        'If marca Then ulblDescClienteEnvio.Text = String.Empty : advClienteEnvio.Text = String.Empty
    End Sub


    Private Sub MntoFacturaVenta_RecordUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.RecordUpdating
        If ExpertisApp.ExecuteTask(Of String, String)(AddressOf ExtensibilidadProgramaCabecera.TipoCliente, AdvIDCliente.Text) = mClienteVarios And Length(advClienteEnvio.Text) = 0 Then
            ExpertisApp.GenerateMessage("En este caso es obligatorio rellenar Cliente Envío.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim IDFactura = e.Argument
        Dim respuesta = ""
        While (respuesta.Equals(""))
            Threading.Thread.Sleep(150000)
            respuesta = ExpertisApp.ExecuteTask(Of Integer, String)(AddressOf ProcesoFacturacionElectronica.RevisarCancelacion, IDFactura)
        End While

        If respuesta.Contains("aceptad") Then
            NotifyIcon1.ShowBalloonTip(3000, "Proceso terminado", respuesta, ToolTipIcon.Info)
        End If

    End Sub

    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        ' First, handle the case where an exception was thrown.
        If (e.Error IsNot Nothing) Then
            NotifyIcon1.ShowBalloonTip(3000, "Error", e.Error.Message, ToolTipIcon.Error)
        ElseIf e.Cancelled Then
            ' Next, handle the case where the user canceled the 
            ' operation.
            ' Note that due to a race condition in 
            ' the DoWork event handler, the Cancelled
            ' flag may not have been set, even though
            ' CancelAsync was called.
            NotifyIcon1.ShowBalloonTip(3000, "Error", "Cancelado por el usuario", ToolTipIcon.Warning)
        Else
            ' Finally, handle the case where the operation succeeded.
            NotifyIcon1.ShowBalloonTip(3000, "Finalizado", "El proceso de cancelación terminó correctamenre", ToolTipIcon.Info)
        End If

    End Sub 'backgroundWorker1_RunWorkerCompleted
End Class
