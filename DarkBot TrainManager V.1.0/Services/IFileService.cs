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
        void CreateBotFolder(string trainPath, string newBotPath);
    }
}
