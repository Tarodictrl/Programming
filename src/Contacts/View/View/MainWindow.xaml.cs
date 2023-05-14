using System.Windows;
using View.ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainVM _mainVM = new MainVM();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = _mainVM;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _mainVM.SaveContacts();
        }
    }
}
