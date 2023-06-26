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

        public FirstStart FirstStart
        {
            get { return _firstStart; }
            set
            {
                _firstStart = value;
                OnPropertyChanged(nameof(FirstStart));
            }
        }
    }
}
