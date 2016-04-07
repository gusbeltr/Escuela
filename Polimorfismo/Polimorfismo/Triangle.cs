using System;

namespace Polimorfismo
{
    internal class Triangle : Shape
    {
        public Triangle(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override void Draw()
        {
            Console.WriteLine("Dibujando un triángulo");
        }
    }
}
