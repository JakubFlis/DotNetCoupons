using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetHamburgerTwo.ViewModels;
using Xamarin.Forms;

namespace DotNetHamburgerTwo.Views
{
    public partial class CouponSummaryPage : ContentPage
    {
        public CouponSummaryPage(CouponViewModel couponViewModel)
        {
            InitializeComponent();

            BindingContext = couponViewModel;
        }
    }
}
