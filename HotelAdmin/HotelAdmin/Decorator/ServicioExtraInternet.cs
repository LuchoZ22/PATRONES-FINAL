using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelAdmin
{
    internal class ServicioExtraInternet : ServicioDecorator
    {
       
        public ServicioExtraInternet(ComponentServicio baseObj): base(baseObj, 10, "Internet") 
        {
            
        }

        

        
    }

}
