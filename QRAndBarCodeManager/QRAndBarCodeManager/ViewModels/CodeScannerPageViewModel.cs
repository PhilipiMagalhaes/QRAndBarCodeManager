using Plugin.SecureStorage;
using Plugin.Vibrate;
using QRAndBarCodeManager.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QRAndBarCodeManager.ViewModels
{
    class CodeScannerPageViewModel : BaseViewModel
    {
        private bool _isAnalyzing;
        private bool _isScanning;
        private ZXing.Result _result;
        private bool _isProcessing;
        private string _currentCode;

        public bool IsAnalyzing { get { return _isAnalyzing; } set { SetProperty(ref _isAnalyzing, value); } }
        public bool IsScanning { get { return _isScanning; } set { SetProperty(ref _isScanning, value); } }
        public bool IsProcessing { get {return _isProcessing; } set {SetProperty(ref _isProcessing, value); } }
        public ZXing.Result Result { get { return _result; } set { SetProperty(ref _result, value); } }
        public string CurrentCode { get { return _currentCode; } set { SetProperty(ref _currentCode, value); } }

        public Command ScanResultCommand { get; }

        public CodeScannerPageViewModel()
        {
           ScanResultCommand = new Command(BarcodeScanned);

           IsScanning = true;
           IsAnalyzing = true;
        }

        private void BarcodeScanned(object obj)
        {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    IsProcessing = true;
                    IsAnalyzing = false;
         
                    if(Result.Text != CurrentCode)
                    {
                        CurrentCode = Result.Text;
                        CrossSecureStorage.Current.SetValue("ScannedCode", Result.Text);
                        CrossVibrate.Current.Vibration();
                        MessageService.ShortAlert("I read it!");
                        await NavigationService.NavigateToCodeResultPage();
                        await Task.Delay(3000);
                        CurrentCode = string.Empty;
                    }
                   
                    IsProcessing = false;
                    IsAnalyzing = true;

                });
        }
    }
}