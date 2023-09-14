using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia___polimorfismo
{
    internal class animales
    {

        public virtual string comunicarse()
        {

            return "ruido... ruido ...";
        }
        public string nombre { get; set; }



    }
}
