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

        public CompositePaquete(double descuento, string nombre, string tipo) : base(descuento, nombre, tipo)
        {
            paqueteActual = new List<AComponentPaquete>();
        }

        public override void GetDetalle()
        {
            Console.WriteLine($"=== Paquete {Nombre} ===");
            Console.WriteLine($"Descuento: {Descuento} %");
            Console.WriteLine("----- Habitaciones -----\n");
            foreach (var p in paqueteActual)
            {
                p.GetDetalle();
            }
        }

        public override void GetDetalleCompleto()
        {
            Console.WriteLine($"=== Paquete {Nombre} ===");
            Console.WriteLine($"Descuento: {Descuento} %");
            Console.WriteLine("----- Habitaciones -----\n");
            foreach (var p in paqueteActual)
            {
                p.GetDetalleCompleto();
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
