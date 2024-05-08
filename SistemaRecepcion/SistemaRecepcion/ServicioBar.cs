using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class ServicioBar : Elemento, IServicio
    {
        public void EnviarEmpleado()
        {
            Console.WriteLine("Se envió un BARTENDER para atender la solicitud.");
        }

        public override void Aceptar(IVisitor visitor)
        {
            visitor.VisitarBar(this);
        }
    }
}
