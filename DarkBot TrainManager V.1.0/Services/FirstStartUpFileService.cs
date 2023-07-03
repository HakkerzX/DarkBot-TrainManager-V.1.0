using DarkBotTrainManager.Model;
using Newtonsoft.Json;
using System.IO;

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
        public void CreateFolder(string targetDitrectoryPath, string newFolderName)
        {
            DirectoryInfo targetFolder = new DirectoryInfo(targetDitrectoryPath);
            if (targetFolder.Exists)
            {
                targetFolder.CreateSubdirectory(newFolderName);
            }
        }

        public void CreateBotFile(string botFolderPath, string botFilePath)
        {
            FileInfo botFile = new FileInfo(botFilePath);
            if (botFile.Exists)
            {
                botFile.CopyTo(botFolderPath, true);
            }
        }
    }
}
