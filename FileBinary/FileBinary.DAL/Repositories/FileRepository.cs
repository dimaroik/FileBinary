using FileBinary.DAL.Interfaces;
using FileBinary.DAL.Serialization;
using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBinary.DAL.Repositories
{
    public class FileRepository : IFileRepository
    {
        private FileSystemRead systemRead ;
        private FileSystemWrite systemWrite ;

        public FileRepository()
        {
            systemRead = new FileSystemRead();
            systemWrite = new FileSystemWrite();
        }

        private readonly string pathSave = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\FileBinary";
        
        public IEnumerable<string> GetAllFiles()
        {
            if (!Directory.Exists(pathSave))
            {
                Directory.CreateDirectory(pathSave);
            }

            foreach (var file in System.IO.Directory.GetFiles(Path))
            {
                var fInfo = new FileInfo(file);

                yield return fInfo.Name;     
            }    
        }

        public void Pack(string path)
        {
            var dirInfo = new DirectoryInfo(path);
            string fileName = System.IO.Path.Combine(Path, dirInfo.Name);

            systemWrite.WriteIn(path , fileName);
        }

        public void Unpack(string nameFile , string locationPath)
        {
            string pathFile = System.IO.Path.Combine(pathSave, nameFile);

            systemRead.ReadIn( pathFile , locationPath);
        }

        public string Path {

            get { return pathSave; }
        }

       

    }
}
