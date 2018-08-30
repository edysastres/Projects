Imports System.Runtime.InteropServices
Imports Expertis.Application.ERP.AltunaMX.GeneradorDeEtiquetas
Imports System.Drawing.Printing

Public Class CIImprimirEtiquetaArticulo
    Private WithEvents mGrid As Solmicro.Expertis.Engine.UI.Grid

    Private Sub CIImprimirEtiquetaArticulo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mGrid = Grid
        Grid.Actions.Add("Abrir Artículo", AddressOf AccionAbrirArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
        Me.CargarImpresoras()
        Me.ntbNCopias.Focus()
    End Sub

    Private Sub CargarImpresoras()
        Dim sImpresora As String = String.Empty
        Dim i, nPrinters, nSelected As Integer
        Dim strPrinter As String = String.Empty               ' Variable que contiene la Impresora Seleccionada
        Dim strDefault As String = String.Empty              ' variable que contiene la impresora predeterminada
        Dim pd As PrinterSettings

        pd = New PrinterSettings
        strDefault = pd.PrinterName

        nPrinters = PrinterSettings.InstalledPrinters.Count() - 1    ' Contiene la cantidad de impresoras instaladas
        nSelected = 0                                   ' Inicializamos el indice

        For i = 0 To nPrinters
            strPrinter = PrinterSettings.InstalledPrinters(i).ToString()
            cboImpresoras.Items.Add(strPrinter)
            If sImpresora = "" Then
                If strPrinter = strDefault Then nSelected = i 'Asignamos el indice de la impresora predeterminada
            Else
                If strPrinter = sImpresora Then nSelected = i 'Asignamos el indice de la impresora predeterminada
            End If
        Next

        cboImpresoras.SelectedIndex = nSelected               ' Seleccionamos la impresora predeterminada
    End Sub

    Private Sub cbImpresoraEspecifica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbImpresoraEspecifica.CheckedChanged
        If cbImpresoraEspecifica.Checked Then
            cboImpresoras.Enabled = True
        Else
            cboImpresoras.Enabled = False
        End If
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
            Dim OrdenFabricacion As String = txtBoxOrdenFabricacion.Text
            Dim OCCliente As String = txtBoxOCCliente.Text
            Dim impresora As String = IIf(cbImpresoraEspecifica.Checked, cboImpresoras.Text, "")

            If cantidad > 0 Then
                Select Case report_alias
                    Case "JMALABBLISTER"
                        Dim oEtiqueta As New Etiqueta(Grid.CheckedRecords, cantidad, OrdenFabricacion, OCCliente, report_alias, impresora)
                        ExpertisApp.ExecuteTask(Of Etiqueta)(AddressOf GeneradorDeEtiquetas.ImprimirEtiquetaBlister, oEtiqueta)

                    Case "JMALABBOLSITAS"
                        Dim oEtiqueta As New Etiqueta(Grid.CheckedRecords, cantidad, OrdenFabricacion, OCCliente, report_alias, impresora)
                        ExpertisApp.ExecuteTask(Of Etiqueta)(AddressOf GeneradorDeEtiquetas.ImprimirEtiquetaBolsita, oEtiqueta)

                    Case "JMALABCAJ"
                        Dim oEtiqueta As New Etiqueta(Grid.CheckedRecords, cantidad, OrdenFabricacion, OCCliente, report_alias, impresora)
                        ExpertisApp.ExecuteTask(Of Etiqueta)(AddressOf GeneradorDeEtiquetas.ImprimirEtiquetaCajitas, oEtiqueta)

                    Case "JMALABEXPORIG"
                        Dim oEtiqueta As New Etiqueta(Grid.CheckedRecords, cantidad, OrdenFabricacion, OCCliente, report_alias, impresora)
                        ExpertisApp.ExecuteTask(Of Etiqueta)(AddressOf GeneradorDeEtiquetas.ImprimirEtiquetaExpedicionORG, oEtiqueta)

                    Case "JMALABEXP"
                        Dim oEtiqueta As New Etiqueta(Grid.CheckedRecords, cantidad, OrdenFabricacion, OCCliente, report_alias, impresora)
                        ExpertisApp.ExecuteTask(Of Etiqueta)(AddressOf GeneradorDeEtiquetas.ImprimirEtiquetaExpedicion, oEtiqueta)

                    Case "JMALABGRANEL"
                        Dim oEtiqueta As New Etiqueta(Grid.CheckedRecords, cantidad, OrdenFabricacion, OCCliente, report_alias, impresora)
                        ExpertisApp.ExecuteTask(Of Etiqueta)(AddressOf GeneradorDeEtiquetas.ImprimirEtiquetaGranel, oEtiqueta)

                    Case "JMALABGRANELDOR"
                        Dim oEtiqueta As New Etiqueta(Grid.CheckedRecords, cantidad, OrdenFabricacion, OCCliente, report_alias, impresora)
                        ExpertisApp.ExecuteTask(Of Etiqueta)(AddressOf GeneradorDeEtiquetas.ImprimirEtiquetaGranelDorman, oEtiqueta)

                    Case "JMALABJUMBO"
                        Dim oEtiqueta As New Etiqueta(Grid.CheckedRecords, cantidad, OrdenFabricacion, OCCliente, report_alias, impresora)
                        ExpertisApp.ExecuteTask(Of Etiqueta)(AddressOf GeneradorDeEtiquetas.ImprimirEtiquetaJumbo, oEtiqueta)

                End Select
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
