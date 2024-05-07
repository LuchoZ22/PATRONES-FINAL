using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class Desayuno : IDetalle
    {
        private string descripcion;

        public Desayuno(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public void GetDetalle()
        {
            Console.WriteLine("\n\t--- Desayuno ---");
            Console.WriteLine($"\tIncluye: {descripcion}");
        }
    }
}
