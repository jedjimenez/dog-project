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
using Xamarin.Forms.Maps;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Position = Xamarin.Forms.Maps.Position;
using Post = Plugin.Geolocator.Abstractions.Position;


namespace project.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class searchLocations
    {
        public string locationName { get; set; }
    }
    public partial class Page2 : ContentPage
    {
        public static int state = 0;
        public static Welcome places = null;
        public ObservableCollection<searchLocations> placesLocations { get; set; }
        public Page2()
        {
            InitializeComponent();
            InitMap();
        }

        public async void InitMap()
        {
            Post position = null;
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 100;
            position = await locator.GetLastKnownLocationAsync();
            string lat = position.Latitude.ToString();
            string lon = position.Longitude.ToString();
            double l = Convert.ToDouble(lat);
            double longit = Convert.ToDouble(lon);
            
            var request = new GeolocationRequest(GeolocationAccuracy.Medium);
            var myLocation = await Geolocation.GetLocationAsync(request);
           
            myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(l, longit), Distance.FromMiles(1)));
        }

        private static string PlaceAPIkey = "AIzaSyAPIW2MXoc0ciHKDCqO5ZuGLfH6G3JKJos";
        private async void displayButton_Clicked(object sender, EventArgs e)
        {
            Post position = null;
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 100;
            position = await locator.GetLastKnownLocationAsync();
            double lat = position.Latitude;
            double lon = position.Longitude;
            string keyword = E1.Text;
            string link = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + lat + "," + lon + "&radius=5000&keyword=" + keyword + "&key=" + PlaceAPIkey;
            Debug.WriteLine(link);
            HttpClient client = new HttpClient();
            var uri = new Uri(link);
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = uri;
            HttpResponseMessage response = await client.SendAsync(request);


            if (response.IsSuccessStatusCode)
            {
                myMap.Pins.Clear();
                myStackLayout.HeightRequest = 250;
                var content = await response.Content.ReadAsStringAsync();
                places = Welcome.FromJson(content);
                setListView();

            }

        }

        public void setListView()
        {
            var placesList = new ObservableCollection<searchLocations>();
            for (int i = 0; i < 4; i++)
            {
                if (places.Results[i] != null)
                {
                    var loc = new searchLocations()
                    {
                        locationName = places.Results[i].Name
                    };
                    placesList.Add(loc);
                }
            }
            myListView.ItemsSource = placesList;
        }
        private void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var pin = new Pin();
            pin.Type = PinType.Place;
            int item = e.SelectedItemIndex;
            if (item == 0)
            {
                pin.Position = new Position(places.Results[0].Geometry.Location.Lat, places.Results[0].Geometry.Location.Lng);
                pin.Label = places.Results[0].Name;
                myMap.Pins.Add(pin);
                myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(places.Results[0].Geometry.Location.Lat, places.Results[0].Geometry.Location.Lng), Distance.FromMiles(1)));
            }

            else if (item == 1)
            {
                pin.Position = new Position(places.Results[1].Geometry.Location.Lat, places.Results[1].Geometry.Location.Lng);
                pin.Label = places.Results[1].Name;
                myMap.Pins.Add(pin);
                myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(places.Results[1].Geometry.Location.Lat, places.Results[1].Geometry.Location.Lng), Distance.FromMiles(1)));
            }
            else if (item == 2)
            {
                pin.Position = new Position(places.Results[2].Geometry.Location.Lat, places.Results[2].Geometry.Location.Lng);
                myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(places.Results[2].Geometry.Location.Lat, places.Results[2].Geometry.Location.Lng), Distance.FromMiles(1)));
                pin.Label = places.Results[2].Name;
                myMap.Pins.Add(pin);
            }
            else if (item == 3)
            {
                pin.Position = new Position(places.Results[3].Geometry.Location.Lat, places.Results[3].Geometry.Location.Lng);
                pin.Label = places.Results[3].Name;
                myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(places.Results[3].Geometry.Location.Lat, places.Results[3].Geometry.Location.Lng), Distance.FromMiles(1)));
                myMap.Pins.Add(pin);
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            myStackLayout.HeightRequest = 100;
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            if (state == 0)
            {
                DisplayAlert("Instructions.", "Click on the box to search for a petstore. Click search after and choose a location from the dropdown to go to its location.", "Ok.");
                state = 1;
            }
        }
    }
}

/* comments
  #if __IOS__
            //Content
#endif
#if __ANDROID__
           //Content
#endif
*/

/*new ideas
 list view instead of picker for places.
 Gesture to pull search up
 grid to put stuff on top of each other using grid.rowspan
    */
