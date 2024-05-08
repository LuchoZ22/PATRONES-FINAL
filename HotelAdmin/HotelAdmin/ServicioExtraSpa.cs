using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelAdmin
{
    internal class ServicioExtraSpa : ServicioDecorator
    {
        public ServicioExtraSpa(ComponentServicio baseObj): base(baseObj, 20, "Spa") { }

        
    }
}
