using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using FibesApp.Models;
using FibesApp.Views.PopUp;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Home
{
    public class FurnitureViewModel : BaseViewModel
    {
        //To Declare Local Class Level Variables
        public double ScreenItemWidth;

        #region Constructor
        public FurnitureViewModel(INavigation nav)
        {
            Navigation = nav;
            //var appMainPageScreenWidth = App.Current.MainPage.Width;
            //ScreenItemWidth = (appMainPageScreenWidth - 65) / 2;
            BoxCommand = new Command(OnBoxCommand);
            FilterCommand = new Command(OnFilterCommand);

            #region Bind Static List
            FurnitureItemList = new ObservableCollection<FurnitureItemModel>()
            {
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    },
                    new FurnitureItemModel()
                    {
                        GetImages = "demoimage.png",
                        ProType = "Kr 120 ",
                        ItemHeight = ScreenItemWidth
                    }
            };
            #endregion
        }        
        #endregion

        #region Properties
        private ObservableCollection<FurnitureItemModel> _FurnitureItemList;
        public ObservableCollection<FurnitureItemModel> FurnitureItemList
        {
            get { return _FurnitureItemList; }
            set
            {
                if (_FurnitureItemList != value)
                {
                    _FurnitureItemList = value;
                    OnPropertyChanged("FurnitureItemList");
                }
            }
        }
        #endregion

        #region Commands
        public Command BoxCommand { get; }
        public Command FilterCommand { get; }
        #endregion

        #region Methods
        /// <summary>
        /// TODO : To Bind the LatestSearch List...
        /// </summary>
        public void GetFurnitureItem()
        {

        }
        /// <summary>
        /// TODO : Open Box Detail Page...
        /// </summary>
        private void OnBoxCommand(object obj)
        {
            
        }
        /// <summary>
        /// TODO : To Open Filter Page...
        /// </summary>
        private void OnFilterCommand(object obj)
        {
            Navigation.PushPopupAsync(new FilterItemView());
        }
        #endregion
    }
}
