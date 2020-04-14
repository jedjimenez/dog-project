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
    public partial class embrace : ContentPage
    {
        public embrace()
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
            costper.Text = "Rates range from $13 - $100 per month, depending on your chosen plan.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "You have a co-pay of 10%, 20% or 30% after deductibe. Coverage amount is based off your actual vet bill ";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Annual Deductible ranges from $10 - $1000.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "Your pet must be at least 6 weeks old to enroll. Pets over 14 years of age are only covered for 'Accident Only' coverage. Once enrolled, pets can stay enrolled for life.";
        }
    }
}