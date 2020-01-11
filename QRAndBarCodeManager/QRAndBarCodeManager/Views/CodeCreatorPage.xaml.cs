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
    public partial class CodeCreatorPage : ContentPage
    {
        public CodeCreatorPage()
        {
            InitializeComponent();
            BindingContext = new CodeCreatorPageViewModel();
        }
    }
}