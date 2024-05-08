using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal abstract class ComponentServicio 
    {
        protected AComponentPaquete paquete;

        protected ComponentServicio(AComponentPaquete paquete)
        {
            this.paquete = paquete;
        }

        public abstract double GetPrecioReal();
        public abstract double GetPrecioConDescuento();
        public abstract void GetDetalle();
        public abstract void GetDetalleCompleto();

    }
}
