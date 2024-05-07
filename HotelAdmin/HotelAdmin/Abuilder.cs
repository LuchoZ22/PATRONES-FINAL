using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal abstract class Abuilder
    {
        protected LeafHabitacion habitacion;
        protected AreasLudicas areasLudicas;
        protected Desayuno desayuno;
        protected ServicioBar servicioBar;
        protected ServicioCena servicioCena;

        public Abuilder()
        {
            habitacion = new LeafHabitacion();
        }

        public abstract void SetTipo();
        public abstract void SetPrecio();
        public  void SetServicioCena()
        {
            habitacion.servicioCena = servicioCena;
        }
        public  void SetServicioBar()
        {
            habitacion.servicioBar = servicioBar;
        }
        public void SetAreaLudica()
        {
            habitacion.areasLudicas = areasLudicas;
        }
        public  void SetDesayuno()
        {
            habitacion.desayuno = desayuno;
        }

        public LeafHabitacion  GetHabitacion()
        {
            LeafHabitacion h = habitacion;
            Reset();
            return h;
            
        }

        public void Reset()
        {
            habitacion = new LeafHabitacion();
        }

        


    }
}
