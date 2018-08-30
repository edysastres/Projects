Imports SunatV2
Imports System.IO
Imports System.Xml
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography.Xml
Imports System.Security.Cryptography
Imports System.Text

Public Class EstrategiaSUNAT
    Inherits EstrategiaFacturacion

    Friend decimales As Integer = 2
    Friend directorio As String = ""
    Friend zip As String = ""
    Friend xml As String = ""
    Friend firmante As String = ""
    Friend xmlRespuesta As String = ""
    Friend respuesta As String = ""

    Friend registro As Registro = New Registro()


    Public Overrides Function Cancelar(ByVal factura As DocumentoFacturaVenta) As Boolean
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo

        '/*
        ' * En este orden se debe construir un ejemplo mínimo
        ' * 1.-Apellidos y nombres o denominación o razón social
        ' * 2.-Número de RUC
        ' * 3.-Fecha de generación del documento dado de baja
        ' * 4.-Tipo de documento
        ' * 5.-Serie del documento dado de baja
        ' * 6.-Número correlativo del documento dado de baja
        ' * 7.-Motivo de baja
        ' * 8.-Numero de item
        ' * 9.-Identificador de la comunicación
        ' * 10.-Fecha de generación de la comunicación
        ' * 11.-Firma digital
        ' * 12.-Versión de UBL
        ' * 13.-Versión de estructura del archivo
        ' * 
        ' */

        Dim ns = New System.Xml.Serialization.XmlSerializerNamespaces

        ns.Add("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")
        ns.Add("ccts", "urn:un:unece:uncefact:documentation:2")
        ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance")
        'ns.Add("tns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
        ns.Add("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1")
        ns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
        ns.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")
        ns.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
        ns.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")
        ns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
        ns.Add("ds", "http://www.w3.org/2000/09/xmldsig#")

        'Obtienes objeto con los datos de fuente

        Dim header As DataRow = factura.HeaderRow


        Dim cancelacion = New VoidedDocumentsType


        Dim empresa As DataRow = New DatosEmpresa().SelOnPrimaryKey(1).Rows(0)

        ' * 1.-Apellidos y nombres o denominación o razón social
        cancelacion.AccountingSupplierParty = New SupplierPartyType
        cancelacion.AccountingSupplierParty.Party = New PartyType
        ReDim cancelacion.AccountingSupplierParty.Party.PartyLegalEntity(0)
        cancelacion.AccountingSupplierParty.Party.PartyLegalEntity(0) = New PartyLegalEntityType
        cancelacion.AccountingSupplierParty.Party.PartyLegalEntity(0).RegistrationName = New RegistrationNameType
        cancelacion.AccountingSupplierParty.Party.PartyLegalEntity(0).RegistrationName.Value = empresa("DescEmpresa")

        ' * 2.-Número de RUC
        cancelacion.AccountingSupplierParty.CustomerAssignedAccountID = New CustomerAssignedAccountIDType
        cancelacion.AccountingSupplierParty.CustomerAssignedAccountID.Value = empresa("Cif")
        ReDim cancelacion.AccountingSupplierParty.AdditionalAccountID(0)
        cancelacion.AccountingSupplierParty.AdditionalAccountID(0) = New AdditionalAccountIDType
        cancelacion.AccountingSupplierParty.AdditionalAccountID(0).Value = "6" ' Catálogo 06 - RUC

        ' * 3.-Fecha de generación del documento dado de baja
        cancelacion.ReferenceDate = New ReferenceDateType
        cancelacion.ReferenceDate.Value = header("FechaTimbrado")

        ' * 4.-Tipo de documento
        ReDim cancelacion.VoidedDocumentsLine(0)
        cancelacion.VoidedDocumentsLine(0) = New VoidedDocumentsLineType
        cancelacion.VoidedDocumentsLine(0).DocumentTypeCode = New DocumentTypeCodeType
        Dim tipoDocumento As String = ""
        Dim literalSerie As String = ""
        Dim sContador As String = header("IDContador")
        If sContador.Contains("NTCREV") Then
            tipoDocumento = "07"
            literalSerie = "F"
        ElseIf sContador.Contains("FACTURA") Then
            tipoDocumento = "01"
            literalSerie = "F"
        ElseIf sContador.Contains("BOLETA") Then
            tipoDocumento = "03"
            literalSerie = "B"
        End If
        cancelacion.VoidedDocumentsLine(0).DocumentTypeCode.Value = tipoDocumento
        cancelacion.VoidedDocumentsLine(0).LineID = New LineIDType


        Dim contador As DataRow = New Contador().SelOnPrimaryKey(header("IDContador")).Rows(0)
        Dim NFactura As String = header("NFactura")
        Dim IDContador As String = contador("Texto")
        'Dim correlativo As String = Replace(header("NFactura"), contador("Texto"), "")
        Dim correlativo As String = NFactura.Substring(IDContador.Length)

        ' * 5.-Serie del documento dado de baja
        cancelacion.VoidedDocumentsLine(0).DocumentSerialID = New IdentifierType
        cancelacion.VoidedDocumentsLine(0).DocumentSerialID.Value = literalSerie + header("IDCentroGestion")
        ' * 6.-Número correlativo del documento dado de baja
        cancelacion.VoidedDocumentsLine(0).DocumentNumberID = New IdentifierType
        cancelacion.VoidedDocumentsLine(0).DocumentNumberID.Value = correlativo

        ' * 7.-Motivo de baja
        cancelacion.VoidedDocumentsLine(0).VoidReasonDescription = New TextType
        cancelacion.VoidedDocumentsLine(0).VoidReasonDescription.Value = Nz(header("Texto"), "N/E")

        ' * 8.-Numero de item
        cancelacion.VoidedDocumentsLine(0).LineID.Value = "1"

        Dim dateString = Date.Now.ToString("yyyyMMdd")
        'Dim FechaDocumento As Date
        'FechaDocumento = header("FechaFactura")
        'Dim dateString = FechaDocumento.ToString("yyyyMMdd")

        ' * 9.-Identificador de la comunicación
        cancelacion.ID = New IDType
        cancelacion.ID.Value = "RA-" + dateString + "-" + correlativo

        ' * 10.-Fecha de generación de la comunicación
        cancelacion.IssueDate = New IssueDateType
        cancelacion.IssueDate.Value = Date.Now

        ' * 11.-Firma digital
        ReDim cancelacion.UBLExtensions(1)
        cancelacion.UBLExtensions(0) = New UBLExtensionType

        ReDim cancelacion.Signature(0)
        cancelacion.Signature(0) = New SignatureType
        cancelacion.Signature(0).ID = New IDType
        cancelacion.Signature(0).ID.Value = "IDSignJMA"
        cancelacion.Signature(0).SignatoryParty = New PartyType
        ReDim cancelacion.Signature(0).SignatoryParty.PartyIdentification(0)
        cancelacion.Signature(0).SignatoryParty.PartyIdentification(0) = New PartyIdentificationType
        cancelacion.Signature(0).SignatoryParty.PartyIdentification(0).ID = New IDType
        cancelacion.Signature(0).SignatoryParty.PartyIdentification(0).ID.Value = empresa("Cif")
        ReDim cancelacion.Signature(0).SignatoryParty.PartyName(0)
        cancelacion.Signature(0).SignatoryParty.PartyName(0) = New PartyNameType
        cancelacion.Signature(0).SignatoryParty.PartyName(0).Name = New NameType1
        cancelacion.Signature(0).SignatoryParty.PartyName(0).Name.Value = empresa("DescEmpresa")
        cancelacion.Signature(0).DigitalSignatureAttachment = New AttachmentType
        cancelacion.Signature(0).DigitalSignatureAttachment.ExternalReference = New ExternalReferenceType
        cancelacion.Signature(0).DigitalSignatureAttachment.ExternalReference.URI = New URIType
        cancelacion.Signature(0).DigitalSignatureAttachment.ExternalReference.URI.Value = "#signatureJMA"

        ' * 12.-Versión de UBL
        cancelacion.UBLVersionID = New UBLVersionIDType
        cancelacion.UBLVersionID.Value = "2.0"

        ' * 13.-Versión de estructura del archivo
        cancelacion.CustomizationID = New CustomizationIDType
        cancelacion.CustomizationID.Value = "1.0"

        'Serializar la factura
        Dim invoiceSerializer = New Serialization.XmlSerializer(cancelacion.GetType)

        'Creando el Directorio

        'Filename:   RUC-<Tipo de comprobante(RA - Comunicación de baja)>-<Serie F###>-<Numero Correlativo ########>.XML
        Dim xmlFileName As String = empresa("Cif") + "-" + "RA" + "-" + dateString + "-" + correlativo
        Dim xmlFileNameWithExtension = xmlFileName + ".XML"
        'Dim xmlFileNameWithExtension = empresa("Cif") + "-" + "RA" + "-" + dateString + ".XML"
        Dim zipFileNameWithExtension = xmlFileName + ".ZIP"
        'Dim zipFileNameWithExtension = empresa("Cif") + "-" + "RA" + "-" + dateString + ".ZIP"

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
            invoiceSerializer.Serialize(xtWriter, cancelacion, ns)
            'invoiceSerializer.Serialize(xtWriter, invoice)
            writer_io.Close()
        End Using

        '''FIRMAR XML
        FirmarXML(directory + "\" + xmlFileNameWithExtension, "VoidedDocuments")

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

        Timbrar(True)

        Return True
    End Function

    Public Overrides Function CrearXML(ByVal documento As DocumentoFacturaVenta) As Boolean
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo
        Return False
    End Function

    Public Overrides Function Timbrar(ByVal EsCancelacion As Boolean) As Boolean
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo
        'Creando el ZIP para enviar
        Dim zipCompleteFileName As String = directorio + "\" + zip
        If System.IO.File.Exists(zipCompleteFileName) Then
            System.IO.File.Delete(zipCompleteFileName)
        End If

        JMAHelper.CompressDirectory(directorio, directorio, zip)

        Dim file = System.IO.File.ReadAllBytes(zipCompleteFileName)

        'Web Reference
        Dim wBillService = New pe.gob.sunat.e_beta.billService()

        If EsCancelacion Then
            Dim response = wBillService.sendSummary(zip, file, firmante)
            registro.FolioFiscal = response
        Else
            Dim response = wBillService.sendBill(zip, file, firmante)
            'Escribir ZIP de respuesta al directorio
            System.IO.File.WriteAllBytes(directorio + "\response.zip", response)

            'Descomprimir zip de respuesta
            JMAHelper.DecompressZipFile(directorio, "response.zip", directorio)

            'Leer XML de respuesta
            xmlRespuesta = directorio + "\R-" + xml + ".XML"

            '''Llenar objeto de registro
            registro.ZIPRequest = file
            registro.ZIPResponse = response
        End If

        If System.IO.File.Exists(directorio + "\response.zip") Then
            System.IO.File.Delete(directorio + "\response.zip")
        End If

        Return True
    End Function

    Public Function FirmarXML(ByVal archivoXML As String, ByVal nodoRaiz As String) As Boolean

        Dim certificate = New X509Certificate2()
        Dim cer As String = New Parametro().LeerParametro("JMA_CER")
        If Length(cer) > 0 Then
            certificate = New X509Certificate2(New ApplicationService().GetReportTemplate(cer), "PERJMFE01")

            Dim xmlDoc = New XmlDocument()
            xmlDoc.PreserveWhitespace = True
            xmlDoc.Load(archivoXML)

            Dim nsMgr As XmlNamespaceManager
            nsMgr = New XmlNamespaceManager(xmlDoc.NameTable)
            nsMgr.AddNamespace("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")
            nsMgr.AddNamespace("ccts", "urn:un:unece:uncefact:documentation:2")
            nsMgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance")
            Select Case nodoRaiz
                Case "Invoice"
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
                Case "CreditNote"
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")
                Case "VoidedDocuments"
                    nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1")
            End Select
            nsMgr.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
            nsMgr.AddNamespace("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")
            nsMgr.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
            nsMgr.AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")
            nsMgr.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
            nsMgr.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#")
            Dim extNode As XmlNode = xmlDoc.SelectSingleNode("/tns:" + nodoRaiz + "/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent", nsMgr)
            If extNode Is Nothing Then
                extNode = xmlDoc.CreateElement("ext", "ExtensionContent", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
            End If
            Dim ext = xmlDoc.ImportNode(extNode, False)
            xmlDoc.SelectSingleNode("/tns:" + nodoRaiz + "/ext:UBLExtensions[1]/ext:UBLExtension", nsMgr).AppendChild(ext)

            Dim signedXml = New SignedXml(xmlDoc) With {.SigningKey = DirectCast(certificate.PrivateKey, System.Security.Cryptography.RSA)}
            signedXml.SigningKey = certificate.PrivateKey
            If signedXml.SigningKey Is Nothing Then
                signedXml.SigningKey = certificate.PublicKey.Key
            End If

            Dim xmlSignature = signedXml.Signature

            Dim env = New XmlDsigEnvelopedSignatureTransform()

            Dim reference = New Reference(String.Empty)
            reference.AddTransform(env)

            xmlSignature.SignedInfo.AddReference(reference)

            Dim keyInfo = New KeyInfo()
            Dim x509Data = New KeyInfoX509Data(certificate)

            x509Data.AddSubjectName(certificate.Subject)

            keyInfo.AddClause(x509Data)

            xmlSignature.KeyInfo = keyInfo
            xmlSignature.Id = "#signatureJMA"

            signedXml.ComputeSignature()

            Dim signature As XmlElement = signedXml.GetXml()

            xmlDoc.SelectSingleNode("/tns:" + nodoRaiz + "/ext:UBLExtensions[1]/ext:UBLExtension/ext:ExtensionContent", nsMgr).AppendChild(xmlDoc.ImportNode(signature, True))
            xmlDoc.Save(archivoXML)


            '''Llenar objeto de registro
            registro.XMLRequest = xmlDoc.ToString()

            Return True
        Else
            ApplicationService.GenerateError("El parámetro 'JMA_CER' no tiene valor.")
            Return False
        End If
    End Function

    Public Overrides Function GetRespuesta() As String
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo
        Dim xmlDoc = New XmlDocument()
        xmlDoc.PreserveWhitespace = True
        xmlDoc.Load(xmlRespuesta)

        Dim respuesta = ""

        Dim nsMgr As XmlNamespaceManager
        nsMgr = New XmlNamespaceManager(xmlDoc.NameTable)
        nsMgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/")
        nsMgr.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
        nsMgr.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
        nsMgr.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
        nsMgr.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#")
        nsMgr.AddNamespace("ar", "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2")


        '''Llenar objeto de registro
        Dim folio = xmlDoc.SelectSingleNode("/ar:ApplicationResponse/cbc:ID", nsMgr)
        registro.FolioFiscal = folio.InnerText

        Dim fechaTimbrado = xmlDoc.SelectSingleNode("/ar:ApplicationResponse/cbc:ResponseDate", nsMgr)
        Dim horaTimbrado = xmlDoc.SelectSingleNode("/ar:ApplicationResponse/cbc:ResponseTime", nsMgr)
        registro.FechaTimbrado = fechaTimbrado.InnerText + "T" + horaTimbrado.InnerText

        Dim firma = xmlDoc.SelectSingleNode("/ar:ApplicationResponse/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/ds:SignatureValue", nsMgr)
        registro.FirmaDigitalSUNAT = firma.InnerText

        Dim certificado = xmlDoc.SelectSingleNode("/ar:ApplicationResponse/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/ds:KeyInfo/ds:X509Data/ds:X509Certificate", nsMgr)
        registro.Certificado = certificado.InnerText

        Dim responseCode = xmlDoc.SelectSingleNode("/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ResponseCode", nsMgr)
        registro.CodigoRespuesta = responseCode.InnerText

        Dim response = xmlDoc.SelectSingleNode("/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:Description", nsMgr)
        registro.RespuestaSUNAT = response.InnerText

        Dim notas = xmlDoc.SelectNodes("/ar:ApplicationResponse/cbc:Note", nsMgr)

        registro.NotasSUNAT = ""
        For Each nota As XmlNode In notas
            registro.NotasSUNAT += (nota.InnerText + vbNewLine)
        Next

        registro.XMLResponse = xmlDoc.ToString()


        respuesta = response.InnerText
        If Not registro.NotasSUNAT.Equals("") Then
            respuesta += (vbNewLine + vbNewLine + registro.NotasSUNAT)
        End If

        If registro.CodigoRespuesta = 0 Then
            'Actualizar entidad
            ActualizarEntidad(False)
            MoverDirectorioApproved()
        End If

        Return respuesta
    End Function

    Public Overrides Function GetRespuestaCancelacion() As String
        'TODO: Generar funcionamiento del método
        'Retornar verdadero o falso para validar si se cumplió su objetivo y mantener la integridad del flujo
        Dim respuesta = ""
        respuesta = "Se recibió la peticion con Ticket: " + registro.FolioFiscal + vbNewLine + "En automático se notificará cuando haya sido autorizada por SUNAT"
        ActualizarEntidad(True)

        'Iniciar demonio de revisión de comunicación de baja

        Return respuesta
    End Function

    Public Sub ActualizarEntidad(ByVal EsCancelacion As Boolean)

        ''Comentado por que se utilizará cuando regrese el CDR en el servicio asíncrono de SUNAT
        ''Crear entidades necesarias

        'Dim Cancelado As New ComprobantesCancelados
        'Dim DtCancelado As DataTable = Cancelado.AddNew()


        'Dim Factura As New FacturaVentaCabecera
        'Dim DtFactura As DataTable = Factura.SelOnPrimaryKey(registro.IDFactura)

        ''Crear Registro de Comprobantes Cancelados
        'DtCancelado.Rows(0)("IDFactura") = registro.IDFactura
        'DtCancelado.Rows(0)("FolioFiscal") = DtFactura.Rows(0)("FolioFiscal")
        'DtCancelado.Rows(0)("NComprobante") = DtFactura.Rows(0)("NFactura")
        'DtCancelado.Rows(0)("IDContador") = DtFactura.Rows(0)("IDContador")
        'DtCancelado.Rows(0)("FechaTimbrado") = DtFactura.Rows(0)("FechaTimbrado")
        'DtCancelado.Rows(0)("FechaCancelacion") = registro.FechaTimbrado
        'DtCancelado.Rows(0)("SelloFiscal") = DtFactura.Rows(0)("SelloFiscal")
        ''DtCancelado.Rows(0)("SelloCFDI") = DtFactura.Rows(0)("SelloCFDI")
        ''DtCancelado.Rows(0)("CodigoBarrasCancelacion") = DtFactura.Rows(0)("CodigoBarras")
        'DtCancelado.Rows(0)("XMLCancelacionRequest") = Encoding.Default.GetBytes(registro.XMLRequest)
        'DtCancelado.Rows(0)("XMLCancelacionResponse") = Encoding.Default.GetBytes(registro.XMLResponse)
        'DtCancelado.Rows(0)("XMLRequest") = DtFactura.Rows(0)("XMLRequest")
        'DtCancelado.Rows(0)("XMLResponse") = DtFactura.Rows(0)("XMLResponse")

        ''Actualizar Tabla Satelite de Documento Actual
        'DtFactura.Rows(0)("Version") = DBNull.Value
        'DtFactura.Rows(0)("FolioFiscal") = DBNull.Value
        'DtFactura.Rows(0)("FechaTimbrado") = DBNull.Value
        'DtFactura.Rows(0)("SelloFiscal") = DBNull.Value
        'DtFactura.Rows(0)("Certificado") = DBNull.Value
        'DtFactura.Rows(0)("DocumentoRespuesta") = DBNull.Value
        'DtFactura.Rows(0)("Notas") = DBNull.Value
        'DtFactura.Rows(0)("XMLRequest") = DBNull.Value
        'DtFactura.Rows(0)("ZipRequest") = DBNull.Value
        'DtFactura.Rows(0)("XMLResponse") = DBNull.Value
        'DtFactura.Rows(0)("ZipResponse") = DBNull.Value
        'Factura.Update(DtFactura)

        If EsCancelacion Then

            'Crear entidades necesarias
            Dim Factura As New FacturaVentaCabecera
            Dim DtFactura As DataTable = Factura.SelOnPrimaryKey(registro.IDFactura)


            'Actualizar Tabla Satelite de Documento Actual
            DtFactura.Rows(0)("TicketCancelacion") = registro.FolioFiscal
            Factura.Update(DtFactura)

        Else
            Dim Factura As New FacturaVentaCabecera
            Dim DtFactura As DataTable = Factura.SelOnPrimaryKey(registro.IDFactura)
            DtFactura.Rows(0)("Version") = registro.Version
            DtFactura.Rows(0)("FolioFiscal") = registro.FolioFiscal
            DtFactura.Rows(0)("FechaTimbrado") = registro.FechaTimbrado
            DtFactura.Rows(0)("SelloFiscal") = registro.FirmaDigitalSUNAT
            DtFactura.Rows(0)("Certificado") = registro.Certificado
            DtFactura.Rows(0)("DocumentoRespuesta") = registro.RespuestaSUNAT
            DtFactura.Rows(0)("Notas") = registro.NotasSUNAT
            DtFactura.Rows(0)("XMLRequest") = Encoding.Default.GetBytes(registro.XMLRequest)
            DtFactura.Rows(0)("ZipRequest") = registro.ZIPRequest
            DtFactura.Rows(0)("XMLResponse") = Encoding.Default.GetBytes(registro.XMLResponse)
            DtFactura.Rows(0)("ZipResponse") = registro.ZIPResponse
            Factura.Update(DtFactura)
        End If

    End Sub

    Public Overrides Function RevisarCancelacion(ByVal documento As DocumentoFacturaVenta) As String
        'TODO: Generar funcionamiento del método
        Dim respuesta = ""

        Dim wBillService = New pe.gob.sunat.e_beta.billService()

        Dim Ticket = documento.HeaderRow("TicketCancelacion")

        Dim response = wBillService.getStatus(Ticket)

        Dim statusCode = response.statusCode

        Dim result = response.content

        If statusCode.Equals("0") Then
            'Escribir ZIP de respuesta al directorio
            System.IO.File.WriteAllBytes(directorio + "\response.zip", result)

            'Descomprimir zip de respuesta
            JMAHelper.DecompressZipFile(directorio, "response.zip", directorio)

            'Leer XML de respuesta
            xmlRespuesta = directorio + "\R-" + xml + ".XML"

            '''Llenar objeto de registro
            registro.ZIPResponse = result
        End If

        Return respuesta
    End Function

    Public Sub MoverDirectorioApproved()
        Dim destination As String = directorio.Replace("REQUEST", "APPROVED")
        JMAHelper.CopyDirectory(directorio, destination)

        If (Directory.Exists(directorio)) Then
            Directory.Delete(directorio, True)
        End If

    End Sub

End Class


Class Registro
    Public IDFactura As String
    Public Version As String
    Public FolioFiscal As String
    Public FechaTimbrado As Date
    Public FirmaDigitalSUNAT As String
    Public Certificado As String
    Public RespuestaSUNAT As String
    Public CodigoRespuesta As String
    Public NotasSUNAT As String
    Public XMLRequest As String
    Public XMLResponse As String
    Public ZIPRequest As Byte()
    Public ZIPResponse As Byte()
End Class