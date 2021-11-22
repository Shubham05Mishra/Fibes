using FibesApp.Models;
using FibesApp.Views.Home;
using FibesApp.Views.Menu;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Menu
{
    public class ItemDetailViewModel : BaseViewModel
    {
        //TODO : To Declare Local Variables Here 
        public double ScreenItemWidth;

        #region Constructor
        public ItemDetailViewModel(INavigation _Nav)
        {
            Navigation = _Nav;
            // var appMainScreenWidth = App.Current.MainPage.Width;
            // ScreenItemWidth = (appMainScreenWidth - 54) / 2;
            OverviewCommand = new Command(OverViewAsync);
            FeaturesCommand = new Command(FeatureAsync);
            BoxCommand = new Command(OnBoxCommand);
            LikeCommand = new Command(OnLikeAsync);
            Back_Command = new Command(OnbackAsync);
            MeasuringUnitUpCommand = new Command(MeasuringUnitUpAsync);
            MeasuringUnitDownCommand = new Command(MeasuringUnitDownAsync);

            #region Bind Static Lists

            ItemsList = new ObservableCollection<ItemDetailModel>()
            {
                new ItemDetailModel()
                {
                    ItemImage = "collectionListItem.png",
                    ItemHeight = ScreenItemWidth,
                },
                  new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemDetailModel()
                {
                    ItemImage = "itemImage.png",
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemDetailModel()
                {
                    ItemImage = "collectionListItem.png",
                    ItemHeight = ScreenItemWidth,
                },
                  new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemDetailModel()
                {
                    ItemImage = "itemImage.png",
                    ItemHeight = ScreenItemWidth,
                },
                   new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    ItemHeight = ScreenItemWidth,
                },
            };
            SimilarProductList = new ObservableCollection<ItemDetailModel>()
            {
                new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    FabricName = "Fabric Name",
                    FabricBrand = "Brand",
                    ItemHeight = ScreenItemWidth,
                },
                  new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    FabricName = "Fabric Name",
                     FabricBrand = "Brand",
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    FabricName = "Fabric Name",
                     FabricBrand = "Brand",
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    FabricName = "Fabric Name",
                     FabricBrand = "Brand",
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    FabricName = "Fabric Name",
                     FabricBrand = "Brand",
                    ItemHeight = ScreenItemWidth,
                },
                  new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    FabricName = "Fabric Name",
                     FabricBrand = "Brand",
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    FabricName = "Fabric Name",
                     FabricBrand = "Brand",
                    ItemHeight = ScreenItemWidth,
                },
                   new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    FabricName = "Fabric Name",
                     FabricBrand = "Brand",
                    ItemHeight = ScreenItemWidth,
                },
            };

            #endregion
        }
        #endregion

        #region Properties
        private ObservableCollection<ItemDetailModel> _ItemsList;
        public ObservableCollection<ItemDetailModel> ItemsList
        {
            get { return _ItemsList; }
            set
            {
                if (_ItemsList != value)
                {
                    _ItemsList = value;
                    OnPropertyChanged("ItemsList");
                }
            }
        }
        private ObservableCollection<ItemDetailModel> _SimilarProductList;
        public ObservableCollection<ItemDetailModel> SimilarProductList
        {
            get { return _SimilarProductList; }
            set
            {
                if (_SimilarProductList != value)
                {
                    _SimilarProductList = value;
                    OnPropertyChanged("SimilarProductList");
                }
            }
        }
        private bool _OverviewVisility = true;
        public bool OverviewVisility
        {
            get { return _OverviewVisility; }
            set
            {
                if (_OverviewVisility != value)
                {
                    _OverviewVisility = value;
                    OnPropertyChanged("OverviewVisility");
                }
            }
        }
        private bool _FeaturesVisility = false;
        public bool FeaturesVisility
        {
            get { return _FeaturesVisility; }
            set
            {
                if (_FeaturesVisility != value)
                {
                    _FeaturesVisility = value;
                    OnPropertyChanged("FeaturesVisility");
                }
            }
        }
        private FontAttributes _OverviewFontAttribute;
        public FontAttributes OverviewFontAttribute
        {
            get { return _OverviewFontAttribute; }
            set
            {
                if (_OverviewFontAttribute != value)
                {
                    _OverviewFontAttribute = value;
                    OnPropertyChanged("OverviewFontAttribute");
                }
            }
        }
        private string _OverviewTextColor;
        public string OverviewTextColor
        {
            get { return _OverviewTextColor; }
            set
            {
                if (_OverviewTextColor != value)
                {
                    _OverviewTextColor = value;
                    OnPropertyChanged("OverviewTextColor");
                }
            }
        }
        private FontAttributes _FeaturesFontAttribute;
        public FontAttributes FeaturesFontAttribute
        {
            get { return _FeaturesFontAttribute; }
            set
            {
                if (_FeaturesFontAttribute != value)
                {
                    _FeaturesFontAttribute = value;
                    OnPropertyChanged("FeaturesFontAttribute");
                }
            }
        }
        private string _FeaturesTextColor;
        public string FeaturesTextColor
        {
            get { return _FeaturesTextColor; }
            set
            {
                if (_FeaturesTextColor != value)
                {
                    _FeaturesTextColor = value;
                    OnPropertyChanged("FeaturesTextColor");
                }
            }
        }

        private string _LikeImage = "heart.png";
        public string LikeImage
        {
            get { return _LikeImage; }
            set
            {
                if (_LikeImage != value)
                {
                    _LikeImage = value;
                    OnPropertyChanged("LikeImage");
                }
            }
        }

        private string _MeasuringUnit = "mtr";
        public string MeasuringUnit
        {
            get { return _MeasuringUnit; }
            set
            {
                if (_MeasuringUnit != value)
                {
                    _MeasuringUnit = value;
                    OnPropertyChanged("MeasuringUnit");
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
        public Command OverviewCommand { get; }
        public Command FeaturesCommand { get; }
        public Command BoxCommand { get; }
        public Command LikeCommand { get; }
        public Command Back_Command { get; }
        public Command MeasuringUnitUpCommand { get; }
        public Command MeasuringUnitDownCommand { get; }

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Bind Item list...
        /// </summary>
        public void OverViewAsync()
        {
            FeaturesVisility = false;
            OverviewVisility = true;
            OverviewFontAttribute = FontAttributes.Bold;
            FeaturesFontAttribute = FontAttributes.None;
            OverviewTextColor = Common.AppColor.AppPurpleColor;
            FeaturesTextColor = Common.AppColor.AppGrayColor;
        }

        /// <summary>
        /// TODO : To Bind BrowseItem list...
        /// </summary>
        public void FeatureAsync()
        {
            FeaturesVisility = true;
            OverviewVisility = false;
            OverviewFontAttribute = FontAttributes.None;
            FeaturesFontAttribute = FontAttributes.Bold;
            OverviewTextColor = Common.AppColor.AppGrayColor;
            FeaturesTextColor = Common.AppColor.AppPurpleColor;
        }
        /// <summary>
        /// TODO :To Define Open Box Detail Page...
        /// </summary>
        private async void OnBoxCommand(object obj)
        {
            IsPageEnable = false;
            await Navigation.PushModalAsync(new Views.Box.BoxDetailView(),false);
        }

        /// <summary>
        /// TODO :To Define Like Button ...
        /// </summary>
        private void OnLikeAsync(object obj)
        {
            if (LikeImage == "heart.png")
                LikeImage = "likeHeart.png";
            else
                LikeImage = "heart.png";
        }

        private void MeasuringUnitDownAsync(object obj)
        {
           if(MeasuringUnit == "mtr")
            {
                MeasuringUnit = "cm";
                return;
            }
           if(MeasuringUnit == "cm")
            {
                MeasuringUnit = "mm";
            }
        }

        private void MeasuringUnitUpAsync(object obj)
        {
            if (MeasuringUnit == "cm")
            {
                MeasuringUnit = "mtr";
            }
            if (MeasuringUnit == "mm")
            {
                MeasuringUnit = "cm";
            }
        }

        /// <summary>
        /// TODO :To Define Back Button ...
        /// </summary>
        private async void OnbackAsync(object obj)
        { 
            App.AppMasterDetailPage = new MasterDetailPage();
            App.AppMasterDetailPage.Master = new Views.Menu.AppMenuView();
            App.AppMasterDetailPage.Detail = new HomeView();
            App.Current.MainPage = App.AppMasterDetailPage; 
        }

        #endregion

        #region Validations
        #endregion
    }
}
