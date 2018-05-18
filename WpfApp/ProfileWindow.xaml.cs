using MahApps.Metro.Controls;
using WpfApp.Pages.ProfileWindow;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : MetroWindow
    {
        private int _id = -1;
        public ProfilePage(int id)
        {
            InitializeComponent();
            _id = id;
            topTab.Content = new TopTab(this,_id);
            optionsTab.Content = new OptionsTab();
            helpTab.Content = new BannerTab();
        }
    }
}
