using System;
using System.Collections.Generic;
using System.Text;

namespace QRAndBarCodeManager.Services
{
    public interface IMessageService
    {
        void LongAlert(string message);
        void ShortAlert(string message);
    }
}
