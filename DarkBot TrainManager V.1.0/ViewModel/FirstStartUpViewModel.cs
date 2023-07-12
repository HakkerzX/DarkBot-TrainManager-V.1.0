using DarkBotTrainManager.Model;
using DarkBotTrainManager.Services;

namespace DarkBotTrainManager.ViewModel
{
    public class FirstStartUpViewModel : BaseNotifyPropertyChangedService
    {
        private const string _firstStartConfigJsonFilePath = $"firstStartConfig.json";

        private FirstStartUp _firstStartUp;

        private IFileService _fileService;
        private IDialogService _dialogService;
        private IAppService _appService;
        private IPathCutService _pathCutService;
        public FirstStartUpViewModel(FirstStartUp firstStarUp, IFileService fileService, IDialogService dialogService, IAppService appService, IPathCutService pathCutService)
        {
            _firstStartUp = firstStarUp;
            _fileService = fileService;
            _dialogService = dialogService;
            _appService = appService;
            _pathCutService = pathCutService;
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
                    string trainFolderName = _pathCutService.GetFolderNameFromPath(DarkBotInstallFolderPath);
                    _fileService.CreateFolder(_dialogService.FolderPath, $"{trainFolderName}");

                    string newBot = "Bot1";
                    _fileService.CreateFolder(DarkBotInstallFolderPath, newBot);
                    _fileService.CreateFile($"{DarkBotInstallFolderPath}\\{newBot}", DarkBotFilePath);

                    _fileService.Save(_firstStartConfigJsonFilePath, _firstStartUp);
                }
                ));
            }
        }

        private RelayCommandService _cancelCommand;
        public RelayCommandService CancelCommand
        {
            get
            {
                return _cancelCommand ??
                (_cancelCommand = new RelayCommandService(obj =>
                {
                    _appService.CloseApp();
                }));
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
                        DarkBotInstallFolderPath = $"{_dialogService.FolderPath}\\DarkBotTrain";
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
            get { return _firstStartUp.DarkBotFilePath; }
            set
            {
                _firstStartUp.DarkBotFilePath = value;
                OnPropertyChanged(nameof(DarkBotFilePath));
            }
        }

        public string DarkBotInstallFolderPath
        {
            get { return _firstStartUp.DarkBotInstallFolderPath; }
            set
            {
                _firstStartUp.DarkBotInstallFolderPath = value;
                OnPropertyChanged(nameof(DarkBotInstallFolderPath));
            }
        }

        #endregion
    }
}
