using DarkBotTrainManager.Model;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Input;

namespace DarkBotTrainManager.Services
{
    public class FirstStartUpFileService : IFileService
    {
        public void Save(string path, FirstStartUp firstStartUp)
        {
            using (StreamWriter streamWriter = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(streamWriter, firstStartUp);
            }
        }
        public void CreateBotFolder(string trainPath, string newBotPath)
        {
            var trainDirectory = new DirectoryInfo(trainPath);
            trainDirectory.CreateSubdirectory(newBotPath);

        }
    }
}
