using System.Windows;
using View.ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainVM mainVM = new MainVM();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = mainVM;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainVM.SaveContacts();
        }
    }
}
