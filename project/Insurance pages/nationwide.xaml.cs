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
    public partial class nationwide : ContentPage
    {
        public nationwide()
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
            costper.Text = "Rates start at approximately $12 per month.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "Nationwide offers a variety of coverage plans. One of the most popular plans would be the 'Whole Pet with Wellness' plan. This plan offers 90% reimbursement" +
                " for accident, injury and wellness care.";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Annual deductibles range from $0 - $1000.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "No age limit for the 'Whole Pet with Wellness' plan. Other plans might have age restrictions.";


        }
    }
}