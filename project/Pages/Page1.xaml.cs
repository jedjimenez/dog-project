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
        public static int state = 0;
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
                    text = "Golden Retriever", smallprint = "Intelligent and Friendly", image = "gold.jpeg"
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
                    text = "Chow Chow", smallprint = "Bright and Serious-Minded", image = "chowchow.jpg"
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
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                list.ItemsSource = list1;
            }
            else
            {
                list.ItemsSource = list1.Where(x => x.text.StartsWith(e.NewTextValue));
            }
        }

  
        void more_Clicked(object sender, EventArgs e)
        {
            var item1 = (MenuItem)sender;
            information item = (information)item1.CommandParameter;

            if (item.text == "American BullDog")
            {
                Navigation.PushAsync(new AmeriBull());
            }
            else if (item.text == "Australian Shepard")
            {
                Navigation.PushAsync(new AusShep());
            }
            else if (item.text == "French Bulldog")
            {
                Navigation.PushAsync(new FrenchB());
            }
            else if (item.text == "Golden Retriever")
            {
                Navigation.PushAsync(new GoldR());
            }
            else if (item.text == "Husky")
            {
                Navigation.PushAsync(new Husky());
            }
            else if (item.text == "Korean Jindo")
            {
                Navigation.PushAsync(new Kjindo());
            }
            else if (item.text == "Pitbull")
            {
                Navigation.PushAsync(new Pitbull());
            }
            else if (item.text == "Pomeranian")
            {
                Navigation.PushAsync(new PomDog());
            }
            else if (item.text == "Pug")
            {
                Navigation.PushAsync(new PugDog());
            }
            else if (item.text == "Shiba Inu")
            {
                Navigation.PushAsync(new Shiba());
            }
            else if (item.text == "Bichon Frise")
            {
                Navigation.PushAsync(new Bichon());
            }
            else if (item.text == "Border Collie")
            {
                Navigation.PushAsync(new Border());
            }
            else if (item.text == "Chihuahua")
            {
                Navigation.PushAsync(new CHi());
            }
            else if (item.text == "Chow Chow")
            {
                Navigation.PushAsync(new CHOW());
            }
            else if (item.text == "Corgi")
            {
                Navigation.PushAsync(new Corgi());
            }
            else if (item.text == "Dachshund")
            {
                Navigation.PushAsync(new Dach());
            }
            else if (item.text == "German Shepherd")
            {
                Navigation.PushAsync(new Germ());
            }
            else if (item.text == "Maltese")
            {
                Navigation.PushAsync(new Mal());
            }
            else if (item.text == "Samoyed")
            {
                Navigation.PushAsync(new Sam());
            }
            else if (item.text == "Shih Tzu")
            {
                Navigation.PushAsync(new Shi());
            }


        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            if(state == 0)
            {
                DisplayAlert("Instructions.", "Scroll and look for a specifc breed of dog or search for it. Hold the image and click the more button at the top for more info.", "Close.");
                state = 1;
            }
        }
    }
   
}