using DarkBotTrainManager.Services;
using System.Windows;

namespace DarkBotTrainManager.ViewModel
{
    public class MainViewModel : BaseNotifyPropertyChangedService
    {
        private Visibility _visibilityTabStart;

        private FirstStartUpViewModel _firstStartUp = new(new FirstStartUpFileService(), new DialogService(), new AppService(), new PathCutService());




        #region Properties

        public FirstStartUpViewModel FirstStartUpViewModel => _firstStartUp;

        public Visibility VisibilityTabStart
        {
            get { return _visibilityTabStart; }
            set
            {
                _visibilityTabStart = value;
                OnPropertyChanged(nameof(VisibilityTabStart));
            }
        }

        #endregion



        #region Commands

        private RelayCommandService _hideCommand;
        public RelayCommandService HideCommand
        {
            get
            {
                return _hideCommand ??
                       (_hideCommand = new RelayCommandService(obj =>
                           {
                               VisibilityTabStart = Visibility.Collapsed;
                           }
                       ));
            }
        }

        private RelayCommandService _showCommand;
        public RelayCommandService ShowCommand
        {
            get
            {
                return _showCommand ??
                       (_showCommand = new RelayCommandService(obj =>
                           {
                               VisibilityTabStart = Visibility.Visible;
                           }
                       ));
            }
        }

        #endregion

    }
}
