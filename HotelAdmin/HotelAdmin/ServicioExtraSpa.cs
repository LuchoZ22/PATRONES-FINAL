using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelAdmin
{
    internal class ServicioExtraSpa : ServicioDecorator
    {
        public ServicioExtraSpa(AComponentPaquete paquete)
            : base(paquete, 0, "Spa") { }

        public override double GetPrecioReal()
        {
            return paquete.GetPrecioReal() + CostoExtra;
        }

        public override double GetPrecioConDescuento()
        {
            return paquete.GetPrecioConDescuento() + CostoExtra;
        }

        public override void GetDetalle()
        {
            base.GetDetalle();
            Console.WriteLine($"\nServicio extra: {Nombre}");
        }

        public double CostoExtra = 20.0;
    }
}
