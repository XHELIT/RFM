using System;
using System.Collections.Generic;
using System.Text;

namespace RFM.Manager
{
    public class FileExistsException : Exception
    {
        public FileExistsException(string message) : base(message)
        {
        }

        public FileExistsException()
        {

        }

        public FileExistsException(string message, Uri uri) : base($"{message} URI: {uri.ToString()}")
        {

        }
    }
}
