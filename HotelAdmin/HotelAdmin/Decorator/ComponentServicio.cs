using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal abstract class ComponentServicio 
    {
        public AComponentPaquete paquete { get; protected set; }

        protected ComponentServicio(AComponentPaquete paquete)
        {
            this.paquete = paquete;
        }

        public abstract double GetPrecioRealServicio();
        public abstract double GetPrecioConDescuentoServicio();
        public abstract void GetDetalleServicio();
        public abstract void GetDetalleCompletoServicio();
        public abstract void PrintExtras();
        public string GetNombrePaquete()
        {
            return paquete.Nombre;
        }

        public string GetTipo()
        {
            return paquete.Tipo;
        }

    }
}
