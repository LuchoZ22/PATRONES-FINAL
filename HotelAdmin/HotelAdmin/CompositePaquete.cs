using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class CompositePaquete : AComponentPaquete
    {

        private List<AComponentPaquete> paqueteActual;

        public CompositePaquete(double descuento, string nombre) : base(descuento, nombre)
        {
            paqueteActual = new List<AComponentPaquete>();
        }

        public override void GetDetalle()
        {
            Console.WriteLine($"=== Paquete {Nombre} ===");
            Console.WriteLine($"Descuento: {Descuento}");
            Console.WriteLine("----- Habitaciones -----");
            foreach (var p in paqueteActual)
            {
                p.GetDetalle();
            }
        }

        //Regresa el monto total del paquete
        public override double GetPrecioReal()
        {
            double monto = 0;
            foreach(var p in paqueteActual)
            {
                monto += p.GetPrecioReal();
            }
            return monto;
        }

        public override double GetPrecioConDescuento()
        {
            double real = GetPrecioReal();
            return real - (real * (Descuento / 100));
        }

        public void AddPaquete(AComponentPaquete p)
        {
            paqueteActual.Add(p);
        }

        public void RemovePaquete(AComponentPaquete p)
        {
            paqueteActual.Remove(p);
        }

        
    }
}
