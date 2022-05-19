using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Styling;
using Avalonia;
using System;
using System.Windows.Input;
using Avalonia.Interactivity;
using Avalonia.Controls.ApplicationLifetimes;
using AniFull.ClientApp.Models;

namespace AniFull.ClientApp.Views
{
    public partial class MainWindow : Window, IStyleable
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExpandWindow_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized) WindowState = WindowState.Normal;
            else WindowState = WindowState.Maximized;
        }

        private void CollapseWindow_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current!.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
            {
                desktopLifetime.Shutdown();
            }
        }

        public LoginPage loginpage = new LoginPage();
        
    }
}
