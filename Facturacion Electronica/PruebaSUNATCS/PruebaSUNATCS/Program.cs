using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSUNATCS
{
    internal static class Program
    {
        static void Main(string[] args)
        {

            #region Calculadora
            Console.WriteLine("Probando calculadora...");


            WSCalculator.CalculatorSoapClient calculator = new WSCalculator.CalculatorSoapClient();
            Console.Write("SUMA: 5 + 2 = ");
            Console.WriteLine(calculator.Add(5, 2));
            Console.Write("RESTA: 5 - 2 = ");
            Console.WriteLine(calculator.Subtract(5, 2));
            Console.Write("MULTIPLICACIÓN: 5 x 2 = ");
            Console.WriteLine(calculator.Multiply(5, 2));
            Console.Write("DIVISIÓN: 5 / 2 = ");
            Console.WriteLine(calculator.Divide(5, 2));
            Console.ReadLine();

            #endregion Calculadora

            //Console.WriteLine("Hello World!");

            //Paso0
            #region Orden
            /*
             * En este orden se debe construir un ejemplo mínimo
             * 1.-Fecha de emisión
             * 2.-Firma Digital
             * 3.-Razon Social Emisor
             * 6.-Numero RUC
             * 7.-Tipo de Documento
             * 8.-Numeracion
             * 9,10.-Nombres/Razón Social de Adquiriente
             * 11,12.-Cantidad de unidades por item
             * 13.-Descripcion del servicio/producto
             * 14.-Valor unitario por item
             * 15.-Precio de Venta por item
             * 16.-IGV por item
             * 21.-Venta por item
             * 27.-Importe Total Venta
             * 28.-Tipo de moneda de la factura
             * 36.-Version UBL
             * 37.-Version estructura
             * 50.-DescuentosGlobales
             * 51.-Descuentos por item
             * 
             */
            #endregion

            //Paso1
            #region Construccion & Serializacion

            InvoiceType invoice = new InvoiceType();

            ///////////////////////////

            System.Xml.Serialization.XmlSerializerNamespaces ns = new System.Xml.Serialization.XmlSerializerNamespaces();
            ns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            ns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            ns.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
            ns.Add("ccts", "urn:un:unece:uncefact:documentation:2");
            ns.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            ns.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
            ns.Add("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1");
            ns.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
            //////////////////////////

            invoice.UUID = new UUIDType();
            invoice.IssueDate = new IssueDateType();
            invoice.UUID.Value = "ALDO";
            invoice.IssueDate.Value = DateTime.Today;
            invoice.UBLVersionID = new UBLVersionIDType();
            invoice.UBLVersionID.Value = "2.0";
            invoice.Signature = new SignatureType[1];
            invoice.Signature[0] = new SignatureType();
            invoice.Signature[0].ID = new IDType();
            invoice.Signature[0].ID.Value = "IDSignJMA";
            invoice.Signature[0].SignatoryParty = new PartyType();
            invoice.Signature[0].SignatoryParty.PartyIdentification = new PartyIdentificationType[1];
            invoice.Signature[0].SignatoryParty.PartyIdentification[0] = new PartyIdentificationType();
            invoice.Signature[0].SignatoryParty.PartyIdentification[0].ID = new IDType();
            invoice.Signature[0].SignatoryParty.PartyIdentification[0].ID.Value = "20507646051";

            invoice.UBLExtensions = new UBLExtensionType[1];
            invoice.UBLExtensions[0] = new UBLExtensionType();

            AdditionalInformationType1 ai = new AdditionalInformationType1();
            ai.AdditionalMonetaryTotal = new AdditionalMonetaryTotalType[1];
            ai.AdditionalMonetaryTotal[0] = new AdditionalMonetaryTotalType();
            ai.AdditionalMonetaryTotal[0].ID = new IDType();
            ai.AdditionalMonetaryTotal[0].ID.Value = "2345.2";

            System.Xml.XmlDocument d = new System.Xml.XmlDocument();
            
            string xml = SerializeObject(ai, ns);

            d.LoadXml(xml);
            

            System.Xml.XmlElement element = d.DocumentElement;

            invoice.UBLExtensions[0].ExtensionContent = element;


            invoice.InvoiceLine = new InvoiceLineType[1];
            for (int i = 0; i < 1; i++)
            {
                InvoiceLineType line = new InvoiceLineType();
                line.Item = new ItemType();
                line.Item.Name = new NameType1();
                line.Item.Name.Value = "ASF";

                line.Price = new PriceType();
                line.Price.PriceAmount = new PriceAmountType();
                line.Price.PriceAmount.Value = 12.45M;

                line.InvoicedQuantity = new InvoicedQuantityType();
                line.InvoicedQuantity.Value = i;

                invoice.InvoiceLine[i] = line;
            }

            invoice.InvoicePeriod = new PeriodType[1];
            invoice.InvoicePeriod[0] = new PeriodType();
            invoice.InvoicePeriod[0].DurationMeasure = new DurationMeasureType();
            invoice.InvoicePeriod[0].DurationMeasure.unitCode = UnitCodeContentType.DAY;

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(invoice.GetType());
            x.Serialize(Console.Out, invoice, ns);

            Console.ReadLine();

            #endregion Construccion & Serializacion

            //Paso2
            #region Archivos

            //Creating directory
            try
            {
                // Determine whether the directory exists.
                string path = @"20100066603-01-F001-1";
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                } else
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
                }

                // Create a new file stream to write the serialized object to a file
                TextWriter WriteFileStream = new StreamWriter(@"20100066603-01-F001-1/20100066603-01-F001-1.xml");

                x.Serialize(WriteFileStream, invoice, ns);
                // Cleanup
                WriteFileStream.Close();

                //ZIP File
                if (File.Exists(@"20100066603-01-F001-1.zip"))
                {
                    File.Delete(@"20100066603-01-F001-1.zip");
                }
                ZipFile.CreateFromDirectory(path, @"20100066603-01-F001-1.zip");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());

                Console.ReadLine();
            }
            #endregion Archivos

            //Paso3
            #region SUNAT WS

            byte[] file = File.ReadAllBytes(@"20100066603-01-F001-1.zip");
            

            pe.gob.sunat.beta.billService billService = new pe.gob.sunat.beta.billService();
            byte[] response = billService.sendBill("20100066603-01-F001-1.zip", file,"");
            //Cómo o para qué se utiliza el tercer parámetro?


            Console.Write(response.ToString());
            #endregion SUNAT WS


            Console.ReadLine();
        }

        public static string SerializeObject<T>(this T toSerialize, System.Xml.Serialization.XmlSerializerNamespaces ns)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(toSerialize.GetType());

            using (System.IO.StringWriter textWriter = new System.IO.StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }
    }
}
