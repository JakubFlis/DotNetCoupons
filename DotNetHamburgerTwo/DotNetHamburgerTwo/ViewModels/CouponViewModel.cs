using System.ComponentModel;
using System.Runtime.CompilerServices;
using DotNetHamburgerTwo.Models;

namespace DotNetHamburgerTwo.ViewModels
{
    public class CouponViewModel : INotifyPropertyChanged
    {
        private readonly Coupon _coupon;
        public event PropertyChangedEventHandler PropertyChanged;

        public CouponViewModel(Coupon coupon)
        {
            _coupon = coupon;
        }

        public string Title
        {
            get { return _coupon?.Title; }
            set
            {
                if (_coupon != null)
                {
                    _coupon.Title = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
                }
            }
        }

        public string Description
        {
            get { return _coupon?.Description; }
            set
            {
                if (_coupon != null)
                {
                    _coupon.Description = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                }
            }
        }

        public string ImageUrl
        {
            get { return _coupon?.ImageUrl; }
            set
            {
                if (_coupon != null)
                {
                    _coupon.ImageUrl = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ImageUrl"));
                }
            }
        }

        public string Category
        {
            get { return _coupon?.Category; }
            set
            {
                if (_coupon != null)
                {
                    _coupon.Title = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                }
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
