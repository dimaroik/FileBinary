
using FileBinary.BLL.Infrastructure;
using FileBinary.BLL.Interfaces;
using FileBinary.DAL.Interfaces;
using FileBinary.DAL.Repositories;
using FileBinary.DAL.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBinary.BLL.Services
{
    public class FileService : IFileService
    {
        IFileRepository repository;

        public FileService()
        {
            repository = new FileRepository();
        }
        public IEnumerable<string> GetAllFiles()
        {
            try
            {
                return repository.GetAllFiles();
            }
            catch (IOException)
            {
                throw new FileDetailsException("Problem with connection to folder", "");
            }
        }

        public void PackFile(string path)
        {
            try
            {
                if (path == null)
                    throw new FileDetailsException("Not set folder" , "");

                repository.Pack(path);
            }
            catch (IOException)
            {
                throw new FileDetailsException("Problem with connection to folder", "");
            }

            
        }
        public void UnpackFile(string nameFile, string pathSave)
        {
            try
            {
                if(pathSave == null)
                    throw new FileDetailsException("Not set folder", "");

                repository.Unpack(nameFile, pathSave);
            }
            catch (IOException)
            {
                throw new FileDetailsException("Problem with connection to folder", "");
            }
           
        }

      
    }
}
