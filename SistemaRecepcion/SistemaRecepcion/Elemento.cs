using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal abstract class Elemento
    {
        protected int _cantidadUsos;
        protected double _costoGenerado;

        public int CantidadUsos() => _cantidadUsos;
        public double CostoGenerado() => _costoGenerado;

        public Elemento()
        {
            _cantidadUsos = 0;
            _costoGenerado = 0;
        }

        public abstract void Aceptar(IVisitor visitor);

        public void IncrementarUsos()
        {
            _cantidadUsos++;
        }

        public void IncrementarCosto(double costo)
        {
            _costoGenerado += costo;
        }
    }
}
