using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using FileBinary.DAL.Models;

namespace FileBinary.DAL.Serialization
{

    public class FileSystemRead
    {
        private bool createRoot = false;

        public void ReadIn(string pathFile, string pathSave)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(pathFile, FileMode.OpenOrCreate))
            {
                IEnumerable<FileBinary.DAL.Models.Directory> fileSystem = (IEnumerable<FileBinary.DAL.Models.Directory>)formatter.Deserialize(fs);
                GetDirectories(fileSystem, pathSave);
            }
 
        }

        private void GetDirectories(IEnumerable<FileBinary.DAL.Models.Directory> fileSystem, string path)
        {
            
            foreach (var dir in fileSystem)
            {
                if (!createRoot)
                {
                    path = path + "\\" + dir.Name;
                    System.IO.Directory.CreateDirectory(path);

                    if (dir.Files != null)
                    {
                        GetFiles(path, dir);
                    }

                    createRoot = true;
                    continue;
                }

                System.IO.Directory.CreateDirectory(path + "\\" + dir.Name);
                
                if (dir.Files != null)
                {
                    GetFiles(path + "\\" + dir.Name, dir);
                }

                if (dir.SubFolders != null)
                {
                    GetDirectories((IEnumerable<FileBinary.DAL.Models.Directory>)dir.SubFolders, path + "\\" + dir.Name);
                }

            }
        }

        private void GetFiles(string path, FileBinary.DAL.Models.Directory directory)
        {
            foreach (var item in (IEnumerable<FileBinary.DAL.Models.File>)directory.Files)
            {
                using (FileStream fstream = new FileStream(path + "\\" + item.Name, FileMode.OpenOrCreate))
                {
                    fstream.Write(item.Data, 0, item.Data.Length);
                }
            }
        }
 
    }
}
