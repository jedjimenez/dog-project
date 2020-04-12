using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using project.Models;
//using Rand.Model;
using System.Collections.ObjectModel;


namespace project.Pages
{
    public class Insurance
    {
        public string Name { get; set; }       //data binding insurance name from xaml 
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        
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
                },
                new Insurance()
                {
                    Name = "Nationwide",
                },
                new Insurance()
                {
                    Name = "Embrace",
                },
                new Insurance()
                {
                    Name = "HealthyPaws",
                },
                new Insurance()
                {
                    Name = "ASPCA",
                },
                new Insurance()     //7
                {
                    Name = "Petplan",
                },
                new Insurance()
                {
                    Name = "Petfirst",
                },
                new Insurance()
                {
                    Name = "American Kennel Club - Pet Insurance",
                },new Insurance()
                {
                    Name = "Figo Pet Insurance",
                },
                new Insurance()
                {
                    Name = "24 Pet Watch",
                },
                new Insurance()
                {
                    Name = "Hartville",
                },
                new Insurance()
                {
                    Name = "Petpartners ",
                },
                 new Insurance()
                {
                    Name = "Prudent Pet",
                },
                new Insurance()
                {
                    Name = "Pet Premium",
                },
                new Insurance()
                {
                    Name = "Spot",          //15th Name and last in the list 
                },

            };
            I_list.ItemsSource = ins_list;
            
        }

        public void I_list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var insur = e.Item as Insurance;

        }
    }
}