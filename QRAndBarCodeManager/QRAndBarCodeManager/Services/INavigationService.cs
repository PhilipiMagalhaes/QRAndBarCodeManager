using System.Threading.Tasks;

namespace QRAndBarCodeManager.Services
{
    public interface INavigationService
    {
        Task Navigate<T>(T page);
        Task NavigateToCodeScanner();
        Task NavigateToCodeCreator();
        Task NavigateToCodeResultPage();
    }
}