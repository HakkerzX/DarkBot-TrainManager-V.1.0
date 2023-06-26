using DarkBotTrainManager.Model;
using DarkBotTrainManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkBotTrainManager.ViewModel
{
    public class FirstStartViewModel : DefaultNotifyPropertyChangedService
    {
        private FirstStart _firstStart;
        public FirstStartViewModel(FirstStart firstStart)
        {
            _firstStart = firstStart;
        }

        /// <summary>
        /// Commands
        /// </summary>
        #region

        private RelayCommandService _saveCommand;

        #endregion

        /// <summary>
        /// Fields
        /// </summary>
        #region 

        public string DarkBotFilePath
        {
            get { return _firstStart.DarkBotFilePath; }
            set
            {
                _firstStart.DarkBotFilePath = value;
                OnPropertyChanged(nameof(DarkBotFilePath));
            }
        }

        public string DarkBotInstallFolderPath
        {
            get { return _firstStart.DarkBotInstallFolderPath; }
            set
            {
                _firstStart.DarkBotInstallFolderPath = value;
                OnPropertyChanged(nameof(DarkBotInstallFolderPath));
            }
        }

        #endregion
    }
}
