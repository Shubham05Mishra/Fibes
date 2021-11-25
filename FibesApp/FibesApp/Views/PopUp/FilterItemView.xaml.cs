using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.PopUp;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilterItemView : PopupPage
    {
        //TODO : To Declare Local Variables Here 
        protected FilterItemViewModel FilterItemVM;
        public FilterItemView()
        {
            InitializeComponent();
            //To Change the color of Safearea in ios
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();            
            FilterItemVM = new FilterItemViewModel(this.Navigation);
            this.BindingContext = FilterItemVM;
        }
    }
}