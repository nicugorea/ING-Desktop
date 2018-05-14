using System.Windows.Controls;

namespace WPF.Pages
{
    public partial class RegisterPage : Page
    {
        private StartWindow _startWindow = null;

        public RegisterPage(StartWindow startWindow)
        {
            InitializeComponent();
            _startWindow = startWindow;
        }

        private void GoToLogin(object sender, System.Windows.RoutedEventArgs e)
        {
            _startWindow.SetMainFrame(new LoginPage(_startWindow));
        }
    }
}
