using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkBotTrainManager.Services;

namespace DarkBotTrainManager.Model
{
    public class FirstStart : DefaultNotifyPropertyChangedService
    {
        private string _darkBotFilePath;
        private string _darkBotFolderPath;

        public string DarkBotFilePath
        {
            get { return _darkBotFilePath; }
            set
            {
                _darkBotFilePath = value;
                OnPropertyChanged(nameof(DarkBotFilePath));
            }
        }

        public string DarkBotFolderPath
        {
            get { return _darkBotFolderPath; }
            set
            {
                _darkBotFolderPath = value;
                OnPropertyChanged(nameof(DarkBotFolderPath));
            }
        }
    }
}

