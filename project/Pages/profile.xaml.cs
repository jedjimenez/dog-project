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
    public partial class profile : ContentPage
    {
        public profile(string userName, string Name, string Email)
        {
            InitializeComponent();
            LName.Text = "Name: " + Name;
            LuName.Text = "Username: " + userName;
            LEmail.Text = "Email: " + Email;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}