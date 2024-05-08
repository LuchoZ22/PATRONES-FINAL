using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class AreasLudicas : IDetalle
    {
        private bool ilimitado;
        private bool piscina;
        private bool juegosInfantiles;
        private bool casino;

        public AreasLudicas(bool ilimitado, bool piscina, bool juegosInfantiles, bool casino)
        {
            this.ilimitado = ilimitado;
            this.piscina = piscina;
            this.juegosInfantiles = juegosInfantiles;
            this.casino = casino;
        }

        public void GetDetalle()
        {
            Console.WriteLine("\n\t--- Acceso Areas Ludicas ---");
            Console.WriteLine($"\tEntrada Ilimitada: {(ilimitado ? "Si" : "No")}");
            Console.WriteLine($"\tPiscina: {(piscina ? "Si" : "No")}");
            Console.WriteLine($"\tJuegos Infantiles: {(juegosInfantiles ? "Si" : "No")}");
            Console.WriteLine($"\tCasino: {(casino ? "Si" : "No")}");
        }
    }
}
