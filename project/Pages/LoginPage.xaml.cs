using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using project.Table;
using Xamarin.Forms.Xaml;

namespace project.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public static int state = 0;
        public static string uName;
        public static string Name;
        public static string Email;
        public LoginPage (string userName, string name, string email)
		{
            SetValue(NavigationPage.HasNavigationBarProperty, false);
			InitializeComponent ();
            uName = userName;
            Name = name;
            Email = email;
		}


        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateAccount());

        }
        
        public void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUserTable>().Where(u => u.UserName.Equals(UserNameEntry.Text) && u.Password.Equals(PwsEntry.Text)).FirstOrDefault();
            if (myquery != null)
            {
                uName = UserNameEntry.Text;
                App.Current.MainPage = new NavigationPage(new Page4(uName, Name, Email));
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await this.DisplayAlert("Error!", "Wrong username or password. Enter again.", "Close");
                    //await Navigation.PushAsync(new LoginPage());
                });
            }

        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            if (state == 0) 
            {
                var result = await DisplayAlert("Instructions.","Login or click the register button to make an account to use the app.","Ok.", "Continue as Guest");
                state = 1;
                if (!result)
                {
                    Navigation.PushAsync(new Page4("guest", "guest", "Unknown"));
                }
            } 
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4("guest", "guest", "Unknown"));
        }

    }
}