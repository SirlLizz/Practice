using Practice_6._2.ViewModels;
using System.Windows;

namespace Practice_6._2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CityViewModel();
        }
    }
}
