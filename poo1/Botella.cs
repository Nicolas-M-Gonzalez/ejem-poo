using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo1
{
    internal class Botella
    {

        private int capapcidad;
        private string color;
        private string material;

        public Botella (string color, string material)
        {
            this.color = color; 
            this.material = material;
        }

        public int capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }



    }
}
