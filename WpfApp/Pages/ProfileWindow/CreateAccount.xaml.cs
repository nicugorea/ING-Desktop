using System.Windows;
using System.Windows.Controls;
using WpfApp.INGService;

namespace WpfApp.Pages.ProfileWindow
{
    public partial class CreateAccount : Page
    {
        private ProfilePage _profilePage = null;

        public CreateAccount( ProfilePage profilePage)
        {
            InitializeComponent();
            ProfilePage = profilePage;
        }

        public ProfilePage ProfilePage { get => _profilePage; set => _profilePage = value; }

        private void BtnMyAccounts(object sender, RoutedEventArgs e)
        {
            ProfilePage.SetMainFrame(new MyAccounsPage(_profilePage));
        }

        private void BtnCreateAccount(object sender, RoutedEventArgs e)
        {
            var account = new Account
            {
                id_user=ProfilePage.Id,
                name=inputName.Text
            };
            DatabaseContext.Instance.ServiceClient.CreateAccount(account);
        }
    }
}
