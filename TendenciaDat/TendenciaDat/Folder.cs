using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
namespace TendenciaDat
{
    internal class Folder
    {
        private StringBuilder builder;
        private IList<string> FilesPath { get; set; }
        private List<FileInfo> Files { get; set; }
        private string path { get; set; }

        public Folder(string path)
        {
            this.path = path;
            this.FilesPath = new List<string>();
            this.Files = new List<FileInfo>();
            this.builder = new StringBuilder();
        }

        public void GetPathName()
        {
            FilesPath = Directory.GetFiles(this.path);
        }

        public void BuilFileInfo()
        {
            foreach (string file in FilesPath)
                Files.Add(new FileInfo(file));
        }

        public override string ToString()
        {
            builder.Clear();


            for (int i = 0; i < Files.Count - 1; i++)
                if (Files[i + 1] != null)
                    builder.AppendLine(Files[i + 1].CreationTime.Subtract(Files[i].CreationTime).Seconds.ToString());

            return builder.ToString();
        }
    }
}
