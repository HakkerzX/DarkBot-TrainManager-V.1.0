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
        private const string _firstStartConfigJsonFilePath = $"firstStartConfig.json";

        private FirstStartUp _firstUpStart;

        private IFileService _fileService;
        private IDialogService _dialogService;
        public FirstStartUpViewModel(FirstStartUp firstStarUp, IFileService fileService, IDialogService dialogService)
        {
            _firstUpStart = firstStarUp;
            _fileService = fileService;
            _dialogService = dialogService;
        }

        /// <summary>
        /// Commands
        /// </summary>
        #region

        private RelayCommandService _saveCommand;
        public RelayCommandService SaveCommand
        {
            get
            {
                return _saveCommand ??
                (_saveCommand = new RelayCommandService(obj =>
                {
                    _fileService.Save(_firstStartConfigJsonFilePath, _firstUpStart);
                }
                ));
            }
        }

        private RelayCommandService _selectTrainFolder;
        public RelayCommandService SelectTrainFolder
        {
            get
            {
                return _selectTrainFolder ??
                (_selectTrainFolder = new RelayCommandService(obj =>
                {
                    if (_dialogService.OpenFolderDialog() == true)
                    {
                        DarkBotInstallFolderPath = _dialogService.FolderPath;
                    }
                }
                ));
            }
        }

        private RelayCommandService _selectBotFile;
        public RelayCommandService SelectBotFile
        {
            get
            {
                return _selectBotFile ??
                (_selectBotFile = new RelayCommandService(obj =>
                {
                    if (_dialogService.OpenFileDialog() == true)
                    {
                        DarkBotFilePath = _dialogService.FilePath;
                    }
                }
                ));
            }
        }


        #endregion

        /// <summary>
        /// Fields
        /// </summary>
        #region 

        public string DarkBotFilePath
        {
            get { return _firstUpStart.DarkBotFilePath; }
            set
            {
                _firstUpStart.DarkBotFilePath = value;
                OnPropertyChanged(nameof(DarkBotFilePath));
            }
        }

        public string DarkBotInstallFolderPath
        {
            get { return _firstUpStart.DarkBotInstallFolderPath; }
            set
            {
                _firstUpStart.DarkBotInstallFolderPath = value;
                OnPropertyChanged(nameof(DarkBotInstallFolderPath));
            }
        }

        #endregion
    }
}
