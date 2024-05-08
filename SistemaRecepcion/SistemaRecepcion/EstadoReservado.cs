using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class EstadoReservado : IEstado
    {
        public void Ejecutar(SistemaSpa spa)
        {
            Console.WriteLine("Hora reservada. Desea pagar? [s/N]");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta.Equals("s"))
            {
                spa.IncrementarUsos();
                spa.IncrementarCosto(30.0);
            }
        }

        public IEstado SiguienteEstado()
        {
            return new EstadoNoDisponible();
        }
    }
}
