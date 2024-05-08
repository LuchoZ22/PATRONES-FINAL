using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel
{
    internal class CortinasCommand : ICommand
    {
        private bool EstanAbiertas;
        private string Horario;

        public CortinasCommand(bool estanAbiertas, string horario)
        {
            EstanAbiertas = estanAbiertas;
            Horario = horario;
        }

        public void Execute()
        {
            if (EstanAbiertas)
            {
                Console.WriteLine($"Se abriran las cortinas en horario {Horario}");
                Console.WriteLine("Abriendo las cortinas");
            }
            else
            {
                Console.WriteLine($"Se cerraran las cortinas en horario {Horario}");
                Console.WriteLine("Cerrando las cortinas");
            }
        }
    }
}
