using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class EstadoNoDisponible : IEstado
    {
        public void Ejecutar(SistemaSpa _)
        {
            Console.WriteLine("Hora reservada y pagada. No disponible.");
        }

        public IEstado SiguienteEstado()
        {
            return this;
        }
    }
}
