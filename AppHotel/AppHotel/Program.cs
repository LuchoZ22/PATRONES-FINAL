using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appHotel = new AppHotel();
            var comandosAgregados = new List<ICommand>();

            Console.WriteLine("====BIENVENIDO A LA APLICACION DEL HOTEL PARA CONTROLAR SU HABITACION INTELIGENTE====");

            while (true)
            {
                Console.WriteLine("\n¿Qué desea hacer?");
                Console.WriteLine("1. Agregar Comando");
                Console.WriteLine("2. Remover Comando");
                Console.WriteLine("3. Ejecutar todos los comandos");
                Console.WriteLine("4. Salir");

                Console.Write("\nIngrese el número de la opción que desea: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AgregarComando(appHotel, comandosAgregados);
                            break;
                        case 2:
                            RemoverComando(appHotel, comandosAgregados);
                            break;
                        case 3:
                            if (comandosAgregados.Count == 0)
                            {
                                Console.WriteLine("\nNO HAY COMANDOS PARA EJECUTAR");
                            }
                            else
                            {
                                Console.WriteLine("=====EJECUCION DE COMANDOS======\n");
                                appHotel.ejecutarCommands();
                                Console.WriteLine("\n=====FIN DE EJECUCION DE COMANDOS=====\n");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Saliendo de la aplicación...");
                            return;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }
        }

        static void AgregarComando(AppHotel appHotel, List<ICommand> comandosAgregados)
        {
            Console.WriteLine("\n¿Qué comando desea agregar?");
            Console.WriteLine("1. Encender Música");
            Console.WriteLine("2. Encender Tina");
            Console.WriteLine("3. Ajustar Intensidad de Luz");
            Console.WriteLine("4. Abrir/Cerrar Cortinas");

            Console.Write("Ingrese el número del comando que desea agregar: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del artista:");
                        string artista = Console.ReadLine();
                        Console.WriteLine("Ingrese el volumen (0-100):");
                        if (int.TryParse(Console.ReadLine(), out int volumen))
                        {
                            Console.WriteLine("Ingrese la hora de ejecución (HH:mm):");
                            string hora = Console.ReadLine();
                            ICommand musicaCommand = new MusicaCommand(artista, volumen, hora);
                            appHotel.añadirCommand(musicaCommand);
                            comandosAgregados.Add(musicaCommand);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la temperatura para la tina:");
                        if (int.TryParse(Console.ReadLine(), out int temperatura))
                        {
                            Console.WriteLine("Ingrese la hora de ejecución (HH:mm):");
                            string hora = Console.ReadLine();
                            ICommand tinaCommand = new TinaCommand(temperatura, hora);
                            appHotel.añadirCommand(tinaCommand);
                            comandosAgregados.Add(tinaCommand);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese la intensidad de luz (0-100):");
                        if (int.TryParse(Console.ReadLine(), out int intensidad))
                        {
                            Console.WriteLine("Ingrese la hora de ejecución (HH:mm):");
                            string hora = Console.ReadLine();
                            ICommand intensidadLuzCommand = new IntensidadLuzCommand(intensidad, hora);
                            appHotel.añadirCommand(intensidadLuzCommand);
                            comandosAgregados.Add(intensidadLuzCommand);
                        }
                        break;
                    case 4:
                        Console.WriteLine("¿Quiere abrir o cerrar las cortinas? (abrir/cerrar):");
                        string accion = Console.ReadLine().ToLower();
                        bool abrir = accion == "abrir";
                        Console.WriteLine("Ingrese la hora de ejecución (HH:mm):");
                        string horaCortinas = Console.ReadLine();
                        ICommand cortinasCommand = new CortinasCommand(abrir, horaCortinas);
                        appHotel.añadirCommand(cortinasCommand);
                        comandosAgregados.Add(cortinasCommand);
                        break;
                    default:
                        Console.WriteLine("Comando inválido.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }


        static void RemoverComando(AppHotel appHotel, List<ICommand> comandosAgregados)
        {
            if (comandosAgregados.Count == 0)
            {
                Console.WriteLine("\nNo hay comandos agregados para remover.");
                return;
            }

            Console.WriteLine("\nComandos agregados:");
            for (int i = 0; i < comandosAgregados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {comandosAgregados[i]}");
            }

            Console.Write("Ingrese el número del comando que desea remover: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 1 && index <= comandosAgregados.Count)
                {
                    ICommand comandoARemover = comandosAgregados[index - 1];
                    appHotel.removerCommand(comandoARemover);
                    comandosAgregados.RemoveAt(index - 1);
                    Console.WriteLine("Comando removido con éxito.");
                }
                else
                {
                    Console.WriteLine("Índice inválido.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }
    }
}
