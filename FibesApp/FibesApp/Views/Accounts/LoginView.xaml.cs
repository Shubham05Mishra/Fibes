using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.Accounts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Accounts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        //TODO : To Define Local Class Level Variables...
        protected LoginViewModel LoginVM;

        //TODO : To Define cosntructor...
        #region Constructor
        public LoginView()
        {
            InitializeComponent();
            LoginVM = new LoginViewModel(this.Navigation);
            this.BindingContext = LoginVM;
        }
        #endregion
    }
}