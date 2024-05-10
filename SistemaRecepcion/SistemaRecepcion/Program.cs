using SistemaRecepcion;

internal class Program
{
    private static void Main(string[] args)
    {
        ServicioCocina servicioCocina = new();
        ServicioBar servicioBar = new();
        ServicioLimpieza servicioLimpieza = new();
        ServicioReportes servicioReportes = new();
        SistemaSpa sistemaSpa = new();

        Mediator mediator = new(servicioCocina, servicioBar, servicioLimpieza, servicioReportes);
        Visitor visitor = new();

        while(true)
        {
            Console.WriteLine("Qué desea hacer?");
            Console.WriteLine("1. Registrar una solicitud de un cliente.");
            Console.WriteLine("2. Reservar un horario en el spa");
            Console.WriteLine("3. Obtener reporte de los sistemas y servicios.");
            Console.WriteLine("0. Salir\n");

            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 0) break;
            else if(opcion == 1)
            {
                Console.Write("Numero de habitación: ");
                int nroHabitacion = int.Parse(Console.ReadLine());

                Console.Write("Servicio solicitado (Cocina, Bar, Limpieza, Reportes): ");
                string servicio = Console.ReadLine();
                servicio ??= string.Empty;

                Console.Write("Descripcion de la solicitud: ");
                string descripcion = Console.ReadLine();
                descripcion ??= string.Empty;

                SolicitudServicio solicitud = new(nroHabitacion, servicio, descripcion);
                mediator.SolicitarServicio(solicitud);
                Console.WriteLine();
            }
            else if(opcion == 2)
            {
                Console.Write("Numero de habitación: ");
                int nroHabitacion = int.Parse(Console.ReadLine());

                Console.Write("Hora de la reserva (formato 24 horas): ");
                int horario = int.Parse(Console.ReadLine());

                SolicitudReserva solicitud = new(nroHabitacion, horario);
                sistemaSpa.ProcesarReserva(solicitud);
                Console.WriteLine();
            }
            else if(opcion == 3)
            {
                servicioCocina.Aceptar(visitor);
                servicioBar.Aceptar(visitor);
                servicioLimpieza.Aceptar(visitor);
                servicioReportes.Aceptar(visitor);
                sistemaSpa.Aceptar(visitor);
                Console.WriteLine();
            }
        }
    }
}