using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RFM.Manager
{
    interface IFile
    {
        //IFile Create(string fileName, string path);
        void Delete();
        string Read();
        void Write();
        void Append();
        void CloseStream();
    }
}
