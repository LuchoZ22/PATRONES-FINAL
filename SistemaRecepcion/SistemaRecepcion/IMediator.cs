using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcion
{
    internal interface IMediator
    {
        void SolicitarServicio(SolicitudServicio solicitudServicio);
    }
}
