using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            list.Add(new Triangle(2, 3));
            list.Add(new Circle(1, 1));

            foreach (var shape in list)
            {
                shape.Draw();
            }
            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
