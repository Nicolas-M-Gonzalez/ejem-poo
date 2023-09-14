using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace herencia___polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            perro p1 = new perro();
            gato g1 = new gato();

            p1.nombre = "polo";
            g1.nombre = " alfonso";

            Console.WriteLine( " el nombre es : " +  p1.nombre );
            Console.WriteLine( " el nombre es: " + g1.nombre );

            List <animales> animales = new List <animales>();
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(new pez());
            animales.Add(new lobo ());
            animales.Add (new perro());
            animales.Add (new gato());

            foreach (animales item in animales) 
            {
                Console.WriteLine(item.comunicarse());
            }




            Console.ReadKey();

        }
    }
}
