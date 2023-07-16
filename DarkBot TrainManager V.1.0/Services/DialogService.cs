using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows;

namespace DarkBotTrainManager.Services
{
    public class DialogService : IDialogService
    {
        public string FilePath { get; set; }
        public string FolderPath { get; set; }

        public bool OpenFolderDialog()
        {
            CommonOpenFileDialog openFolderDialog = new CommonOpenFileDialog();
            openFolderDialog.IsFolderPicker = true;
            if (openFolderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                FolderPath = openFolderDialog.FileName;
                return true;
            }
            return false;
        }

        public bool OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                return true;
            }
            return false;
        }

        public bool SaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                FilePath = saveFileDialog.FileName;
                return true;
            }
            return false;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
