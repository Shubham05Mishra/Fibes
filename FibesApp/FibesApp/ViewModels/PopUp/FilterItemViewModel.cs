using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.PopUp
{
    public class FilterItemViewModel : BaseViewModel
    {        
        #region Constructor
        public FilterItemViewModel(INavigation nav)
        {
            Navigation = nav;            
        }
        #endregion

        #region Properties
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
        #endregion
        #region Methods
        #endregion
    }
}
