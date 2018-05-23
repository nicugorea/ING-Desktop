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
    
    public partial class MyPayments : Page
    {
        private ProfilePage _profilePage = null;

        public ProfilePage ProfilePage { get => _profilePage; set => _profilePage = value; }

        public MyPayments(ProfilePage profilePage)
        {
            InitializeComponent();
            ProfilePage = profilePage;
            SetUpDataGrids();

        }

        class SentPaymentsData
        {
            public int Id { get; set; }
            public int Reciever { get; set; }
            public string Name { get; set; }
            public decimal Balance { get; set; }
        }

        class RecievedPaymentsData
        {
            public int Id { get; set; }
            public int Sender { get; set; }
            public string Name { get; set; }
            public decimal Balance { get; set; }
        }

        void SetUpDataGrids()
        {
            var sentPayments = DatabaseContext.Instance.ServiceClient.GetSentPayments(ProfilePage.AccountId);
            List<SentPaymentsData> sentPaymentsData = new List<SentPaymentsData>();
            foreach (var payment in sentPayments)
            {
                var sentPaymentData = new SentPaymentsData
                {
                    Id = payment.id_payment,
                    Reciever = payment.id_reciever,
                    Name = payment.name,
                    Balance = payment.amount
                };
                sentPaymentsData.Add(sentPaymentData);
            }
            sentPaymentsDatagrid.ItemsSource = sentPaymentsData;

            var recievedPayments = DatabaseContext.Instance.ServiceClient.GetRecievedPayments(ProfilePage.AccountId);
            List<RecievedPaymentsData> recievedPaymentsData = new List<RecievedPaymentsData>();
            foreach (var payment in recievedPayments)
            {
                var recievedPaymentData = new RecievedPaymentsData
                {
                    Id = payment.id_payment,
                    Sender = payment.id_sender,
                    Name = payment.name,
                    Balance = payment.amount
                };
                recievedPaymentsData.Add(recievedPaymentData);
            }
            recievedPaymentsDatagrid.ItemsSource = recievedPaymentsData;




        }

    }
}
