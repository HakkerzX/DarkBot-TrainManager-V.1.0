using DarkBotTrainManager.Services;
using System.Windows;

namespace DarkBotTrainManager.ViewModel
{
    public class MainViewModel : BaseNotifyPropertyChangedService
    {
        private Visibility _visibilityTabStart = Visibility.Hidden;

        public MainViewModel()
        {
            FirstStartUpViewModel = new(new FirstStartUpFileService(), new DialogService(), new AppService(), new PathCutService());
        }


        #region Properties

        public FirstStartUpViewModel FirstStartUpViewModel { get; private set; }

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

        private RelayCommand _hideCommand;
        public RelayCommand HideCommand
        {
            get
            {
                return _hideCommand ??
                       (_hideCommand = new RelayCommand(obj =>
                           {
                               VisibilityTabStart = Visibility.Collapsed;
                           }
                       ));
            }
        }

        private RelayCommand _showCommand;
        public RelayCommand ShowCommand
        {
            get
            {
                return _showCommand ??
                       (_showCommand = new RelayCommand(obj =>
                           {
                               VisibilityTabStart = Visibility.Visible;
                           }
                       ));
            }
        }

        #endregion

    }
}
