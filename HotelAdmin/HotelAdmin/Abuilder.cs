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
        public abstract void SetServicioCena();
        public abstract void SetServicioBar();
        public abstract void SetAreaLudica();
        public abstract void SetDesayuno();
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
