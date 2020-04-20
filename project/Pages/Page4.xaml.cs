using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public static string userName;
        public static string Name;
        public static string Email;
        public Page4(string uName, string name, string email)
        {
            InitializeComponent();
            userLabel.Text = "Welcome " + uName;
            userName = uName;
            Name = name;
            Email = email;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page5());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage(null,null,null));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new profile(userName, Name, Email));
        }
    }
}