using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploFacade2
{
    class FacturaManager
    {
        private Cabecera _cabecera;
        private Conceptos _conceptos;
        private InfoGeneral _infoGeneral;
        private ComercioExterior _comercioExterior;

        public FacturaManager()
        {
            _cabecera = new Cabecera();
            _conceptos = new Conceptos();
            _infoGeneral = new InfoGeneral();
            _comercioExterior = new ComercioExterior();
        }

        public void CrearFacturaNacional()
        {
            Console.WriteLine("\nCreando Factura Nacional ---- ");
            _cabecera.GenerarCabecera();
            _infoGeneral.GenerarInfoGeneral();
            _conceptos.GenerarConceptos();
        }

        public void CrearFacturaUSA()
        {
            Console.WriteLine("\nCreando Factura USA ---- ");
            _cabecera.GenerarCabecera();
            _infoGeneral.GenerarInfoGeneral();
            _conceptos.GenerarConceptos();
            _comercioExterior.GenerarComercioExterior();
        }

        public void CrearNotaCredito()
        {
            Console.WriteLine("\nNo implementado ---- ");
        }

        public void CrearPago()
        {
            Console.WriteLine("\nNo implementado ---- ");
        }
    }
}
