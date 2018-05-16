using MahApps.Metro.Controls;
using System.Windows.Controls;
using WPF.Pages;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StartWindow : MetroWindow
    {
        public StartWindow()
        {
            InitializeComponent();
            mainFrame.Content = new LoginPage(this);
        }

        public void SetMainFrame(Page page)
        {
            mainFrame.Content = page;
        }
    }
}
