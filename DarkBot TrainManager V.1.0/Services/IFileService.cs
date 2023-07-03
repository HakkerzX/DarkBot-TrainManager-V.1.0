using DarkBotTrainManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkBotTrainManager.Services
{
    public interface IFileService
    {
        void Save(string path, FirstStartUp firstStartUp);
        void CreateFolder(string targetDitrectoryPath, string newFolderName);
        void CreateFile(string botFolderPath, string botFilePath);
    }
}
