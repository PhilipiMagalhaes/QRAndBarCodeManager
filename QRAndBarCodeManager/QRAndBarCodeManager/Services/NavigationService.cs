using QRAndBarCodeManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace QRAndBarCodeManager.Services
{
    public class NavigationService : INavigationService
    {
        public async Task Navigate<T>(T page)
        {
            {
                if (App.Current.MainPage.Navigation.NavigationStack.Count == 0 ||
                         App.Current.MainPage.Navigation.NavigationStack.Last().GetType() != typeof(T))
                {
                    await App.Current.MainPage.Navigation.PushAsync(page as Page);
                }
            }
        }
        public async Task NavigateToCodeCreator()
        {
            await Navigate(new CodeCreatorPage());
        }
        public async Task NavigateToCodeScanner()
        {
            await Navigate(new CodeScannerPage());
        }
        public async Task NavigateToCodeResultPage()
        {
            await Navigate(new CodeResultPage());
        }

    }
}

