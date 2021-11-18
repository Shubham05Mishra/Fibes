using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRCodeScannerView : ContentPage
    {
        //TODO : To Declare Local Varibles Here 
        protected QRCodeScannerViewModel QRCodeScannerVM;

        #region Constructor
        public QRCodeScannerView()
        {
            InitializeComponent();
            QRCodeScannerVM = new QRCodeScannerViewModel(this.Navigation);
            this.BindingContext = QRCodeScannerVM;
        } 
        #endregion

        #region Event Handler
        /// <summary>
        /// On QRCode Scan Event 
        /// </summary>
        /// <param name="result"></param>
        private void QRCodeScan(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Navigation.PushModalAsync(new Views.Menu.ItemDetailView());
            });
        } 
        #endregion
    }
   
}