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

        public string DarkBotFilePath
        {
            get { return _firstStart.DarkBotFilePath; }
            set
            {
                _firstStart.DarkBotFilePath = value;
                OnPropertyChanged(nameof(DarkBotFilePath));
            }
        }


    }
}
