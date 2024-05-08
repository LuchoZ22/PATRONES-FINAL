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

        public override double GetPrecioReal()
        {
            return base.paquete.GetPrecioReal();
        }

        public override double GetPrecioConDescuento()
        {
            return base.paquete.GetPrecioConDescuento();
        }

        public override void GetDetalle()
        {
            base.paquete.GetDetalle();
        }

        public override void GetDetalleCompleto()
        {
           base.paquete.GetDetalleCompleto();
        }
    }
}
