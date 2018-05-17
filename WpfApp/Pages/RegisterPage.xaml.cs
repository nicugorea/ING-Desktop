using System.Windows.Controls;
using WpfApp.INGService;

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

        private void SetMessage(string message)
        {
            RegisterMessage.Content = message;
        }

        private bool IsInputOk()
        {
            if (inputUsername.Text.Length < 6)
            {
                SetMessage("Numele de utilizator contine mai putin de 6 caractere!");
                return false;
            }
            if (inputPassword.Password.Length < 6)
            {
                SetMessage("Parola contine mai putin de 6 caractere!");
                return false;
            }
            if (inputPassword.Password != inputConfirmPassword.Password)
            {
                SetMessage("Parolele nu coincid");
                return false;
            }
            if (inputFirstName.Text.Length < 6)
            {
                SetMessage("Numele contine mai putin de 6 caractere!");
                return false;
            }
            if (inputLastName.Text.Length < 6)
            {
                SetMessage("Prenumele contine mai putin de 6 caractere!");
                return false;
            }
            return true;
        }

        private void GoToLogin(object sender, System.Windows.RoutedEventArgs e)
        {
            _startWindow.SetMainFrame(new LoginPage(_startWindow));
        }

        private void CreateNewAccount(object sender, System.Windows.RoutedEventArgs e)
        {

            if (!IsInputOk()) return;

            var newUser = new User
            {
                username = inputUsername.Text,
                password = inputPassword.Password,
                first_name = inputFirstName.Text,
                last_name = inputLastName.Text
            };

            if (DatabaseContext.Instance.ServiceClient.AddUser(newUser))
                SetMessage("Registered");
            else SetMessage("Username is used!");
        }
    }
}
