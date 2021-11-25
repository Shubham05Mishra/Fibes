using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using FibesApp.Models;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace FibesApp.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        //TODO : To Declare Local Variables Here 
        public double ScreenItemWidth;
        ZXingScannerPage ScannerPage;

        #region Constructor
        public HomeViewModel(INavigation _Nav)
        {
            Navigation = _Nav;
            var appMainScreenWidth = App.Current.MainPage.Width;
            ScreenItemWidth = (appMainScreenWidth - 53) / 2;
            MyCollectionCommand = new Command(MyCollectionAsync);
            SearchCommand = new Command(SearchAsync);
            BrowseCommand = new Command(BrowseAsync);            
            MenuCommand = new Command(MenuAync);
            ProfileCommand = new Command(OnProfileAsync);
            QRcodeCommand = new Command(QRCodeAsync);

            #region Bind Static Lists
            ItemsList = new ObservableCollection<ItemModel>()
            {
                new ItemModel()
                {
                    Id=1,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                 new ItemModel()
                {Id=2,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Furniture",
                    ProductCount = "327",
                },
                 new ItemModel()
                {
                     Id=3,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Outdoor",
                    ProductCount = "32",
                },
                  new ItemModel()
                {
                      Id=4,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Public Environment",
                    ProductCount = "12",
                },
                   new ItemModel()
                {
                       Id=5,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                 new ItemModel()
                {
                       Id=6,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                 new ItemModel()
                {
                       Id=7,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                 new ItemModel()
                {
                       Id=8,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                 new ItemModel()
                {
                       Id=9,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                 new ItemModel()
                {
                       Id=10,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
            };
            BrowseItemsList = new ObservableCollection<ItemModel>()
            {
                new ItemModel()
                {Id=1,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                 new ItemModel()
                {Id=2,
                    ItemImage = "collectionListItem.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Furniture",
                    ProductCount = "327",
                },
                  new ItemModel()
                {Id=3,
                    ItemImage = "collectionListItem.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Outdoor",
                    ProductCount = "32",
                },
                   new ItemModel()
                {
                       Id=4,
                    ItemImage = "collectionListItem.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Public Environment",
                    ProductCount = "12",
                },
                    new ItemModel()
                {
                        Id=5,
                    ItemImage = "collectionListItem.png",
                    IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                 new ItemModel()
                {Id=6,
                    ItemImage = "collectionListItem.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                 new ItemModel()
                {Id=7,
                    ItemImage = "collectionListItem.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                  new ItemModel()
                {Id=8,
                    ItemImage = "collectionListItem.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
                   new ItemModel()
                {Id=9,
                    ItemImage = "collectionListItem.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                    ProductName = "Curtain",
                    ProductCount = "77",
                },
            };
            #endregion
        }
        #endregion

        #region Properties
        private ObservableCollection<ItemModel> _ItemsList;
        public ObservableCollection<ItemModel> ItemsList
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
        private ObservableCollection<ItemModel> _BrowseItemsList;
        public ObservableCollection<ItemModel> BrowseItemsList
        {
            get { return _BrowseItemsList; }
            set
            {
                if (_BrowseItemsList != value)
                {
                    _BrowseItemsList = value;
                    OnPropertyChanged("BrowseItemsList");
                }
            }
        }
        private string _UserName = "Andrew";
        public string UserName
        {
            get { return _UserName; }
            set
            {
                if (_UserName != value)
                {
                    _UserName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }
        private bool _MyCollectionVisility = true;
        public bool MyCollectionVisility
        {
            get { return _MyCollectionVisility; }
            set
            {
                if (_MyCollectionVisility != value)
                {
                    _MyCollectionVisility = value;
                    OnPropertyChanged("MyCollectionVisility");
                }
            }
        }
        private bool _BrowserVisility = false;
        public bool BrowserVisility
        {
            get { return _BrowserVisility; }
            set
            {
                if (_BrowserVisility != value)
                {
                    _BrowserVisility = value;
                    OnPropertyChanged("BrowserVisility");
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
        private FontAttributes _MyCollectionFontAttribute;
        public FontAttributes MyCollectionFontAttribute
        {
            get { return _MyCollectionFontAttribute; }
            set
            {
                if (_MyCollectionFontAttribute != value)
                {
                    _MyCollectionFontAttribute = value;
                    OnPropertyChanged("MyCollectionFontAttribute");
                }
            }
        }
        private string _MyCollectionTextColor;
        public string MyCollectionTextColor
        {
            get { return _MyCollectionTextColor; }
            set
            {
                if (_MyCollectionTextColor != value)
                {
                    _MyCollectionTextColor = value;
                    OnPropertyChanged("MyCollectionTextColor");
                }
            }
        }
        private FontAttributes _BrowseFontAttribute;
        public FontAttributes BrowseFontAttribute
        {
            get { return _BrowseFontAttribute; }
            set
            {
                if (_BrowseFontAttribute != value)
                {
                    _BrowseFontAttribute = value;
                    OnPropertyChanged("BrowseFontAttribute");
                }
            }
        }
        private string _BrowseTextColor;
        public string BrowseTextColor
        {
            get { return _BrowseTextColor; }
            set
            {
                if (_BrowseTextColor != value)
                {
                    _BrowseTextColor = value;
                    OnPropertyChanged("BrowseTextColor");
                }
            }
        }
        private string _BarcodeText
;
        public string BarcodeText
        {
            get { return _BarcodeText; }
            set
            {
                if (_BarcodeText != value)
                {
                    _BarcodeText = value;
                    OnPropertyChanged("BarcodeText");
                }
            }
        }
        private bool _IsLike = false;
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
        private bool _IsNotLike = true;
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
        #endregion

        #region Commands
        public Command MyCollectionCommand { get; }
        public Command SearchCommand { get; }
        public Command BrowseCommand { get; }
        public Command MenuCommand { get; }
        public Command ProfileCommand { get; }
        public Command QRcodeCommand { get; }        
        #endregion

        #region Methods
        /// <summary>
        /// TODO : To Open Search Page...
        /// </summary>
        private async void SearchAsync(object obj)
        {
            if (Device.RuntimePlatform == Device.Android)
            { IsPageEnable = false; }

            await Navigation.PushModalAsync(new Views.Home.SearchView(),false);
        }

        /// <summary>
        /// TODO : To Bind Item list...
        /// </summary>
        public void MyCollectionAsync()
        {
            BrowserVisility = false;
            MyCollectionVisility = true;
            MyCollectionFontAttribute = FontAttributes.Bold;
            BrowseFontAttribute = FontAttributes.None;
            MyCollectionTextColor = Common.AppColor.AppDarkBlueColor;
            BrowseTextColor = Common.AppColor.AppGrayColor;
        }

        /// <summary>
        /// TODO : To Bind BrowseItem list...
        /// </summary>
        public void BrowseAsync()
        {
            BrowserVisility = true;
            MyCollectionVisility = false;
            MyCollectionFontAttribute = FontAttributes.None;
            BrowseFontAttribute = FontAttributes.Bold;
            MyCollectionTextColor = Common.AppColor.AppGrayColor;
            BrowseTextColor = Common.AppColor.AppDarkBlueColor;
        }

        /// <summary>
        /// TODO : To Open Menu Page
        /// </summary>
        public void MenuAync(object obj)
        {
            if (App.Current.MainPage is MasterDetailPage mdp)
            {
                mdp.IsPresented = true;
            }
        }        

        /// <summary>
        /// TODO : Open Profile Page
        /// </summary>
        private async void OnProfileAsync(object obj)
        {
            if (Device.RuntimePlatform == Device.Android)
            { IsPageEnable = false; }
            await Navigation.PushModalAsync(new Views.Accounts.ProfileView(),false);

        }

        /// <summary>
        /// TODO : Open Barcode Scanner
        /// </summary>
        private async void QRCodeAsync(object obj)
        {
            ScannerPage = new ZXingScannerPage();
            await Navigation.PushModalAsync(new Views.Home.QRCodeScannerView());
        }

        #endregion

        #region Validations
        #endregion
    }

}
