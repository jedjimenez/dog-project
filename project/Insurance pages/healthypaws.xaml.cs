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
    public partial class healthypaws : ContentPage
    {
        public healthypaws()
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
            costper.Text = "Monthly rates range from $15 - $90, depending on breed, zip code, age of pet and choice of deductible and co-pay.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "One option covers accidents, illnesses, cancer, emergency care, genetic conditions, alternative care and more. You have the choice between a co-pay of 10%, 20%, 30% or 50%." +
                " Coverage is based on vet bill.";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Four options for annual deductible include: $100, $250, $500 or $750. Determined based on age of the pet.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "Your pet must be at least 8 weeks old and under 14 years old at time of enrollment. Once enrolled pet can stay insured regardless of age.";
        }
    }
}