using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel
{
    internal class IntensidadLuzCommand : ICommand
    {
        private int Intensidad;
        private string Horario; 

        public IntensidadLuzCommand(int intensidad, string horario)
        {
            Intensidad = intensidad;
            Horario = horario;
        }

        public void Execute()
        {
            Console.WriteLine($"La intensidad de luz en la habitacion cambiara en horario {Horario}");
            Console.WriteLine($"Cambiando la intensidad de luz en la habitacion a {Intensidad}%");  
        }
    }
}
