using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project.Pages
{
    public class information
    {
        public string text { get; set; }
        public string smallprint { get; set; } 
        public string image { get; set; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public ObservableCollection<information> list1 { get; set; } //makes an observable collection for the cells
        public Page1()
        {
            InitializeComponent();
        }

    }
}