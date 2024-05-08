using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal class Visitor : IVisitor
    {
        public void VisitarBar(ServicioBar bar)
        {
            Console.WriteLine("Visitando el BAR");
            Console.WriteLine($"Cantidad de usos: {bar.CantidadUsos()}");
            Console.WriteLine($"Costo generado: {bar.CostoGenerado()}");
        }

        public void VisitarCocina(ServicioCocina cocina)
        {
            Console.WriteLine("Visitando la COCINA");
            Console.WriteLine($"Cantidad de usos: {cocina.CantidadUsos()}");
            Console.WriteLine($"Costo generado: {cocina.CostoGenerado()}");
        }

        public void VisitarLimpieza(ServicioLimpieza limpieza)
        {
            Console.WriteLine("Visitando el SERVICIO DE LIMPIEZA");
            Console.WriteLine($"Cantidad de usos: {limpieza.CantidadUsos()}");
        }

        public void VisitarReportes(ServicioReportes reportes)
        {
            Console.WriteLine("Visitando el SERVICIO DE REPORTES");
            Console.WriteLine($"Cantidad de usos: {reportes.CantidadUsos()}");
        }

        public void VisitarSpa(SistemaSpa spa)
        {
            Console.WriteLine("Visitando el SPA");
            Console.WriteLine($"Cantidad de usos: {spa.CantidadUsos()}");
            Console.WriteLine($"Costo generado: {spa.CostoGenerado()}");
        }
    }
}
