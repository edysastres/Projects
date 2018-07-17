using System;

namespace EjemploFacade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Facade
            FacturaManager fManager = new FacturaManager();

            string r = "";
            do
            {
                Console.WriteLine("\n\nElige la opción adecuada:");
                Console.WriteLine("\t1.-Generar Factura Nacional");
                Console.WriteLine("\t2.-Generar Factura USA");
                Console.WriteLine("\t3.-Generar Nota de Crédito");
                Console.WriteLine("\ts.-Salir");
                Console.WriteLine("\t");

                r = Console.ReadLine();

                if(r == "1")
                {
                    fManager.CrearFacturaNacional();
                }
                else if (r == "2")
                {
                    fManager.CrearFacturaUSA();
                }
                else if (r == "2")
                {
                    fManager.CrearNotaCredito();
                }
                Console.ReadLine();
                Console.Clear();
            } while (r != "e");
        }
    }
}
