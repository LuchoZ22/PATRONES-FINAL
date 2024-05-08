using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class EstadoDisponible : IEstado
    {
        public void Ejecutar(SistemaSpa _)
        {
            Console.WriteLine("Hora libre. Reservando...");
        }

        public IEstado SiguienteEstado()
        {
            return new EstadoReservado();
        }
    }
}
