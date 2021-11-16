using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.Menu;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppMenuView : ContentPage
    {
        AppMenuViewModel MenuVM;
        public AppMenuView()
        {
            InitializeComponent();
            // iOS Platform
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            MenuVM = new AppMenuViewModel(this.Navigation);
            this.BindingContext = MenuVM;
        }
    }
}