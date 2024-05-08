using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class ServicioCocina : Elemento, IServicio
    {
        public void EnviarEmpleado()
        {
            Console.WriteLine("Se envió un COCINERO para atender la solicitud.");
        }

        public override void Aceptar(IVisitor visitor)
        {
            visitor.VisitarCocina(this);
        }
    }
}
