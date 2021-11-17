using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailView : ContentPage
    {
        //TODO : To Declare Local Variables Here 
        protected ItemDetailViewModel ItemDetailVM;

        #region Constructor
        public ItemDetailView()
        {
            InitializeComponent();
            ItemDetailVM = new ItemDetailViewModel(this.Navigation);
            this.BindingContext = ItemDetailVM;
        }
        #endregion

        #region Event Handler
        #endregion
    }
}