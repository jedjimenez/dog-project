using Android.OS;
using project.Table;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using Android.App.Admin;

namespace project.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class profile : ContentPage
    {
        public static string currentuserName;
        public profile(string userName, string Name, string Email)
        {

            InitializeComponent();
            if(userName == "guest")
            {
                B1.IsVisible = false;
                B2.IsVisible = true;
            }
            else
            {
                B1.IsVisible = true;
                B2.IsVisible = false;
                var dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbpath);
                var user = db.Query<RegUserTable>("select * from RegUserTable where UserName = ?", userName);
                Name = user[0].Name;
                currentuserName = userName;
                Email = user[0].Email;
            }
            LName.Text = "Name: " + Name;
            LuName.Text = "Username: " + userName;
            LEmail.Text = "Email: " + Email;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var user = db.Query<RegUserTable>("select * from RegUserTable where UserName = ?", currentuserName);
            E1.IsVisible = true;
            E2.IsVisible = true;
            B3.IsVisible = true;
            E1.Text = user[0].Name;
            E2.Text = user[0].Email;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateAccount());
        }

        private void B2_Clicked(object sender, EventArgs e)
        {
            string name = E1.Text;
            string email = E2.Text;
            var dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.Query<RegUserTable>("update RegUserTable set Name = ? where UserName = ?", name, currentuserName);
            db.Query<RegUserTable>("update RegUserTable set Email = ? where UserName = ?", email, currentuserName);
            LName.Text = "Name: " + name;
            LEmail.Text = "Email: " + email;
            E1.IsVisible = false;
            E2.IsVisible = false;
            B3.IsVisible = false;
        }
    }
}