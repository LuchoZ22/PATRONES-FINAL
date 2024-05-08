using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class AdministradorHabitaciones
    {
        private List<Tuple<int,ComponentServicio>> habitaciones;
        private int idCounter;


        public AdministradorHabitaciones()
        {
            habitaciones = new List<Tuple<int, ComponentServicio>>();
            idCounter = 0;
        }

        public AComponentPaquete CrearOne(Abuilder builder)
        {
            DirectorHabitacion.BuildHabitacion(builder, 0);
            AComponentPaquete aux = builder.GetHabitacion();
            return aux;
        }
        public AComponentPaquete CrearOne(Abuilder builder, int descuento)
        {
            DirectorHabitacion.BuildHabitacion(builder, descuento);
            AComponentPaquete aux = builder.GetHabitacion();
            return aux;
        }

        public AComponentPaquete CrearMedium(Abuilder builder) 
        {
            CompositePaquete medium = new CompositePaquete(10, "Medium");
            medium.AddPaquete(CrearOne(builder, 10));
            medium.AddPaquete(CrearOne(builder, 10));
            return  medium;
        }

        public AComponentPaquete CrearMedium(Abuilder builder, int descuento)
        {
            CompositePaquete medium = new CompositePaquete(descuento, "Medium");
            medium.AddPaquete(CrearOne(builder, descuento));
            medium.AddPaquete(CrearOne(builder, descuento));
            return medium;
        }

        public AComponentPaquete CrearBig(Abuilder builder) 
        {
            CompositePaquete big = new CompositePaquete(20, "Big");
            big.AddPaquete(CrearOne(builder, 20));
            big.AddPaquete(CrearMedium(builder, 20));
            big.AddPaquete(CrearMedium(builder, 20));
            return big;
        }
    }
}
