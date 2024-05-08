using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class SistemaSpa : Elemento
    {
        private IEstado[] horasReservadas;

        public SistemaSpa()
        {
            horasReservadas = new IEstado[24];
            for(int i = 0; i < horasReservadas.Length; i++)
            {
                horasReservadas[i] = new EstadoDisponible();
            }
        }

        public void ProcesarReserva(SolicitudReserva solicitudReserva)
        {
            Console.Write($"[{solicitudReserva.Hora()}:00] ");

            horasReservadas[solicitudReserva.Hora()].Ejecutar(this);
            horasReservadas[solicitudReserva.Hora()] = horasReservadas[solicitudReserva.Hora()].SiguienteEstado();
        }

        public override void Aceptar(IVisitor visitor)
        {
            visitor.VisitarSpa(this);
        }
    }
}
