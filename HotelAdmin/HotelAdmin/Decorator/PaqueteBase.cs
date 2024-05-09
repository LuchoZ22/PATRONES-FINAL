using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelAdmin
{
    internal class PaqueteBase : ComponentServicio
    {
        public PaqueteBase(AComponentPaquete paquete) : base(paquete) 
        { 
        }

        public override double GetPrecioRealServicio()
        {
            return base.paquete.GetPrecioReal();
        }

        public override double GetPrecioConDescuentoServicio()
        {
            return base.paquete.GetPrecioConDescuento();
        }

        public override void GetDetalleServicio()
        {
            base.paquete.GetDetalle();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nPRECIO TOTAL CON DESCUENTOS: {GetPrecioConDescuentoServicio()} Bs");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void GetDetalleCompletoServicio()
        {
            base.paquete.GetDetalleCompleto();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nPRECIO TOTAL: {GetPrecioRealServicio()} Bs");
            Console.WriteLine($"PRECIO TOTAL CON DESCUENTOS: {GetPrecioConDescuentoServicio()} Bs");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void PrintExtras()
        {
        }
    }
}
