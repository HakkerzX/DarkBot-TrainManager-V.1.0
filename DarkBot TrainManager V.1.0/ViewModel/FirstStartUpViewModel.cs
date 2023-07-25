using DarkBotTrainManager.Model;
using DarkBotTrainManager.Services;

namespace DarkBotTrainManager.ViewModel
{
    public class FirstStartUpViewModel : BaseNotifyPropertyChangedService
    {
        private const string _firstStartConfigJsonFilePath = $"firstStartConfig.json";

        private FirstStartUp _firstStartUp = new FirstStartUp();


        private IFileService _fileService;
        private IDialogService _dialogService;
        private IAppService _appService;
        private IPathCutService _pathCutService;
        public FirstStartUpViewModel(IFileService fileService, IDialogService dialogService, IAppService appService, IPathCutService pathCutService)
        {
            _fileService = fileService;
            _dialogService = dialogService;
            _appService = appService;
            _pathCutService = pathCutService;
        }


        #region  Commands

        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return _saveCommand ??
                (_saveCommand = new RelayCommand(obj =>
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

        private RelayCommand _cancelCommand;
        public RelayCommand CancelCommand
        {
            get
            {
                return _cancelCommand ??
                (_cancelCommand = new RelayCommand(obj =>
                {
                    _appService.CloseApp();
                }));
            }
        }

        private RelayCommand _selectTrainFolder;
        public RelayCommand SelectTrainFolder
        {
            get
            {
                return _selectTrainFolder ??
                (_selectTrainFolder = new RelayCommand(obj =>
                {
                    if (_dialogService.OpenFolderDialog() == true)
                    {
                        DarkBotInstallFolderPath = $"{_dialogService.FolderPath}\\DarkBotTrain";
                    }
                }
                ));
            }
        }

        private RelayCommand _selectBotFile;
        public RelayCommand SelectBotFile
        {
            get
            {
                return _selectBotFile ??
                (_selectBotFile = new RelayCommand(obj =>
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


        #region Fields

        public string DarkBotFilePath
        {
            get
            {
                return _firstStartUp.DarkBotFilePath;
            }
            set
            {
                _firstStartUp.DarkBotFilePath = value;
                OnPropertyChanged(nameof(DarkBotFilePath));
            }
        }

        public string DarkBotInstallFolderPath
        {
            get
            {
                return _firstStartUp.DarkBotInstallFolderPath;
            }
            set
            {
                _firstStartUp.DarkBotInstallFolderPath = value;
                OnPropertyChanged(nameof(DarkBotInstallFolderPath));
            }
        }

        #endregion
    }
}
