using FibesApp.Models;
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

            #region Bind Static Lists
            ItemsList = new ObservableCollection<ItemDetailModel>()
            {
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
                    ItemImage = "itemImage.png",
                    ItemHeight = ScreenItemWidth,
                },
                   new ItemDetailModel()
                {
                    ItemImage = "listItemImage.png",
                    ItemHeight = ScreenItemWidth,
                },
            };
        }

        

        #endregion
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
        private ObservableCollection<ItemDetailModel> _FeaturesItemsList;
        public ObservableCollection<ItemDetailModel> FeaturesItemsList
        {
            get { return _FeaturesItemsList; }
            set
            {
                if (_FeaturesItemsList != value)
                {
                    _FeaturesItemsList = value;
                    OnPropertyChanged("FeaturesItemsList");
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
        #endregion

        #region Commands
        public Command OverviewCommand { get; }
        public Command FeaturesCommand { get; }
        public Command BoxCommand { get; }
        public Command LikeCommand { get; }

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
        /// TODO : Open Box Detail Page...
        /// </summary>
        private async void OnBoxCommand(object obj)
        {
            await Navigation.PushModalAsync(new Views.Box.BoxDetailView(), false);
        }

        /// <summary>
        /// TODO : Like Button ...
        /// </summary>
        private void OnLikeAsync(object obj)
        {
            if(LikeImage == "heart.png")            
                LikeImage = "likeHeart.png";            
            else            
                LikeImage = "heart.png";                     
        }
        #endregion
    }
}
