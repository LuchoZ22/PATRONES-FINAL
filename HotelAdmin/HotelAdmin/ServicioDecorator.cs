using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal abstract class ServicioDecorator : ComponentServicio
    {
        protected ServicioDecorator(AComponentPaquete paquete, double descuento, string nombre) : base(paquete, descuento, nombre) { }
    }
}
