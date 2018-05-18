using System.Windows.Controls;
using WpfApp;

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

        private void SetMessage(string message)
        {
            LoginMessage.Content = message;
        }

        private bool IsInputOk()
        {
            if (inputUsername.Text.Length < 6)
            {
                SetMessage("Numele de utilizator are mai putin de 6 caractere!");
                return false;
            }
            if (inputPassword.Password.Length < 6)
            {
                SetMessage("Parola are mai putin de 6 caractere!");
                return false;
            }
            return true;
        }

        private void ButtonClickLogin(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!IsInputOk()) return;
            if (DatabaseContext.Instance.ServiceClient.LogIn(inputUsername.Text, inputPassword.Password))
            {
                SetMessage("Autentificare cu succes");
                ProfilePage profileWindow = new ProfilePage(
                    DatabaseContext.Instance.ServiceClient.GetUserIdByUsername(inputUsername.Text));
                App.Current.MainWindow = profileWindow;
                _startWindow.Close();
                profileWindow.Show();
            }
                
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
