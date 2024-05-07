using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class ServicioCena : IDetalle
    {

        private string plato;
        private bool refrescoIlimitado;
        private bool servicioHabitacion;

        public ServicioCena(string plato, bool refrescoIlimitad, bool servicioHabitacion)
        {
            this.plato = plato;
            this.refrescoIlimitado = refrescoIlimitad;
            this.servicioHabitacion = servicioHabitacion;
        }

        public void GetDetalle()
        {
            Console.WriteLine("\n\t--- Cena ---");
            Console.WriteLine($"\tPlato: {plato}");
            Console.WriteLine($"\tRefresco Ilimitado: {(refrescoIlimitado?"Si":"No")}");
            Console.WriteLine($"\tServicioHabitacion: {(servicioHabitacion ? "Si" : "No")}");
        }
    }
}
