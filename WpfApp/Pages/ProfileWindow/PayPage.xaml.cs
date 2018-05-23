using System.Windows;
using WpfApp.INGService;
using System.Windows.Controls;
using System;

namespace WpfApp.Pages.ProfileWindow
{
    public partial class PayPage : Page
    {
        private ProfilePage _profilePage = null;

        public PayPage(ProfilePage profilePage)
        {
            InitializeComponent();
            _profilePage = profilePage;
        }

        private void BtnPay(object sender, RoutedEventArgs e)
        {
            decimal payAmmount = -1;
            int idReciever = -1;
            Int32.TryParse(inputIdReciever.Text, out idReciever);
            Decimal.TryParse(inputAmmount.Text, out payAmmount);

            var payment = new Payment
            {
                id_sender = _profilePage.AccountId,
                id_reciever = idReciever,
                amount = payAmmount,
                name = inputName.Text
            };

            DatabaseContext.Instance.ServiceClient.AddPayment(payment);
        }
    }
}
