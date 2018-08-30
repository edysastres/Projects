<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class LabelExpedicionOrigLandscape
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabelExpedicionOrigLandscape))
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrDataImagePerfil = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrDataImageSilueta = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrDataMaterialAcabado = New DevExpress.XtraReports.UI.XRLabel
        Me.XrDataQuantity = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrDataRefCte = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabelRefCte = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabelFinishing = New DevExpress.XtraReports.UI.XRLabel
        Me.XrDataPacking = New DevExpress.XtraReports.UI.XRLabel
        Me.XrDataProductionOrder = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabelProductionOrder = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLineVert2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrDataReference = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabelReference = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLineHoriz2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabelDateMask = New DevExpress.XtraReports.UI.XRLabel
        Me.XrDataPackingDate = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabelPackingDate = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLineVert3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLineVert1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabelQuantity = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLineHoriz3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabelPacking = New DevExpress.XtraReports.UI.XRLabel
        Me.XrMarco = New DevExpress.XtraReports.UI.XRShape
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrDataImagePerfil, Me.XrDataImageSilueta, Me.XrDataMaterialAcabado, Me.XrDataQuantity, Me.XrLine1, Me.XrLabel1, Me.XrDataRefCte, Me.XrLabelRefCte, Me.XrLabelFinishing, Me.XrDataPacking, Me.XrDataProductionOrder, Me.XrLabelProductionOrder, Me.XrLineVert2, Me.XrDataReference, Me.XrLabelReference, Me.XrLineHoriz2, Me.XrLabelDateMask, Me.XrDataPackingDate, Me.XrLabelPackingDate, Me.XrLineVert3, Me.XrLineVert1, Me.XrLabelQuantity, Me.XrLineHoriz3, Me.XrLabelPacking, Me.XrMarco})
        Me.Detail.Dpi = 254.0!
        Me.Detail.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Detail.Height = 1680
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrDataImagePerfil
        '
        Me.XrDataImagePerfil.Dpi = 254.0!
        Me.XrDataImagePerfil.Image = CType(resources.GetObject("XrDataImagePerfil.Image"), System.Drawing.Image)
        Me.XrDataImagePerfil.Location = New System.Drawing.Point(296, 106)
        Me.XrDataImagePerfil.Name = "XrDataImagePerfil"
        Me.XrDataImagePerfil.Size = New System.Drawing.Size(42, 148)
        Me.XrDataImagePerfil.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrDataImageSilueta
        '
        Me.XrDataImageSilueta.Dpi = 254.0!
        Me.XrDataImageSilueta.Image = CType(resources.GetObject("XrDataImageSilueta.Image"), System.Drawing.Image)
        Me.XrDataImageSilueta.Location = New System.Drawing.Point(339, 42)
        Me.XrDataImageSilueta.Name = "XrDataImageSilueta"
        Me.XrDataImageSilueta.Size = New System.Drawing.Size(375, 291)
        Me.XrDataImageSilueta.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrDataMaterialAcabado
        '
        Me.XrDataMaterialAcabado.Angle = 270.0!
        Me.XrDataMaterialAcabado.CanGrow = False
        Me.XrDataMaterialAcabado.Dpi = 254.0!
        Me.XrDataMaterialAcabado.Font = New System.Drawing.Font("Arial", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrDataMaterialAcabado.Location = New System.Drawing.Point(296, 339)
        Me.XrDataMaterialAcabado.Name = "XrDataMaterialAcabado"
        Me.XrDataMaterialAcabado.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrDataMaterialAcabado.Size = New System.Drawing.Size(190, 1312)
        Me.XrDataMaterialAcabado.StylePriority.UseFont = False
        Me.XrDataMaterialAcabado.StylePriority.UseTextAlignment = False
        Me.XrDataMaterialAcabado.Text = "NO"
        Me.XrDataMaterialAcabado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrDataQuantity
        '
        Me.XrDataQuantity.Angle = 270.0!
        Me.XrDataQuantity.CanGrow = False
        Me.XrDataQuantity.Dpi = 254.0!
        Me.XrDataQuantity.Font = New System.Drawing.Font("Arial Narrow", 42.0!, System.Drawing.FontStyle.Bold)
        Me.XrDataQuantity.Location = New System.Drawing.Point(741, 1292)
        Me.XrDataQuantity.Name = "XrDataQuantity"
        Me.XrDataQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrDataQuantity.Size = New System.Drawing.Size(190, 360)
        Me.XrDataQuantity.StylePriority.UseFont = False
        Me.XrDataQuantity.StylePriority.UseTextAlignment = False
        Me.XrDataQuantity.Text = "1000"
        Me.XrDataQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.Location = New System.Drawing.Point(21, 339)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(963, 5)
        '
        'XrLabel1
        '
        Me.XrLabel1.Angle = 270.0!
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(931, 1185)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(42, 85)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "V2"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrDataRefCte
        '
        Me.XrDataRefCte.Angle = 270.0!
        Me.XrDataRefCte.CanGrow = False
        Me.XrDataRefCte.Dpi = 254.0!
        Me.XrDataRefCte.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrDataRefCte.Location = New System.Drawing.Point(549, 339)
        Me.XrDataRefCte.Name = "XrDataRefCte"
        Me.XrDataRefCte.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrDataRefCte.Size = New System.Drawing.Size(128, 507)
        Me.XrDataRefCte.StylePriority.UseFont = False
        Me.XrDataRefCte.StylePriority.UseTextAlignment = False
        Me.XrDataRefCte.Text = "H 72PT/H 86PT"
        Me.XrDataRefCte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrDataRefCte.WordWrap = False
        '
        'XrLabelRefCte
        '
        Me.XrLabelRefCte.Angle = 270.0!
        Me.XrLabelRefCte.Dpi = 254.0!
        Me.XrLabelRefCte.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelRefCte.Location = New System.Drawing.Point(677, 339)
        Me.XrLabelRefCte.Name = "XrLabelRefCte"
        Me.XrLabelRefCte.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabelRefCte.Size = New System.Drawing.Size(42, 507)
        Me.XrLabelRefCte.StylePriority.UseFont = False
        Me.XrLabelRefCte.StylePriority.UseTextAlignment = False
        Me.XrLabelRefCte.Text = "REF. CLIENT / REF. CLIENTE"
        Me.XrLabelRefCte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabelFinishing
        '
        Me.XrLabelFinishing.Angle = 270.0!
        Me.XrLabelFinishing.Dpi = 254.0!
        Me.XrLabelFinishing.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrLabelFinishing.Location = New System.Drawing.Point(487, 339)
        Me.XrLabelFinishing.Name = "XrLabelFinishing"
        Me.XrLabelFinishing.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabelFinishing.Size = New System.Drawing.Size(34, 1312)
        Me.XrLabelFinishing.StylePriority.UseFont = False
        Me.XrLabelFinishing.StylePriority.UseTextAlignment = False
        Me.XrLabelFinishing.Text = "MATERIAL & FINISHING / MATERIAL Y ACABADO"
        Me.XrLabelFinishing.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrDataPacking
        '
        Me.XrDataPacking.Angle = 270.0!
        Me.XrDataPacking.CanGrow = False
        Me.XrDataPacking.Dpi = 254.0!
        Me.XrDataPacking.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrDataPacking.Location = New System.Drawing.Point(741, 42)
        Me.XrDataPacking.Name = "XrDataPacking"
        Me.XrDataPacking.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrDataPacking.Size = New System.Drawing.Size(148, 297)
        Me.XrDataPacking.StylePriority.UseFont = False
        Me.XrDataPacking.StylePriority.UseTextAlignment = False
        Me.XrDataPacking.Text = "BULK / GRANEL"
        Me.XrDataPacking.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrDataProductionOrder
        '
        Me.XrDataProductionOrder.Angle = 270.0!
        Me.XrDataProductionOrder.CanGrow = False
        Me.XrDataProductionOrder.Dpi = 254.0!
        Me.XrDataProductionOrder.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrDataProductionOrder.Location = New System.Drawing.Point(20, 360)
        Me.XrDataProductionOrder.Name = "XrDataProductionOrder"
        Me.XrDataProductionOrder.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrDataProductionOrder.Size = New System.Drawing.Size(170, 571)
        Me.XrDataProductionOrder.StylePriority.UseFont = False
        Me.XrDataProductionOrder.StylePriority.UseTextAlignment = False
        Me.XrDataProductionOrder.Text = "0901025"
        Me.XrDataProductionOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabelProductionOrder
        '
        Me.XrLabelProductionOrder.Angle = 270.0!
        Me.XrLabelProductionOrder.Dpi = 254.0!
        Me.XrLabelProductionOrder.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrLabelProductionOrder.Location = New System.Drawing.Point(212, 360)
        Me.XrLabelProductionOrder.Name = "XrLabelProductionOrder"
        Me.XrLabelProductionOrder.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabelProductionOrder.Size = New System.Drawing.Size(64, 571)
        Me.XrLabelProductionOrder.StylePriority.UseFont = False
        Me.XrLabelProductionOrder.StylePriority.UseTextAlignment = False
        Me.XrLabelProductionOrder.Text = "PRODUCTION ORDER / ORDEN DE FABRICACION"
        Me.XrLabelProductionOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLineVert2
        '
        Me.XrLineVert2.Dpi = 254.0!
        Me.XrLineVert2.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLineVert2.LineWidth = 3
        Me.XrLineVert2.Location = New System.Drawing.Point(524, 339)
        Me.XrLineVert2.Name = "XrLineVert2"
        Me.XrLineVert2.Size = New System.Drawing.Size(26, 1312)
        '
        'XrDataReference
        '
        Me.XrDataReference.Angle = 270.0!
        Me.XrDataReference.CanGrow = False
        Me.XrDataReference.Dpi = 254.0!
        Me.XrDataReference.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrDataReference.Location = New System.Drawing.Point(741, 339)
        Me.XrDataReference.Name = "XrDataReference"
        Me.XrDataReference.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrDataReference.Size = New System.Drawing.Size(170, 847)
        Me.XrDataReference.StylePriority.UseFont = False
        Me.XrDataReference.StylePriority.UseTextAlignment = False
        Me.XrDataReference.Text = "H 72PT/H 86PT"
        Me.XrDataReference.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrDataReference.WordWrap = False
        '
        'XrLabelReference
        '
        Me.XrLabelReference.Angle = 270.0!
        Me.XrLabelReference.Dpi = 254.0!
        Me.XrLabelReference.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrLabelReference.Location = New System.Drawing.Point(931, 360)
        Me.XrLabelReference.Name = "XrLabelReference"
        Me.XrLabelReference.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabelReference.Size = New System.Drawing.Size(42, 805)
        Me.XrLabelReference.StylePriority.UseFont = False
        Me.XrLabelReference.StylePriority.UseTextAlignment = False
        Me.XrLabelReference.Text = "REFERENCE / REFERENCIA     "
        Me.XrLabelReference.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLineHoriz2
        '
        Me.XrLineHoriz2.Dpi = 254.0!
        Me.XrLineHoriz2.LineWidth = 3
        Me.XrLineHoriz2.Location = New System.Drawing.Point(20, 952)
        Me.XrLineHoriz2.Name = "XrLineHoriz2"
        Me.XrLineHoriz2.Size = New System.Drawing.Size(265, 20)
        '
        'XrLabelDateMask
        '
        Me.XrLabelDateMask.Angle = 270.0!
        Me.XrLabelDateMask.Dpi = 254.0!
        Me.XrLabelDateMask.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelDateMask.Location = New System.Drawing.Point(22, 42)
        Me.XrLabelDateMask.Name = "XrLabelDateMask"
        Me.XrLabelDateMask.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabelDateMask.Size = New System.Drawing.Size(42, 297)
        Me.XrLabelDateMask.StylePriority.UseFont = False
        Me.XrLabelDateMask.StylePriority.UseTextAlignment = False
        Me.XrLabelDateMask.Text = "DD / MM / YY"
        Me.XrLabelDateMask.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrDataPackingDate
        '
        Me.XrDataPackingDate.Angle = 270.0!
        Me.XrDataPackingDate.CanGrow = False
        Me.XrDataPackingDate.Dpi = 254.0!
        Me.XrDataPackingDate.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.XrDataPackingDate.Location = New System.Drawing.Point(84, 42)
        Me.XrDataPackingDate.Name = "XrDataPackingDate"
        Me.XrDataPackingDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrDataPackingDate.Size = New System.Drawing.Size(106, 297)
        Me.XrDataPackingDate.StylePriority.UseFont = False
        Me.XrDataPackingDate.StylePriority.UseTextAlignment = False
        Me.XrDataPackingDate.Text = "08/09/09"
        Me.XrDataPackingDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabelPackingDate
        '
        Me.XrLabelPackingDate.Angle = 270.0!
        Me.XrLabelPackingDate.Dpi = 254.0!
        Me.XrLabelPackingDate.Font = New System.Drawing.Font("Arial", 7.5!, System.Drawing.FontStyle.Bold)
        Me.XrLabelPackingDate.Location = New System.Drawing.Point(212, 42)
        Me.XrLabelPackingDate.Name = "XrLabelPackingDate"
        Me.XrLabelPackingDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabelPackingDate.Size = New System.Drawing.Size(64, 297)
        Me.XrLabelPackingDate.StylePriority.UseFont = False
        Me.XrLabelPackingDate.StylePriority.UseTextAlignment = False
        Me.XrLabelPackingDate.Text = "PACKING DATE / FECHA DE EMPAQUE"
        Me.XrLabelPackingDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLineVert3
        '
        Me.XrLineVert3.Dpi = 254.0!
        Me.XrLineVert3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLineVert3.LineWidth = 3
        Me.XrLineVert3.Location = New System.Drawing.Point(275, 42)
        Me.XrLineVert3.Name = "XrLineVert3"
        Me.XrLineVert3.Size = New System.Drawing.Size(21, 1609)
        '
        'XrLineVert1
        '
        Me.XrLineVert1.Dpi = 254.0!
        Me.XrLineVert1.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLineVert1.LineWidth = 3
        Me.XrLineVert1.Location = New System.Drawing.Point(724, 42)
        Me.XrLineVert1.Name = "XrLineVert1"
        Me.XrLineVert1.Size = New System.Drawing.Size(21, 1609)
        '
        'XrLabelQuantity
        '
        Me.XrLabelQuantity.Angle = 270.0!
        Me.XrLabelQuantity.Dpi = 254.0!
        Me.XrLabelQuantity.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelQuantity.Location = New System.Drawing.Point(931, 1291)
        Me.XrLabelQuantity.Name = "XrLabelQuantity"
        Me.XrLabelQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabelQuantity.Size = New System.Drawing.Size(34, 339)
        Me.XrLabelQuantity.StylePriority.UseFont = False
        Me.XrLabelQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelQuantity.Text = "QUANTITY / CANTIDAD"
        Me.XrLabelQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLineHoriz3
        '
        Me.XrLineHoriz3.Dpi = 254.0!
        Me.XrLineHoriz3.LineWidth = 3
        Me.XrLineHoriz3.Location = New System.Drawing.Point(741, 1270)
        Me.XrLineHoriz3.Name = "XrLineHoriz3"
        Me.XrLineHoriz3.Size = New System.Drawing.Size(237, 42)
        '
        'XrLabelPacking
        '
        Me.XrLabelPacking.Angle = 270.0!
        Me.XrLabelPacking.Dpi = 254.0!
        Me.XrLabelPacking.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabelPacking.Location = New System.Drawing.Point(889, 42)
        Me.XrLabelPacking.Name = "XrLabelPacking"
        Me.XrLabelPacking.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabelPacking.Size = New System.Drawing.Size(76, 297)
        Me.XrLabelPacking.StylePriority.UseFont = False
        Me.XrLabelPacking.StylePriority.UseTextAlignment = False
        Me.XrLabelPacking.Text = "PACKING / EMPAQUE"
        Me.XrLabelPacking.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrMarco
        '
        Me.XrMarco.Dpi = 254.0!
        Me.XrMarco.Location = New System.Drawing.Point(21, 42)
        Me.XrMarco.Name = "XrMarco"
        Me.XrMarco.Shape = ShapeRectangle1
        Me.XrMarco.Size = New System.Drawing.Size(956, 1611)
        '
        'LabelExpedicionOrigLandscape
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 1699
        Me.PageWidth = 1013
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.Version = "9.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrMarco As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrLabelPacking As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLineHoriz3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabelQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLineVert1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLineVert3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabelDateMask As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrDataPackingDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelPackingDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLineHoriz2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLineVert2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrDataReference As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelReference As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrDataProductionOrder As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelProductionOrder As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelFinishing As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrDataPacking As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrDataRefCte As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRefCte As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrDataQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrDataMaterialAcabado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrDataImageSilueta As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrDataImagePerfil As DevExpress.XtraReports.UI.XRPictureBox
End Class
