using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF;

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
