using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static project.Pages.DogStores;

namespace project.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public static int state = 0;
        private ObservableCollection<GroupedByStores> list { get; set; }
        public Page3()
        {
            InitializeComponent();
            getStores();
        }

        private void getStores()
        {
            list = new ObservableCollection<GroupedByStores>();
            
            var PetStores = new GroupedByStores() { Title = "Pet Stores" };
            PetStores.Add(new DogStores() { id = 1, name = "Pet Smart", description = "where pets are family", img = "petsmart.jpg" });
            PetStores.Add(new DogStores() { id = 2, name = "Petco", description = "where the healthy pets go", img = "petco.jpg" });
            PetStores.Add(new DogStores() { id = 3, name = "Kahoots", description = "your family pet place", img = "kahoot.jpg" });
            list.Add(PetStores);

            var OnlineStore = new GroupedByStores() { Title = "Online Pet Retailers" };
            OnlineStore.Add(new DogStores() { id = 4, name = "Chewy", description = "online retailer of pet food and other pet products", img = "chewy.jpg" });
            OnlineStore.Add(new DogStores() { id = 5, name = "Amazon", description = "Work Hard. Have Fun", img = "amazon.png" });
            list.Add(OnlineStore);

            var Food = new GroupedByStores() { Title = "Food Brands" };
            Food.Add(new DogStores() { id = 6, name = "Fromm Family Pet Food", description = "four-star nutritionals", img = "fromm.png" });
            Food.Add(new DogStores() { id = 7, name = "Wellness Pet Food", description = "we believe in better nutrition", img = "wellness.png" });
            Food.Add(new DogStores() { id = 8, name = "Instinct The Raw Brand", description = "real food is raw", img = "instinct.png" });
            Food.Add(new DogStores() { id = 9, name = "Nature's Logic", description = "the way pet food should be", img = "natureslogic.jpg" });
            Food.Add(new DogStores() { id = 10, name = "Taste of the Wild", description = "based on your pet’s natural diet", img = "taste.png" });
            Food.Add(new DogStores() { id = 11, name = "Blue Buffalo", description = "love them like family; feed them like family", img = "blue.png" });
            Food.Add(new DogStores() { id = 12, name = "Canidae", description = "a healthier today for a longer tomorrow", img = "canidae.png" });
            Food.Add(new DogStores() { id = 13, name = "Orijen", description = "nourish as nature intended", img = "orijen.jpg" });
            Food.Add(new DogStores() { id = 14, name = "Diamond Pet Foods", description = "a passion for making quality food", img = "diamond.jpg" });
            Food.Add(new DogStores() { id = 15, name = "Nulo", description = "healthier together", img = "nulo.jpg" });
            Food.Add(new DogStores() { id = 16, name = "Nutro", description = "feed clean", img = "nutro.png" });
            list.Add(Food);
            Dogs.ItemsSource = list;
        }

        async void Dogs_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var select = (DogStores)e.Item;

            switch (select.id)
            {
                case 1:
                    Device.OpenUri(new Uri("https://www.petsmart.com/"));
                    break;
                case 2:
                    Device.OpenUri(new Uri("https://www.petco.com/shop/en/petcostore"));
                    break;
                case 3:
                    Device.OpenUri(new Uri("https://kahootsfeedandpet.com/collections/all"));
                    break;
                case 4:
                    Device.OpenUri(new Uri("https://www.chewy.com/"));
                    break;
                case 5:
                    Device.OpenUri(new Uri("https://www.amazon.com/s/ref=nb_sb_noss?url=search-alias%3Dpets&field-keywords="));
                    break;
                case 6:
                    Device.OpenUri(new Uri("https://frommfamily.com/"));
                    break;
                case 7:
                    Device.OpenUri(new Uri("https://www.wellnesspetfood.com/"));
                    break;
                case 8:
                    Device.OpenUri(new Uri("https://www.instinctpetfood.com/dogs"));
                    break;
                case 9:
                    Device.OpenUri(new Uri("https://www.natureslogic.com/"));
                    break;
                case 10:
                    Device.OpenUri(new Uri("https://www.tasteofthewildpetfood.com/"));
                    break;
                case 11:
                    Device.OpenUri(new Uri("https://bluebuffalo.com/"));
                    break;
                case 12:
                    Device.OpenUri(new Uri("https://www.canidae.com/"));
                    break;
                case 13:
                    Device.OpenUri(new Uri("https://www.orijen.ca/us/"));
                    break;
                case 14:
                    Device.OpenUri(new Uri("https://www.diamondpet.com/"));
                    break;
                case 15:
                    Device.OpenUri(new Uri("https://nulo.com/s"));
                    break;
                case 16:
                    Device.OpenUri(new Uri("https://www.nutro.com/"));
                    break;
            }
            ((ListView)sender).SelectedItem = null;
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            if(state == 0)
            {
                DisplayAlert("Instructions.", "Scroll and tap on any store to be taken to its website.", "Close.");
                state = 1;
            }
        }
    }
}