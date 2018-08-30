Public Class ProcesoFacturacionElectronica

    Shared objEstrategia As EstrategiaFacturacion

    <Task()> Public Shared Function TimbrarDocumento(ByVal IDFactura As Integer, ByVal services As ServiceProvider) As String
        Dim empresa As TokenInfo
        empresa = AdminData.GetSessionInfo()
        Dim nEmpresa As String = empresa.DataBase.DataBaseName
        'Dim objFactura = New DocumentoFacturaVenta(rowFactura("IDFactura"))
        Dim objFactura = New DocumentoFacturaVenta(IDFactura)
        'Dim sContador As String = rowFactura("IDContador")
        Dim sContador As String = objFactura.HeaderRow("IDContador")

        Dim respuesta As String = ""
        If nEmpresa.Contains("Peru") Then
            If sContador.Contains("NTCREV") Then
                objEstrategia = New NotaCreditoSUNAT
                Dim creado = objEstrategia.CrearXML(objFactura)
                If creado Then
                    Dim timbrado = objEstrategia.Timbrar(False)
                    If timbrado Then
                        respuesta = objEstrategia.GetRespuesta()
                    End If
                End If
            ElseIf sContador.Contains("FACTURA") Then
                objEstrategia = New FacturaVentaSUNAT
                Dim creado = objEstrategia.CrearXML(objFactura)
                If creado Then
                    Dim timbrado = objEstrategia.Timbrar(False)
                    If timbrado Then
                        respuesta = objEstrategia.GetRespuesta()
                    End If
                End If
            ElseIf sContador.Contains("BOLETA") Then
                objEstrategia = New BoletaSUNAT
                Dim creado = objEstrategia.CrearXML(objFactura)
                If creado Then
                    Dim timbrado = objEstrategia.Timbrar(False)
                    If timbrado Then
                        respuesta = objEstrategia.GetRespuesta()
                    End If
                End If
            End If
        ElseIf nEmpresa.Contains("Colomb") Then
            If sContador.Contains("NTCREV") Then

            ElseIf sContador.Contains("FACTURA") Then

            ElseIf sContador.Contains("BOLETA") Then

            End If
        ElseIf nEmpresa.Contains("Mex") Then
            If sContador.Contains("NTCREV") Then

            ElseIf sContador.Contains("FACTURA") Then

            ElseIf sContador.Contains("BOLETA") Then

            End If
        End If

        Return respuesta

    End Function

    <Task()> Public Shared Function CancelarDocumentoTimbrado(ByVal IDFactura As Integer, ByVal services As ServiceProvider) As String
        Dim empresa As TokenInfo
        empresa = AdminData.GetSessionInfo()
        Dim nEmpresa As String = empresa.DataBase.DataBaseName
        'Dim objFactura = New DocumentoFacturaVenta(rowFactura("IDFactura"))
        Dim objFactura = New DocumentoFacturaVenta(IDFactura)
        'Dim sContador As String = rowFactura("IDContador")
        Dim sContador As String = objFactura.HeaderRow("IDContador")

        Dim respuesta As String = ""

        If nEmpresa.Contains("Peru") Then
            If sContador.Contains("NTCREV") Then
                objEstrategia = New NotaCreditoSUNAT
                Dim cancelado = objEstrategia.Cancelar(objFactura)
                If cancelado Then
                    respuesta = objEstrategia.GetRespuestaCancelacion()
                End If
            ElseIf sContador.Contains("FACTURA") Then
                objEstrategia = New FacturaVentaSUNAT
                Dim cancelado = objEstrategia.Cancelar(objFactura)
                If cancelado Then
                    respuesta = objEstrategia.GetRespuestaCancelacion()
                End If
            ElseIf sContador.Contains("BOLETA") Then
                objEstrategia = New BoletaSUNAT
                Dim cancelado = objEstrategia.Cancelar(objFactura)
                If cancelado Then
                    respuesta = objEstrategia.GetRespuestaCancelacion()
                End If
            End If
        ElseIf nEmpresa.Contains("Colomb") Then
            If sContador.Contains("NTCREV") Then

            ElseIf sContador.Contains("FACTURA") Then

            ElseIf sContador.Contains("BOLETA") Then

            End If
        ElseIf nEmpresa.Contains("Mex") Then
            If sContador.Contains("NTCREV") Then

            ElseIf sContador.Contains("FACTURA") Then

            ElseIf sContador.Contains("BOLETA") Then

            End If
        End If

        Return respuesta

    End Function


    <Task()> Public Shared Function RevisarCancelacion(ByVal IDFactura As Integer, ByVal services As ServiceProvider) As String
        Dim empresa As TokenInfo
        empresa = AdminData.GetSessionInfo()
        Dim nEmpresa As String = empresa.DataBase.DataBaseName
        'Dim objFactura = New DocumentoFacturaVenta(rowFactura("IDFactura"))
        Dim objFactura = New DocumentoFacturaVenta(IDFactura)
        'Dim sContador As String = rowFactura("IDContador")
        Dim sContador As String = objFactura.HeaderRow("IDContador")

        Dim respuesta As String = ""

        If nEmpresa.Contains("Peru") Then
            If sContador.Contains("NTCREV") Then

            ElseIf sContador.Contains("FACTURA") Then
                objEstrategia = New FacturaVentaSUNAT
                respuesta = objEstrategia.RevisarCancelacion(objFactura)
            ElseIf sContador.Contains("BOLETA") Then

            End If
        ElseIf nEmpresa.Contains("Colomb") Then
            If sContador.Contains("NTCREV") Then

            ElseIf sContador.Contains("FACTURA") Then

            ElseIf sContador.Contains("BOLETA") Then

            End If
        ElseIf nEmpresa.Contains("Mex") Then
            If sContador.Contains("NTCREV") Then

            ElseIf sContador.Contains("FACTURA") Then

            ElseIf sContador.Contains("BOLETA") Then

            End If
        End If

        Return respuesta

    End Function
End Class