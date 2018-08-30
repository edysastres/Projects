
Imports SunatV2
Imports System.IO
Imports System.Xml
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography.Xml
Imports System.Security.Cryptography

Public Class FacturaVentaSUNAT
    Inherits EstrategiaSUNAT



#Region "Obligatorios"
    '/*
    ' * En este orden se debe construir un ejemplo mínimo
    ' * 1.-Fecha de emisión
    ' * 2.-Firma Digital
    ' * 3.-Razon Social Emisor
    ' * 6.-Numero RUC
    ' * 7.-Tipo de Documento
    ' * 8.-Numeracion
    ' * 9,10.-Nombres/Razón Social de Adquiriente
    ' * 11,12.-Cantidad de unidades por item
    ' * 13.-Descripcion del servicio/producto
    ' * 14.-Valor unitario por item
    ' * 15.-Precio de Venta por item
    ' * 16.-IGV por item
    ' * 21.-Venta por item
    ' * 27.-Importe Total Venta
    ' * 28.-Tipo de moneda de la factura
    ' * 33.-Numero de orden del Item
    ' * 36.-Version UBL
    ' * 37.-Version estructura
    ' * 
    ' */
#End Region

    Public Overrides Function CrearXML(ByVal factura As DocumentoFacturaVenta) As Boolean
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo

        'Serialización - Headers
        Dim ns = New System.Xml.Serialization.XmlSerializerNamespaces

        ns.Add("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")
        ns.Add("ccts", "urn:un:unece:uncefact:documentation:2")
        ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance")
        ns.Add("tns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
        ns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
        ns.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")
        ns.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
        ns.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")
        ns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
        ns.Add("ds", "http://www.w3.org/2000/09/xmldsig#")

        'Obtienes objeto con los datos de fuente

        Dim header As DataRow = factura.HeaderRow


        Dim invoice = New InvoiceType

        ' * 1.-Fecha de emisión
        invoice.IssueDate = New IssueDateType
        invoice.IssueDate.Value = header("FechaFactura")

        Dim empresa As DataRow = New DatosEmpresa().SelOnPrimaryKey(1).Rows(0)

        ' * 2.-Firma Digital
        ReDim invoice.UBLExtensions(1)
        invoice.UBLExtensions(0) = New UBLExtensionType

        ReDim invoice.Signature(0)
        invoice.Signature(0) = New SignatureType
        invoice.Signature(0).ID = New IDType
        invoice.Signature(0).ID.Value = "IDSignJMA"
        invoice.Signature(0).SignatoryParty = New PartyType
        ReDim invoice.Signature(0).SignatoryParty.PartyIdentification(0)
        invoice.Signature(0).SignatoryParty.PartyIdentification(0) = New PartyIdentificationType
        invoice.Signature(0).SignatoryParty.PartyIdentification(0).ID = New IDType
        invoice.Signature(0).SignatoryParty.PartyIdentification(0).ID.Value = empresa("Cif")
        ReDim invoice.Signature(0).SignatoryParty.PartyName(0)
        invoice.Signature(0).SignatoryParty.PartyName(0) = New PartyNameType
        invoice.Signature(0).SignatoryParty.PartyName(0).Name = New NameType1
        invoice.Signature(0).SignatoryParty.PartyName(0).Name.Value = empresa("DescEmpresa")
        invoice.Signature(0).DigitalSignatureAttachment = New AttachmentType
        invoice.Signature(0).DigitalSignatureAttachment.ExternalReference = New ExternalReferenceType
        invoice.Signature(0).DigitalSignatureAttachment.ExternalReference.URI = New URIType
        invoice.Signature(0).DigitalSignatureAttachment.ExternalReference.URI.Value = "#signatureJMA"

        ' * 3.-Razon Social Emisor
        invoice.AccountingSupplierParty = New SupplierPartyType
        invoice.AccountingSupplierParty.Party = New PartyType
        ReDim invoice.AccountingSupplierParty.Party.PartyLegalEntity(0)
        invoice.AccountingSupplierParty.Party.PartyLegalEntity(0) = New PartyLegalEntityType
        invoice.AccountingSupplierParty.Party.PartyLegalEntity(0).RegistrationName = New RegistrationNameType
        invoice.AccountingSupplierParty.Party.PartyLegalEntity(0).RegistrationName.Value = empresa("DescEmpresa")

        ' * 6.-Numero RUC
        invoice.AccountingSupplierParty.CustomerAssignedAccountID = New CustomerAssignedAccountIDType
        invoice.AccountingSupplierParty.CustomerAssignedAccountID.Value = empresa("Cif")
        ReDim invoice.AccountingSupplierParty.AdditionalAccountID(0)
        invoice.AccountingSupplierParty.AdditionalAccountID(0) = New AdditionalAccountIDType
        invoice.AccountingSupplierParty.AdditionalAccountID(0).Value = "6" ' Catálogo 06 - RUC

        ' * 7.-Tipo de Documento
        invoice.InvoiceTypeCode = New InvoiceTypeCodeType
        invoice.InvoiceTypeCode.Value = "01" 'Catálogo 01 - Factura

        ' * 8.-Numeracion F(Serie)-(NumeroCorrelativo)
        Dim contador As DataRow = New Contador().SelOnPrimaryKey(header("IDContador")).Rows(0)
        Dim NFactura As String = header("NFactura")
        Dim IDContador As String = contador("Texto")
        Dim correlativo As String = NFactura.Substring(IDContador.Length)
        'Dim correlativo As String = Replace(header("NFactura"), contador("Texto"), "")

        Dim invoiceID As String
        invoiceID = "F" + header("IDCentroGestion") + "-" + correlativo
        invoice.ID = New IDType
        invoice.ID.Value = invoiceID

        ' * 9.-Tipo y numero de documento de identidad del adquiriente o usuario
        invoice.AccountingCustomerParty = New CustomerPartyType
        invoice.AccountingCustomerParty.CustomerAssignedAccountID = New CustomerAssignedAccountIDType
        invoice.AccountingCustomerParty.CustomerAssignedAccountID.Value = header("CifCliente")
        ReDim invoice.AccountingCustomerParty.AdditionalAccountID(0)
        invoice.AccountingCustomerParty.AdditionalAccountID(0) = New AdditionalAccountIDType
        invoice.AccountingCustomerParty.AdditionalAccountID(0).Value = "6" ' Catálogo 06 - RUC

        ' * 10.-Nombres/Razón Social de Adquiriente
        invoice.AccountingCustomerParty.Party = New PartyType
        ReDim invoice.AccountingCustomerParty.Party.PartyLegalEntity(0)
        invoice.AccountingCustomerParty.Party.PartyLegalEntity(0) = New PartyLegalEntityType
        invoice.AccountingCustomerParty.Party.PartyLegalEntity(0).RegistrationName = New RegistrationNameType
        invoice.AccountingCustomerParty.Party.PartyLegalEntity(0).RegistrationName.Value = header("RazonSocial")

        'LINES
        Dim rows = factura.dtLineas.Select("IDTipoLinea='00'")
        Dim lines(rows.Length) As InvoiceLineType
        Dim indexLine As Integer = 1
        For Each row As DataRow In rows

            'Creación de la linea
            Dim line = New InvoiceLineType

            ' * 33.-Numero de orden del item
            line.ID = New IDType
            line.ID.Value = indexLine

            ' * 11.-Unidad de medida por item
            line.InvoicedQuantity = New InvoicedQuantityType
            Dim IDArtículo As String = row("IDArticulo")
            Dim unitCodeString = If(IDArtículo.Contains("SERVICIO"), "ACT", "EA")
            Dim unitCode = DirectCast([Enum].Parse(GetType(UnitCodeContentType), unitCodeString), UnitCodeContentType)
            line.InvoicedQuantity.unitCode = unitCode
            line.InvoicedQuantity.unitCodeSpecified = True

            ' * 12.-Cantidad de unidades por item
            Dim cantidad = row("Cantidad")
            line.InvoicedQuantity.Value = Math.Round(cantidad, decimales)

            ' * 13.-Descripcion del servicio/producto
            line.Item = New ItemType
            ReDim line.Item.Description(0)
            line.Item.Description(0) = New DescriptionType
            line.Item.Description(0).Value = row("DescArticulo")

            ' * 14.-Valor unitario por item
            line.Price = New PriceType
            line.Price.PriceAmount = New PriceAmountType
            line.Price.PriceAmount.currencyID = CurrencyCodeContentType.PEN ' Catálogo 02 - Sol Peruano
            Dim valorUnitario = row("Precio")
            line.Price.PriceAmount.Value = Math.Round(valorUnitario, decimales)

            ' * 15.-Precio de Venta por item y código
            line.PricingReference = New PricingReferenceType
            ReDim line.PricingReference.AlternativeConditionPrice(0)
            line.PricingReference.AlternativeConditionPrice(0) = New PriceType
            line.PricingReference.AlternativeConditionPrice(0).PriceAmount = New PriceAmountType
            line.PricingReference.AlternativeConditionPrice(0).PriceAmount.currencyID = CurrencyCodeContentType.PEN ' Catálogo 02 - Sol Peruano
            Dim tipoIVARow As DataRow = New TipoIva().SelOnPrimaryKey(row("IDTipoIVA")).Rows(0)
            Dim factorIVA As Decimal = tipoIVARow("Factor") / 100.0
            Dim IVAUnitario = valorUnitario * factorIVA
            line.PricingReference.AlternativeConditionPrice(0).PriceAmount.Value = Math.Round(valorUnitario + IVAUnitario, decimales)
            line.PricingReference.AlternativeConditionPrice(0).PriceTypeCode = New PriceTypeCodeType
            line.PricingReference.AlternativeConditionPrice(0).PriceTypeCode.Value = "01" ' Catálogo 16 - PrecioUnitario

            ' * 16.-IGV por item
            ReDim line.TaxTotal(0)
            line.TaxTotal(0) = New TaxTotalType
            line.TaxTotal(0).TaxAmount = New TaxAmountType
            line.TaxTotal(0).TaxAmount.currencyID = CurrencyCodeContentType.PEN
            line.TaxTotal(0).TaxAmount.Value = Math.Round(IVAUnitario, decimales)
            ReDim line.TaxTotal(0).TaxSubtotal(0)
            line.TaxTotal(0).TaxSubtotal(0) = New TaxSubtotalType
            line.TaxTotal(0).TaxSubtotal(0).TaxAmount = New TaxAmountType
            line.TaxTotal(0).TaxSubtotal(0).TaxAmount.currencyID = CurrencyCodeContentType.PEN ' Catálogo 02 - Sol Peruano
            line.TaxTotal(0).TaxSubtotal(0).TaxAmount.Value = Math.Round(IVAUnitario, decimales)
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory = New TaxCategoryType
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxExemptionReasonCode = New TaxExemptionReasonCodeType
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxExemptionReasonCode.Value = "10" ' Catálogo 07 - Gravado, Operación Onerosa
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme = New TaxSchemeType
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.ID = New IDType
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.ID.Value = "1000" ' Catálogo No. 05: Códigos de Tipos de Tributos
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.Name = New NameType1
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.Name.Value = "IGV" ' Catálogo No. 05: Códigos de Tipos de Tributos
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.TaxTypeCode = New TaxTypeCodeType
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.TaxTypeCode.Value = "VAT" ' Catálogo No. 05: Códigos de Tipos de Tributos

            ' * 21.-Venta por item
            line.LineExtensionAmount = New LineExtensionAmountType
            line.LineExtensionAmount.currencyID = CurrencyCodeContentType.PEN ' Catálogo 02 - Sol Peruano
            Dim factorDescuento As Decimal = row("Dto1") / 100.0
            Dim descuento = (valorUnitario * cantidad * factorDescuento)
            line.LineExtensionAmount.Value = Math.Round((valorUnitario * cantidad) - descuento, decimales)

            'Asignar línea al arreglo
            lines(indexLine - 1) = line
            indexLine += 1
        Next

        'Adjuntar lineas a la factura
        invoice.InvoiceLine = lines

        ' * 18.-Total valor de venta - operaciones gravadas
        'Sin impuestos
        invoice.UBLExtensions(1) = New UBLExtensionType

        Dim ai = New AdditionalInformationType1
        ReDim ai.AdditionalMonetaryTotal(0)
        ai.AdditionalMonetaryTotal(0) = New AdditionalMonetaryTotalType
        ai.AdditionalMonetaryTotal(0).ID = New IDType
        ai.AdditionalMonetaryTotal(0).ID.Value = "1001" ' Catálogo No. 14: Códigos - Otros conceptos tributarios - Total valor de venta - operaciones gravadas
        ai.AdditionalMonetaryTotal(0).PayableAmount = New PayableAmountType
        ai.AdditionalMonetaryTotal(0).PayableAmount.currencyID = CurrencyCodeContentType.PEN ' Catálogo 02 - Sol Peruano
        ai.AdditionalMonetaryTotal(0).PayableAmount.Value = Math.Round(header("ImpLineas"), decimales)

        Dim document = New XmlDocument
        Dim xml As String
        Dim xmlSerializer = New Serialization.XmlSerializer(ai.GetType)
        Dim textWriter = New StringWriter
        xmlSerializer.Serialize(textWriter, ai)
        xml = textWriter.ToString

        document.LoadXml(xml)

        Dim element = document.DocumentElement
        invoice.UBLExtensions(1).ExtensionContent = element

        ' * 19.-Total valor de venta - operaciones inafectas
        'Obligatoria si hay líneas inafectas al IGV

        ' * 20.-Total valor de venta - operaciones exoneradas
        'Obligatoria si hay líneas exoneradas al IGV

        ' * 27.-Importe Total Venta
        invoice.LegalMonetaryTotal = New MonetaryTotalType
        invoice.LegalMonetaryTotal.PayableAmount = New PayableAmountType
        invoice.LegalMonetaryTotal.PayableAmount.currencyID = CurrencyCodeContentType.PEN ' Catálogo 02 - Sol Peruano
        invoice.LegalMonetaryTotal.PayableAmount.Value = Math.Round(header("ImpTotal"), decimales)

        ' * 28.-Tipo de moneda de la factura
        invoice.DocumentCurrencyCode = New DocumentCurrencyCodeType
        invoice.DocumentCurrencyCode.Value = header("IDMoneda")  ' Catálogo 02 - Sol Peruano

        ' * 36.-Version UBL
        invoice.UBLVersionID = New UBLVersionIDType
        invoice.UBLVersionID.Value = "2.0"

        ' * 37.-Version estructura
        invoice.CustomizationID = New CustomizationIDType
        invoice.CustomizationID.Value = "1.0"

        'Serializar la factura
        Dim invoiceSerializer = New Serialization.XmlSerializer(invoice.GetType)

        'Creando el Directorio

        'Filename:   RUC-<Tipo de comprobante(01 - Factura)>-<Serie F###>-<Numero Correlativo ########>.XML
        Dim xmlFileName As String = empresa("Cif") + "-" + "01" + "-" + "F" + header("IDCentroGestion") + "-" + correlativo
        Dim xmlFileNameWithExtension = xmlFileName + ".XML"
        Dim zipFileNameWithExtension = xmlFileName + ".ZIP"
        'Try
        'Creando el XML
        Dim directory = JMAHelper.GetDocumentsPath(xmlFileName, header("IDContador"), False, header("FechaFactura"))
        If Not System.IO.Directory.Exists(xml) Then
            Dim directoryInfo = System.IO.Directory.CreateDirectory(directory)
        End If

        Dim encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

        'ISO-8859-1 
        Using writer_io As IO.StreamWriter = New StreamWriter(String.Format("{0}\{1}", directory, xmlFileNameWithExtension), False, encoding), xtWriter = XmlWriter.Create(writer_io)
            xtWriter.WriteProcessingInstruction("xml", "version=""1.0"" encoding=""ISO-8859-1"" standalone=""no""")
            invoiceSerializer.Serialize(xtWriter, invoice, ns)
            'invoiceSerializer.Serialize(xtWriter, invoice)
            writer_io.Close()
        End Using

        '''FIRMAR XML
        FirmarXML(directory + "\" + xmlFileNameWithExtension, "Invoice")

        directorio = directory
        zip = zipFileNameWithExtension
        Me.xml = xmlFileName


        '''Llenar objeto de registro
        registro.IDFactura = header("IDFactura")
        registro.Version = "2.0"
        'registro.FolioFiscal - No definido en este momento
        'registro.FechaTimbrado - No definido en este momento
        'registro.FirmaDigitalSUNAT - No definido en este momento
        'registro.Certificado - No definido en este momento
        'registro.RespuestaSUNAT - No definido en este momento
        'registro.NotasSUNAT - No definido en este momento
        'registro.XMLRequest - No definido en este momento 
        'registro.XMLResponse - No definido en este momento
        'registro.ZIPRequest - No definido en este momento
        'registro.ZIPResponse - No definido en este momento

        Return True

    End Function

    'Public Overrides Function Timbrar() As Boolean

    '    'Creando el ZIP para enviar
    '    Dim zipCompleteFileName As String = directorio + "\" + zip
    '    If System.IO.File.Exists(zipCompleteFileName) Then
    '        System.IO.File.Delete(zipCompleteFileName)
    '    End If

    '    JMAHelper.CompressDirectory(directorio, directorio, zip)

    '    Dim file = System.IO.File.ReadAllBytes(zipCompleteFileName)

    '    'Web Reference
    '    Dim wBillService = New pe.gob.sunat.e_beta.billService()
    '    Dim response = wBillService.sendBill(zip, file, firmante)

    '    If System.IO.File.Exists(directorio + "\response.zip") Then
    '        System.IO.File.Delete(directorio + "\response.zip")
    '    End If

    '    'Escribir ZIP de respuesta al directorio
    '    System.IO.File.WriteAllBytes(directorio + "\response.zip", response)

    '    'Descomprimir zip de respuesta
    '    JMAHelper.DecompressZipFile(directorio, "response.zip", directorio)

    '    'Leer XML de respuesta
    '    xmlRespuesta = directorio + "\R-" + xml + ".XML"

    '    '''Llenar objeto de registro
    '    registro.ZIPRequest = file
    '    registro.ZIPResponse = response

    '    Return True

    'End Function

End Class

