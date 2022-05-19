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
using System.Windows.Shapes;

namespace AniFull.ClientAppOnWPF
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private bool _loginError;

        public bool LoginError
        {
            get
            {
                return _loginError;
            }
            set
            {
                _loginError = value;
            }
        }

        private async void VerificationUser()
        {
            var client = App.httpClient;
            var response = await client.GetAsync("https://localhost:7006/api/User");
/*
            if (response.IsSuccessStatusCode)
            {

            }*/
        }

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void WindowMovement_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void MinimizeWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void VerificateUser_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
