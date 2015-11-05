using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetHamburgerTwo.Models;
using DotNetHamburgerTwo.ViewModels;
using Xamarin.Forms;

namespace DotNetHamburgerTwo.Views
{
    public partial class CouponListPage : ContentPage
    {
        public CouponListPage()
        {
            InitializeComponent();

            BindingContext = new CouponListViewModel();
        }

        private void Coupons_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var coupon = e.SelectedItem as Coupon;

            if (coupon == null)
            {
                return;
            }

            Navigation.PushAsync(new CouponSummaryPage(new CouponViewModel(coupon)));

            Coupons.SelectedItem = null;
        }
    }
}
