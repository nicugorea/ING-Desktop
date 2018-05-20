using System.Windows;
using System.Windows.Controls;
using WPF;
using WpfApp.INGService;

namespace WpfApp.Pages.ProfileWindow
{
    /// <summary>
    /// Interaction logic for TopTab.xaml
    /// </summary>
    public partial class TopTab : Page
    {
        private ProfilePage _profileWindow = null;

        private int _id = -1;

        public TopTab(ProfilePage profileWindow, int id)
        {
            InitializeComponent();
            _profileWindow = profileWindow;
            _id = id;
            InitializeName();
        }

        private void InitializeName()
        {
             var user = DatabaseContext.Instance.ServiceClient.GetUser(_id);
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

            _profileWindow.Close();
            startWindow.Show();
        }
    }
}
