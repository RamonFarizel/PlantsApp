using System;
using Xamarin.CommunityToolkit.ObjectModel;

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

        public MainPageViewModel()
        {
            Title = "Testing";
        }
    }
}
