<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class LabelBlisters
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
        Dim EaN13Generator1 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator
        Dim EaN13Generator2 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabelBlisters))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrBarCode0 = New DevExpress.XtraReports.UI.XRBarCode
        Me.XrBarCode = New DevExpress.XtraReports.UI.XRBarCode
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrDataReference0 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrDataReference = New DevExpress.XtraReports.UI.XRLabel
        Me.XrDatePrint0 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrDatePrint = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrDatePrint, Me.XrDatePrint0, Me.XrBarCode0, Me.XrBarCode, Me.XrPictureBox2, Me.XrPictureBox1, Me.XrDataReference0, Me.XrDataReference})
        Me.Detail.Dpi = 254.0!
        Me.Detail.Height = 222
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrBarCode0
        '
        Me.XrBarCode0.Dpi = 254.0!
        Me.XrBarCode0.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrBarCode0.Location = New System.Drawing.Point(463, 138)
        Me.XrBarCode0.Name = "XrBarCode0"
        Me.XrBarCode0.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254.0!)
        Me.XrBarCode0.Size = New System.Drawing.Size(291, 74)
        Me.XrBarCode0.StylePriority.UseFont = False
        Me.XrBarCode0.Symbology = EaN13Generator1
        '
        'XrBarCode
        '
        Me.XrBarCode.Dpi = 254.0!
        Me.XrBarCode.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrBarCode.Location = New System.Drawing.Point(53, 138)
        Me.XrBarCode.Name = "XrBarCode"
        Me.XrBarCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254.0!)
        Me.XrBarCode.Size = New System.Drawing.Size(291, 74)
        Me.XrBarCode.StylePriority.UseFont = False
        Me.XrBarCode.Symbology = EaN13Generator2
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Dpi = 254.0!
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.Location = New System.Drawing.Point(489, 11)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.Size = New System.Drawing.Size(238, 64)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Dpi = 254.0!
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.Location = New System.Drawing.Point(79, 11)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.Size = New System.Drawing.Size(238, 64)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrDataReference0
        '
        Me.XrDataReference0.Dpi = 254.0!
        Me.XrDataReference0.Location = New System.Drawing.Point(463, 85)
        Me.XrDataReference0.Name = "XrDataReference0"
        Me.XrDataReference0.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrDataReference0.Size = New System.Drawing.Size(291, 53)
        Me.XrDataReference0.StylePriority.UseTextAlignment = False
        Me.XrDataReference0.Text = "Referencia"
        Me.XrDataReference0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrDataReference
        '
        Me.XrDataReference.Dpi = 254.0!
        Me.XrDataReference.Location = New System.Drawing.Point(53, 85)
        Me.XrDataReference.Name = "XrDataReference"
        Me.XrDataReference.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrDataReference.Size = New System.Drawing.Size(291, 53)
        Me.XrDataReference.StylePriority.UseTextAlignment = False
        Me.XrDataReference.Text = "Referencia"
        Me.XrDataReference.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrDatePrint0
        '
        Me.XrDatePrint0.Angle = 90.0!
        Me.XrDatePrint0.Dpi = 254.0!
        Me.XrDatePrint0.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrDatePrint0.Location = New System.Drawing.Point(437, 21)
        Me.XrDatePrint0.Name = "XrDatePrint0"
        Me.XrDatePrint0.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrDatePrint0.Size = New System.Drawing.Size(26, 180)
        Me.XrDatePrint0.StylePriority.UseFont = False
        Me.XrDatePrint0.StylePriority.UseTextAlignment = False
        Me.XrDatePrint0.Text = "XrDatePrint0"
        Me.XrDatePrint0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrDatePrint
        '
        Me.XrDatePrint.Angle = -90.0!
        Me.XrDatePrint.Dpi = 254.0!
        Me.XrDatePrint.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrDatePrint.Location = New System.Drawing.Point(344, 21)
        Me.XrDatePrint.Name = "XrDatePrint"
        Me.XrDatePrint.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrDatePrint.Size = New System.Drawing.Size(26, 180)
        Me.XrDatePrint.StylePriority.UseFont = False
        Me.XrDatePrint.StylePriority.UseTextAlignment = False
        Me.XrDatePrint.Text = "XrDatePrint"
        Me.XrDatePrint.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'LabelBlisters
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridSize = New System.Drawing.Size(5, 4)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 240
        Me.PageWidth = 770
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "9.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrDataReference As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrDataReference0 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode0 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrBarCode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrDatePrint0 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrDatePrint As DevExpress.XtraReports.UI.XRLabel
End Class
