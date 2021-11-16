using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Accounts
{
   public class ProfileViewModel : BaseViewModel
    {
        #region Constructor
        public ProfileViewModel(INavigation nav)
        {
            Navigation = nav;
        }
        #endregion
    }
}
