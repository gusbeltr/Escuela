using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Circle : Shape
    {

        public Circle(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Draw()
        {
            Console.WriteLine("Dibujando un Circulo, Clase derivada");
        }
    }
}
