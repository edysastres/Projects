
Public Class AccionGlobalCancelarTimbrado
    Implements Engine.IAction




    Public Sub Execute(ByVal entityName As String, ByVal programID As System.Guid, ByVal record As System.Data.DataTable) Implements Solmicro.Expertis.Engine.IAction.Execute

        If entityName = "FacturaVentaCabecera" Then
            If Not record Is Nothing AndAlso record.Rows.Count > 0 Then
                If Length(record.Rows(0)("IDFactura")) > 0 Then
                    If Length(record.Rows(0)("FolioFiscal")) > 0 Then
                        If record.Rows(0)("IDContador").ToString.Contains("FACTURA") Then
                            Dim strViewName As String = "tbFacturaVentaCabecera"
                            Dim oFltr As New Filter
                            oFltr.Add(New StringFilterItem("IDFacturaRectificada", FilterOperator.Equal, record.Rows(0)("IDFactura")))

                            Dim dtRelacionada As DataTable
                            dtRelacionada = New BE.DataEngine().Filter(strViewName, oFltr, , )

                            If dtRelacionada.Rows.Count > 0 Then
                                ExpertisApp.GenerateMessage(String.Format("La factura está relacionada con la nota {0} es necesario primero cancelarla", dtRelacionada.Rows(0)("NFactura")))
                                Return
                            End If
                        End If

                        Dim respuesta = ""
                        If Length(record.Rows(0)("TicketCancelacion")) > 0 Then
                            respuesta = "Ticket: " + record.Rows(0)("TicketCancelacion")
                        Else
                            respuesta = ExpertisApp.ExecuteTask(Of Integer, String)(AddressOf ProcesoFacturacionElectronica.CancelarDocumentoTimbrado, record.Rows(0)("IDFactura"))
                            ExpertisApp.GenerateMessage(respuesta)
                        End If

                        If respuesta.Contains("Ticket") Then
                            Dim FrmFactura As MntoFacturaVenta = ExpertisApp.GetForm(programID)
                            FrmFactura.NotifyIcon1.ShowBalloonTip(3000, "Cancelación Iniciada...", respuesta, ToolTipIcon.Info)

                            'Lanzar proceso Background
                            FrmFactura.BackgroundWorker1.RunWorkerAsync(record.Rows(0)("IDFactura"))

                        End If

                    Else
                        ExpertisApp.GenerateMessage("El comprobante no ha sido timbrado")
                    End If
                End If
            End If
        End If

    End Sub
End Class
