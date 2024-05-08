using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal interface IVisitor
    {
        void VisitarSpa(SistemaSpa spa);
        void VisitarCocina(ServicioCocina cocina);
        void VisitarBar(ServicioBar bar);
        void VisitarLimpieza(ServicioLimpieza limpieza);
        void VisitarReportes(ServicioReportes reportes);
    }
}
