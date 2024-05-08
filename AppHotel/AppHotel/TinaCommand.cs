using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel
{
    internal class TinaCommand : ICommand
    {
        private int Temperatura;
        private string Horario;
        public TinaCommand(int temperatura, string horario)
        {
            Temperatura = temperatura;
            Horario = horario;
        }

        public void Execute()
        {
            Console.WriteLine($"La tina se empezara a llenar de agua en el horario {Horario}");
            Console.WriteLine($"Llenando tina con agua a {Temperatura} grados");
        }
    }
}
