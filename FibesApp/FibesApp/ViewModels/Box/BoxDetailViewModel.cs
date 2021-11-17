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
                    ProitemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock",
                },
                new BoxDetailModel()
                 {
                    ProitemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock",
                },
                new BoxDetailModel()
                 {
                    ProitemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock",
                },
                new BoxDetailModel()
                 {
                    ProitemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock",
                },
                new BoxDetailModel()
                 {
                    ProitemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock",
                },
                new BoxDetailModel()
                 {
                    ProitemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock"
                },
                new BoxDetailModel()
                 {
                    ProitemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock"
                },
                new BoxDetailModel()
                 {
                    ProitemImage = "itemImage.png",
                   ProName = "Product",
                   ProBrand = "Brand",
                   ProType = "Kr 120 ",
                   ProStatus="In Stock"
                },

            };
        }

       
        #endregion
        #endregion
        #region Property
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

        public Command ClearCommand { get; }
        public Command SubmitCommand { get; }
        #endregion

        #region Method
        private async void OnSubmitAsync(object obj)
        {
            await Navigation.PushModalAsync(new Views.Box.SubmitBoxView());
        }

        private async void OnClearAsync(object obj)
        {
            await Navigation.PushModalAsync(new Views.Box.EmptyBoxView());
        }
        #endregion
    }
}
