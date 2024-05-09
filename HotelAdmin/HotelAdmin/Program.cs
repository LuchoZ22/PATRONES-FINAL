

namespace HotelAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdminPaquetes adminPaquetes = new AdminPaquetes();
            int opcion = 0;
            int salir = 7;
            while(opcion != salir)
            {
                PrintMenu();
                opcion = GetValor("Opcion: ", 1, salir);
                Console.Clear();
                switch(opcion) 
                {
                    case 1:
                        Console.WriteLine("Ingrese tipo de paquete:");
                        Console.WriteLine("\t1. ONE\n\t2. MEDIUM\n\t3. BIG");
                        int paquete = GetValor("Opcion: ", 1, 3);
                        Console.WriteLine("Ingrese el tipo de habitacion: ");
                        Console.WriteLine("\t1. Estándar\n\t2. Lujo\n\t3. Inteligente");
                        int tipo = GetValor("Opcion: ", 1, 3);
                        adminPaquetes.AñadirNuevoPaquete(paquete, tipo);
                        break;
                    case 2:
                        adminPaquetes.PrintListaPaquetes();
                        break;
                    case 3:
                        adminPaquetes.PrintDetallesPaquetes();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el id del paquete");
                        int id2 = GetValor("ID: ", 1, int.MaxValue);
                        adminPaquetes.PrintDescripcionPaquete(id2);
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el id del paquete");
                        int id = GetValor("ID: ", 1, int.MaxValue);
                        Console.WriteLine("Ingrese el Servicio Extra");
                        Console.WriteLine("\t1. Internet (10 Bs)\n\t2. Gimnasio (20 Bs)\n\t3. Spa (20 Bs)\n\t4. Karaoke (30 Bs)\n\t5. Cine (30 Bs)");
                        int servicio = GetValor("Opcion: ", 1, 5);
                        adminPaquetes.AñadirServicioPaquete(id, servicio);
                        break;
                    case 6:
                        Console.WriteLine("Ingrese el id del paquete que desea eliminar");
                        int id1 = GetValor("ID: ",1, int.MaxValue);
                        adminPaquetes.EliminarPaquete(id1);
                        break;
                    default:
                        break;

                }
            }
            

            
        }

        public static int GetValor(string msg, int min, int max)
        {
            int aux;
            do
            {
                Console.Write(msg);
            }
            while (!(int.TryParse(Console.ReadLine(), out aux) || aux < min || aux > max));
            return aux;
        }
        public static void PrintMenu()
        {
            Console.WriteLine("ADMINISTRADOR PAQUETES HOTEL");
            Console.WriteLine("\t1. Crear nuevo paquete\n\t2. Lista de paquetes actuales\n\t3. Obtener detalles de cada paquete\n\t4. Obtener descripcion completa de paquete \n\t5. Añadir servicio extra a un paquete\n\t6. Eliminar un paquete\n\t7. Salir");
        }
    }
}
