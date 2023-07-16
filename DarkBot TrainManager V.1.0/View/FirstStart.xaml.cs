using DarkBotTrainManager.Model;
using DarkBotTrainManager.Services;
using DarkBotTrainManager.ViewModel;
using System.Windows;

namespace DarkBotTrainManager.View
{
    /// <summary>
    /// Логика взаимодействия для FirstStart.xaml
    /// </summary>
    public partial class FirstStart : Window
    {
        public FirstStart(FirstStartUp firstStartUp)
        {
            InitializeComponent();

            DataContext = new FirstStartUpViewModel(firstStartUp, new FirstStartUpFileService(), new DialogService(), new AppService(), new PathCutService());
        }
    }
}
