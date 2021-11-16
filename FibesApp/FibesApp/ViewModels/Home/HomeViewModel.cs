using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using FibesApp.Models;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        #region Constructor
        public HomeViewModel(INavigation _Nav)
        {
            Navigation = _Nav;
             MyCollectionCommand = new Command(MyCollectionAsync);
             BrowseCommand = new Command(BrowseAsync);
            // FilterCommand = new Command(FilterAsync);
            MenuCommand = new Command(MenuAync);
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
        private string _MyCollectionColor;
        public string MyCollectionColor
        {
            get { return _MyCollectionColor; }
            set
            {
                if (_MyCollectionColor != value)
                {
                    _MyCollectionColor = value;
                    OnPropertyChanged("MyCollectionColor");
                }
            }
        }
        private string _BrowseColor;
        public string BrowseColor
        {
            get { return _BrowseColor; }
            set
            {
                if (_BrowseColor != value)
                {
                    _BrowseColor = value;
                    OnPropertyChanged("BrowseColor");
                }
            }
        }
        #endregion
        #region Commands
        public Command MyCollectionCommand { get; }
        public Command BrowseCommand { get; }
        public Command MenuCommand { get; }
        public Command FilterCommand { get; }
        #endregion
        #region Methods
        /// <summary>
        /// TODO : To Bind Item list...
        /// </summary>
        public void MyCollectionAsync()
        {
            MyCollectionVisility = true;
            BrowserVisility = false;
            ItemsList = new ObservableCollection<ItemModel>()
            {
                new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = false,
                },
                 new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = false,
                },
                 new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = false,
                },
                  new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = false,
                },
                   new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = false,
                },
            };
        }
        /// <summary>
        /// TODO : To Bind BrowseItem list...
        /// </summary>
        public void BrowseAsync()
        {
            BrowserVisility = true;
            MyCollectionVisility = false;
            BrowseItemsList = new ObservableCollection<ItemModel>()
            {
                new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = true,
                },
                 new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = true,
                },
                  new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = true,
                },
                   new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = true,
                },
                    new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = true,
                },
                 new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = true,
                },
                 new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = true,
                },
                  new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = true,
                },
                   new ItemModel()
                {
                    ItemImage = "itemImage.png",
                    IsLike = true,
                },
            };
        }
        /// <summary>
        /// TODO : Open Menu Page
        /// </summary>
        private async void MenuAync(object obj)
        {
          //  await (App.Current.MainPage as (new Menu.MenuView())).IsPresented = true;
        }
            #endregion
        }
}
