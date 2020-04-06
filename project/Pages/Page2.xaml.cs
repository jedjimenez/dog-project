using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Net.Http;
using project.Models;

namespace project.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private static string PlaceAPIkey = "AIzaSyAOPcZFynkveO6OXz6y8uN4HTrjBe4qUwE";
        private async void displayButton_Clicked(object sender, EventArgs e)
        {
            string link = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=33.493401,-117.148788&radius=1500&type=restaurants&keyword=burgers&key=" + PlaceAPIkey;
            HttpClient client = new HttpClient();
            var uri = new Uri(link);
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = uri;
            HttpResponseMessage response = await client.SendAsync(request);

            Welcome places = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                places = Welcome.FromJson(content);
                Loc.Text = "Lat/long: " + places.Results[0].Geometry.Location.Lat + "/" + places.Results[0].Geometry.Location.Lng;

            }
        }
    }
}