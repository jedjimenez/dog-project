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
    public partial class petpremium : ContentPage
    {
        public petpremium()
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
            costper.Text = "Monthly rates vary from $12-$80 depending on the chosen plan.";

            Coverage.Text = "Coverage\r\n";
            space2.Text = "\r\n";
            coverage.Text = "Coverage gives you a choice for either an accidents only or a total coverage plan. The total coverage plan covers accidents and illnesses. The accident only plan" +
                " does have allowances for alternative therapies. Both plans offer a wellness plan as an extra option. ";

            Deductible.Text = "Deductible\r\n";
            space3.Text = "\r\n";
            deductible.Text = "Deductible options include $100, $250 or $500, annually.";

            Age.Text = "Age Limit\r\n";
            space4.Text = "\r\n";
            age.Text = "Pets must be at least 8 weeks old to enroll. There is no upper age limit.";
        }
    }
}