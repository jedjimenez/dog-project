using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using project.Models;
using Rand.Model;
using System.Collections.ObjectModel;
using project.Insurance_pages;


namespace project.Pages
{
    public class Insurance
    {
        public string Name { get; set; }       //data binding insurance name from xaml 
        public bool sight { get; set; }
        public string overview { get; set; }
        public string about { get; set; }
                 
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        private Insurance overwritten_ins;

        public ObservableCollection<Insurance> ins_list { get; set; }
        public Page5()
        {
            InitializeComponent();
            ret_ins();
        }

        public void ret_ins()   //retrieves insurance
        {
            ins_list = new ObservableCollection<Insurance>()
            {
                new Insurance()
                {
                    Name = "Trupanion",
                    sight = false,
                    about = "The Trupanion team has been taking care of pet owners for over a decade by offering simple, fair, and affordable pet insurance." +
                    " We want to help take care of your pet, too, and know pet owners want to work with companies that mirror their own goals and passions. " +
                    "Learn more about us here – we know you’ll like what you see!",
                    overview = "Learn more about Trupanion by clicking the 'READ MORE' button",
                                                        
                },
                new Insurance()
                {
                    Name = "Nationwide",
                    sight = false,
                    about = "With nearly four decades of experience protecting dogs, we know that coverage counts. " +
                    "That's why we offer the best coverage for the best value. ",
                    overview = "Learn more about Nationwide Pet insurance by clicking the 'READ MORE' button",
                   

        },
                new Insurance()
                {
                    Name = "Embrace",
                    sight = false,
                    about = "From puppyhood to the senior years, pet medical insurance from Embrace will be there through it all." +
                    " Protect your newest family member or loyal friend with an Embrace Pet Insurance plan.",
                    overview = "Learn more about Embrace by clicking the 'READ MORE' button",
                    
                },
                new Insurance()
                {
                    Name = "HealthyPaws",
                    sight = false,
                    about = "With Healthy Paws, you can give your pet the best medical care possible. " +
                    "The Healthy Paws top-rated cat insurance & dog insurance plans cover accidents, illnesses, cancer, emergency care, genetic conditions, and" +
                    " alternative care such as chiropractic care and acupuncture.",
                    overview = "Learn more about HealthyPaws by clicking the 'READ MORE' button",
                    

                },
                new Insurance()
                {
                    Name = "ASPCA",
                    sight = false,
                    about = "Founded in 1997, we’re one of the original pet insurance providers in the U.S. " +
                    "In 2006, as part of a strategic partnership with the American Society for the Prevention of Cruelty to Animals® (ASPCA®)," +
                    " we introduced our most recognizable and impactful brand, ASPCA® Pet Health Insurance. In the past 20 years, through our insurance underwriters," +
                    " we’ve insured more than 400,000 dogs and cats, processing more than 1.6 million claims.",
                    overview = "Learn more about ASPCA by clicking the 'READ MORE' button",
                    

                },
                new Insurance()     //7
                {
                    Name = "Petplan",
                    sight = false,
                    about = "Our mission is to ensure happier, healthier lives for pets and peace of mind for their people by providing the most comprehensive pet insurance coverage in one simple plan",
                    overview = "Learn more about Petplan by clicking the 'READ MORE' button",
                    

                },
                new Insurance()
                {
                    Name = "Petfirst",
                    sight = false,
                    about = " It’s our mission to imbue our product with financial and emotional value for every customer, associate, and partner. " +
                    "We think big and dream bigger, but our number one priority is doing right by you and your pet.",
                    overview = "Learn more about Petfirst by clicking the 'READ MORE' button",
                    
                },
                new Insurance()
                {
                    Name = "American Kennel Club - Pet Insurance",
                    sight = false,
                    about = "Founded in 1884, the AKC is the recognized and trusted expert in breed, health, and training information for dogs." +
                    " AKC actively advocates for responsible dog ownership and is dedicated to advancing dog sports.",
                    overview = "Learn more about the American Kennel Club - Pet Insurance by clicking the 'READ MORE' button",
                    


                },
                new Insurance()
                {
                    Name = "Figo Pet Insurance",
                    sight = false,
                    about = "Pet insurance can make a huge difference in the lives of you and your pet. We believe everyone should have it, even if it’s not from us.",
                    overview = "Learn more about Figo Pet Insurance by clicking the 'READ MORE' button",
                  

                },
                new Insurance()
                {
                    Name = "24 Pet Watch",
                    sight = false,
                    about = "As a leading provider of pet insurance and pet protection services, 24PetWatch® takes the well-being of your pet seriously. " +
                    "That means you’re free to enjoy all the fun parts about being a pet owner and leave the little details to us. Well, besides the poop scooping—that’s all you.", 
                    overview = "Learn more about 24 Pet Watch by clicking the 'READ MORE' button",
                    

                },
                new Insurance()
                {
                    Name = "Hartville",
                    sight = false,
                    about ="We defined, and continue to redefine, what quality coverage and service are with new and improved plans that include more of what our customers want and need.",
                    overview = "Learn more about Hartville by clicking the 'READ MORE' button",
                    
                },
                new Insurance()
                {
                    Name = "Petpartners",
                    sight = false,
                    about = "Pet Partners, formerly known as the Delta Society, is the national leader in demonstrating and promoting the health and wellness benefits of animal-assisted interventions",
                    overview = "Learn more about Petpartners by clicking the 'READ MORE' button",
                    

                },
                 new Insurance()
                {
                    Name = "Prudent Pet",
                    sight = false,
                    about = "Our company goes above and beyond to offer flexible options like preventive care that covers annual exams, dental cleanings, heartworm and flea prevention. " +
                    "You won’t find those options with other dog pet insurance providers.",
                    overview = "Learn more about Prudent Pet by clicking the 'READ MORE' button",
                    
                },
                new Insurance()
                {
                    Name = "Pet Premium",
                    sight = false,
                    about = "We are building a fully integrated health platform because we understand that the best thing we can do for you is to help keep your pet healthy and live a long, happy life.",
                    overview = "Learn more about Pet Premium by clicking the 'READ MORE' button",
                    

                },
                new Insurance()
                {
                    Name = "Spot",          //15th Name and last in the list 
                    sight = false,
                    about = "We're committed to helping pets lead longer, healthier lives by providing health insurance with first-class service and high quality coverage.",
                    overview = "Learn more about Spot Insurance Company by clicking the 'READ MORE' button",
               
                },

            };
            I_list.ItemsSource = ins_list;
            
        }


        public void I_list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var info = e.Item as Insurance;            //after tapping the specific cell 'e' will receive data from that specific cell and pass it as an Insurance object
            DisplayHidden(info);
        }

        /*
         * These two functions DisplayHidden(Insurance info) and initAgain(Insurance info) 
         * were followed pretty closely to this tutorial:
         * https://www.youtube.com/watch?v=GG10QPrRC3w
         * where the developer explains how a list view expandable item works in xamarin 
         */
        private void DisplayHidden(Insurance info)
        {
            if(overwritten_ins == info)
            {
                info.sight = !info.sight;
                initAgain(info);
            }
            else
            {
                if(overwritten_ins != null)
                {
                    overwritten_ins.sight = false;
                    initAgain(overwritten_ins);
                }
                info.sight = true;
                initAgain(info);
            }
            overwritten_ins = info;
        }

        private void initAgain(Insurance info)
        {
            var i = ins_list.IndexOf(info);
            ins_list.Remove(info);
            ins_list.Insert(i, info);
        }

        async void ContentPage_Appearing(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(string.Format("https://dog.ceo/api/breeds/image/random"));

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri
            };

            HttpResponseMessage response = await client.SendAsync(request);
            random_pic R = null;

            if (response.IsSuccessStatusCode)
            {

                var content = await response.Content.ReadAsStringAsync();
                R = random_pic.FromJson(content);

                img.Source = R.Message;               
            }


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var read = (Insurance)((Button)sender).CommandParameter;

            if(read.Name == "Trupanion" )
            {
                Navigation.PushAsync(new trupanion());
            }
            else if(read.Name == "Nationwide")
            {
                Navigation.PushAsync(new nationwide());
            }
            else if (read.Name == "Embrace")
            {
                Navigation.PushAsync(new embrace());
            }
            else if (read.Name == "HealthyPaws")
            {
                Navigation.PushAsync(new healthypaws());
            }
            else if (read.Name == "ASPCA")
            {
                Navigation.PushAsync(new aspca());
            }
            else if (read.Name == "Petplan")
            {
                Navigation.PushAsync(new petplan());
            }
            else if (read.Name == "Petfirst")
            {
                Navigation.PushAsync(new petfirst());
            }
            else if (read.Name == "American Kennel Club - Pet Insurance")
            {
                Navigation.PushAsync(new kennel());
            }
            else if (read.Name == "Figo Pet Insurance")
            {
                Navigation.PushAsync(new figo());
            }
            else if (read.Name == "24 Pet Watch")
            {
                Navigation.PushAsync(new petwatch());
            }
            else if (read.Name == "Hartville")
            {
                Navigation.PushAsync(new hartville());
            }
            else if (read.Name == "Petpartners")
            {
                Navigation.PushAsync(new petpartners());
            }
            else if (read.Name == "Prudent Pet")
            {
                Navigation.PushAsync(new prudentpet());
            }
            else if (read.Name == "Pet Premium")
            {
                Navigation.PushAsync(new petpremium());
            }
            else if (read.Name == "Spot")
            {
                Navigation.PushAsync(new spot());
            }
          
        }
    }
}