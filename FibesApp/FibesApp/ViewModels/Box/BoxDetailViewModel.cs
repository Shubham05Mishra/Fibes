using FibesApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Box
{
    public class BoxDetailViewModel : BaseViewModel
    {
        //TODO : To Declare Local Variables Here                 

        #region Constructor
        public BoxDetailViewModel(INavigation Nav)
        {
            Navigation = Nav;
            ClearCommand = new Command(OnClearAsync);
            SubmitCommand = new Command(OnSubmitAsync);

            #region Bind static List
            DetailItemsList = new ObservableCollection<BoxDetailModel>()
            {
                new BoxDetailModel()
                 {
                    Id = 1,
                    ProItemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock",
                },
                new BoxDetailModel()
                 {
                    Id = 2,
                    ProItemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock",
                },
                new BoxDetailModel()
                 {
                    Id = 3,
                    ProItemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock",
                },
                new BoxDetailModel()
                 {
                    Id = 4,
                    ProItemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock",
                },
                new BoxDetailModel()
                 {
                    Id = 5,
                    ProItemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock",
                },
                new BoxDetailModel()
                 {
                    Id = 6,
                    ProItemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock"
                },
                new BoxDetailModel()
                 {
                    Id = 7,
                    ProItemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock"
                },
                new BoxDetailModel()
                 {
                    Id = 8, 
                    ProItemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock"
                },

            };
            #endregion
        }

        
        #endregion

        #region Properties
        private ObservableCollection<BoxDetailModel> _DetailItemsList;
        public ObservableCollection<BoxDetailModel> DetailItemsList
        {
            get { return _DetailItemsList; }
            set
            {
                if (_DetailItemsList != value)
                {
                    _DetailItemsList = value;
                    OnPropertyChanged("DetailItemsList");
                }
            }
        }
        private bool _IsPageEnable = true;
        public bool IsPageEnable
        {
            get { return _IsPageEnable; }
            set
            {
                if (_IsPageEnable != value)
                {
                    _IsPageEnable = value;
                    OnPropertyChanged("IsPageEnable");
                }
            }
        }

        #endregion

        #region Commands
        public Command ClearCommand { get; }
        public Command SubmitCommand { get; }
        #endregion

        #region Methods
        /// <summary>
        /// TODO : To Define Submit Button Tap Event...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnSubmitAsync(object obj)
        {
            if (Device.RuntimePlatform == Device.Android)
            { IsPageEnable = false; }
            await Navigation.PushModalAsync(new Views.Box.SubmitBoxView(),false);
        }

        /// <summary>
        /// TODO : To Define Clear Button Tap Event...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnClearAsync(object obj)
        {
            if (Device.RuntimePlatform == Device.Android)
            { IsPageEnable = false; }
            await Navigation.PushModalAsync(new Views.Box.EmptyBoxView(),false);
        }
        #endregion

        #region Validations
        #endregion
    }
}
