Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting

Public Class LabelBolsitasLandscape

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        AddHandler Me.PrintingSystem.StartPrint, AddressOf printingSystem_StartPrint
        ShowPrintingWarnings = False
        ShowExportWarnings = False
        PrintingSystem.ShowMarginsWarning = False
        PrintingSystem.ShowPrintStatusDialog = False

    End Sub

    Private Sub printingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
        ' set specific printer name
        e.PrintDocument.PrinterSettings.PrinterName = Me.PrinterName
        e.PrintDocument.PrinterSettings.PrintFileName = Me.PrinterName & ".prn"
        e.PrintDocument.PrinterSettings.PrintToFile = True
    End Sub

End Class