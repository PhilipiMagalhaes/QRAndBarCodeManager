using Plugin.SecureStorage;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZXing;
using ZXing.Common;

namespace QRAndBarCodeManager.ViewModels
{
    public class CodeCreatorPageViewModel : BaseViewModel
    {
        private BarcodeFormat _barCodeFormat;
        private string _codeValue;
        private string _dataValue;

        public BarcodeFormat BarCodeFormat { get { return _barCodeFormat; } set { SetProperty(ref _barCodeFormat, value); } }
        public EncodingOptions BarCodeOptions { get; set; }
        public string CodeValue { get { return _codeValue; } set { SetProperty(ref _codeValue, value); } }
        public string DataValue { get { return _dataValue; } set { SetProperty(ref _dataValue, value); } }

        public Command GenerateCode { get; }

        public CodeCreatorPageViewModel()
        {
            GenerateCode = new Command(GenerateCodeExecute);
            BarCodeOptions = new EncodingOptions() { Height = 400, Width = 400, Margin = 0, PureBarcode = true };
        }

        private void GenerateCodeExecute(object obj)
        {
            var SelectedCodeFormat = CrossSecureStorage.Current.GetValue("CurrentCodeFormat");
            if ( SelectedCodeFormat == "QR")
            BarCodeFormat = BarcodeFormat.QR_CODE;

            CodeValue = DataValue;
        }
    }
}
