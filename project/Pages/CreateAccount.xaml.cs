using System;
using System.IO;
using SQLite;
using Xamarin.Forms; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.Table;
using Xamarin.Forms.Xaml;
using Android.OS;
using System.Diagnostics;

namespace project.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAccount : ContentPage
	{
        public static int state = 0;
		public CreateAccount ()
		{
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
		}

        public void Button_Clicked(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(UserNameEntry.Text)) || (string.IsNullOrEmpty(PwsEntry.Text)))
            {
                DisplayAlert("Error", "Please enter the username and the password", "Ok.");
            }
            else if (PwsEntry.Text != ConPwsEntry.Text)
            {
                DisplayAlert("Error", "The passwords do not match.", "Close");
            }
            else if (string.IsNullOrEmpty(EmailEntry.Text))
            {
                DisplayAlert("Error", "Please enter an email", "Ok");
            }
            else if (string.IsNullOrEmpty(NameEntry.Text))
            {
                DisplayAlert("Error", "Please enter a name", "Ok");
            }
            else
            {
                var dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbpath);
                db.CreateTable<RegUserTable>();
                var user = db.Query<RegUserTable>("select * from RegUserTable");
                string name = NameEntry.Text;
                string uName = UserNameEntry.Text;
                string email = EmailEntry.Text;
                System.Diagnostics.Debug.WriteLine(email);
                bool flag = true;
                for (int i = 0; i < user.Count; i++)
                {
                    if (uName == user[i].UserName)
                    {
                        DisplayAlert("Error", "The username is not available", "Ok");
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    var item = new RegUserTable()
                    {
                        UserName = UserNameEntry.Text,
                        Password = PwsEntry.Text,
                        Email = email,
                        PhoneNumber = PhoneEntry.Text,
                        Name = NameEntry.Text


                    };
                    db.Insert(item);
                    Device.BeginInvokeOnMainThread(async () =>
                    {

                        var result = await this.DisplayAlert("Congratulations!", "User registration successfull", "Accept", "Retry");

                        if (result)
                        {
                            await Navigation.PushAsync(new LoginPage(uName, name, email));
                        }

                    }


                );

                }
            }
        }
        public async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage(null,null,null));
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            if(state == 0)
            {
                var result = await DisplayAlert("Instructions.", "Please enter your information to register for our app.", "Ok", "Continue as guest");
                state = 1;
                if (!result)
                {
                    Navigation.PushAsync(new Page4("guest", "guest", "Unknown"));
                }
            }
        }
    }
}