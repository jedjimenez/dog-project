using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project.Insurance_pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class aspca : ContentPage
    {

        
        public aspca()
        {
            InitializeComponent();

            /*
             * This information displays the cost per month, coverage, deductible and age limit for the specific insurance
             * most of the data I have used to get this information came from this site as a source:
             * https://www.petinsurancereview.com/dog-insurance
             * 
             * This site basically compared all the insurances that I picked and I used data from the site in these .xaml.cs files to 
             * procure the information
             */



            CostPer.Text = "Monthly Cost\r\n";
            space1.Text = "\r\n";
            costper.Text = "Rates start at $10(accident only) or $16(complete coverage). Rates vary depending on age, species, breed, and location.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "Coverage services might include dental and therapy. The rate at which it is covered can be pre-picked by the customer from these three options: 70%, 80% or 90%." +
                " Although, you have to pay a co-pay of 10%, 20% or 30% after your deductible.";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Annual deductible options range from $250 - $1000. Per condition deductibles range from $250 - $2500.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "Your pet must be at least 6 weeks of age to enroll and no upper age limits for enrollment.";


        }
    }
}