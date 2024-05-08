using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class AdminPaquetes
    {
        private BEstandar bEstandar;
        private BLujo bLujo;
        private BInteligente bInteligente;

        private List<Tuple<int, ComponentServicio>> paquetesServicio;
        private int idCount;

        public AdminPaquetes() 
        {
            bEstandar = new BEstandar();
            bLujo = new BLujo();
            bInteligente = new BInteligente();
            paquetesServicio = new List<Tuple<int, ComponentServicio>>();
            idCount = 0;
        }

        public void AñadirNuevoPaquete(int paquete, int tipo)
        {
            AComponentPaquete auxPaquete;
            Abuilder auxBuilder;
            switch (tipo) 
            {
                case 1:
                    auxBuilder = bEstandar;
                    break;
                case 2:
                    auxBuilder = bLujo;
                    break;
                case 3:
                    auxBuilder = bInteligente;
                    break;
                default:
                    throw new ArgumentException("El tipo de habitacion solicitada es incorrecto");
            }

            switch(paquete)
            {
                case 1:
                    auxPaquete = CreadorPaquetes.CrearOne(auxBuilder);
                    break;
                case 2:
                    auxPaquete = CreadorPaquetes.CrearMedium(auxBuilder);
                    break;
                case 3:
                    auxPaquete = CreadorPaquetes.CrearBig(auxBuilder);
                    break;
                default:
                    throw new ArgumentException("El tipo de paquete es incorrecto");
            }
            ComponentServicio auxServicio = new PaqueteBase(auxPaquete);

            paquetesServicio.Add(new Tuple<int, ComponentServicio>(++idCount, auxServicio));

        }

        public void PrintPaquetes()
        {
            foreach(var paquete in paquetesServicio)
            {
                Console.WriteLine($"| id: {paquete.Item1} | Paquete {paquete.Item2.GetNombrePaquete()}\t|Tipo: {paquete.Item2.paquete.Tipo}\t| Precio: {paquete.Item2.GetPrecioConDescuentoServicio()}");
            }
        }

        public void AñadirServicioPaquete(int id, int servicio)
        {
            int servId = paquetesServicio.FindIndex((it => it.Item1 == id));


            if (servId != null)
            {
                ComponentServicio auxPaqueteServicio = paquetesServicio[servId].Item2;
                ServicioDecorator decorator = null;
                switch (servicio) 
                {
                    case 1:
                        decorator = new ServicioExtraInternet(auxPaqueteServicio);
                        break;
                    case 2:
                        decorator = new ServicioExtraGimnasio(auxPaqueteServicio);
                        break;
                    case 3:
                        decorator = new ServicioExtraSpa(auxPaqueteServicio);
                        break;
                    case 4:
                        decorator = new ServicioExtraKaraoke(auxPaqueteServicio);
                        break;
                    case 5:
                        decorator = new ServicioExtraCine(auxPaqueteServicio);
                        break;
                    default:
                        Console.WriteLine("ERROR: El id del servicio extra no existe");
                        break;
                }
                if (decorator != null)
                {
                    // Update the item in paquetesServicio with the new decorator
                    
                    paquetesServicio[servId] = new Tuple<int, ComponentServicio>(id, decorator);
                    Console.WriteLine($"Servicio extra '{decorator.nombreServicio}' agregado al paquete con id: {id}");
                }
            }
            else
                Console.WriteLine($"ERROR: El paquete con el id: {id} no existe o ya fue eliminado");
        }

    }
}
