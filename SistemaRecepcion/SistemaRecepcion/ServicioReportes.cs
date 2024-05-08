using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class ServicioReportes : Elemento, IServicio
    {
        public void EnviarEmpleado()
        {
            Console.WriteLine("Se envió al PERSONAL del hotel para atender la solicitud.");
        }

        public override void Aceptar(IVisitor visitor)
        {
            visitor.VisitarReportes(this);
        }
    }
}
