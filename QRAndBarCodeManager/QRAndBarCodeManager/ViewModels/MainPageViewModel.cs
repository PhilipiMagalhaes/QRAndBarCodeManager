using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Plugin.SecureStorage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QRAndBarCodeManager.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public PermissionStatus CamPermission { get; set; }
        public Command ReadCode { get; }
        public Command CreateQRCode { get; }

        public MainPageViewModel()
        {
            ReadCode = new Command(ReadCodeExecute);
            CreateQRCode = new Command(CreateQRCodeExecute);        
        }

        private async void CreateQRCodeExecute(object obj)
        {
            await NavigationService.NavigateToCodeCreator();
        }
        private async void ReadCodeExecute(object obj)
        {
            await GrantPermissions();
            if (CamPermission != PermissionStatus.Granted)
            {
                AlertService.DisplayAlert("Permission denied",
                    "We need camera permission for scan your code, please check your permissions",
                    "Got it");
            }
            else
            {
                await NavigationService.NavigateToCodeScanner();
            }
            
        }
        async Task GrantPermissions()
        {
            CamPermission = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
            if (CamPermission != PermissionStatus.Granted)
            {
                var permission = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Camera);
                if (permission.ContainsKey(Permission.Camera))
                    CamPermission = permission[Permission.Camera];
 
            }
        }
    }
}
