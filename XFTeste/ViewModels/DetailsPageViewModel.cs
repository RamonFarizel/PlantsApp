using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;
using XFTeste.Models;

namespace XFTeste.ViewModels
{
    public class DetailsPageViewModel : ObservableObject
    {
        AsyncCommand _backNavigationCommand;
        public AsyncCommand BackNavigationCommand => _backNavigationCommand ??
            (_backNavigationCommand = new AsyncCommand(ExecuteBackNavigationCommand));

        async Task ExecuteBackNavigationCommand() =>
            await App.Current.MainPage.Navigation.PopAsync();


        Plant _plant;
        public Plant Plant
        {
            get => _plant;
            set => SetProperty(ref _plant, value);
        }

        public DetailsPageViewModel(Plant plant)
        {
            Plant = plant;
        }
    }
}
