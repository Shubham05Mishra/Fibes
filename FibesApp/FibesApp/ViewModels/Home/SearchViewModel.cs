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
        //To Declare Local Class Level Variables...
        public double ScreenItemWidth;

        #region Constructor
        public SearchViewModel(INavigation nav)
        {
            Navigation = nav;
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
        #endregion

        #region Commands
        #endregion

        #region Methods
        /// <summary>
        /// TODO : To Bind the LatestSearch List...
        /// </summary>
        public void GetLatestSearch()
        {
            LatestSearchList = new ObservableCollection<LatestSearchItemModel>()
            {
                    new LatestSearchItemModel()
                    {
                        SearchItem = "Aman"
                    },
                    new LatestSearchItemModel()
                    {
                        SearchItem = "Shubham"
                    },
                    new LatestSearchItemModel()
                    {
                        SearchItem = "Mayank"
                    },
                    new LatestSearchItemModel()
                    {
                        SearchItem = "Abhilesh"
                    },
            };
        }
        /// <summary>
        /// TODO : To Bind the PopularProduct List...
        /// </summary>
        public void GetPopularProduct()
        {
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
        }
        #endregion
    }
}
