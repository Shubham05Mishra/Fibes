using FibesApp.Models;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.PopUp
{
    public class FilterItemViewModel : BaseViewModel
    {        
        #region Constructor
        public FilterItemViewModel(INavigation nav)
        {
            Navigation = nav;
            DownArrowCommand = new Command(OnDownAsync);

            #region Bind Static Lists
            PopularProductList = new ObservableCollection<SortItemModel>()
            {
                 new SortItemModel()
                {
                   SortButtonText = "Popularity",
                },
                  new SortItemModel()
                {
                   SortButtonText = "Newest",
                },
                   new SortItemModel()
                {
                   SortButtonText = "Oldest",
                },
                    new SortItemModel()
                {
                   SortButtonText = "High Price",
                },
                     new SortItemModel()
                {
                   SortButtonText = "Low Pricr",
                },
                new SortItemModel()
                {
                   SortButtonText = "Review",
                },
            };
            CompositionList = new ObservableCollection<SortItemModel>()
            {
                 new SortItemModel()
                {
                   CompositionButtonText = "Polyster",
                },
                  new SortItemModel()
                {
                   CompositionButtonText = "Nylon",
                },
                   new SortItemModel()
                {
                   CompositionButtonText = "Cotton",
                },
                    new SortItemModel()
                {
                   CompositionButtonText = "Synthetic",
                },
                     new SortItemModel()
                {
                   CompositionButtonText = "Velvet",
                },
                new SortItemModel()
                {
                   CompositionButtonText = "Wool",
                },
                new SortItemModel()
                {
                   CompositionButtonText = "shiffon",
                },
                new SortItemModel()
                {
                   CompositionButtonText = "Silk",
                },
            };
            BrandList = new ObservableCollection<SortItemModel>()
            {
                 new SortItemModel()
                {
                   BrandName = "Brand A",
                },
                  new SortItemModel()
                {
                   BrandName = "Brand B",
                },
                   new SortItemModel()
                {
                   BrandName = "Brand C",
                },
                    new SortItemModel()
                {
                   BrandName = "Brand D",
                },
                     new SortItemModel()
                {
                   BrandName = "Brand E",
                },
                new SortItemModel()
                {
                   BrandName = "Brand F",
                },
                new SortItemModel()
                {
                   BrandName = "Brand G",
                },
                new SortItemModel()
                {
                   BrandName = "Brand H",
                },
            };
            #endregion
        }


        #endregion

        #region Properties
        private ObservableCollection<SortItemModel> _CompositionList;
        public ObservableCollection<SortItemModel> CompositionList
        {
            get { return _CompositionList; }
            set
            {
                if (_CompositionList != value)
                {
                    _CompositionList = value;
                    OnPropertyChanged("CompositionList");
                }
            }
        }
        private ObservableCollection<SortItemModel> _PopularProductList;
        public ObservableCollection<SortItemModel> PopularProductList
        {
            get { return _PopularProductList; }
            set
            {
                if (_PopularProductList != value)
                {
                    _PopularProductList = value;
                    OnPropertyChanged("PopularProductList");
                }
            }
        }
        private ObservableCollection<SortItemModel> _BrandList;
        public ObservableCollection<SortItemModel> BrandList
        {
            get { return _BrandList; }
            set
            {
                if (_BrandList != value)
                {
                    _BrandList = value;
                    OnPropertyChanged("BrandList");
                }
            }
        }

        private int _TotalItemsInCollection = 3289;
        public int TotalItemsInCollection
        {
            get { return _TotalItemsInCollection; }
            set
            {
                if (_TotalItemsInCollection != value)
                {
                    _TotalItemsInCollection = value;
                    OnPropertyChanged("TotalItemsInCollection");
                }
            }
        }

        private int _TotalItemsInProducts = 43289;
        public int TotalItemsInProducts
        {
            get { return _TotalItemsInProducts; }
            set
            {
                if (_TotalItemsInProducts != value)
                {
                    _TotalItemsInProducts = value;
                    OnPropertyChanged("TotalItemsInProducts");
                }
            }
        }

        public Command DownArrowCommand { get; }
        #endregion
        #region Commands
        #endregion
        #region Methods
        private async void OnDownAsync(object obj)
        {
            await PopupNavigation.PopAsync(true);
        }
        #endregion
    }
}
