using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class BEstandar : Abuilder
    {
        

        public BEstandar()
        {
            areasLudicas = new AreasLudicas(false, true, true, false);
            desayuno = new Desayuno("Una infusión, pan, galletas, mermeladas");
            servicioBar = new ServicioBar("Refrescos, Bebidas del lugar");
            servicioCena = new ServicioCena("1 plato del día por persona + refresco", false, false);
        }

        public override void SetAreaLudica()
        {
            base.habitacion.areasLudicas = areasLudicas;
        }

        public override void SetDesayuno()
        {
            base.habitacion.desayuno = desayuno;
        }

        public override void SetPrecio()
        {
            base.habitacion.precio = 200;
        }

        public override void SetServicioBar()
        {
            base.habitacion.servicioBar = servicioBar;
        }

        public override void SetServicioCena()
        {
            base.habitacion.servicioCena = servicioCena;
        }

        public override void SetTipo()
        {
            base.habitacion.tipo = "Estándar";
        }
    }
}
