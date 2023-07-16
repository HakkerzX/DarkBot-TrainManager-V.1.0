using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DarkBotTrainManager.Services
{
    public class BaseNotifyPropertyChangedService : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
