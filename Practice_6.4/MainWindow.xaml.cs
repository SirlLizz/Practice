using Practice_6._4.ViewModels;
using System.Windows;

namespace Practice_6._4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new WriterViewModel();
        }
    }
}
