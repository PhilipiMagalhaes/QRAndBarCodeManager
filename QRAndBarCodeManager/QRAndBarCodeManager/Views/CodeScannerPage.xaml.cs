using QRAndBarCodeManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRAndBarCodeManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodeScannerPage : ContentPage
    {
        public CodeScannerPage()
        {
            InitializeComponent();
            BindingContext = new CodeScannerPageViewModel();
        }
        protected override void OnAppearing()
        {
            
        }

    }
}