using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class SolicitudServicio(int numeroHabitacion, string servicio, string descripcion) : Solicitud(numeroHabitacion)
    {
        private string _servicio = servicio;
        private string _descripcion = descripcion;

        public string Servicio() => _servicio;
        public string Descripcion() => _descripcion;
    }
}
