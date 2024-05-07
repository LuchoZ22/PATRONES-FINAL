using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class ServicioBar : IDetalle
    {
        private string descripcion;

        public ServicioBar(string descripcion)
        {
            this.descripcion = descripcion;
        }
    
        public void GetDetalle()
        {
            Console.WriteLine("\n\t--- Servicio Bar ---");
            Console.WriteLine($"\tIncluye: {descripcion}");
        }
    }
}
