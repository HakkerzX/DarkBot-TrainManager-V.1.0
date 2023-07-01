using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DarkBotTrainManager.ViewModel;
using DarkBotTrainManager.Model;
using DarkBotTrainManager.Services;

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

            DataContext = new FirstStartUpViewModel(firstStartUp, new FirstStartUpFileService(), new DialogService(), new AppService());
        }
    }
}
