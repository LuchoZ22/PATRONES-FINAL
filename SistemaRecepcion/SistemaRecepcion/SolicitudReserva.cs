using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class SolicitudReserva(int numeroHabitacion, int hora) : Solicitud(numeroHabitacion)
    {
        private readonly int _hora = hora;

        public int Hora() => _hora;
    }
}
