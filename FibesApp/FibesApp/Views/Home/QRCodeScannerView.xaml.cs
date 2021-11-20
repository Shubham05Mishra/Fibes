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
    public partial class QRCodeScannerView : ZXingScannerPage
    {
        //TODO : To Declare Local Varibles Here 
        protected QRCodeScannerViewModel QRCodeScannerVM;
        
        #region Constructor
        public QRCodeScannerView()
        {
            InitializeComponent();
            InitScanner(); 
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// TOTO : To Open QR code Scanner
        /// </summary>
        void InitScanner()
        {
            try
            {
                DefaultOverlayTopText = "Align the barcode within the frame";
                DefaultOverlayBottomText = string.Empty; 
                OnScanResult += QRCodeResult; 
                Title = "Scan QRCode";                 
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// TODO : To Define the QRCode method...
        /// </summary>
        /// <param name="result"></param>
        void QRCodeResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                IsScanning = false;
                IsAnalyzing = false;
                await Navigation.PushModalAsync(new Views.Menu.ItemDetailView());
            });
        }
        /// <summary>
        /// TODO : To Define the Page On Disappearing Event...
        /// </summary>
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Content = null;
        }
        /// <summary>
        /// TODO : To Define the Page On appearing Event...
        /// </summary>
        protected override void OnAppearing()
        {
            IsScanning = true;
            IsAnalyzing = true;
            base.OnAppearing();            
        } 
        #endregion
    } 
}