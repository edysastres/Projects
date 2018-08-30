Imports System.Runtime.InteropServices
Imports Expertis.Application.ERP.AltunaMX.GeneradorDeEtiquetas
Imports System.Drawing.Printing

Public Class CIImpEtiquetaArticulo
    Private WithEvents mGrid As Solmicro.Expertis.Engine.UI.Grid

    Private Sub CIImprimirEtiquetaArticulo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mGrid = Grid
        Grid.Actions.Add("Abrir Artículo", AddressOf AccionAbrirArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
    End Sub

    Private Sub CIImprimirEtiquetaArticulo_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, advArticulo.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, advTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advFamilia.Text, FilterType.String)
        e.Filter.Add("IDArticuloPadre", FilterOperator.Equal, advArticuloPadre.Text, FilterType.String)
    End Sub

    Private Sub CIImprimirEtiquetaArticulo_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles Me.SetReportDesignObjects
        '//este es el primer evento que salta para los informes
        e.Cancel = True
        '//utilizar el metodo privado para esta impresion en JMA
        '//(se hace asi porque los informes van a ser desarrollados por JMA, evitar utilizar la impresion auxiliar, por sencillez)
        Imprimir(e.Alias)
    End Sub

    Private Sub Imprimir(ByVal report_alias As String)
        If Not Grid.CheckedRecords Is Nothing AndAlso Grid.CheckedRecords.Rows.Count > 0 Then
            Dim cantidad As Integer = ntbNCopias.Value
            If cantidad > 0 Then
                Dim articulos As DataTable = Grid.CheckedRecords
                For Each a As DataRow In articulos.Rows
                    Dim rpt As New Report(report_alias)
                    rpt.Filter.Add(New StringFilterItem("IDArticulo", a("IDArticulo")))
                    rpt.ExportOptions.ExportType = ReportExportDestinationType.Printer
                    rpt.ExportOptions.PrintSettings.Copies = cantidad
                    ExpertisApp.OpenReport(rpt)
                Next
            Else
                ExpertisApp.GenerateMessage("El número de copias no es válido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ntbNCopias.Focus()
            End If
        Else
            ExpertisApp.GenerateMessage("No hay artículos seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Grid.Focus()
        End If
    End Sub

    Private Sub AccionAbrirArticulo()
        If Length(Grid.GetValue("IDArticulo")) > 0 Then
            ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", Grid.GetValue("IDArticulo")))
        End If
    End Sub
End Class
