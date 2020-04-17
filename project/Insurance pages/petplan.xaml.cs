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
    public partial class petplan : ContentPage
    {
        public petplan()
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
            costper.Text = "The cost per month purely depends on the plan that you have made with the following factors being: your dog's age, breed, location, annual coverage" +
                ", reimbursement level and annual deductible.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "You have a co-pay of 10%, 20% or 30% after your deductible. Complete sick visits, including exam fees, are covered. Comprehensive non-routine dental coverage for oral" +
                " disease and injuries are covered as standard policy with no dental condition limits.";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Annual deductible ranges from $250 - $1000. Also, per condition deductibles range from $250 - $2500";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "The age of your pet must be at least 6 weeks to enroll. No upper age limit for enrollments.";


        }
    }
}