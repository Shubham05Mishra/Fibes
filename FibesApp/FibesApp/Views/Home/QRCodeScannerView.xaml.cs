using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace FibesApp.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRCodeScannerView : ContentPage
    {
        //TODO : To Declare Local Varibles Here 
        protected QRCodeScannerViewModel QRCodeScannerVM;
        bool isScanned = false;

        #region Constructor
        public QRCodeScannerView()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// TODO : To Define the QRCode method...
        /// </summary>
        /// <param name="result"></param>
        void QRCodeResult(ZXing.Result result)
        {
            try
            {
                Device.BeginInvokeOnMainThread(async () =>
                   {
                       if (isScanned == false)
                       {
                           isScanned = true;
                           zxingScanner.IsScanning = false;
                           zxingScanner.IsAnalyzing = false;
                           await Navigation.PushModalAsync(new Views.Menu.ItemDetailView());
                       }
                   });
            }
            catch (Exception ex)
            { }
        }
        /// <summary>
        /// TODO : To Define the Page On Disappearing Event...
        /// </summary>
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            zxingScanner.Result = null;
        }
        /// <summary>
        /// TODO : To Define the Page On appearing Event...
        /// </summary>
        protected override void OnAppearing()
        {
            zxingScanner.IsAnalyzing = true;
            base.OnAppearing();
            isScanned = false;
            zxingScanner.IsScanning = true; 
        }

        /// <summary>
        /// TODO: Cancel Button Tap Event...
        /// </summary>
        private async void CancelTabbed(object sender, EventArgs e)
        {
            zxingScanner.IsScanning = false;
            zxingScanner.IsAnalyzing = false;
            await Navigation.PopModalAsync();
        }
        #endregion
    }
}