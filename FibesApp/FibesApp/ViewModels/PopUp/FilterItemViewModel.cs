using FibesApp.Models;
using FibesApp.ViewModels.Home;
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
        public FurnitureViewModel FunitureVM;

        #region Constructor
        public FilterItemViewModel(INavigation nav)
        {
            Navigation = nav;
            DownArrowCommand = new Command(OnDownAsync);

            #region Bind Static Lists
            SortList = new ObservableCollection<SortItemModel>()
            {
                new SortItemModel()
                {
                   Id=1,
                   SortButtonText = "Popularity",
                   BtnTextColor = Common.AppColor.AppBlackColor,
                   BtnBackgroundColor = Common.AppColor.AppBackgroundColor
                },
                new SortItemModel()
                {   
                    Id=2,
                    SortButtonText = "Newest",                   
                },
                new SortItemModel()
                {
                    Id=3,
                    SortButtonText = "Oldest",
                },
                new SortItemModel()
                {
                    Id=4,
                    SortButtonText = "High Price",
                },
                new SortItemModel()
                {
                    Id=5,
                    SortButtonText = "Low Price",
                },
                new SortItemModel()
                {
                    Id=6,
                    SortButtonText = "Review",
                },
            };
            CompositionList = new ObservableCollection<SortItemModel>()
            {
                new SortItemModel()
                {
                    Id=1,
                    CompositionButtonText = "Polyster",
                },
                new SortItemModel()
                {
                    Id=2,
                    CompositionButtonText = "Nylon",
                },
                new SortItemModel()
                {
                    Id=3,
                    CompositionButtonText = "Cotton",
                },
                new SortItemModel()
                {
                    Id=4,
                    CompositionButtonText = "Synthetic",
                },
                new SortItemModel()
                {
                    Id=5,
                    CompositionButtonText = "Velvet",
                },
                new SortItemModel()
                {
                    Id=6,
                    CompositionButtonText = "Wool",
                },
                new SortItemModel()
                {
                    Id=7,
                    CompositionButtonText = "shiffon",
                },
                new SortItemModel()
                {
                    Id=8,
                    CompositionButtonText = "Silk",
                },
            };
            BrandList = new ObservableCollection<SortItemModel>()
            {
                new SortItemModel()
                {
                    Id=1,
                    BrandName = "Brand A",
                },
                new SortItemModel()
                {
                    Id=2,
                    BrandName = "Brand B",
                },
                new SortItemModel()
                {
                    Id=3,
                    BrandName = "Brand C",
                },
                new SortItemModel()
                {
                    Id=4,
                    BrandName = "Brand D",
                },
                new SortItemModel()
                {
                    Id=5,
                    BrandName = "Brand E",
                },
                new SortItemModel()
                {
                    Id=6,
                    BrandName = "Brand F",
                },
                new SortItemModel()
                {
                    Id=7,
                    BrandName = "Brand G",
                },
                new SortItemModel()
                {
                    Id=8,
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
        private ObservableCollection<SortItemModel> _SortList;
        public ObservableCollection<SortItemModel> SortList
        {
            get { return _SortList; }
            set
            {
                if (_SortList != value)
                {
                    _SortList = value;
                    OnPropertyChanged("SortList");
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
        #endregion

        #region Commands
        public Command DownArrowCommand { get; }
        #endregion

        #region Methods
        private async void OnDownAsync(object obj)
        {
            await FunitureVM.UpdatePageEnableMode(true);
            await PopupNavigation.PopAsync(true);
        }
        #endregion
    }
}
