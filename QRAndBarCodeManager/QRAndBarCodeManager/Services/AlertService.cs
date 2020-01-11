using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QRAndBarCodeManager.Services
{
    public class AlertService : IAlertService
    {
        public async void DisplayAlert(string title, string message, string okMessage)
        {
            await App.Current.MainPage.DisplayAlert(title, message, okMessage);
        }
    }
}
