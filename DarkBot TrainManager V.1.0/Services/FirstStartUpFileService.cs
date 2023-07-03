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

        public void CreateFile(string targetFolderPath, string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            if (file.Exists)
            {
                targetFolderPath = $"{targetFolderPath}\\{file.Name}";
                file.CopyTo(targetFolderPath, true);
            }
        }
    }
}
