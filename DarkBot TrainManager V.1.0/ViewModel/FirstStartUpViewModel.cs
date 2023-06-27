using DarkBotTrainManager.Model;
using DarkBotTrainManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkBotTrainManager.ViewModel
{
    public class FirstStartUpViewModel : BaseNotifyPropertyChangedService
    {

        private FirstStartUp _firstStart;

        private IFileService _fileService;
        private IDialogService _dialogService;
        public FirstStartUpViewModel(FirstStartUp firstStart, IFileService fileService, IDialogService dialogService)
        {
            _firstStart = firstStart;
            _fileService = fileService;
            _dialogService = dialogService;
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
