using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia___polimorfismo
{
    internal class perro: animal_domestico
    {

        public override string comunicarse()
        {
            return "guau ... guau";
        }
    }
}
