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
		public LoginPage ()
		{
            SetValue(NavigationPage.HasNavigationBarProperty, false);
			InitializeComponent ();
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
                App.Current.MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error!", "Wrong username or password. Enter again.", "Yes", "Cancel");

                    if (result)
                        await Navigation.PushAsync(new LoginPage());
                    else
                        await Navigation.PushAsync(new LoginPage());


                });
            }

        }

 
    }
}