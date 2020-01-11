using Plugin.SecureStorage;
using QRAndBarCodeManager.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace QRAndBarCodeManager.ViewModels
{
    public class CodeResultPageViewModel : BaseViewModel
    {
        private string _result;

        public string Result { get {return _result; } set {SetProperty(ref _result, value); } }
        public Command CopyCommand { get; }
        public CodeResultPageViewModel()
        {
            CopyCommand = new Command(CopyExecute);
            Result = CrossSecureStorage.Current.GetValue("ScannedCode");
        }

        private void CopyExecute(object obj)
        {
            Clipboard.SetTextAsync(Result);
            MessageService.ShortAlert("Result was copied to clipboard");
        }
    }
}
