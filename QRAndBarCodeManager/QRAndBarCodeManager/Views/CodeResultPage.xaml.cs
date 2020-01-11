using Plugin.SecureStorage;
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
    public partial class CodeResultPage : ContentPage
    {
        public CodeResultPage()
        {
            InitializeComponent();
            BindingContext = new CodeResultPageViewModel();
        }
    }
}