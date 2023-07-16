using DarkBotTrainManager.Model;

namespace DarkBotTrainManager.Services
{
    public interface IFileService
    {
        void Save(string path, FirstStartUp firstStartUp);
        void CreateFolder(string targetDitrectoryPath, string newFolderName);
        void CreateFile(string botFolderPath, string botFilePath);
    }
}
