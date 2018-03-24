using System;
using System.IO;
using IOFile = System.IO.File;
using IOPath = System.IO.Path;

namespace RFM.Manager
{
    public class File
    {
        public string Path {get; private set; }
        public string Name {get; private set; }
        public string Format {get; private set; }


        public File(string path, string name, string format)
        {
            this.Path = path;
            this.Name = name;
            this.Format = format;
        }

        public static File CreateFile(string fileName, string path)
        {
            var fullPath = IOPath.Combine(path, fileName);

            if (IOFile.Exists(fullPath))
            {
                throw new 
            }

            return null;
        }


    }
}
