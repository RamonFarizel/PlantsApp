using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace XFTeste.ViewModels
{
    public class DetailsPageViewModel : ObservableObject
    {
        AsyncCommand _backNavigationCommand;
        public AsyncCommand BackNavigationCommand => _backNavigationCommand ??
            (_backNavigationCommand = new AsyncCommand(ExecuteBackNavigationCommand));

        async Task ExecuteBackNavigationCommand() =>
            await App.Current.MainPage.Navigation.PopAsync();

        public DetailsPageViewModel()
        {

        }
    }
}
