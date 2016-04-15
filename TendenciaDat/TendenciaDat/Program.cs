using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TendenciaDat
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessDirectory("C:\\temp");
            Console.ReadKey();
        }

        public static void ProcessDirectory(string targetDirectory)
        {
            var listFiles = new List<FileInfo>();
            string[] fileEntries = Directory.GetFiles(targetDirectory);

            foreach (string fileName in fileEntries)
                listFiles.Add( new FileInfo(fileName));

            var first = listFiles.OrderBy(f => f.CreationTime).FirstOrDefault();

            foreach (var item in listFiles.OrderBy(f => f.CreationTime))
            {
                TimeSpan ts =item.CreationTime.Subtract(first.CreationTime);

                Console.WriteLine(item.CreationTime+ "-" + first.CreationTime + "<====> " +ts.Seconds);

                first = item;
            }
        }
        
    }
}
