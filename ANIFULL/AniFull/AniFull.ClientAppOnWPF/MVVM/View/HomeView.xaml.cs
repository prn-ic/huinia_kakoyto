using AniFull.ClientAppOnWPF.MVVM.Model;
using AniFull.ClientAppOnWPF.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
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

namespace AniFull.ClientAppOnWPF.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        private HomeViewModel Home { get; set; } = new HomeViewModel();
        public HomeView()
        {
            this.Content = Home;
            InitializeComponent();
        }

        private void ShowFilters_Click(object sender, RoutedEventArgs e)
        {
            if (FilterPropertyMini.Visibility == Visibility.Hidden)
            {
                FilterPropertyMini.Visibility = Visibility.Visible;
            }
            else
            {
                FilterPropertyMini.Visibility = Visibility.Hidden;
            }
        }

        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchContent.Visibility = Visibility.Visible;
        }

        private void SearchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            SearchContent.Visibility = Visibility.Hidden;
        }

        private async void StartSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            HomeViewModel.FindingVideo.Clear();
            var client = App.httpClient;
            var response = await client.GetAsync("https://localhost:7006/api/Videos");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadFromJsonAsync<List<Videos>>(new JsonSerializerOptions(JsonSerializerDefaults.Web));
                foreach (var item in content)
                {
                    HomeViewModel.FindingVideo.Add(item);
                }
            }
        }
    }
}
