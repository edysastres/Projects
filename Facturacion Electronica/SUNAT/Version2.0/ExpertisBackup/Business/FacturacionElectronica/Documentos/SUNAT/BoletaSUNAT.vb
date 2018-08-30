Imports System.IO
Imports SunatV2
Imports System.Xml

Public Class BoletaSUNAT
    Inherits EstrategiaSUNAT

    Dim objBoleta As New InvoiceType

#Region "Obligatorios"
    '/*
    ' * En este orden se debe construir un ejemplo mínimo
    ' * 1.-Fecha de emisión
    ' * 2.-Descripción de la empresa
    ' * 5.-Número RUC
    ' * 6.-Tipo de Documento
    ' * 7.-Numeración ID
    ' * 8.-Tipo y número de documento adquiriente 6-RUC
    ' * 9.-Nombres/Razón Social de Adquiriente
    ' * 11.-Unidad de medida por ítem
    ' * 12.-Cantidad de unidades por ítem
    ' * 13.-Descripcion del servicio/producto por ítem
    ' * 14.-Precio de Venta unitario por item
    ' * 15.-Tipo de monto y Monto total de la boleta (gravadas)
    ' * 23.-Importe Total Venta
    ' * 24.-Tipo de moneda de la factura
    ' * 27.-IGV por ítem
    ' * 29.-ID por ítem
    ' * 31.-Valor venta unitario sin IGV por ítem
    ' * 32.-Valor venta unitario por ítem
    ' * 36.-Firma digital
    ' * 37.-Versión UBL
    ' * 38.-Version estructura
    ' * 
    ' */
#End Region


    Public Overrides Function CrearXML(ByVal boleta As DocumentoFacturaVenta) As Boolean
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

        Dim header As DataRow = boleta.HeaderRow

        objBoleta.IssueDate = New IssueDateType
        ' * 1.-Fecha de emisión
        objBoleta.IssueDate.Value = header("FechaFactura")

        'Acceso entidad empresa 

        Dim rowEmpresa As DataRow = New DatosEmpresa().SelOnPrimaryKey(1).Rows(0)

        objBoleta.AccountingSupplierParty = New SupplierPartyType
        objBoleta.AccountingSupplierParty.Party = New PartyType
        ReDim objBoleta.AccountingSupplierParty.Party.PartyLegalEntity(0)
        objBoleta.AccountingSupplierParty.Party.PartyLegalEntity(0) = New PartyLegalEntityType
        objBoleta.AccountingSupplierParty.Party.PartyLegalEntity(0).RegistrationName = New RegistrationNameType
        ' * 2.-Descripción de la empresa
        objBoleta.AccountingSupplierParty.Party.PartyLegalEntity(0).RegistrationName.Value = rowEmpresa("DescEmpresa")

        objBoleta.AccountingSupplierParty.CustomerAssignedAccountID = New CustomerAssignedAccountIDType
        ' * 5.-Número RUC
        objBoleta.AccountingSupplierParty.CustomerAssignedAccountID.Value = rowEmpresa("Cif")
        ReDim objBoleta.AccountingSupplierParty.AdditionalAccountID(0)
        objBoleta.AccountingSupplierParty.AdditionalAccountID(0) = New AdditionalAccountIDType
        objBoleta.AccountingSupplierParty.AdditionalAccountID(0).Value = "6" 'RUC Catálogo No. 06
        ' * 6.-Tipo de Documento
        objBoleta.InvoiceTypeCode = New InvoiceTypeCodeType
        objBoleta.InvoiceTypeCode.Value = "03"   'BOLETA DE VENTA Catálogo No. 01

        objBoleta.ID = New IDType
        Dim contador As DataRow = New Contador().SelOnPrimaryKey(header("IDContador")).Rows(0)
        Dim NFactura As String = header("NFactura")
        Dim IDContador As String = contador("Texto")
        Dim correlativo As String = NFactura.Substring(IDContador.Length)
        'Dim correlativo As String = Replace(header("NFactura"), contador("Texto"), "")
        Dim boletaID As String
        objBoleta.ID.Value = header("NFactura")
        boletaID = "B" + header("IDCentroGestion") + "-" + correlativo
        ' * 7.-Numeración ID
        objBoleta.ID.Value = boletaID
        ' * 8.-Tipo y número de documento adquiriente 6-RUC
        objBoleta.AccountingCustomerParty = New CustomerPartyType
        objBoleta.AccountingCustomerParty.CustomerAssignedAccountID = New CustomerAssignedAccountIDType
        objBoleta.AccountingCustomerParty.CustomerAssignedAccountID.Value = header("CifCliente")
        ReDim objBoleta.AccountingCustomerParty.AdditionalAccountID(0)
        objBoleta.AccountingCustomerParty.AdditionalAccountID(0) = New AdditionalAccountIDType
        objBoleta.AccountingCustomerParty.AdditionalAccountID(0).Value = "6" 'Tipo de documento de identidad de acuerdo a catálogo SUNAT RUC
        objBoleta.AccountingCustomerParty.Party = New PartyType
        ReDim objBoleta.AccountingCustomerParty.Party.PartyLegalEntity(0)
        objBoleta.AccountingCustomerParty.Party.PartyLegalEntity(0) = New PartyLegalEntityType
        objBoleta.AccountingCustomerParty.Party.PartyLegalEntity(0).RegistrationName = New RegistrationNameType
        ' * 9.-Nombres/Razón Social de Adquiriente
        objBoleta.AccountingCustomerParty.Party.PartyLegalEntity(0).RegistrationName.Value = header("RazonSocial")

        'header("") subtotal - gravadas
        'inafectadas ?
        'exoneradas ?

        Dim objAdditionalMonetaryTotal() As AdditionalMonetaryTotalType = Nothing
        ReDim objAdditionalMonetaryTotal(0)
        objAdditionalMonetaryTotal(0) = New AdditionalMonetaryTotalType
        objAdditionalMonetaryTotal(0).ID = New IDType
        ' * 15.-Tipo de monto y Monto total de la boleta (gravadas)
        objAdditionalMonetaryTotal(0).ID.Value = "1001" 'tipo de monto Catálogo No 14
        objAdditionalMonetaryTotal(0).PayableAmount = New PayableAmountType
        objAdditionalMonetaryTotal(0).PayableAmount.Value = Math.Round(header("BaseImponible"), decimales)
        objAdditionalMonetaryTotal(0).PayableAmount.currencyID = CurrencyCodeContentType.PEN

        Dim objAdditionalInformation As AdditionalInformationType1 = Nothing
        objAdditionalInformation = New AdditionalInformationType1
        objAdditionalInformation.AdditionalMonetaryTotal = objAdditionalMonetaryTotal



        Dim ExtContent As System.Xml.XmlDocument = New System.Xml.XmlDocument()

        Dim Xml As String '= SerializeObject(objAdditionalInformation, ns)

        Dim xmlSerializer = New Serialization.XmlSerializer(objAdditionalInformation.GetType)
        Dim textWriter = New StringWriter
        xmlSerializer.Serialize(textWriter, objAdditionalInformation)
        xml = textWriter.ToString

        ExtContent.LoadXml(Xml)

        Dim element As System.Xml.XmlElement = ExtContent.DocumentElement

        Dim objUBLExtension As UBLExtensionType = Nothing
        objUBLExtension = New UBLExtensionType
        objUBLExtension.ExtensionContent = element

        'INAFECTADAS ???

        'objAdditionalMonetaryTotal() = Nothing
        'objAdditionalMonetaryTotal(0).ID = header("TipoMonto") 'tipo de monto Catálogo No 14
        'objAdditionalMonetaryTotal(0).PayableAmount = header("ImpTotal")

        'objAdditionalInformation = Nothing
        'objAdditionalInformation.AdditionalMonetaryTotal = objAdditionalMonetaryTotal

        'ExtContent = Nothing

        'Xml = SerializeObject(objAdditionalInformation, ns)

        'ExtContent.LoadXml(Xml)

        'element = ExtContent.DocumentElement

        'objUBLExtension = Nothing
        'objUBLExtension.ExtensionContent = element

        'EXONERADAS ???

        'objAdditionalMonetaryTotal() = Nothing
        'objAdditionalMonetaryTotal(0).ID = header("TipoMonto") 'tipo de monto Catálogo No 14
        'objAdditionalMonetaryTotal(0).PayableAmount = header("ImpTotal")

        'objAdditionalInformation = Nothing
        'objAdditionalInformation.AdditionalMonetaryTotal = objAdditionalMonetaryTotal

        'ExtContent = Nothing

        'Xml = SerializeObject(objAdditionalInformation, ns)

        'ExtContent.LoadXml(Xml)

        'element = ExtContent.DocumentElement

        'objUBLExtension = Nothing
        'objUBLExtension.ExtensionContent = element

        'Dim ListaUBLExtension As List(Of UBLExtensionType) = Nothing
        'ListaUBLExtension = New List(Of UBLExtensionType)

        'ListaUBLExtension.Add(New UBLExtensionType)
        'ListaUBLExtension.Add(objUBLExtension)

        'objBoleta.UBLExtensions = ListaUBLExtension.ToArray
        ReDim objBoleta.UBLExtensions(1)
        objBoleta.UBLExtensions(0) = New UBLExtensionType
        objBoleta.UBLExtensions(1) = New UBLExtensionType

        objBoleta.UBLExtensions(1).ExtensionContent = element

        ' * 23.-Importe Total Venta
        Dim objPayableAmountType = New PayableAmountType
        objPayableAmountType.currencyID = CurrencyCodeContentType.PEN
        objPayableAmountType.Value = Math.Round(header("ImpTotal"), decimales)

        Dim objMonetaryTotalType = New MonetaryTotalType
        objMonetaryTotalType.PayableAmount = objPayableAmountType

        objBoleta.LegalMonetaryTotal = objMonetaryTotalType
        ' * 24.-Tipo de moneda de la factura
        Dim objDocumentCurrencyCodeType = New DocumentCurrencyCodeType
        objDocumentCurrencyCodeType.Value = header("IDMoneda")

        objBoleta.DocumentCurrencyCode = objDocumentCurrencyCodeType

        '******** Lineas **********

        Dim nRegister() As DataRow = boleta.dtLineas.Select("IDTipoLinea = '00'")

        Dim lines(nRegister.Length) As InvoiceLineType
        Dim index As Integer = 0

        For Each row As DataRow In nRegister
            Dim line = New InvoiceLineType

            line.InvoicedQuantity = New InvoicedQuantityType
            ' * 11.-Unidad de medida por ítem
            Dim IDUdMedida As String = row("IDUdMedida")
            Dim unitCodeString = If(IDUdMedida.Contains("SERVICIO"), "ACT", "EA")
            Dim unitCode = DirectCast([Enum].Parse(GetType(UnitCodeContentType), unitCodeString), UnitCodeContentType)
            line.InvoicedQuantity.unitCode = unitCode
            line.InvoicedQuantity.unitCodeSpecified = True

            ' * 12.-Cantidad de unidades por ítem
            line.InvoicedQuantity.Value = Math.Round(row("Cantidad"), decimales)
            line.Item = New ItemType
            ' * 13.-Descripcion del servicio/producto por ítem
            ReDim line.Item.Description(0)
            line.Item.Description(0) = New DescriptionType
            line.Item.Description(0).Value = row("DescArticulo")

            line.PricingReference = New PricingReferenceType
            ReDim line.PricingReference.AlternativeConditionPrice(0)
            line.PricingReference.AlternativeConditionPrice(0) = New PriceType
            line.PricingReference.AlternativeConditionPrice(0).PriceAmount = New PriceAmountType
            Dim rowIva As DataRow = New TipoIva().SelOnPrimaryKey(row("IDTipoIVA")).Rows(0)
            ' * 14.-Precio de Venta unitario por item
            line.PricingReference.AlternativeConditionPrice(0).PriceAmount.currencyID = CurrencyCodeContentType.PEN
            line.PricingReference.AlternativeConditionPrice(0).PriceAmount.Value = Math.Round(row("Importe") * (1 + (rowIva("Factor") / 100)), decimales) ' con igb
            line.PricingReference.AlternativeConditionPrice(0).PriceTypeCode = New PriceTypeCodeType
            line.PricingReference.AlternativeConditionPrice(0).PriceTypeCode.Value = "01" 'Tipo de precio Catálogo No. 16
            ' * 27.-IGV por ítem
            ReDim line.TaxTotal(0)
            line.TaxTotal(0) = New TaxTotalType
            line.TaxTotal(0).TaxAmount = New TaxAmountType
            line.TaxTotal(0).TaxAmount.currencyID = CurrencyCodeContentType.PEN
            line.TaxTotal(0).TaxAmount.Value = Math.Round(row("Importe") * (rowIva("Factor") / 100), decimales) 'calcular
            ReDim line.TaxTotal(0).TaxSubtotal(0)
            line.TaxTotal(0).TaxSubtotal(0) = New TaxSubtotalType
            line.TaxTotal(0).TaxSubtotal(0).TaxAmount = New TaxAmountType
            line.TaxTotal(0).TaxSubtotal(0).TaxAmount.currencyID = CurrencyCodeContentType.PEN
            line.TaxTotal(0).TaxSubtotal(0).TaxAmount.Value = Math.Round(row("Importe") * (rowIva("Factor") / 100), decimales) 'calcular
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory = New TaxCategoryType
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxExemptionReasonCode = New TaxExemptionReasonCodeType
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxExemptionReasonCode.Value = "10" 'Catalogo No 7 - Gravado, Operación Onerosa
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme = New TaxSchemeType
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.ID = New IDType
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.ID.Value = "1000" 'Catalogo No 5
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.Name = New NameType1
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.Name.Value = "IGV" 'Catalogo No 5
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.TaxTypeCode = New TaxTypeCodeType
            line.TaxTotal(0).TaxSubtotal(0).TaxCategory.TaxScheme.TaxTypeCode.Value = "VAT" 'Catalogo No 5

            line.ID = New IDType
            ' * 29.-ID por ítem
            line.ID.Value = index + 1

            ' * 31.-Valor venta unitario sin IGV por ítem
            line.Price = New PriceType
            line.Price.PriceAmount = New PriceAmountType
            line.Price.PriceAmount.currencyID = CurrencyCodeContentType.PEN
            line.Price.PriceAmount.Value = Math.Round(row("Precio"), decimales) 'sin igb

            ' * 32.-Valor venta unitario por ítem
            line.LineExtensionAmount = New LineExtensionAmountType
            line.LineExtensionAmount.currencyID = CurrencyCodeContentType.PEN
            line.LineExtensionAmount.Value = Math.Round(row("Importe"), decimales)

            
            'Asignarla al arreglo 
            lines(index) = line
            index += 1
        Next

        objBoleta.InvoiceLine = lines

        ' * 36.-Firma Digital

        ReDim objBoleta.Signature(0)
        objBoleta.Signature(0) = New SignatureType
        objBoleta.Signature(0).ID = New IDType
        objBoleta.Signature(0).ID.Value = "IDSignJMA"
        objBoleta.Signature(0).SignatoryParty = New PartyType
        ReDim objBoleta.Signature(0).SignatoryParty.PartyIdentification(0)
        objBoleta.Signature(0).SignatoryParty.PartyIdentification(0) = New PartyIdentificationType
        objBoleta.Signature(0).SignatoryParty.PartyIdentification(0).ID = New IDType
        objBoleta.Signature(0).SignatoryParty.PartyIdentification(0).ID.Value = rowEmpresa("Cif")
        ReDim objBoleta.Signature(0).SignatoryParty.PartyName(0)
        objBoleta.Signature(0).SignatoryParty.PartyName(0) = New PartyNameType
        objBoleta.Signature(0).SignatoryParty.PartyName(0).Name = New NameType1
        objBoleta.Signature(0).SignatoryParty.PartyName(0).Name.Value = rowEmpresa("DescEmpresa")
        objBoleta.Signature(0).DigitalSignatureAttachment = New AttachmentType
        objBoleta.Signature(0).DigitalSignatureAttachment.ExternalReference = New ExternalReferenceType
        objBoleta.Signature(0).DigitalSignatureAttachment.ExternalReference.URI = New URIType
        objBoleta.Signature(0).DigitalSignatureAttachment.ExternalReference.URI.Value = "#signatureJMA"

        ' * 37.-Versión UBL
        Dim objUBLVersionID = New UBLVersionIDType
        objUBLVersionID.Value = "2.0"
        objBoleta.UBLVersionID = objUBLVersionID
        ' * 38.-Version estructura
        Dim objCustomizationID = New CustomizationIDType
        objCustomizationID.Value = "1.0"
        objBoleta.CustomizationID = objCustomizationID




        Dim DocumentSerializer As New Xml.Serialization.XmlSerializer(objBoleta.GetType)
        'Using writer As TextWriter = New StreamWriter(String.Format("{0}\REMISION_{1}.xml", "C:\Comparte", "BoletaSUNAT"))
        '    DocumentSerializer.Serialize(writer, objBoleta, ns)
        '    writer.Close()
        'End Using

        Dim xmlFileName As String = rowEmpresa("Cif") + "-" + "03" + "-" + "B" + header("IDCentroGestion") + "-" + correlativo
        Dim xmlFileNameWithExtension = xmlFileName + ".XML"
        Dim zipFileNameWithExtension = xmlFileName + ".ZIP"
        'Try
        'Creando el XML
        Dim directory = JMAHelper.GetDocumentsPath(xmlFileName, header("IDContador"), False, header("FechaFactura"))
        If Not System.IO.Directory.Exists(Xml) Then
            Dim directoryInfo = System.IO.Directory.CreateDirectory(directory)
        End If

        Dim encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

        'Using writer_io As IO.TextWriter = New StreamWriter(String.Format("{0}\{1}", directory, xmlFileNameWithExtension))
        '    DocumentSerializer.Serialize(writer_io, objBoleta, ns)
        '    writer_io.Close()
        'End Using

        Using writer_io As IO.StreamWriter = New StreamWriter(String.Format("{0}\{1}", directory, xmlFileNameWithExtension), False, encoding), xtWriter = XmlWriter.Create(writer_io)
            xtWriter.WriteProcessingInstruction("xml", "version=""1.0"" encoding=""ISO-8859-1"" standalone=""no""")
            DocumentSerializer.Serialize(xtWriter, objBoleta, ns)
            'invoiceSerializer.Serialize(xtWriter, invoice)
            writer_io.Close()
        End Using

        '''FIRMAR XML
        FirmarXML(directory + "\" + xmlFileNameWithExtension, "Invoice")

        directorio = directory
        zip = zipFileNameWithExtension
        Me.xml = xmlFileName

        'Creando el ZIP
        'Dim zipCompleteFileName As String = directory + "\" + zipFileNameWithExtension
        'If System.IO.File.Exists(zipCompleteFileName) Then
        'System.IO.File.Delete(zipCompleteFileName)
        'End If

        'JMAHelper.CompressDirectory(directory, directory, zipFileNameWithExtension)

        'Dim file = System.IO.File.ReadAllBytes(zipCompleteFileName)
        'Dim SunatClient = New pe.gob.sunat.e_beta.billService()
        'Dim response = SunatClient.sendBill(zipFileNameWithExtension, file, rowEmpresa("Cif"))

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

    '<Extension()>
    Public Shared Function SerializeObject(Of T)(ByVal toSerialize As T, ByVal ns As System.Xml.Serialization.XmlSerializerNamespaces) As String
        Dim xmlSerializer As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(toSerialize.[GetType]())

        Using textWriter As System.IO.StringWriter = New System.IO.StringWriter()
            xmlSerializer.Serialize(textWriter, toSerialize)
            Return textWriter.ToString()
        End Using
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
