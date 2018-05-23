using MahApps.Metro.Controls;
using System.Windows.Controls;
using WpfApp.Pages.ProfileWindow;

namespace WpfApp
{
    public partial class ProfilePage : MetroWindow
    {
        private int id = -1;
        private int accountId = -1;
        private TopTab TopTab = null;

        public ProfilePage(int id)
        {
            InitializeComponent();
            Id = id;
            TopTab = new TopTab(this);
            topTab.Content = TopTab;
            optionsTab.Content = new OptionsTab(this);
            helpTab.Content = new BannerTab();
            mainFrame.Content = new PayPage(this);

        }
        public int Id { get => id; set => id = value; }

        public int AccountId { get => accountId; set => accountId = value; }

        public void SetMainFrame(Page page)
        {
            mainFrame.Content = page;
        }

        public void SetAccountId(int id)
        {
            AccountId = id;
            TopTab.SetAccountId(id);
        }

    }
}
