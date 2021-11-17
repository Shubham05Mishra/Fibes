using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using FibesApp.Models;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        //TODO : To Declare Local Variables Here 
        public double ScreenItemWidth;
        #region Constructor
        public HomeViewModel(INavigation _Nav)
        {
            Navigation = _Nav;
            var appMainScreenWidth = App.Current.MainPage.Width;
            ScreenItemWidth = (appMainScreenWidth - 53) / 2;
            MyCollectionCommand = new Command(MyCollectionAsync);
            BrowseCommand = new Command(BrowseAsync);
            FilterCommand = new Command(FilterAsync);
            MenuCommand = new Command(MenuAync);
            ProfileCommand = new Command(OnProfileAsync);

            #region Bind Static Lists
            ItemsList = new ObservableCollection<ItemModel>()
            {
                new ItemModel()
                {
                    Id=1,
                    ItemImage = "listItemImage.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemModel()
                {Id=2,
                    ItemImage = "listItemImage.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemModel()
                {
                     Id=3,
                    ItemImage = "listItemImage.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                },
                  new ItemModel()
                {
                      Id=4,
                    ItemImage = "listItemImage.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                },
                   new ItemModel()
                {
                       Id=5,
                    ItemImage = "listItemImage.png",
                    IsLike = false,
                    ItemHeight = ScreenItemWidth,
                },
            };
            BrowseItemsList = new ObservableCollection<ItemModel>()
            {
                new ItemModel()
                {Id=1,
                    ItemImage = "listItemImage.png",
                    IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemModel()
                {Id=2,
                    ItemImage = "listItemImage.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                },
                  new ItemModel()
                {Id=3,
                    ItemImage = "listItemImage.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                },
                   new ItemModel()
                {
                       Id=4,
                    ItemImage = "listItemImage.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                },
                    new ItemModel()
                {
                        Id=5,
                    ItemImage = "listItemImage.png",
                    IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemModel()
                {Id=6,
                    ItemImage = "listItemImage.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                },
                 new ItemModel()
                {Id=7,
                    ItemImage = "listItemImage.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                },
                  new ItemModel()
                {Id=8,
                    ItemImage = "listItemImage.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
                },
                   new ItemModel()
                {Id=9,
                    ItemImage = "listItemImage.png",
                     IsLike = false,
                    IsNotLike = true,
                    ItemHeight = ScreenItemWidth,
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
        public Command BrowseCommand { get; }
        public Command MenuCommand { get; }
        public Command ProfileCommand { get; }
        public Command FilterCommand { get; }
        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Bind Item list...
        /// </summary>
        public void MyCollectionAsync()
        {
            BrowserVisility = false;
            MyCollectionVisility = true;
            MyCollectionFontAttribute = FontAttributes.Bold;
            BrowseFontAttribute = FontAttributes.None;
            MyCollectionTextColor = Common.AppColor.AppPurpleColor;
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
            BrowseTextColor = Common.AppColor.AppPurpleColor;
        }

        /// <summary>
        /// TODO : Open Menu Page
        /// </summary>
        public void MenuAync(object obj)
        {
            if (App.Current.MainPage is MasterDetailPage mdp)
            {
                mdp.IsPresented = true;
            }
        }
        /// <summary>
        /// TODO : It Shows Filter Items
        /// </summary>
        private void FilterAsync(object obj)
        {
            //throw new NotImplementedException();
        }
        public async Task LikeAsync(ItemModel item)
        {
            try
            {

                if (item.IsNotLike == true)
                {
                    item.IsLike = true;
                    item.IsNotLike = false;

                }
                else
                {
                    item.IsLike = false;
                    item.IsNotLike = true;
                }
            }
            catch (Exception ex)
            {

            }

        }
        /// <summary>
        /// TODO : Open Profile Page
        /// </summary>
        private async void OnProfileAsync(object obj)
        {
            await Navigation.PushModalAsync(new Views.Accounts.ProfileView());

        }
        #endregion
    }
}
