using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel
{
    internal class MusicaCommand : ICommand
    {
        private string Artista;
        private int Volumen;
        private string Horario;

        public MusicaCommand(string artista, int volumen, string horario)
        {
            Artista = artista;
            Volumen = volumen;
            Horario = horario;
        }

        public void Execute()
        {
            // Lógica para controlar la música ambiente
            Console.WriteLine($"La musica se reproducira en horario {Horario}");
            Console.WriteLine($"Reproduciendo música de {Artista} con volumen {Volumen}");
        }
    }
}
