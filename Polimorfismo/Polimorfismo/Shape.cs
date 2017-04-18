using System;

namespace Polimorfismo
{
    internal class Shape
    {
        protected int X { get; set; }
        protected int Y { get; set; }

        //Virtual, para sobrescribir el comportamiento en las clases derivadas.
        public virtual void Draw()
        {
            Console.WriteLine("Cambiando malas muchas cosas de la clase Base");
        }
    }
}
