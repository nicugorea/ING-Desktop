using System.Windows;
using System.Windows.Controls;
using WPF;
using WpfApp.INGService;

namespace WpfApp.Pages.ProfileWindow
{
    public partial class TopTab : Page
    {
        private ProfilePage _profilePage = null;

        public TopTab(ProfilePage profilePage)
        {
            InitializeComponent();
            _profilePage = profilePage;
            InitializeName();
        }

        public void SetAccountId(int id)
        {
            btnAccountId.Content = id;
        }

        private void InitializeName()
        {
             var user = DatabaseContext.Instance.ServiceClient.GetUser(_profilePage.Id);
            btnNameSurname.Content = user.first_name + " " + user.last_name;
        }

        private void BtnHelp(object sender, RoutedEventArgs e)
        {

        }

        private void BtnNameSurname(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLogout(object sender, RoutedEventArgs e)
        {
            var startWindow = new StartWindow();
            App.Current.MainWindow = startWindow;

            _profilePage.Close();
            startWindow.Show();
        }

        private void BtnAccountId(object sender, RoutedEventArgs e)
        {

        }
    }
}
