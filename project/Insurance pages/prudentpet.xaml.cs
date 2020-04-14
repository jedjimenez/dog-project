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
    public partial class prudentpet : ContentPage
    {
        public prudentpet()
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
            costper.Text = "Monthly rates start at $10 for accident only and $16 for accident & illness. Rates vary based on species, age, breed as well as your location.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "Coverage is based on the vet bill. Options for reimbursement are 90%, 80% or 70%.";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Prudent Pet lets the you choose a deductible that works best for you and your family. Deductible options include $100, $250 or $500 plans.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "At Prudent Pet there is no age limit except that your pet will need to be at least 8 weeks old to enroll.";


        }
    }
}