Public Class NotaCreditoSUNAT
    Inherits EstrategiaSUNAT

    Public notaCredito As SunatV2.CreditNoteType
    Dim Cabecera As DataRow
    Dim Cuerpo As DataTable
    Dim DrDatosEmpresa As DataRow
    Dim DrFacturaRectificada As DataRow
#Region "Funciones Facturación"
    Public Overrides Function CrearXML(ByVal Documento As DocumentoFacturaVenta) As Boolean
        'Objeto para la NC
        notaCredito = New SunatV2.CreditNoteType

        'Objetos auxiliares para la consulta de datos del sistema
        Cabecera = Documento.HeaderRow
        Cuerpo = Documento.dtLineas
        DrDatosEmpresa = New DatosEmpresa().SelOnPrimaryKey(1).Rows(0)
        DrFacturaRectificada = New FacturaVentaCabecera().SelOnPrimaryKey(Cabecera("IDFacturaRectificada")).Rows(0)

        'Dim document = New System.Xml.XmlDocument
        'Dim xml As String
        'Dim textWriter = New System.IO.StringWriter
        'xml = textWriter.ToString

        '1.-Fecha de emisión
        notaCredito.IssueDate = New SunatV2.IssueDateType
        notaCredito.IssueDate.Value = Cabecera("FechaFactura")

        '2.-Firma digital
        ReDim notaCredito.UBLExtensions(1)
        notaCredito.UBLExtensions(0) = New SunatV2.UBLExtensionType

        ReDim notaCredito.Signature(0)
        notaCredito.Signature(0) = New SunatV2.SignatureType
        notaCredito.Signature(0).ID = New SunatV2.IDType
        notaCredito.Signature(0).ID.Value = "IDSignJMA"
        notaCredito.Signature(0).SignatoryParty = New SunatV2.PartyType
        ReDim notaCredito.Signature(0).SignatoryParty.PartyIdentification(0)
        notaCredito.Signature(0).SignatoryParty.PartyIdentification(0) = New SunatV2.PartyIdentificationType
        notaCredito.Signature(0).SignatoryParty.PartyIdentification(0).ID = New SunatV2.IDType
        notaCredito.Signature(0).SignatoryParty.PartyIdentification(0).ID.Value = DrDatosEmpresa("Cif")
        ReDim notaCredito.Signature(0).SignatoryParty.PartyName(0)
        notaCredito.Signature(0).SignatoryParty.PartyName(0) = New SunatV2.PartyNameType
        notaCredito.Signature(0).SignatoryParty.PartyName(0).Name = New SunatV2.NameType1
        notaCredito.Signature(0).SignatoryParty.PartyName(0).Name.Value = DrDatosEmpresa("DescEmpresa")
        notaCredito.Signature(0).DigitalSignatureAttachment = New SunatV2.AttachmentType
        notaCredito.Signature(0).DigitalSignatureAttachment.ExternalReference = New SunatV2.ExternalReferenceType
        notaCredito.Signature(0).DigitalSignatureAttachment.ExternalReference.URI = New SunatV2.URIType
        notaCredito.Signature(0).DigitalSignatureAttachment.ExternalReference.URI.Value = "#signatureJMA"

        '3.-Razón Social
        notaCredito.AccountingSupplierParty = New SunatV2.SupplierPartyType
        notaCredito.AccountingSupplierParty.Party = New SunatV2.PartyType
        ReDim notaCredito.AccountingSupplierParty.Party.PartyLegalEntity(0)
        notaCredito.AccountingSupplierParty.Party.PartyLegalEntity(0) = New SunatV2.PartyLegalEntityType
        notaCredito.AccountingSupplierParty.Party.PartyLegalEntity(0).RegistrationName = New SunatV2.RegistrationNameType
        notaCredito.AccountingSupplierParty.Party.PartyLegalEntity(0).RegistrationName.Value = DrDatosEmpresa("DescEmpresa")

        '6.-Número de RUC
        notaCredito.AccountingSupplierParty.CustomerAssignedAccountID = New SunatV2.CustomerAssignedAccountIDType
        notaCredito.AccountingSupplierParty.CustomerAssignedAccountID.Value = DrDatosEmpresa("Cif")
        ReDim notaCredito.AccountingSupplierParty.AdditionalAccountID(0)
        notaCredito.AccountingSupplierParty.AdditionalAccountID(0) = New SunatV2.AdditionalAccountIDType
        notaCredito.AccountingSupplierParty.AdditionalAccountID(0).Value = "6"

        Dim tipoDocumento As String = ""
        Dim literalSerie As String = ""
        Dim contadorRectificado As String = DrFacturaRectificada("IDContador")
        If contadorRectificado.Contains("NTCREV") Then
            tipoDocumento = "07"
            literalSerie = "F"
        ElseIf contadorRectificado.Contains("FACTURA") Then
            tipoDocumento = "01"
            literalSerie = "F"
        ElseIf contadorRectificado.Contains("BOLETA") Then
            tipoDocumento = "03"
            literalSerie = "B"
        End If

        Dim contadorFacturaRectificada As DataRow = New Contador().SelOnPrimaryKey(DrFacturaRectificada("IDContador")).Rows(0)
        Dim NFacturaRectificada As String = DrFacturaRectificada("NFactura")
        Dim IDContadorFacturaRectificada As String = contadorFacturaRectificada("Texto")
        Dim correlativoFacturaRectificada As String = NFacturaRectificada.Substring(IDContadorFacturaRectificada.Length)

        '7.-Codigo del tipo de nota de credito y Numero de serie y correlativo del documento que modifica
        ReDim notaCredito.DiscrepancyResponse(0)
        notaCredito.DiscrepancyResponse(0) = New SunatV2.ResponseType
        notaCredito.DiscrepancyResponse(0).ReferenceID = New SunatV2.ReferenceIDType
        notaCredito.DiscrepancyResponse(0).ReferenceID.Value = literalSerie + Cabecera("IDCentroGestion") + "-" + correlativoFacturaRectificada 'ObtenerNoFactura(DrFacturaRectificada("NFactura"), DrFacturaRectificada("IDContador")) 'Nz(Cabecera("IDFacturaRectificada"), 0)
        notaCredito.DiscrepancyResponse(0).ResponseCode = New SunatV2.ResponseCodeType
        notaCredito.DiscrepancyResponse(0).ResponseCode.Value = "10"

        Dim contador As DataRow = New Contador().SelOnPrimaryKey(Cabecera("IDContador")).Rows(0)
        Dim NFactura As String = Cabecera("NFactura")
        Dim IDContador As String = contador("Texto")
        Dim correlativo As String = NFactura.Substring(IDContador.Length)

        '8.-Numeracion serie y numero correlativo
        Dim DrContador = New Contador().SelOnPrimaryKey(Cabecera("IDContador")).Rows(0)
        notaCredito.ID = New SunatV2.IDType
        notaCredito.ID.Value = literalSerie + Cabecera("IDCentroGestion") + "-" + correlativo 'ObtenerNoFactura(Cabecera("NFactura"), Cabecera("IDContador")) 

        '9.-Tipo y numero de documento del adquiriente o usuario
        notaCredito.AccountingCustomerParty = New SunatV2.CustomerPartyType
        notaCredito.AccountingCustomerParty.CustomerAssignedAccountID = New SunatV2.CustomerAssignedAccountIDType
        notaCredito.AccountingCustomerParty.CustomerAssignedAccountID.Value = Cabecera("CifCliente")
        ReDim notaCredito.AccountingCustomerParty.AdditionalAccountID(0)
        notaCredito.AccountingCustomerParty.AdditionalAccountID(0) = New SunatV2.AdditionalAccountIDType
        notaCredito.AccountingCustomerParty.AdditionalAccountID(0).Value = "6"

        '10.-Apellidos y nombres o denominación o razón social del adquiriente o usuario
        notaCredito.AccountingCustomerParty.Party = New SunatV2.PartyType
        ReDim notaCredito.AccountingCustomerParty.Party.PartyLegalEntity(0)
        notaCredito.AccountingCustomerParty.Party.PartyLegalEntity(0) = New SunatV2.PartyLegalEntityType
        notaCredito.AccountingCustomerParty.Party.PartyLegalEntity(0).RegistrationName = New SunatV2.RegistrationNameType
        notaCredito.AccountingCustomerParty.Party.PartyLegalEntity(0).RegistrationName.Value = Cabecera("RazonSocial")


        '11.-Motivo o sustento
        ReDim notaCredito.DiscrepancyResponse(0).Description(0)
        notaCredito.DiscrepancyResponse(0).Description(0) = New SunatV2.DescriptionType
        notaCredito.DiscrepancyResponse(0).Description(0).Value = Nz(Cabecera("Texto"), "N/E")


        '20.-Total valor de venta - operaciones gravadas
        'Sin impuestos
        notaCredito.UBLExtensions(1) = New SunatV2.UBLExtensionType

        Dim ai = New SunatV2.AdditionalInformationType1
        ReDim ai.AdditionalMonetaryTotal(0)
        ai.AdditionalMonetaryTotal(0) = New SunatV2.AdditionalMonetaryTotalType
        ai.AdditionalMonetaryTotal(0).ID = New SunatV2.IDType
        ai.AdditionalMonetaryTotal(0).ID.Value = "1001" ' Catálogo No. 14: Códigos - Otros conceptos tributarios - Total valor de venta - operaciones gravadas
        ai.AdditionalMonetaryTotal(0).PayableAmount = New SunatV2.PayableAmountType
        ai.AdditionalMonetaryTotal(0).PayableAmount.currencyID = SunatV2.CurrencyCodeContentType.PEN ' Catálogo 02 - Sol Peruano
        ai.AdditionalMonetaryTotal(0).PayableAmount.Value = Math.Round(Cabecera("ImpLineas"), decimales) * -1

        Dim document = New System.Xml.XmlDocument
        Dim xml As String
        Dim xmlSerializer = New System.Xml.Serialization.XmlSerializer(ai.GetType)
        Dim textWriter = New System.IO.StringWriter
        xmlSerializer.Serialize(textWriter, ai)
        xml = textWriter.ToString

        document.LoadXml(xml)

        Dim element = document.DocumentElement
        notaCredito.UBLExtensions(1).ExtensionContent = element

        '29.-Importe total
        notaCredito.LegalMonetaryTotal = New SunatV2.MonetaryTotalType
        notaCredito.LegalMonetaryTotal.PayableAmount = New SunatV2.PayableAmountType
        Select Case Cabecera("IDMoneda")
            Case "PEN"
                notaCredito.LegalMonetaryTotal.PayableAmount.currencyID = SunatV2.CurrencyCodeContentType.PEN
            Case "USD"
                notaCredito.LegalMonetaryTotal.PayableAmount.currencyID = SunatV2.CurrencyCodeContentType.USD
        End Select
        notaCredito.LegalMonetaryTotal.PayableAmount.Value = Math.Round(Cabecera("ImpTotal"), decimales) * -1


        '30.-Tipo de moneda en la cual se emite la NCE
        notaCredito.DocumentCurrencyCode = New SunatV2.DocumentCurrencyCodeType
        notaCredito.DocumentCurrencyCode.Value = Cabecera("IDMoneda")

        '31.-Serie y número del documento que modifica
        Dim DrFacturaReferenciada As DataRow
        If Not (Cabecera("IDFacturaRectificada").GetType().Equals(GetType(DBNull))) Then
            DrFacturaReferenciada = New FacturaVentaCabecera().SelOnPrimaryKey(Cabecera("IDFacturaRectificada")).Rows(0)
        End If
        If Not IsNothing(DrFacturaReferenciada) Then
            ReDim notaCredito.BillingReference(0)
            notaCredito.BillingReference(0) = New SunatV2.BillingReferenceType
            notaCredito.BillingReference(0).InvoiceDocumentReference = New SunatV2.DocumentReferenceType
            notaCredito.BillingReference(0).InvoiceDocumentReference.ID = New SunatV2.IDType
            notaCredito.BillingReference(0).InvoiceDocumentReference.ID.Value = notaCredito.DiscrepancyResponse(0).ReferenceID.Value
            notaCredito.BillingReference(0).InvoiceDocumentReference.DocumentTypeCode = New SunatV2.DocumentTypeCodeType
            notaCredito.BillingReference(0).InvoiceDocumentReference.DocumentTypeCode.Value = tipoDocumento
        End If

        '34.-Numero de orden del Item
        Dim f As New Filter
        f.Add("IDFactura", FilterOperator.Equal, Cabecera("IDFactura"))
        Dim DtLineas As DataTable = New DataEngine().RetrieveData("tbFacturaVentaLinea", "*", f)
        Dim cont As Integer = 0
        ReDim notaCredito.CreditNoteLine(DtLineas.Rows.Count)
        For Each Row As DataRow In DtLineas.Rows
            notaCredito.CreditNoteLine(cont) = New SunatV2.CreditNoteLineType
            notaCredito.CreditNoteLine(cont).ID = New SunatV2.IDType
            notaCredito.CreditNoteLine(cont).ID.Value = cont + 1 'Row("IDArticulo")
            cont = cont + 1
        Next

        '36.-Version de UBL 
        notaCredito.UBLVersionID = New SunatV2.UBLVersionIDType
        notaCredito.UBLVersionID.Value = "2.0"

        '37.-Version de la estructura del documento
        notaCredito.CustomizationID = New SunatV2.CustomizationIDType
        notaCredito.CustomizationID.Value = "1.0"

        'Namespaces
        Dim ns As New System.Xml.Serialization.XmlSerializerNamespaces
        ns.Add("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")
        ns.Add("ccts", "urn:un:unece:uncefact:documentation:2")
        ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance")
        ns.Add("tns", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")
        ns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
        ns.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")
        ns.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
        ns.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")
        ns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
        ns.Add("ds", "http://www.w3.org/2000/09/xmldsig#")

        'Procedimientos para Serialización
        Dim serializer = New System.Xml.Serialization.XmlSerializer(notaCredito.GetType)
        serializer.Serialize(Console.Out, notaCredito, ns)

        'Información del documento
        'Nombre del archivo: <RUC>-<TipoComprobante>-<Serie del comprobante>-<No. Correlativo>.Ext
        'RUC: 11 dígitos (1-11)
        '- (12)
        'Tipo Comprobante: 2 dígitos (13-14)
        '   01: Factura electrónica
        '   03: Boleta de venta
        '   07: Nota de crédito
        '   08: Nota de débito
        '- (15)
        'Serie del comprobante[FAAA/BAAA]: 4 dígitos (16-19)
        '- (20)
        'No. Correlativo: 8 dígitos (21-28)
        '.: Punto de extensión (29)
        'Extensión del archivo [XML/ZIP]: 3 dígitos (30-32)
        Dim FileName As String = DrDatosEmpresa("Cif") + "-07-" + literalSerie + Cabecera("IDCentroGestion") + "-" + correlativo 'ObtenerTipoDocumento(Cabecera("IDFacturaRectificada")) + Cabecera("IDCentroGestion") + "-" + ObtenerNoFactura(Cabecera("NFactura"), Cabecera("IDContador"))
        Dim xmlFileName As String = FileName + ".xml"
        Dim zipFileName As String = FileName + ".zip"
        'Creando el XML
        Dim directory = JMAHelper.GetDocumentsPath(FileName, Cabecera("IDContador"), False, Cabecera("FechaFactura"))
        If Not System.IO.Directory.Exists(xml) Then
            Dim directoryInfo = System.IO.Directory.CreateDirectory(directory)
        End If

        Dim encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

        'ISO-8859-1
        Using writer_io As IO.StreamWriter = New System.IO.StreamWriter(String.Format("{0}\{1}", directory, xmlFileName), False, encoding), xtWriter = System.Xml.XmlWriter.Create(writer_io)
            xtWriter.WriteProcessingInstruction("xml", "version=""1.0"" encoding=""ISO-8859-1"" standalone=""no""")
            serializer.Serialize(xtWriter, notaCredito, ns)
            'invoiceSerializer.Serialize(xtWriter, invoice)
            writer_io.Close()
        End Using

        '''FIRMAR XML
        FirmarXML(directory + "\" + xmlFileName, "CreditNote")

        directorio = directory
        zip = zipFileName
        Me.xml = FileName


        '''Llenar objeto de registro
        registro.IDFactura = Cabecera("IDFactura")
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

        ''Creando el ZIP
        'Dim zipCompleteFileName As String = directory + zipFileName
        'If System.IO.File.Exists(zipCompleteFileName) Then
        '    System.IO.File.Delete(zipCompleteFileName)
        'End If
        'JMAHelper.CompressDirectory(directory, directory, zipFileName)
        ''Archivo XML
        'Dim ResXml As New System.Xml.XmlDocument
        'ResXml.Load(String.Format("{0}\{1}", directory, xmlFileName))
        ''InsertarArchivoGenerados(Cabecera("IDFactura"), "2", String.Empty, Cabecera("NFactura"), Cabecera("IDContador"), DateTime.Now, DrDatosEmpresa("Cif"), Cabecera("CifCliente"), JMAHelper.ConvertFileToBase64(ResXml), JMAHelper.ConvertFileToBase64(zip.ZipFile.Read(String.Format("{0}\{1}", directory, zipFileName))), Nothing)
        ''Cancelar()
        Return True
    End Function

    'Public Overrides Function Timbrar() As Boolean
    '    Return MyBase.Timbrar()
    'End Function

    'Public Overrides Function Cancelar() As Boolean
    '    Dim f As New Filter
    '    f.Add("IDFactura", Cabecera("IDFactura"))
    '    Dim EntTimbrados As New ComprobantesTimbrados()
    '    Dim DrComprobanteTimbrado As DataTable = EntTimbrados.Filter(f)
    '    'DrComprobanteTimbrado.Rows(0)
    '    For Each row As DataRow In DrComprobanteTimbrado.Rows
    '        Dim DtABorrar As DataTable = New ComprobantesTimbrados().SelOnPrimaryKey(row("IDComprobante"))
    '        EntTimbrados.Delete(DtABorrar)
    '    Next
    '    Dim DtCancelados As DataTable = New ComprobantesCancelados().Filter(New Filter).Clone()
    '    '-> TODO: Implementar métodos de obtención del comprobante de cancelación (llamadas al Endpoint de cancelación) 
    '    '-> para obtener los datos requeridos por la entidad y la autoridad para validar la cancelación como correcta
    '    '-> y almacenarlos en la tabla de la base de datos.
    '    'DtCancelados.Rows.Add(Autonumérico, IDFactura, FolioFiscal, NComprobante, IDContador, FechaTimbrado, FechaCancelacion, SelloFiscal, SelloCFDI, CodigoDeBarras, JMAHelper.ConvertFileToBase64(XMLCancelacion)/RespuestaCancelacion(Base64), FechaCreacion, FechaModificacion, Usuario) 
    '    DtCancelados.Rows.Add(AdminData.GetAutoNumeric(), DrComprobanteTimbrado(0)("IDFactura"), DrComprobanteTimbrado(0)("FolioFiscal"), DrComprobanteTimbrado(0)("NComprobante"), DrComprobanteTimbrado(0)("IDContador"), DrComprobanteTimbrado(0)("FechaTimbrado"), DateTime.Now, DrComprobanteTimbrado(0)("SelloFiscal"), DrComprobanteTimbrado(0)("SelloCFDI"), JMAHelper.ConvertStringToByteArray("Pendiente"), DrComprobanteTimbrado(0)("XMLGenerado"), DateTime.Now, DateTime.Now, AdminData.GetSessionInfo().UserName)
    '    Dim EntCancelados As New ComprobantesCancelados()
    '    EntCancelados.Validate(DtCancelados)
    '    EntCancelados.Update(DtCancelados)
    'End Function

#End Region
#Region "Funciones generales"
    Public Function ObtenerNoFactura(ByVal NFactura As String, ByVal IDContador As String) As String
        Dim Chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ/\-_.:;"
        Dim i As Integer = 0
        Dim arr As Char() = NFactura.ToCharArray()
        Dim c As Char = "A"
        While (Chars.Contains(c))
            c = arr(i)
            i += 1
        End While
        Return NFactura.Substring(i - 1)
        'Return NFactura.Substring(IDContador.Length)
    End Function

    Public Function ObtenerTipoDocumento(ByVal IDDocumento As String) As String
        Dim DrDocumento As DataRow = New FacturaVentaCabecera().SelOnPrimaryKey(IDDocumento).Rows(0)
        If Not IsNothing(DrDocumento) Then
            If (DrDocumento.ToString().Contains("FACTURA")) Then
                Return "F"
            ElseIf (DrDocumento.ToString().Contains("BOLETA")) Then
                Return "B"
            End If
        Else
            ApplicationService.GenerateError("El documento rectificado indicado por esta nota de crédito no es válido o no existe en la base de datos. Favor de comprobarlo")
        End If
    End Function

    Public Function InsertarArchivoGenerados(ByVal IDFactura As String, ByVal Version As String, ByVal FolioFiscal As String, ByVal NComprobante As String, ByVal IDContador As String, ByVal FechaTimbrado As DateTime, ByVal Emisor As String, ByVal Receptor As String, ByVal XML As Byte(), ByVal Zip As Byte(), ByVal CodigoBarras As Byte(), Optional ByVal SelloFiscal As String = "N/E", Optional ByVal SelloCFDI As String = "N/E") As Boolean
        Dim EntComprobantes As New ComprobantesTimbrados
        Dim f As New Filter
        Dim DtComprobantes As DataTable = EntComprobantes.Filter(f).Clone()
        'Métodos de llenado de la tabla e inserción de datos.
        DtComprobantes.Rows.Add(AdminData.GetAutoNumeric(), IDFactura, Version, FolioFiscal, NComprobante, IDContador, FechaTimbrado, SelloFiscal, SelloCFDI, Emisor, Receptor, DateTime.Now, DateTime.Now, AdminData.GetSessionInfo().UserName, CodigoBarras, XML, Zip)
        EntComprobantes.Validate(DtComprobantes)
        EntComprobantes.Update(DtComprobantes)
    End Function
#End Region
End Class
