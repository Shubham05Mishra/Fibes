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
            AddToBoxCommand = new Command(OnAddToBoxAsync);
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
            Colour = new ObservableCollection<ItemDetailModel>()
            {
                new ItemDetailModel()
                {
                    colourName = "red"
                },
                  new ItemDetailModel()
                {
                    colourName = "yellow"
                },
                 new ItemDetailModel()
                {
                    colourName = "blue"
                },
                 new ItemDetailModel()
                {
                    colourName = "pink"
                },
                 new ItemDetailModel()
                {
                   colourName = "olive green"
                },
                  new ItemDetailModel()
                {
                      colourName = "green"
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
        private ObservableCollection<ItemDetailModel> _Colour;
        public ObservableCollection<ItemDetailModel> Colour
        {
            get { return _Colour; }
            set
            {
                if (_Colour != value)
                {
                    _Colour = value;
                    OnPropertyChanged("Colour");
                }
            }
        }
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
        private string _Composition = "78% Polyster,22% Cotton";
        public string Composition
        {
            get { return _Composition; }
            set
            {
                if (_Composition != value)
                {
                    _Composition = value;
                    OnPropertyChanged("Composition");
                }
            }
        }
        private string _Width = "145 cm";
        public string Width
        {
            get { return _Width; }
            set
            {
                if (_Width != value)
                {
                    _Width = value;
                    OnPropertyChanged("Width");
                }
            }
        }
        private string _Weight = "380 g / m2";
        public string Weight
        {
            get { return _Weight; }
            set
            {
                if (_Weight != value)
                {
                    _Weight = value;
                    OnPropertyChanged("Weight");
                }
            }
        }
        private string _Durability = "100,000";
        public string Durability
        {
            get { return _Durability; }
            set
            {
                if (_Durability != value)
                {
                    _Durability = value;
                    OnPropertyChanged("Durability");
                }
            }
        }
        private string _FlameResistance = "EN 1021-1(cigarette test)";
        public string FlameResistance
        {
            get { return _FlameResistance; }
            set
            {
                if (_FlameResistance != value)
                {
                    _FlameResistance = value;
                    OnPropertyChanged("FlameResistance");
                }
            }
        }
        private string _Lightfastness = "4-5 (scale 1-8)";
        public string Lightfastness
        {
            get { return _Lightfastness; }
            set
            {
                if (_Lightfastness != value)
                {
                    _Lightfastness = value;
                    OnPropertyChanged("Lightfastness");
                }
            }
        }
        private string _Pilling = "5-6 (scale 1-5)";
        public string Pilling
        {
            get { return _Pilling; }
            set
            {
                if (_Pilling != value)
                {
                    _Pilling = value;
                    OnPropertyChanged("Pilling");
                }
            }
        }
        private string _Care = "5-6 (scale 1-5)";
        public string Care
        {
            get { return _Care; }
            set
            {
                if (_Care != value)
                {
                    _Care = value;
                    OnPropertyChanged("Care");
                }
            }
        }
        private string _Use = "5-6 (scale 1-5)";
        public string Use
        {
            get { return _Use; }
            set
            {
                if (_Use != value)
                {
                    _Use = value;
                    OnPropertyChanged("Use");
                }
            }
        }
        private string _Certificate = "5-6 (scale 1-5)";
        public string Certificate
        {
            get { return _Certificate; }
            set
            {
                if (_Certificate != value)
                {
                    _Certificate = value;
                    OnPropertyChanged("Certificate");
                }
            }
        }
        private string _Availability = "In Stock";
        public string Availability
        {
            get { return _Availability; }
            set
            {
                if (_Availability != value)
                {
                    _Availability = value;
                    OnPropertyChanged("Availability");
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
        public Command AddToBoxCommand { get; }
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
            if (Device.RuntimePlatform == Device.Android)
            { IsPageEnable = false; }
            await Navigation.PushModalAsync(new Views.Box.BoxDetailView(),false);
        }
        /// <summary>
        /// TODO :To Define Add to Box Detail Page...
        /// </summary>
        private async void OnAddToBoxAsync(object obj)
        {
            if (Device.RuntimePlatform == Device.Android)
            { IsPageEnable = false; }
            await Navigation.PushModalAsync(new Views.Box.BoxDetailView(), false);
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
