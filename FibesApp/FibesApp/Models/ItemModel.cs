using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.Models
{
    public class ItemModel : BindableObject
    {
        public int Id { get; set; } 
        public string ItemImage { get; set; }   
        public double ItemHeight { get; set; }

        private bool _IsLike ;
        public bool IsLike
        {
            get { return _IsLike; }
            set
            {
                if (_IsLike != value)
                {
                    _IsLike = value;
                    OnPropertyChanged("IsLike");
                }
            }
        }
        private bool _IsNotLike;
        public bool IsNotLike
        {
            get { return _IsNotLike; }
            set
            {
                if (_IsNotLike != value)
                {
                    _IsNotLike = value;
                    OnPropertyChanged("IsNotLike");
                }
            }
        }
    }
}
