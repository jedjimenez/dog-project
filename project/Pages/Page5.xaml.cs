using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using project.Models;

namespace project.Pages
{
  public class pics
    {
        public Uri GetUri { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();

        }

     

        async void ContentPage_Appearing(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(string.Format("https://dog.ceo/api/breeds/image/random"));

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri
            };

            HttpResponseMessage response = await client.SendAsync(request);
            random_picture R = null;

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStreamAsync();
                

            }
        }
    }
}