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
        }
        
        public override void SetAreaLudica()
        {
            habitacion.areasLudicas = areasLudicas;
        }

        public override void SetDesayuno()
        {
            habitacion.desayuno = desayuno;
        }

        public override void SetPrecio()
        {
            habitacion.precio = 350;
        }

        public override void SetServicioBar()
        {
            habitacion.servicioBar = servicioBar;
        }

        public override void SetServicioCena()
        {
            habitacion.servicioCena = servicioCena;
        }

        public override void SetTipo()
        {
            habitacion.tipo = "Lujo";
        }
    }
}
