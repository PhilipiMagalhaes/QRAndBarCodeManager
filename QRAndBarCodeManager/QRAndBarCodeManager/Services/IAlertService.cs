using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QRAndBarCodeManager.Services
{
    public interface IAlertService
    {
        void DisplayAlert(string title, string message, string okMessage);
    }
}
