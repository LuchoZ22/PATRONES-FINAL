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
        protected string nombreServicio;
        protected ServicioDecorator(ComponentServicio pbase, double costoExtra, string nServicio) : base(null) 
        {
            paqueteBase = pbase;
            this.costoExtra = costoExtra;
            nombreServicio = nServicio;
        }

        public override double GetPrecioReal()
        {
            return paqueteBase.GetPrecioReal() + costoExtra;
        }

        public override double GetPrecioConDescuento()
        {
            return paqueteBase.GetPrecioConDescuento() + costoExtra;
        }

        public override void GetDetalle()
        {
            paqueteBase.GetDetalle();
            //Console.WriteLine("--- EXTRAS ---");
            Console.WriteLine($"\nServicio extra: {nombreServicio}");
        }

        public override void GetDetalleCompleto()
        {
            paqueteBase.GetDetalleCompleto();
            //Console.WriteLine("--- EXTRAS ---");
            Console.WriteLine($"\nServicio extra: {nombreServicio}");
        }
    }
}
