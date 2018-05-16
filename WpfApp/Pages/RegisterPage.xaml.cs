using System.Windows.Controls;
using WpfApp.INGService;

namespace WPF.Pages
{
    public partial class RegisterPage : Page
    {
        private StartWindow _startWindow = null;

        private void SetMessage(string message)
        {
            RegisterMessage.Content = message;
        }

        public RegisterPage(StartWindow startWindow)
        {
            InitializeComponent();
            _startWindow = startWindow;
        }

        private void GoToLogin(object sender, System.Windows.RoutedEventArgs e)
        {
            _startWindow.SetMainFrame(new LoginPage(_startWindow));
        }

        private void CreateNewAccount(object sender, System.Windows.RoutedEventArgs e)
        {
            if (inputConfirmPassword.Password != inputPassword.Password)
            {
                SetMessage("Parolele nu coincid!");
                return;
            }

            var newUser = new User
            {
                username = inputUsername.Text,
                password = inputPassword.Password,
                first_name = inputFirstName.Text,
                last_name = inputLastName.Text
            };
            string message = WpfApp.src.Utility.IsUserValid(newUser);
            if (message == "Ok")
                DatabaseContext.Instance.ServiceClient.AddUser(newUser);
            SetMessage(message);
        }
    }
}
