using DarkBotTrainManager.Model;
using DarkBotTrainManager.ViewModel;
using System.Windows;

namespace DarkBotTrainManager.View
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            FirstStart firstStart = new FirstStart(new FirstStartUp());
            firstStart.Show();
        }
    }
}
