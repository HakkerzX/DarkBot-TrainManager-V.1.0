using DarkBotTrainManager.Services;
using System.Windows;

namespace DarkBotTrainManager.ViewModel
{
    public class MainViewModel : BaseNotifyPropertyChangedService
    {
        private Visibility _visiblityTabStart;

        public Visibility VisiblityTabStart
        {
            get { return _visiblityTabStart; }
            set
            {
                _visiblityTabStart = value;
                OnPropertyChanged(nameof(VisiblityTabStart));
            }
        }

        private RelayCommandService _hideCommand;
        public RelayCommandService HideCommand
        {
            get
            {
                return _hideCommand ??
                (_hideCommand = new RelayCommandService(obj =>
                {
                    VisiblityTabStart = Visibility.Collapsed;
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
                    VisiblityTabStart = Visibility.Visible;
                }
                ));
            }
        }

    }
}
