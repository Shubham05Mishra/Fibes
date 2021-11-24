using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZXing.Mobile;

namespace FibesApp.ViewModels.Home
{
    public class QRCodeScannerViewModel : BaseViewModel
    {
        //TODO : To Declare Local Variables Here 

        #region Constructor
        public QRCodeScannerViewModel(INavigation _Nav)
        {
            Navigation = _Nav;
            ScanCommand = new Command(OnScanInAsync);
        }
        #endregion

        #region Properties
        private string _Result;
        public string Result
        {
            get { return _Result; }
            set
            {
                if (_Result != value)
                {
                    _Result = value;
                    OnPropertyChanged("Result");
                }
            }
        }
        private bool _IsScanning = true;
        public bool IsScanning
        {
            get { return _IsScanning; }
            set
            {
                if (_IsScanning != value)
                {
                    _IsScanning = value;
                    OnPropertyChanged("IsScanning");
                }
            }
        }
        private bool _IsAnalyzing = true;
        public bool IsAnalyzing
        {
            get { return _IsAnalyzing; }
            set
            {
                if (_IsAnalyzing != value)
                {
                    _IsAnalyzing = value;
                    OnPropertyChanged("IsAnalyzing");
                }
            }
        }
        #endregion

        #region Commands
        public Command ScanCommand { get; }
        #endregion

        #region Methods
        /// <summary>
        /// TODO:To Call The SignIn button ...
        /// </summary>
        private async void OnScanInAsync(object obj)
        {
            IsScanning = false;
            IsAnalyzing = false;
            await Navigation.PushModalAsync(new Views.Menu.ItemDetailView(), false);
        }
        #endregion


        #region Validations
        #endregion

    }
}
