using System;
using System.IO;
using IOFile = System.IO.File;
using IOPath = System.IO.Path;

namespace RFM.Manager
{
    public class File : IFile
    {
        public string Path {get; private set; }
        public string Name {get; private set; }
        public string Format {get; private set; }
        private FileStream fileStream;


        private File(string path, string name, FileStream fileStream)
        {
            this.Path = path;
            this.Name = name;
            this.fileStream = fileStream;
        }

        public File(string path, string name)
        {
            this.Path = path;
            this.Name = name;
        }

        public static File CreateFile(string fileName, string path)
        {
           // throw new NotImplementedException("Method yet to be implemented");

            var fullPath = IOPath.Combine(path, fileName);

            if (IOFile.Exists(fullPath))
            {
                throw new FileExistsException($"File: {fullPath} alreadyExists");
            }

            var fs = IOFile.Create(fullPath); //rename

            fs.Close();

            return new File(path, fileName);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }

        public void Append()
        {
            throw new NotImplementedException();
        }

        public void CloseStream()
        {
            throw new NotImplementedException();
        }
    }
}
