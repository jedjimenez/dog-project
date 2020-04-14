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
    public partial class trupanion : ContentPage
    {
        public trupanion()
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
            costper.Text = "Monthly cost varies between a multitude of factors, some of these factors are your pet's breed, age of enrollment and gender. Monthly premiums do not rise for birthdays " +
                "or from claims.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "90% coverage for all new injuries and illnesses-once the deductible is met. Trupanion pays 90% of the remaining invoice. Trupanion has the ability to pay your veterinarian" +
                "directly and in as little as 5 minutes. Simply pay your portion at check-out and Trupanion works with your veterinarian directly to take care of the rest.";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Offers a flexible deductible from $0 - $1000. To fit any budget and can be raised or lowered at anytime. Trupanion's deductible offers a lifetime per condition deductible." +
                "This means that you pay a deductible only when your pet develops a new condition.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "Trupanion allows enrollment of your pet from birth until their 14th birthday. Once enrolled, pets stay insured regarless of age and coverage will not change.";





        }
    }
}