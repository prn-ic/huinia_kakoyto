using AniFull.ClientAppOnWPF.Core;
using AniFull.ClientAppOnWPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;

namespace AniFull.ClientAppOnWPF.MVVM.ViewModel
{
    class HomeViewModel: ObservableObject
    {
        public ObservableCollection<Videos> Video { get; set; }

        public static ObservableCollection<Videos> FindingVideo { get; set; }

        private string _name;

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }


        public HomeViewModel()
        {
            Name = "Хуесос";
            Video = new ObservableCollection<Videos>();
            FindingVideo = new ObservableCollection<Videos>();
            GetVideos();
        }

        private async void GetVideos()
        {
            var client = App.httpClient;
            var response = await client.GetAsync("https://localhost:7006/api/Videos");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadFromJsonAsync<IEnumerable<Videos>>(new JsonSerializerOptions(JsonSerializerDefaults.Web));
                foreach (var item in content)
                {
                    Video.Add(item);
                }
            }
        }

       
    }
}
