

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

           /*
            var aux = CreadorPaquetes.CrearOne(builderLujo);
            ComponentServicio basePaquete = new PaqueteBase(aux);
            basePaquete.GetDetalle();
            ServicioExtraCine extraCine = new ServicioExtraCine(basePaquete);
            extraCine.GetDetalle();
            ServicioExtraInternet extraInternet = new ServicioExtraInternet(extraCine);
            extraInternet.GetDetalle();
           */
            AdminPaquetes adminPaquetes = new AdminPaquetes();
            adminPaquetes.AñadirNuevoPaquete(1, 1);
            adminPaquetes.AñadirNuevoPaquete(2, 2);
            adminPaquetes.PrintPaquetes();
            adminPaquetes.AñadirServicioPaquete(1, 1);
            adminPaquetes.PrintPaquetes();

        }
    }
}
