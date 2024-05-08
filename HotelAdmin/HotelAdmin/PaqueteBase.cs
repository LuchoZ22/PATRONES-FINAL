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
        public PaqueteBase(double descuento, string nombre) : base(null, descuento, nombre) { }

        public override double GetPrecioReal()
        {
            return 100.0;
        }

        public override double GetPrecioConDescuento()
        {
            return GetPrecioReal() * (1 - Descuento);
        }

        public override void GetDetalle()
        {
            Console.WriteLine($"Paquete base:  {Nombre}");
        }
    }
}
