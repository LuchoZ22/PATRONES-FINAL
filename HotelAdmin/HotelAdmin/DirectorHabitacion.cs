using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class DirectorHabitacion
    {

        public static void BuildHabitacion(Abuilder builder)
        {
            builder.SetTipo();
            builder.SetPrecio();
            builder.SetServicioCena();
            builder.SetServicioBar();
            builder.SetAreaLudica();
            builder.SetDesayuno();
        }
    }
}
