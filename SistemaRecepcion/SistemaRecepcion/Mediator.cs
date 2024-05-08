using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class Mediator : IMediator
    {
        private ServicioCocina _servicioCocina;
        private ServicioBar _servicioBar;
        private ServicioLimpieza _servicioLimpieza;
        private ServicioReportes _servicioReportes;

        public Mediator(ServicioCocina servicioCocina, ServicioBar servicioBar, ServicioLimpieza servicioLimpieza, ServicioReportes servicioReportes)
        {
            _servicioCocina = servicioCocina;
            _servicioBar = servicioBar;
            _servicioLimpieza = servicioLimpieza;
            _servicioReportes = servicioReportes;
        }

        public void SolicitarServicio(SolicitudServicio solicitudServicio)
        {
            IServicio servicioAtender = solicitudServicio.Servicio() switch
            {
                "Cocina" => _servicioCocina,
                "Bar" => _servicioBar,
                "Limpieza" => _servicioLimpieza,
                "Reportes" => _servicioReportes,
                _ => throw new Exception("Error al obtener un servicio. Compruebe el nombre del servicio e intente denuevo"),
            };
            servicioAtender.EnviarEmpleado();
            ((Elemento)servicioAtender).IncrementarUsos();
            ((Elemento)servicioAtender).IncrementarCosto(new Random().NextDouble() * 100.0);
        }
    }
}
