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
                    text = "American BullDog", smallprint = "Strong and Muscular" ,image = "ambull.jpeg"
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
                },
                new information()
                {
                    text = "Bichon Frise", smallprint = "Playful and Curious", image = "bichon.jpg"
                },
                new information()
                {
                    text = "Border Collie", smallprint = "Smart and Agile", image = "border.jpg"
                },
                new information()
                {
                    text = "Chihuahua", smallprint = "Small and Fierce", image = "chihuahua.jpg"
                },
                new information()
                {
                    text = "ChowChow", smallprint = "Bright and Serious-Minded", image = "chowchow.jpg"
                },
                new information()
                {
                    text = "Corgi", smallprint = "Smart and Affectionate", image = "corgi.jpg"
                },
                new information()
                {
                    text = "Dachshund", smallprint = "Friendly and Curious", image = "dachshund.jpg"
                },
                new information()
                {
                    text = "German Shepherd", smallprint = "Smart and Friendly", image = "german.jpg"
                },
                new information()
                {
                    text = "Maltese", smallprint = "Small and Firendly", image = "maltese.jpg"
                },
                new information()
                {
                    text = "Samoyed", smallprint = "Gentle and Firendly", image = "samoyed.jpg"
                },
                new information()
                {
                    text = "Shih Tzu", smallprint = "Playful and Affectionate", image = "shihtzu.jpg"
                }
            };
            list.ItemsSource = list1;
        }

        private async void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItemIndex == 0)
            {
                await Navigation.PushAsync(new AmeriBull());
            }
            else if (e.SelectedItemIndex == 1)
            {
                await Navigation.PushAsync(new AusShep());
            }
            else if (e.SelectedItemIndex == 2)
            {
                await Navigation.PushAsync(new FrenchB());
            }
            else if (e.SelectedItemIndex == 3)
            {
                await Navigation.PushAsync(new GoldR());
            }
            else if (e.SelectedItemIndex == 4)
            {
                await Navigation.PushAsync(new Husky());
            }
            else if (e.SelectedItemIndex == 5)
            {
                await Navigation.PushAsync(new Kjindo());
            }
            else if (e.SelectedItemIndex == 6)
            {
                await Navigation.PushAsync(new Pitbull());
            }
            else if (e.SelectedItemIndex == 7)
            {
                await Navigation.PushAsync(new PomDog());
            }
            else if (e.SelectedItemIndex == 8)
            {
                await Navigation.PushAsync(new PugDog());
            }
            else if (e.SelectedItemIndex == 9)
            {
                await Navigation.PushAsync(new Shiba());
            }
            else if (e.SelectedItemIndex == 10)
            {
                await Navigation.PushAsync(new Bichon());
            }
            else if (e.SelectedItemIndex == 11)
            {
                await Navigation.PushAsync(new Border());
            }
            else if (e.SelectedItemIndex == 12)
            {
                await Navigation.PushAsync(new CHi());
            }
            else if (e.SelectedItemIndex == 13)
            {
                await Navigation.PushAsync(new CHOW());
            }
            else if (e.SelectedItemIndex == 14)
            {
                await Navigation.PushAsync(new Corgi());
            }
            else if (e.SelectedItemIndex == 15)
            {
                await Navigation.PushAsync(new Dach());
            }
            else if (e.SelectedItemIndex == 16)
            {
                await Navigation.PushAsync(new Germ());
            }
            else if (e.SelectedItemIndex == 17)
            {
                await Navigation.PushAsync(new Mal());
            }
            else if (e.SelectedItemIndex == 18)
            {
                await Navigation.PushAsync(new Sam());
            }
            else if (e.SelectedItemIndex == 19)
            {
                await Navigation.PushAsync(new Shi());
            }
        }

        private void more_Clicked(object sender, EventArgs e)
        {
 
        }
    }
   
}