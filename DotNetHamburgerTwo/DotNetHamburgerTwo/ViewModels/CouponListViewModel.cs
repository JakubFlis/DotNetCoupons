using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using DotNetHamburgerTwo.Models;
using DotNetHamburgerTwo.Views;

namespace DotNetHamburgerTwo.ViewModels
{
    public class CouponListViewModel
    {
        public ObservableCollection<Coupon> Coupons { get; set; }

        public CouponListViewModel()
        {
            Coupons = new ObservableCollection<Coupon>(GetCoupons());
        }

        private IEnumerable<Coupon> GetCoupons()
        {
            var assembly = typeof(CouponListPage).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("DotNetHamburgerTwo.coupons.xml");
            string text;

            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            var doc = XDocument.Parse(text);
            var coupons = (from item in doc.Descendants("item")
                           select new Coupon
                           {
                               Title = item.Element("title")?.Value,
                               Category = item.Element("category")?.Value,
                               ImageUrl = item.Element("thumbnail")?.Value,
                               Description = item.Element("description")?.Value
                           }).ToList();

            return coupons;
        }
    }
}
