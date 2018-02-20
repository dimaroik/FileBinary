using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBinary.DAL.Interfaces
{
    public interface IFileRepository
    {
        IEnumerable<string> GetAllFiles();
        void Pack(string path);
        void Unpack(string nameFile, string locationPath);
        string Path { get; }
    }
}
