using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DarkBotTrainManager.Services
{
    class AppService : IAppService
    {
        public void CloseApp()
        {
            Application.Current.Shutdown();
        }
    }
}
