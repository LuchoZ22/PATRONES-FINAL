using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class ServicioLimpieza : Elemento, IServicio
    {
        public void EnviarEmpleado()
        {
            Console.WriteLine("Se envió un empleado de LIMPIEZA para atender la solicitud.");
        }

        public override void Aceptar(IVisitor visitor)
        {
            visitor.VisitarLimpieza(this);
        }
    }
}
