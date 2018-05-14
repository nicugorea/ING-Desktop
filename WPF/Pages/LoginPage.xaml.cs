using System.Windows.Controls;

namespace WPF.Pages
{
    public partial class LoginPage : Page
    {
        private StartWindow _startWindow = null;

        public LoginPage(StartWindow startWindow)
        {
            InitializeComponent();
            _startWindow = startWindow;
        }

        private void ButtonClickLogin(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void CreateNewAccount(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _startWindow.SetMainFrame(new RegisterPage(_startWindow));
        }

        private void CreateNewAccount(object sender, System.Windows.RoutedEventArgs e)
        {
            _startWindow.SetMainFrame(new RegisterPage(_startWindow));
        }
    }
}
