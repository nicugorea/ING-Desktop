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

namespace WpfApp.Pages.ProfileWindow
{
    /// <summary>
    /// Interaction logic for OptionsTab.xaml
    /// </summary>
    public partial class OptionsTab : Page
    {

        private ProfilePage _profilePage = null;
        public ProfilePage ProfilePage { get => _profilePage; set => _profilePage = value; }

        public OptionsTab(ProfilePage profilePage)
        {
            InitializeComponent();
            ProfilePage = profilePage;
        }


        private void BtnMyAccounts(object sender, RoutedEventArgs e)
        {
            ProfilePage.SetMainFrame(new MyAccounsPage(_profilePage));
        }

        private void BtnPay(object sender, RoutedEventArgs e)
        {
            ProfilePage.SetMainFrame(new PayPage(_profilePage));
        }

        private void BtnCreateAccount(object sender, RoutedEventArgs e)
        {
            ProfilePage.SetMainFrame(new CreateAccount(_profilePage));
        }

        private void BtnMyPayments(object sender, RoutedEventArgs e)
        {
            ProfilePage.SetMainFrame(new MyPayments(_profilePage));
        }
    }
}
