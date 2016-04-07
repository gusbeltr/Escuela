using System;

namespace Polimorfismo
{
    internal class Circle : Shape
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
