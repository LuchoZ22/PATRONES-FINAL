using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal abstract class ServicioDecorator : ComponentServicio
    {
        protected ComponentServicio paqueteBase;
        protected double costoExtra;
        public string nombreServicio { get; protected set; }
        protected ServicioDecorator(ComponentServicio pbase, double costoExtra, string nServicio) : base(pbase.paquete) 
        {
            paqueteBase = pbase;
            this.costoExtra = costoExtra;
            nombreServicio = nServicio;
        }

        public override double GetPrecioRealServicio()
        {
            return paqueteBase.GetPrecioRealServicio() + costoExtra;
        }

        public override double GetPrecioConDescuentoServicio()
        {
            return paqueteBase.GetPrecioConDescuentoServicio() + costoExtra;
        }

        public override void GetDetalleServicio()
        {
            base.paquete.GetDetalle();
            Console.WriteLine("\n-- Extras --");
            PrintExtras();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nPRECIO TOTAL CON DESCUENTOS: {GetPrecioConDescuentoServicio()} Bs");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void GetDetalleCompletoServicio()
        {
            paqueteBase.GetDetalleCompletoServicio();
            Console.WriteLine("\n-- Extras --");
            PrintExtras();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nPRECIO TOTAL SIN DESCUENTOS: {GetPrecioRealServicio()} Bs");
            Console.WriteLine($"\nPRECIO TOTAL CON DESCUENTOS: {GetPrecioConDescuentoServicio()} Bs");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void PrintExtras()
        {
            paqueteBase.PrintExtras();
            Console.WriteLine($"Extra: Servicio {nombreServicio} | {costoExtra} Bs");
        }

    }
}
