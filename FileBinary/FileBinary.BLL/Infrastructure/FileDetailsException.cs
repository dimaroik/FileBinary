using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBinary.BLL.Infrastructure
{
    public class FileDetailsException : Exception
    {
        public string Property { get; protected set; }
        public FileDetailsException(string message, string prop)
            : base(message)
        {
            Property = prop;
        }
    }
}
