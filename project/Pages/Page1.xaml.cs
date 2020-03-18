using project.Dog_Pages;
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
            dog_data();
        }
        private void dog_data() //this will populate the observable collection
        {
            list1 = new ObservableCollection<information>()
            {
                new information()
                {
                    text = "AmericanBull Dog", smallprint = "Strong and Muscular" ,image = "ambull.jpeg"
                },
                new information()
                {
                    text = "Australian Shepard", smallprint = "Intelligent and Energetic", image = "ausshep.jpg"
                },
                new information()
                {
                    text = "French Bulldog", smallprint = "Excellent family dog", image = "french.jpg"
                },
                new information()
                {
                    text = "Golden Retriever", smallprint = "Intelligent and Friendly", image = "gold.jpg"
                },
                new information()
                {
                    text = "Husky",  smallprint = "Athletic and intelligent", image = "husky.jpg"
                },
                new information()
                {
                    text = "Korean Jindo", smallprint = "Loyal and Intelligent hunting dogs", image = "jindo.jpg"
                },
                new information()
                {
                    text = "Pitbull", smallprint = "Nanny dogs and Companion", image = "pitbull.jpg"
                },
                new information()
                {
                    text = "Pomeranian",smallprint = "Small and Compact", image = "pom.jpg"
                },
                new information()
                {
                    text = "Pug",smallprint = "Sturdy and Funny", image = "pug.jpg"
                },
                new information()
                {
                    text = "Shiba Inu", smallprint = "Hunter and companion", image = "shiba.jpg"
                }
            };
            list.ItemsSource = list1;
        }

        private async void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItemIndex == 0)
            {
                await Navigation.PushAsync(new AmeriBull());
            }
            else if(e.SelectedItemIndex == 1)
            {
                await Navigation.PushAsync(new AusShep());
            }
        }
    }
   
}