Public Class AccionGlobalTimbrar
    Implements Engine.IAction


    Public Sub Execute(ByVal entityName As String, ByVal programID As System.Guid, ByVal record As System.Data.DataTable) Implements Solmicro.Expertis.Engine.IAction.Execute
        If entityName = "FacturaVentaCabecera" Then
            If Not record Is Nothing AndAlso record.Rows.Count > 0 Then
                If Length(record.Rows(0)("IDFactura")) > 0 Then
                    If Length(record.Rows(0)("FolioFiscal")) > 0 Then
                        ExpertisApp.GenerateMessage("La factura ya está timbrada")
                    ElseIf record.Rows(0)("IDContador").ToString.Contains("NTCREV") AndAlso Not Length(record.Rows(0)("IDFacturaRectificada")) > 0 Then
                        ExpertisApp.GenerateMessage("Es necesario que la nota de crédito tenga asignada una factura rectificada")
                    ElseIf record.Rows(0)("Estado") = 1 Then
                        Dim respuesta = ExpertisApp.ExecuteTask(Of Integer, String)(AddressOf ProcesoFacturacionElectronica.TimbrarDocumento, record.Rows(0)("IDFactura"))
                        ActionRefreshSimpleForm(programID)
                        ExpertisApp.GenerateMessage(respuesta)
                    Else
                        ExpertisApp.GenerateMessage("La factura no está contabilizada, es necesario primero contabilizarla")
                    End If
                End If

            End If
        End If
    End Sub

End Class
