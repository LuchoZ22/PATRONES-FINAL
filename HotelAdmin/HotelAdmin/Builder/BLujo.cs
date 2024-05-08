using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class BLujo : Abuilder
    {
        
        public BLujo() 
        {
            areasLudicas = new AreasLudicas(true, true, true, true);
            desayuno = new Desayuno("Una infusión, un jugo de frutas, pan, galletas, ración de alimento cocinado");
            servicioBar = new ServicioBar("Refrescos, bebidas clásicas, aperitivos");
            servicioCena = new ServicioCena("rodizio del menú + refresco ilimitado", false, false);
            tipo = "Lujo";
        }
        

        public override void SetPrecio()
        {
            habitacion.precio = 350;
        }

        
    }
}
