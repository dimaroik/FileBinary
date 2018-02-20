using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBinary.DAL.Models
{
    [Serializable]
    public class Directory
    {
        public Directory[] SubFolders { get; set; }
        public File[] Files { get; set; }
        public string Name { get; set; }
    }


}
