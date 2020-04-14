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
    public partial class spot : ContentPage
    {
        public spot()
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
            costper.Text = "Rates start at $10 for accident only. For complete coverage, the rates start at $16. Rates vary based on species, age, breed, and location.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "Spot reimburses you up to 90% of those eligible vet bills. The rate is pre-selected by the customer: 90%, 80% or 70%.";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "The deductible for Spot can be $100, $250 or $500, annually.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "No upper age limits. Pets must be at least 8 weeks old to enroll.";

        }
    }
}