
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBinary.BLL.Interfaces
{
    public interface IFileService
    {
        void PackFile(string path);
        IEnumerable<string> GetAllFiles();
        void UnpackFile(string nameFile , string pathSave);
    }
}
