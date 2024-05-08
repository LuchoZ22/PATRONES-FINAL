using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal abstract class ComponentServicio : AComponentPaquete
    {
        protected AComponentPaquete paquete;

        protected ComponentServicio(AComponentPaquete paquete, double descuento, string nombre) : base(descuento, nombre)
        {
            this.paquete = paquete;
        }

        public override double GetPrecioReal()
        {
            return paquete.GetPrecioReal();
        }

        public override double GetPrecioConDescuento()
        {
            return paquete.GetPrecioConDescuento();
        }

        public override void GetDetalle()
        {
            paquete.GetDetalle();
        }
    }
}
