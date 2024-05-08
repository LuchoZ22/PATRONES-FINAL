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

        // SOLICITUDES DE SERVICIOS
        SolicitudServicio solicitud1 = new SolicitudServicio(512, "Cocina", "Un plato de spaguetti grande por favor.");
        mediator.SolicitarServicio(solicitud1);
        SolicitudServicio solicitud2 = new SolicitudServicio(240, "Reportes", "Hay una serpiente en mi bota.");
        mediator.SolicitarServicio(solicitud2);

        // SOLICITUDES DE RESERVA DEL SPA
        SolicitudReserva solicitudReserva1 = new(316, 10);
        sistemaSpa.ProcesarReserva(solicitudReserva1);
        SolicitudReserva solicitudReserva2 = new(234, 9);
        sistemaSpa.ProcesarReserva(solicitudReserva2);
        SolicitudReserva solicitudReserva3 = new(928, 12);
        sistemaSpa.ProcesarReserva(solicitudReserva3);
        SolicitudReserva solicitudReserva4 = new(814, 10);
        sistemaSpa.ProcesarReserva(solicitudReserva4);
        SolicitudReserva solicitudReserva5 = new(504, 15);
        sistemaSpa.ProcesarReserva(solicitudReserva5);
        SolicitudReserva solicitudReserva6 = new(104, 10);
        sistemaSpa.ProcesarReserva(solicitudReserva6);
        SolicitudReserva solicitudReserva7 = new(582, 12);
        sistemaSpa.ProcesarReserva(solicitudReserva7);

        // REPORTES DE USOS Y COSTO GENERADO
        servicioCocina.Aceptar(visitor);
        servicioBar.Aceptar(visitor);
        servicioLimpieza.Aceptar(visitor);
        servicioReportes.Aceptar(visitor);
        sistemaSpa.Aceptar(visitor);
    }
}