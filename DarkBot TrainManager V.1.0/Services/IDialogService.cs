namespace DarkBotTrainManager.Services
{
    public interface IDialogService
    {
        void ShowMessage(string message);
        string FilePath { get; set; }
        string FolderPath { get; set; }
        bool OpenFileDialog();
        bool SaveFileDialog();
        bool OpenFolderDialog();
    }
}
