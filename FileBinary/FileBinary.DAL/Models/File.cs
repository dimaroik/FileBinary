using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBinary.DAL.Models
{
    [Serializable]
    public class File
    {
        public byte[] Data { get; set; }
        public string Name { get; set; }
    }
}
