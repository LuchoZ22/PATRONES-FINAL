

namespace HotelAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abuilder builderEstandar = new BEstandar();
            Abuilder builderLujo = new BLujo();
            Abuilder builderInteligente = new BInteligente();
            /*
            //PRUEBAS LUCHO
           

            DirectorHabitacion.BuildHabitacion(builderEstandar);
            LeafHabitacion h = builderEstandar.GetHabitacion();
            h.GetDetalle();

            Console.WriteLine("\n#########################################################################\n");

            DirectorHabitacion.BuildHabitacion(builderLujo);
            h = builderLujo.GetHabitacion();
            h.GetDetalle();

            Console.WriteLine("\n#########################################################################\n");

            DirectorHabitacion.BuildHabitacion(builderInteligente);
            h = builderInteligente.GetHabitacion();
            h.GetDetalle();
            */

            AdministradorHabitaciones admin = new AdministradorHabitaciones();
            var aux = admin.CrearOne(builderLujo);
            ComponentServicio basePaquete = new PaqueteBase(aux);
            basePaquete.GetDetalle();
            ServicioExtraCine extraCine = new ServicioExtraCine(basePaquete);
            extraCine.GetDetalle();
            ServicioExtraInternet extraInternet = new ServicioExtraInternet(extraCine);
            extraInternet.GetDetalle();


        }
    }
}
