using System;
using AniFull.ClientApp.Models;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using System.Windows.Input;

namespace AniFull.ClientApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            var os = Environment.OSVersion.Platform;

            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
            {
                ShowTaskBar = true;
            }
            else
            {
                ShowTaskBar = false;
            }
        }

        public bool _showTaskBar = false;

        public LoginPage loginpage = new LoginPage();
        public string Greeting => "Welcome to Avalonia!";

        public bool ShowTaskBar { 
            get
            {
                return _showTaskBar;
            }
            set
            {
                _showTaskBar = value;
            }
        }
        
    }
}
