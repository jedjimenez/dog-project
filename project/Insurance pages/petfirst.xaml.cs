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
    public partial class petfirst : ContentPage
    {
        public petfirst()
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
            costper.Text = "Rates range from $16 - $100, depending on your chosen plan.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "You have a co-pay of 10% - 30% after your deductible.";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Deductible rates are $50 - $500 per incident.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "Your pet must be at least 8 weeks old to enroll.";


        }
    }
}