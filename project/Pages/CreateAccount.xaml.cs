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

namespace project.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAccount : ContentPage
	{
		public CreateAccount ()
		{
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
		}

        public void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                UserName = UserNameEntry.Text,
                Password = PwsEntry.Text,
                Email = EmailEntry.Text,
                PhoneNumber = PhoneEntry.Text,


            };
            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulations!", "User registration successfull", "Yes", "Cancel");

                if (result)
                    await Navigation.PushAsync(new LoginPage());

            }


            );
        }

        public async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}