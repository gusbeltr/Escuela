using System;

namespace TendenciaDat
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dir = new Folder("C:\\temp\\Boleta2");

            dir.GetPathName();
            dir.BuilFileInfo();
            var output = dir.ToString();
            Console.Write(output);
            Console.ReadKey();
        }
    }
}
