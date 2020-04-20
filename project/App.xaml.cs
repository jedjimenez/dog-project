using project.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage(null,null,null));
            /*var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new NavigationPage(new Page1())); //creates a child page for tab
            tabbedPage.Children.Add(new Page2()); //creates a child page for tab
            tabbedPage.Children.Add(new Page3()); //creates a child page for tab
            tabbedPage.Children.Add(new Page4()); //creates the fourth page
            MainPage = new TabbedPage(); //my main page will be the tabbed page that will have the children attached to it
            MainPage = tabbedPage; //makes the main page the where the tabbs will be shown
*/
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
