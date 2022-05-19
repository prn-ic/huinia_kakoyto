using AniFull.ClientAppOnWPF.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniFull.ClientAppOnWPF.MVVM.ViewModel
{
    class MainViewModel: ObservableObject
    {
        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand HomeViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }

        private object? _currentView;
        public object CurrentView
        {
            get { return _currentView!; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            CurrentView = HomeVM;



            HomeViewCommand = new RelayCommand(x =>
            {
                CurrentView = null;
            });

        }

    }
}
