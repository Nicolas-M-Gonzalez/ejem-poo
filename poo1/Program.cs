using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona();
            p1.setedad(20);

            Console.WriteLine(" la edad de la persona es :" + p1.getedad()) ;

            Botella b1 = new Botella( "rojo", "plastico" );
            b1.capacidad = 200;



            Console.ReadKey();








        }
    }
}
