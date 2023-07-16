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
