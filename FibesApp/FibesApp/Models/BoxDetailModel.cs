using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.Models
{
   public class BoxDetailModel : BindableObject
    {
        public int Id { get; set; }
        public string ProItemImage { get; set; }
        public string ProName { get; set; }
        public string ProBrand { get; set; }
        public string ProType { get; set; }
        public string ProStatus { get; set; }
        public int ProQuantity { get; set; }
        private int _ItemCount = 1;
        public int ItemCount
        {
            get { return _ItemCount; }
            set
            {
                if (_ItemCount != value)
                {
                    _ItemCount = value;
                    OnPropertyChanged("ItemCount");
                }
            }
        }

    }
}
