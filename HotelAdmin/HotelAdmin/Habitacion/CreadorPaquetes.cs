using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class CreadorPaquetes
    {
       
        public CreadorPaquetes()
        {
           
        }

        public static AComponentPaquete CrearOne(Abuilder builder)
        {
            DirectorHabitacion.BuildHabitacion(builder, 0);
            AComponentPaquete aux = builder.GetHabitacion();
            return aux;
        }
        private static AComponentPaquete CrearOne(Abuilder builder, int descuento)
        {
            DirectorHabitacion.BuildHabitacion(builder, descuento);
            AComponentPaquete aux = builder.GetHabitacion();
            return aux;
        }

        public static AComponentPaquete CrearMedium(Abuilder builder) 
        {
            CompositePaquete medium = new CompositePaquete(10, "Medium", builder.tipo);
            medium.AddPaquete(CrearOne(builder, 10));
            medium.AddPaquete(CrearOne(builder, 10));
            return  medium;
        }

        private static AComponentPaquete CrearMedium(Abuilder builder, int descuento)
        {
            CompositePaquete medium = new CompositePaquete(descuento, "Medium", builder.tipo);
            medium.AddPaquete(CrearOne(builder, descuento));
            medium.AddPaquete(CrearOne(builder, descuento));
            return medium;
        }

        public static AComponentPaquete CrearBig(Abuilder builder) 
        {
            CompositePaquete big = new CompositePaquete(20, "Big", builder.tipo);
            big.AddPaquete(CrearOne(builder, 20));
            big.AddPaquete(CrearMedium(builder, 20));
            big.AddPaquete(CrearMedium(builder, 20));
            return big;
        }
    }
}
