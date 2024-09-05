using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ST10396397_PROG6212_POE_P1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            loginWindow.Show();
        }

        private void Claim_Click(object sender, RoutedEventArgs e)
        {
            var claimWindow = new ClaimWindow();
            claimWindow.Show();
        }

        private void VIEW_Click(object sender, RoutedEventArgs e)
        {
            var viewWindow = new ViewWindow();
            viewWindow.Show();
        }

        private void MANAGE_Click_1(object sender, RoutedEventArgs e)
        {
            var manageWindow = new ManageWindow();
            manageWindow.Show();
        }

        private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}