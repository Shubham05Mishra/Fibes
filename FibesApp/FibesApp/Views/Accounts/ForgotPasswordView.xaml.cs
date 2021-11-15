using FibesApp.ViewModels.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Accounts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPasswordView : ContentPage
    {
        //TODO : To Define Local Class Level Variables...
        protected ForgotPasswordViewModel ForgotPasswordVM;
        //TODO : To Define cosntructor...
        #region Constructor
        public ForgotPasswordView()
        {
            InitializeComponent();
            ForgotPasswordVM = new ForgotPasswordViewModel(this.Navigation);
            this.BindingContext = ForgotPasswordVM;

        }
        #endregion
    }
}