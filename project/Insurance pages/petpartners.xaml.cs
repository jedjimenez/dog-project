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
    public partial class petpartners : ContentPage
    {
        public petpartners()
        {
                /*
                 * This information displays the cost per month, coverage, deductible and age limit for the specific insurance
                 * most of the data I have used to get this information came from this site as a source:
                 * https://www.petinsurancereview.com/dog-insurance
                 * 
                 * This site basically compared all the insurances that I picked and I used data from the site in these .xaml.cs files to 
                 * procure the information
                 */
            InitializeComponent();
            CostPer.Text = "Monthly Cost\r\n";
            space1.Text = "\r\n";
            costper.Text = "Cost per month ranges from $5 - $90 depending on coverage options chosen.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "You have to pay a co-pay of 20% after your annual deductible. The pay-out amount is based on your vet bill.";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Choose from a $100 - $1000 annual deductible.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "Your pet must be at least 8 weeks to enroll with no upper age limit.";


        }
    }
}