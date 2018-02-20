using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileBinary.DAL.Serialization
{
 
    public class FileSystemWrite
    {
        bool createRoot = false;
        private IEnumerable<FileBinary.DAL.Models.Directory> GetDirectoriesR(string root)
        {
            if (!createRoot)
            {
                var dirInfo = new DirectoryInfo(root);
                var directory = new FileBinary.DAL.Models.Directory
                {
                    Name = dirInfo.Name,
                    Files = GetFilesR(root).ToArray()   
                };
                createRoot = true;
                yield return directory;
            }

            foreach (var dir in System.IO.Directory.GetDirectories(root))
            {
                var dirInfo = new DirectoryInfo(dir);
                var directory = new FileBinary.DAL.Models.Directory
                {
                    Name = dirInfo.Name,
                    Files = GetFilesR(dir).ToArray(),
                    SubFolders = GetDirectoriesR(dir).ToArray()
                };
                yield return directory;
            }
        }

        private IEnumerable<FileBinary.DAL.Models.File> GetFilesR(string dir)
        {
            foreach (var file in System.IO.Directory.GetFiles(dir))
            {
                var fInfo = new FileInfo(file);

                yield return new FileBinary.DAL.Models.File
                {
                    Data = System.IO.File.ReadAllBytes(file),
                    Name = fInfo.Name
                };
            }
        }

        public void WriteIn(string path , string pathSave)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(pathSave + ".DAT", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, GetDirectoriesR(path).ToArray());
            }
        }

       

       
    }
}
