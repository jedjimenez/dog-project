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
    public partial class figo : ContentPage
    {
        public figo()
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



            CostPer.Text = "Cost per Month\r\n";
            space1.Text = "\r\n";
            costper.Text = "Rates per month range from $9 - $135, depending on the chosen plan.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "Your reimbursement options mmight include 70%, 80% or 90%, the total reimbursement is based on your vet bill.";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Deductibles offered may be $100, $250, $500, $750, $1000 or $1500 annually. Deductibles offered are based upon your pets age and location.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "No upper age limit and your pet must be at least 8 weeks old to enroll.";


        }
    }
}