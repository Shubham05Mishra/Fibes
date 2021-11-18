using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using FibesApp.Models;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Home
{
    public class SearchViewModel : BaseViewModel
    {
        //To Declare Local Class Level Variables
        public double ScreenItemWidth;

        #region Constructor
        public SearchViewModel(INavigation nav)
        {
            Navigation = nav;
            var appMainPageScreenWidth = App.Current.MainPage.Width;
            ScreenItemWidth = (appMainPageScreenWidth - 65) / 2;
            BoxCommand = new Command(OnBoxCommand);

            #region Bind Static List
            LatestSearchList = new ObservableCollection<LatestSearchItemModel>()
            {
                    new LatestSearchItemModel()
                    {
                        SearchItem = "Search product A"
                    },
                    new LatestSearchItemModel()
                    {
                        SearchItem = "Search product B"
                    },
                    new LatestSearchItemModel()
                    {
                        SearchItem = "Search product C"
                    },
                    new LatestSearchItemModel()
                    {
                        SearchItem = "Search product D"
                    },
            };

            PopularProductList = new ObservableCollection<PopularProductItemModel>()
            {
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    },
                    new PopularProductItemModel()
                    {
                        GetImages = "demoimage.png",
                        ItemHeight = ScreenItemWidth
                    }
            };
            #endregion
        }
        #endregion

        #region Properties
        private ObservableCollection<LatestSearchItemModel> _LatestSearchList;
        public ObservableCollection<LatestSearchItemModel> LatestSearchList
        {
            get { return _LatestSearchList; }
            set
            {
                if (_LatestSearchList != value)
                {
                    _LatestSearchList = value;
                    OnPropertyChanged("LatestSearchList");
                }
            }
        }
        private ObservableCollection<PopularProductItemModel> _PopularProductList;
        public ObservableCollection<PopularProductItemModel> PopularProductList
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

        private bool _IsLatestSearchListVisible = true;
        public bool IsLatestSearchListVisible
        {
            get { return _IsLatestSearchListVisible; }
            set
            {
                if (_IsLatestSearchListVisible != value)
                {
                    _IsLatestSearchListVisible = value;
                    OnPropertyChanged("IsLatestSearchListVisible");
                }
            }
        }
        private bool _IsEmptyListVisible = false;
        public bool IsEmptyListVisible
        {
            get { return _IsEmptyListVisible; }
            set
            {
                if (_IsEmptyListVisible != value)
                {
                    _IsEmptyListVisible = value;
                    OnPropertyChanged("IsEmptyListVisible");
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
        public Command BoxCommand { get; }
        #endregion

        #region Methods
        /// <summary>
        /// TODO : To Bind the LatestSearch List...
        /// </summary>
        public void GetLatestSearch()
        {
           
        }
        /// <summary>
        /// TODO : To Bind the PopularProduct List...
        /// </summary>
        public void GetPopularProduct()
        {
           
        }

        /// <summary>
        /// TODO : Open Box Detail Page...
        /// </summary>
        private async void OnBoxCommand(object obj)
        {
            IsPageEnable = false;
            await Navigation.PushModalAsync(new Views.Box.BoxDetailView(),false);
        }
        #endregion
    }
}
