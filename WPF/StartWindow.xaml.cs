﻿using MahApps.Metro.Controls;
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
            loginFrame.Content = new LoginPage(this);
        }

        private void CreateNewAccount(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            return;
        }
    }
}
