﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin
{
    internal class BInteligente : Abuilder
    {
        public BInteligente() 
        {
            areasLudicas = new AreasLudicas(true, true, false, true);
            desayuno = new Desayuno("Un refresco, un jugo, frutas, pan,galletas, ración de alimento cocinado, alimento fitness");
            servicioBar = new ServicioBar("Refrescos, bebidas clásicas, jugos de frutas");
            servicioCena = new ServicioCena("Rodizio del menú + refresco ilimitado", true, true);
        }

        public override void SetAreaLudica()
        {
            habitacion.areasLudicas = areasLudicas;
        }

        public override void SetDesayuno()
        {
            habitacion.desayuno = desayuno;
        }

        public override void SetPrecio()
        {
            habitacion.precio = 400;
        }

        public override void SetServicioBar()
        {
            habitacion.servicioBar = servicioBar;
        }

        public override void SetServicioCena()
        {
            habitacion.servicioCena = servicioCena;
        }

        public override void SetTipo()
        {
            habitacion.tipo = "Inteligente";
        }
    }
}
