using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class LeafHabitacion : AComponentPaquete
    {

        public string tipo { get; set; }
        public double precio { get; set; }
        public ServicioCena servicioCena { get; set; }
        public ServicioBar servicioBar { get; set; }
        public AreasLudicas areasLudicas { get; set; }
        public Desayuno desayuno { get; set; }

        public LeafHabitacion() : base(0, "ONE")
        {

        }

        public LeafHabitacion(string tipo, double precio, ServicioCena servicioCena, ServicioBar servicioBar, AreasLudicas areasLudicas, Desayuno desayuno, double descuento, string nombre) : base (descuento, nombre)
        {
            this.tipo = tipo;
            this.precio = precio;
            this.servicioCena = servicioCena;
            this.servicioBar = servicioBar;
            this.areasLudicas = areasLudicas;
            this.desayuno = desayuno;
        }

        public override void GetDetalle()
        {
            Console.WriteLine($"HABITACION TIPO: {tipo}");
            Console.WriteLine($"Precio Real: {GetPrecioReal()} Bs");
            Console.WriteLine($"Precio Descuento: {GetPrecioConDescuento()} Bs");
            Console.WriteLine("Descripción: ");
            servicioCena.GetDetalle();
            servicioBar.GetDetalle();
            areasLudicas.GetDetalle();
            desayuno.GetDetalle();
        }

        public override double GetPrecioConDescuento()
        {
            return precio - (precio * (base.Descuento/100.0));
        }

        public override double GetPrecioReal()
        {
            return precio;
        }
    }
}
