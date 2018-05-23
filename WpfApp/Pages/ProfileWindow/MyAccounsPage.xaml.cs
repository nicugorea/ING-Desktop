using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WpfApp.INGService;


namespace WpfApp.Pages.ProfileWindow
{
    public partial class MyAccounsPage : Page
    {
        private ProfilePage _profilePage = null;

        public MyAccounsPage(ProfilePage profilePage)
        {
            InitializeComponent();
            ProfilePage = profilePage;
            SetUpDataGrid();
        }

        public ProfilePage ProfilePage { get => _profilePage; set => _profilePage = value; }

        private void BtnCreateAccount(object sender, RoutedEventArgs e)
        {
            ProfilePage.SetMainFrame(new CreateAccount(_profilePage));
        }

        class AccountData {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Balance { get; set; }
        }
        
        void SetUpDataGrid()
        {
            var accounts = DatabaseContext.Instance.ServiceClient.GetAccounts(ProfilePage.Id);
            List<AccountData> accountsData = new List<AccountData>();
            foreach (Account account in accounts)
            {
                var accountData = new AccountData {
                    Id = account.id_account,
                    Name=account.name,
                    Balance = account.balance};
                accountsData.Add(accountData);                
            }
            datagridAccounts.ItemsSource = accountsData;
        }

        private void BtnSelectAccount(object sender, RoutedEventArgs e)
        {
            var user = (AccountData)datagridAccounts.SelectedItem;
            if (user == null)
                return;
            ProfilePage.SetAccountId(user.Id);
        }
    }
}
