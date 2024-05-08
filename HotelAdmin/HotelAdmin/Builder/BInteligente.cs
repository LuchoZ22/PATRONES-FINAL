using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class BInteligente : Abuilder
    {
        public BInteligente() 
        {
            areasLudicas = new AreasLudicas(true, true, false, true);
            desayuno = new Desayuno("Un refresco, un jugo, frutas, pan,galletas, ración de alimento cocinado, alimento fitness");
            servicioBar = new ServicioBar("Refrescos, bebidas clásicas, jugos de frutas");
            servicioCena = new ServicioCena("Rodizio del menú + refresco ilimitado", true, true);
            tipo = "Inteligente";
        }

       

        public override void SetPrecio()
        {
            habitacion.precio = 400;
        }

        
    }
}
