Public Class GeneradorDeEtiquetas
    Shared CodBarCommand As String

    Public Class Etiqueta
        Public dtArticulos As DataTable
        Public cantidad As Integer
        Public orden_produccion As String
        Public orden_cliente As String
        Public alias_report As String
        Public impresora As String

        Public Sub New(ByVal dtArticulos As DataTable, ByVal cantidad As Integer, ByVal orden_produccion As String, ByVal orden_cliente As String, ByVal alias_report As String, ByVal impresora As String)
            Me.dtArticulos = dtArticulos
            Me.cantidad = cantidad
            Me.orden_produccion = orden_produccion
            Me.orden_cliente = orden_cliente
            Me.alias_report = alias_report
            Me.impresora = impresora
        End Sub
    End Class

    Public Shared Sub ProcessFile(ByVal FileInput As String, _
                            ByVal FileOutput As String, _
                            ByVal NumCopias As Integer, _
                            ByVal DPi300 As Boolean)
        Dim encode As System.Text.Encoding = System.Text.Encoding.GetEncoding(0)

        Dim st As New FileStream(FileInput, FileMode.Open, FileAccess.Read)
        Dim br As New BinaryReader(st, encode)

        Dim wst As New FileStream(FileOutput, FileMode.Create, FileAccess.ReadWrite)
        Dim bw As New StreamWriter(wst, encode)

        Dim byt As Integer
        Dim iC As Int64, iL As Int64

        iL = st.Length - 1

        Dim strLine As String = ""

        Dim strFind As String = "{XS;I,0001,0002C6201|}"

        'Interleaved 2 of 5
        'XBaa;bbbb,cccc,d,e,ff,gg,hh,ii,jj,k,llll,mnnnnnnnnnn, p, qq, r=
        ' aa Barcode Number; bbbb posicion X; ccc posicion Y, d 2 = Interleaved 2 of 5 (ITF)
        ' e checar digito 3 = autoagregar; ff ancho; gg espacio; hh Wide; ii espacio; 
        ' jj espacio entre caracteres; k rotacion 3 = 270; llll Alto; m + increment - decrement
        ' nnnnnnnnnn skip value; mostrar caracteres 1 = si; qq ceros a suprimir; r 
        ' {XB00;0250,1035,2,1,04,04,08,08,03,1,0156,+0000000000,1,00=
        Dim strReplace As String = CodBarCommand
        Dim strReplace2 As String = ""

        For iC = 0 To iL
            byt = br.ReadByte
            strLine &= Chr(byt)

            If Chr(byt) = "}" Then
                'Este código es para recorrer al frente la etiqueta de cajitas, buscar más adelante como hacerlo desde el diseñador y no de esta forma
                If DPi300 Then
                    If strLine.Contains("{D0620,0800,") Then
                        strFind = Microsoft.VisualBasic.Strings.Right(strLine, 16)
                        strReplace = "0612," & Microsoft.VisualBasic.Strings.Right(strLine, 11)
                    End If
                End If

                If strLine.Contains("{XS;I,0001,") Then
                    strFind = Microsoft.VisualBasic.Strings.Right(strLine, 22)
                    strReplace = CodBarCommand
                    strReplace &= Mid(strLine, 3, 6) & NumCopias.ToString("0000") & Microsoft.VisualBasic.Strings.Right(strLine, 12)
                End If

                strLine = strLine.Replace(strFind, strReplace)
                bw.Write(strLine)
                strLine = ""
            End If
            If iC = iL Then
                bw.Write(strLine)
            End If
        Next

        bw.Close()
        wst.Close()
        br.Close()
        st.Close()
    End Sub


    Public Shared Function GetImage(ByVal imagenOrig As Bitmap, Optional ByVal RotationVal As RotateFlipType = RotateFlipType.Rotate270FlipXY) As Bitmap
        Dim iAlto, iAncho As Integer
        Dim imageMod As New Bitmap(1, 1)

        iAlto = CInt(imagenOrig.Size.Height)
        iAncho = CInt(imagenOrig.Size.Width)
        imagenOrig.RotateFlip(RotationVal)
        imageMod = New Bitmap(imagenOrig, iAlto, iAncho)

        Return imageMod
    End Function

    <Task()> Public Shared Sub ImprimirEtiquetaBlister(ByVal data As Etiqueta, ByVal services As ServiceProvider)
        For Each a As DataRow In data.dtArticulos.Rows
            Dim xRpt As LabelBlisters = New LabelBlisters

            With xRpt
                .PrinterName = ExpertisApp.ExecuteTask(Of String, String)(AddressOf ClsEtiquetas.ObtenerImpresora, data.alias_report)
                .XrDataReference.Text = a.Item("DescArticulo")
                .XrDataReference0.Text = .XrDataReference.Text
                .XrBarCode.Text = a.Item("CodigoBarrasEmbalaje")
                .XrBarCode0.Text = .XrBarCode.Text

            End With
            xRpt.PrintingSystem.ShowMarginsWarning = False

            xRpt.Print()

            ProcessFile(xRpt.PrinterName.Replace("\", "") & ".prn", xRpt.PrinterName.Replace("\", "") & ".txt", data.cantidad, True)
            ReportPrinter.SendFileToPrinter(xRpt.PrinterName, xRpt.PrinterName.Replace("\", "") & ".txt")
        Next
    End Sub


    <Task()> Public Shared Sub ImprimirEtiquetaBolsita(ByVal data As Etiqueta, ByVal services As ServiceProvider)
        For Each a As DataRow In data.dtArticulos.Rows

            Dim xRpt As LabelBolsitasLandscape = New LabelBolsitasLandscape

            CodBarCommand = "{XB00;0260,0468,5,3,03,3,0046,+0000000000,016,1,00=" & a.Item("CodigoBarrasEmbalaje").Substring(0, 12) & "|}" & vbCrLf & _
            "{XB01;0639,0468,5,3,03,3,0046,+0000000000,016,1,00=" & a.Item("CodigoBarrasEmbalaje").Substring(0, 12) & "|}" & vbCrLf

            With xRpt
                .PrinterName = ExpertisApp.ExecuteTask(Of String, String)(AddressOf ClsEtiquetas.ObtenerImpresora, data.alias_report)
                '.XrDataMarca0.Text = rptEmpaque.Marca
                '.XrDataMarca1.Text = rptEmpaque.Marca

                .XrDataReference0.Text = _
                    IIf(a.Item("EZ") = String.Empty OrElse a.Item("EZ") = "---", _
                        IIf(a.Item("ILCO") = String.Empty OrElse a.Item("ILCO") = "---", "---", _
                            a.Item("ILCO") & " " & a.Item("MAT")), _
                    a.Item("EZ") & " " & a.Item("MAT"))
                .XrDataReference1.Text = .XrDataReference0.Text

                .XrDataRefCte0.Text = a.Item("ReferenciaCliente")
                .XrDataRefCte1.Text = .XrDataRefCte0.Text

                .XrDataProductionOrder0.Text = IIf(data.orden_produccion = String.Empty, "----", data.orden_produccion)
                .XrDataProductionOrder1.Text = .XrDataProductionOrder0.Text

                .XrDataQuantity0.Text = Format(a.Item("CapacidadEmbalaje"), "##,##0")
                .XrDataQuantity1.Text = .XrDataQuantity0.Text

                .XrDataPackingDate0.Text = Format(a.Item("FECHA"), "dd/MM/yy")
                .XrDataPackingDate1.Text = .XrDataPackingDate0.Text

                If True Then
                    .XrPictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    .XrPictureBox2.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                Else
                    .XrPictureBox1.Visible = False
                    .XrPictureBox2.Visible = False
                End If
            End With

            xRpt.Print()

            ProcessFile(xRpt.PrinterName.Replace("\", "") & ".prn", xRpt.PrinterName.Replace("\", "") & ".txt", data.cantidad, True)
            ReportPrinter.SendFileToPrinter(xRpt.PrinterName, xRpt.PrinterName.Replace("\", "") & ".txt")
        Next
    End Sub

    <Task()> Public Shared Sub ImprimirEtiquetaCajitas(ByVal data As Etiqueta, ByVal services As ServiceProvider)
        For Each a As DataRow In data.dtArticulos.Rows
            Dim xRpt As LabelCajitasUSALandscape = New LabelCajitasUSALandscape
            Dim stream As New MemoryStream()
            Dim image As Byte()

            With xRpt
                .PrinterName = ExpertisApp.ExecuteTask(Of String, String)(AddressOf ClsEtiquetas.ObtenerImpresora, data.alias_report)
                .XrDataQuantity.Text = Format(a.Item("CapacidadEmbalaje"), "##,##0")
                .XrDataQuantity0.Text = .XrDataQuantity.Text
                .XrDataReference.Text = _
                    IIf(a.Item("EZ") = String.Empty OrElse a.Item("EZ") = "---", _
                        IIf(a.Item("ILCO") = String.Empty OrElse a.Item("ILCO") = "---", "---", _
                            a.Item("ILCO") & " " & a.Item("MAT")), _
                    a.Item("EZ") & " " & a.Item("MAT"))
                .XrDataReference0.Text = .XrDataReference.Text
                .XrDataMaterial.Text = a.Item("MAT")
                .XrDataMaterial0.Text = .XrDataMaterial.Text
                .XrDataPackingDate.Text = Format(a.Item("FECHA"), "dd/MM/yy")
                .XrDataPackingDate0.Text = .XrDataPackingDate.Text
                .XrDataProductionOrder.Text = IIf(data.orden_produccion = String.Empty, "----", data.orden_produccion)
                .XrDataProductionOrder0.Text = .XrDataProductionOrder.Text

                If Not a.Item("SILUETA") Is DBNull.Value Then
                    image = DirectCast(a.Item("SILUETA"), Byte())
                    stream.Write(image, 0, image.Length)
                    Dim silueta As New Bitmap(stream)
                    .XrDataImageSilueta.Image = GetImage(silueta, RotateFlipType.Rotate90FlipXY)
                    .XrDataImageSilueta0.Image = .XrDataImageSilueta.Image
                End If

                If Not a.Item("PERFIL") Is DBNull.Value Then
                    image = DirectCast(a.Item("PERFIL"), Byte())
                    stream.Write(image, 0, image.Length)
                    Dim perfil As New Bitmap(stream)
                    .XrDataImagePerfil.Image = GetImage(perfil, RotateFlipType.Rotate90FlipXY)
                    .XrDataImagePerfil0.Image = .XrDataImagePerfil.Image
                End If

                If True Then
                    CodBarCommand = "{XB00;0634,0274,5,3,02,3,0090,+0000000000,018,1,00=" & data.dtArticulos.Rows(0)("CodigoBarrasEmbalaje").Substring(0, 12) & "|}" & vbCrLf & _
                                                "{XB01;0229,0269,5,3,02,3,0090,+0000000000,018,1,00=" & a.Item("CodigoBarrasEmbalaje").Substring(0, 12) & "|}" & vbCrLf
                Else
                    CodBarCommand = "{XB00;0664,0274,5,3,03,3,0090,+0000000000,018,1,00=" & data.dtArticulos.Rows(0)("CodigoBarrasEmbalaje").Substring(0, 12) & "|}" & vbCrLf & _
                                                "{XB01;0249,0269,5,3,03,3,0090,+0000000000,018,1,00=" & a.Item("CodigoBarrasEmbalaje").Substring(0, 12) & "|}" & vbCrLf
                End If
            End With

            xRpt.Print()

            ProcessFile(xRpt.PrinterName.Replace("\", "") & ".prn", xRpt.PrinterName.Replace("\", "") & ".txt", data.cantidad, True)
            ReportPrinter.SendFileToPrinter(xRpt.PrinterName, xRpt.PrinterName.Replace("\", "") & ".txt")
        Next
    End Sub


    <Task()> Public Shared Sub ImprimirEtiquetaExpedicionORG(ByVal data As Etiqueta, ByVal services As ServiceProvider)
        For Each a As DataRow In data.dtArticulos.Rows
            Dim xRpt As LabelExpedicionOrigLandscape = New LabelExpedicionOrigLandscape
            Dim stream As New MemoryStream()
            Dim image As Byte()

            With xRpt
                .PrinterName = ExpertisApp.ExecuteTask(Of String, String)(AddressOf ClsEtiquetas.ObtenerImpresora, data.alias_report)
                .XrDataReference.Text = a.Item("DescArticulo")
                .XrDataRefCte.Text = a.Item("ReferenciaCliente")
                .XrDataQuantity.Text = Format(a.Item("CapacidadEmbalaje"), "##,##0")
                .XrDataMaterialAcabado.Text = IIf(a.Item("MAT") = String.Empty, "", " ") & IIf(a.Item("MAT").Trim = "--", "", a.Item("TER"))
                If .XrDataMaterialAcabado.Text.Length > 0 Then .XrDataMaterialAcabado.Text = .XrDataMaterialAcabado.Text.Trim & " / "
                .XrDataMaterialAcabado.Text = .XrDataMaterialAcabado.Text
                .XrDataPacking.Text = a.Item("MAT")
                .XrDataPackingDate.Text = Format(a.Item("FECHA"), "dd/MM/yy")
                .XrDataProductionOrder.Text = IIf(data.orden_cliente = String.Empty, "----", data.orden_cliente)

                If Not a.Item("SILUETA") Is DBNull.Value Then
                    Image = DirectCast(a.Item("SILUETA"), Byte())
                    Stream.Write(Image, 0, Image.Length)
                    Dim silueta As New Bitmap(Stream)
                    .XrDataImageSilueta.Image = GetImage(silueta, RotateFlipType.Rotate90FlipXY)
                End If

                If Not a.Item("PERFIL") Is DBNull.Value Then
                    Image = DirectCast(a.Item("PERFIL"), Byte())
                    Stream.Write(Image, 0, Image.Length)
                    Dim perfil As New Bitmap(Stream)
                    .XrDataImagePerfil.Image = GetImage(perfil, RotateFlipType.Rotate90FlipXY)
                End If
            End With
            xRpt.Print()

            ProcessFile(xRpt.PrinterName.Replace("\", "") & ".prn", xRpt.PrinterName.Replace("\", "") & ".txt", data.cantidad, True)
            ReportPrinter.SendFileToPrinter(xRpt.PrinterName, xRpt.PrinterName.Replace("\", "") & ".txt")
        Next
    End Sub

    <Task()> Public Shared Sub ImprimirEtiquetaExpedicion(ByVal data As Etiqueta, ByVal services As ServiceProvider)
        For Each a As DataRow In data.dtArticulos.Rows
            Dim xRpt As LabelExpedicionUSALandscape = New LabelExpedicionUSALandscape
            Dim stream As New MemoryStream()
            Dim image As Byte()

            With xRpt
                .PrinterName = ExpertisApp.ExecuteTask(Of String, String)(AddressOf ClsEtiquetas.ObtenerImpresora, data.alias_report)
                .XrDataPacking.Text = Format(a.Item("CapacidadEmbalaje"), "##,##0")
                .XrDataCrossReference.Text = _
                    IIf(a.Item("EZ") = String.Empty OrElse a.Item("EZ") = "---", _
                        IIf(a.Item("ILCO") = String.Empty OrElse a.Item("ILCO") = "---", "---", _
                            a.Item("ILCO") & " " & a.Item("MAT")), _
                    a.Item("EZ") & " " & a.Item("MAT"))
                .XrDataMaterial.Text = a.Item("MAT") & "/" & a.Item("TER")
                .XrDataPackingDate.Text = a.Item("FECHA")
                .XrDataProductionOrder.Text = data.orden_cliente
                If Not a.Item("SILUETA") Is DBNull.Value Then
                    Image = DirectCast(a.Item("SILUETA"), Byte())
                    Stream.Write(Image, 0, Image.Length)
                    Dim silueta As New Bitmap(Stream)
                    .XrDataImageSilueta.Image = GetImage(silueta, RotateFlipType.Rotate90FlipXY)
                End If

                If Not a.Item("PERFIL") Is DBNull.Value Then
                    Image = DirectCast(a.Item("PERFIL"), Byte())
                    Stream.Write(Image, 0, Image.Length)
                    Dim perfil As New Bitmap(Stream)
                    .XrDataImagePerfil.Image = GetImage(perfil, RotateFlipType.Rotate90FlipXY)
                End If
                .XrDataQuantity.Text = Format(a.Item("CapacidadEmbalaje"), "##,##0")
            End With

            xRpt.Print()

            ProcessFile(xRpt.PrinterName.Replace("\", "") & ".prn", xRpt.PrinterName.Replace("\", "") & ".txt", data.cantidad, True)
            ReportPrinter.SendFileToPrinter(xRpt.PrinterName, xRpt.PrinterName.Replace("\", "") & ".txt")
        Next
    End Sub

    <Task()> Public Shared Sub ImprimirEtiquetaGranel(ByVal data As Etiqueta, ByVal services As ServiceProvider)
        For Each a As DataRow In data.dtArticulos.Rows
            Dim xRpt As LabelGranelLandscape = New LabelGranelLandscape

            With xRpt
                .PrinterName = ExpertisApp.ExecuteTask(Of String, String)(AddressOf ClsEtiquetas.ObtenerImpresora, data.alias_report)
                .XrDataRefCte.Text = a.Item("ReferenciaCliente")
                .XrDataRefCte0.Text = .XrDataRefCte.Text
                .XrDataQuantity.Text = Format(a.Item("CapacidadEmbalaje") / 2, "##,##0")
                .XrDataQuantity0.Text = .XrDataQuantity.Text
                .XrDataReference.Text = a.Item("DescArticulo")
                .XrDataReference0.Text = .XrDataReference.Text
                .XrDataMaterial.Text = a.Item("MAT") & "/" & a.Item("TER")
                .XrDataMaterial0.Text = .XrDataMaterial.Text
                .XrDataPackingDate.Text = a.Item("FECHA")
                .XrDataPackingDate0.Text = .XrDataPackingDate.Text
                .XrDataProductionOrder.Text = data.orden_cliente
                .XrDataProductionOrder0.Text = .XrDataProductionOrder.Text
            End With

            xRpt.Print()

            ProcessFile(xRpt.PrinterName.Replace("\", "") & ".prn", xRpt.PrinterName.Replace("\", "") & ".txt", data.cantidad, True)
            ReportPrinter.SendFileToPrinter(xRpt.PrinterName, xRpt.PrinterName.Replace("\", "") & ".txt")
        Next
    End Sub

    <Task()> Public Shared Sub ImprimirEtiquetaGranelDorman(ByVal data As Etiqueta, ByVal services As ServiceProvider)
        For Each a As DataRow In data.dtArticulos.Rows
            Dim xRpt As LabelGranelLandscape = New LabelGranelLandscape

            With xRpt
                .PrinterName = ExpertisApp.ExecuteTask(Of String, String)(AddressOf ClsEtiquetas.ObtenerImpresora, data.alias_report)
                .XrDataRefCte.Text = a.Item("ReferenciaCliente")
                .XrDataRefCte0.Text = .XrDataRefCte.Text
                .XrDataQuantity.Text = Format(a.Item("CapacidadEmbalaje"), "##,##0")
                .XrDataQuantity0.Text = .XrDataQuantity.Text
                .XrDataReference.Text = a.Item("DescArticulo")
                .XrDataReference0.Text = .XrDataReference.Text
                .XrDataMaterial.Text = a.Item("MAT") & "/" & a.Item("TER")
                .XrDataMaterial0.Text = .XrDataMaterial.Text
                .XrDataPackingDate.Text = a.Item("FECHA")
                .XrDataPackingDate0.Text = .XrDataPackingDate.Text
                .XrDataProductionOrder.Text = data.orden_cliente
                .XrDataProductionOrder0.Text = .XrDataProductionOrder.Text
                .XrLabelRefCte0.Text = "PART NUMBER"
                .XrLabelRefCte1.Text = "PART NUMBER"
            End With


            xRpt.Print()

            ProcessFile(xRpt.PrinterName.Replace("\", "") & ".prn", xRpt.PrinterName.Replace("\", "") & ".txt", data.cantidad, True)
            ReportPrinter.SendFileToPrinter(xRpt.PrinterName, xRpt.PrinterName.Replace("\", "") & ".txt")
        Next
    End Sub

    <Task()> Public Shared Sub ImprimirEtiquetaJumbo(ByVal data As Etiqueta, ByVal services As ServiceProvider)
        For Each a As DataRow In data.dtArticulos.Rows
            Dim xRpt As LabelJumboUSALandscape = New LabelJumboUSALandscape
            Dim stream As New MemoryStream()
            Dim image As Byte()

            With xRpt
                .PrinterName = ExpertisApp.ExecuteTask(Of String, String)(AddressOf ClsEtiquetas.ObtenerImpresora, data.alias_report)
                .XrDataQuantity.Text = Format(a.Item("CapacidadEmbalaje"), "##,##0")
                .XrDataQuantity0.Text = .XrDataQuantity.Text
                .XrDataReference.Text = _
                    IIf(a.Item("EZ") = String.Empty OrElse a.Item("EZ") = "---", _
                        IIf(a.Item("ILCO") = String.Empty OrElse a.Item("ILCO") = "---", "---", _
                            a.Item("ILCO") & " " & a.Item("MAT")), _
                    a.Item("EZ") & " " & a.Item("MAT"))
                .XrDataReference0.Text = .XrDataReference.Text
                .XrDataMaterial.Text = a.Item("MAT") & "/" & a.Item("TER")
                .XrDataMaterial0.Text = .XrDataMaterial.Text
                .XrDataPackingDate.Text = a.Item("FECHA")
                .XrDataPackingDate0.Text = .XrDataPackingDate.Text
                .XrDataProductionOrder.Text = data.orden_cliente
                .XrDataProductionOrder0.Text = .XrDataProductionOrder.Text

                If Not a.Item("SILUETA") Is DBNull.Value Then
                    image = DirectCast(a.Item("SILUETA"), Byte())
                    stream.Write(image, 0, image.Length)
                    Dim silueta As New Bitmap(stream)
                    .XrDataImageSilueta.Image = GetImage(silueta, RotateFlipType.Rotate90FlipXY)
                End If

                If Not a.Item("PERFIL") Is DBNull.Value Then
                    image = DirectCast(a.Item("PERFIL"), Byte())
                    stream.Write(image, 0, image.Length)
                    Dim perfil As New Bitmap(stream)
                    .XrDataImagePerfil.Image = GetImage(perfil, RotateFlipType.Rotate90FlipXY)
                End If
            End With


            xRpt.Print()

            ProcessFile(xRpt.PrinterName.Replace("\", "") & ".prn", xRpt.PrinterName.Replace("\", "") & ".txt", data.cantidad, True)
            ReportPrinter.SendFileToPrinter(xRpt.PrinterName, xRpt.PrinterName.Replace("\", "") & ".txt")
        Next
    End Sub

End Class
