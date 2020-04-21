using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using project.Table;

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
            userName = uName;
            if (uName != "guest")
            {
                var dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbpath);
                var user = db.Query<RegUserTable>("select Name from RegUserTable where UserName = ?", uName);
                Name = user[0].Name;
                Email = user[0].Email;
                userLabel.Text = "Welcome " + Name;
            }
            else
            {
                Name = name;
                Email = email;
            }
            userLabel.Text = "Welcome " + Name;
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
            if(userName == "guest")
            {
                Navigation.PushAsync(new profile(userName, Name, Email));
            }
            else
            {
                Navigation.PushAsync(new profile(userName, null, null)) ;
            }
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            if (userName != "guest")
            {
                var dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbpath);
                var user = db.Query<RegUserTable>("select Name from RegUserTable where UserName = ?", userName);
                userLabel.Text = "Welcome " + user[0].Name;
            }
        }
    }
}