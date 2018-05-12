using System.Windows.Controls;

namespace WPF.Pages
{
    public partial class LoginPage : Page
    {
        StartWindow _startWindow = null;
        public LoginPage(StartWindow startWindow)
        {
            InitializeComponent();
            _startWindow = startWindow;
        }
    }
}
