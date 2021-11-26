using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.Models;
using FibesApp.ViewModels.Home;
using FibesApp.ViewModels.PopUp;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilterItemView : PopupPage
    {
        //TODO : To Declare Local Variables Here 
        protected FilterItemViewModel FilterItemVM;
        FurnitureViewModel FunitureVM;

        public FilterItemView(FurnitureViewModel _funitureVM)
        {
            InitializeComponent(); 
            //To Change the color of Safearea in ios
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();            
            FilterItemVM = new FilterItemViewModel(this.Navigation);
            this.BindingContext = FilterItemVM;
            FunitureVM = _funitureVM;
            FilterItemVM.FunitureVM = _funitureVM;
        }

        #region Event Handler
        /// <summary>
        /// TODO : Clicked event for changing text and background colour...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortedItem(object sender, EventArgs e)
        {
            var item = (sender as Button).BindingContext as SortItemModel;
            if (item != null)
            {
                foreach (var SortedItem in FilterItemVM.SortList)
                {
                    if (SortedItem.Id == item.Id)
                    {
                        if (SortedItem.BtnTextColor == Common.AppColor.AppBlackColor)
                        {
                            SortedItem.BtnTextColor = Common.AppColor.AppBackgroundColor;
                            SortedItem.BtnBackgroundColor = Common.AppColor.AppDarkBlueColor;
                            SortedItem.BtnBorderColor = Common.AppColor.AppDarkBlueColor;
                        }
                        else
                        {
                            SortedItem.BtnTextColor = Common.AppColor.AppBlackColor;
                            SortedItem.BtnBackgroundColor = Common.AppColor.AppBackgroundColor;
                            SortedItem.BtnBorderColor = Common.AppColor.AppBlackColor;
                        }                        
                    }
                    else
                    {
                        SortedItem.BtnTextColor = Common.AppColor.AppBlackColor;
                        SortedItem.BtnBackgroundColor = Common.AppColor.AppBackgroundColor;
                        SortedItem.BtnBorderColor = Common.AppColor.AppBlackColor;
                    }
                }
            }
        }
        /// <summary>
        /// TODO : Clicked event for changing text and background colour...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompositionItem(object sender, EventArgs e)
        {
            var item = (sender as Button).BindingContext as SortItemModel;
            if (item != null)
            {
                foreach (var CompositionItem in FilterItemVM.CompositionList)
                {
                    if (CompositionItem.Id == item.Id)
                    {
                        if (CompositionItem.CompositionBtnTextColor == Common.AppColor.AppBlackColor)
                        {
                            CompositionItem.CompositionBtnTextColor = Common.AppColor.AppBackgroundColor;
                            CompositionItem.CompositionBtnBackgroundColor = Common.AppColor.AppDarkBlueColor;
                        }
                        else
                        {
                            CompositionItem.CompositionBtnTextColor = Common.AppColor.AppBlackColor;
                            CompositionItem.CompositionBtnBackgroundColor = Common.AppColor.AppBackgroundColor;
                        }
                        break;
                    }
                    
                }
            }
        }
        /// <summary>
        /// TODO : Clicked event of checkbox for changing the font attribute of brand list...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxItem(object sender, CheckedChangedEventArgs e)
        {
            var item = (sender as CheckBox).BindingContext as SortItemModel;
            if(item != null)
            {
                foreach (var CheckBoxItem in FilterItemVM.BrandList)
                {
                    if(CheckBoxItem.Id == item.Id)
                    {
                        if (CheckBoxItem.BrandListFontAttribute == FontAttributes.None)
                        {
                            CheckBoxItem.BrandListFontAttribute = FontAttributes.Bold;
                            CheckBoxItem.CheckBoxBorderColor = Common.AppColor.AppDarkBlueColor;
                        }
                        else
                        {
                            CheckBoxItem.BrandListFontAttribute = FontAttributes.None;
                            CheckBoxItem.CheckBoxBorderColor = Common.AppColor.AppGrayColor;
                        }
                        break;
                    }                    
                }
            }
        }
        #endregion
    }
}