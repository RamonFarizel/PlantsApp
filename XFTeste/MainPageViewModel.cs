using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;
using XFTeste.Views;

namespace XFTeste
{
    public class MainPageViewModel : ObservableObject
    {
        string _title = string.Empty;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        IAsyncCommand _navigateCommand;
        public IAsyncCommand NavigateCommand => _navigateCommand ??
            (_navigateCommand = new AsyncCommand(ExecuteNavigateCommand));

        public MainPageViewModel()
        {
            Title = "Testing";
        }

        async Task ExecuteNavigateCommand()
        {
            await App.Current.MainPage.Navigation.PushAsync(new DetailsPage());
        }
    }
}
