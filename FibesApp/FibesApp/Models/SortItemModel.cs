using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.Models
{
    public class SortItemModel : BindableObject
    {
        public int Id { get; set; }
        public string SortButtonText { get; set; }
        public string CompositionButtonText { get; set; }
        public string BrandName { get; set; }

        private string _BtnTextColor = Common.AppColor.AppBlackColor;
        public string BtnTextColor
        {
            get { return _BtnTextColor; }
            set
            {
                if (_BtnTextColor != value)
                {
                    _BtnTextColor = value;
                    OnPropertyChanged("BtnTextColor");
                }
            }
        }
        private string _BtnBorderColor = Common.AppColor.AppBlackColor;
        public string BtnBorderColor
        {
            get { return _BtnBorderColor; }
            set
            {
                if (_BtnBorderColor != value)
                {
                    _BtnBorderColor = value;
                    OnPropertyChanged("BtnBorderColor");
                }
            }
        }
        private string _BtnBackgroundColor = Common.AppColor.AppBackgroundColor;
        public string BtnBackgroundColor
        {
            get { return _BtnBackgroundColor; }
            set
            {
                if (_BtnBackgroundColor != value)
                {
                    _BtnBackgroundColor = value;
                    OnPropertyChanged("BtnBackgroundColor");
                }
            }
        }

        private string _CompositionBtnBackgroundColor = Common.AppColor.AppBackgroundColor;
        public string CompositionBtnBackgroundColor
        {
            get { return _CompositionBtnBackgroundColor; }
            set
            {
                if (_CompositionBtnBackgroundColor != value)
                {
                    _CompositionBtnBackgroundColor = value;
                    OnPropertyChanged("CompositionBtnBackgroundColor");
                }
            }
        }

        private string _CompositionBtnTextColor = Common.AppColor.AppBlackColor;
        public string CompositionBtnTextColor
        {
            get { return _CompositionBtnTextColor; }
            set
            {
                if (_CompositionBtnTextColor != value)
                {
                    _CompositionBtnTextColor = value;
                    OnPropertyChanged("CompositionBtnTextColor");
                }
            }
        }

        private FontAttributes _BrandListFontAttribute = FontAttributes.None;
        public FontAttributes BrandListFontAttribute
        {
            get { return _BrandListFontAttribute; }
            set
            {
                if (_BrandListFontAttribute != value)
                {
                    _BrandListFontAttribute = value;
                    OnPropertyChanged("BrandListFontAttribute");
                }
            }
        }
        private string _CheckBoxBorderColor = Common.AppColor.AppGrayColor;
        public string CheckBoxBorderColor
        {
            get { return _CheckBoxBorderColor; }
            set
            {
                if (_CheckBoxBorderColor != value)
                {
                    _CheckBoxBorderColor = value;
                    OnPropertyChanged("CheckBoxBorderColor");
                }
            }
        }
    }
}
