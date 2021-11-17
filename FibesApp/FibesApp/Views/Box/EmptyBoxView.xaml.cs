using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.Box;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Box
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmptyBoxView : ContentPage
    {
        //TODO : To Define Local Class Level Variables...
        protected EmptyBoxViewModel EmptyBoxVM;
        //TODO : To Define cosntructor...
        #region Constructor
        public EmptyBoxView()
        {
            InitializeComponent();
            //To Change the color of Safearea in ios
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            EmptyBoxVM = new EmptyBoxViewModel(this.Navigation);
            this.BindingContext = EmptyBoxVM;
        }
        #endregion
    }
}