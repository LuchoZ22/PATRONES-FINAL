using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal abstract class AComponentPaquete
    {
        public double Descuento {  get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        protected AComponentPaquete(double descuento, string nombre, string tipo)
        {
            Descuento = descuento;
            Nombre = nombre;
            Tipo = tipo;
        }

        public abstract double GetPrecioReal();
        public abstract double GetPrecioConDescuento();
        public abstract void GetDetalle();
        public abstract void GetDetalleCompleto();

        
    }
}
