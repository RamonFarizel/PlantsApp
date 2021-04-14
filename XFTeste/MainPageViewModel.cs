using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;
using XFTeste.Models;
using XFTeste.Views;

namespace XFTeste
{
    public class MainPageViewModel : ObservableObject
    {
        const string PlantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        string _title = string.Empty;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        Plant _plant;
        public Plant Plant
        {
            get => _plant;
            set
            {
                SetProperty(ref _plant, value);

                if (value is null)
                    return;
                
                NavigateCommand.Execute(value);
                Plant = null;
            }
        }

        ObservableCollection<Plant> _plants;
        public ObservableCollection<Plant> Plants
        {
            get => _plants;
            set => SetProperty(ref _plants, value);
        }

        IAsyncCommand<Plant> _navigateCommand;
        public IAsyncCommand<Plant> NavigateCommand => _navigateCommand ??
            (_navigateCommand = new AsyncCommand<Plant>(ExecuteNavigateCommand));

        public MainPageViewModel()
        {
            Title = "Testing";
            CreatePlantsList();
        }

        void CreatePlantsList()
        {
            Plants = new ObservableCollection<Plant>()
            {
                new Plant()
                {
                    PlantImage = "Plant1",
                    Title = "Turf Pot Plant",
                    Description = PlantDescription,
                    Price = "$85.00"
                },
                new Plant()
                {
                    PlantImage = "Plant2",
                    Title = "Scandinavian Plant",
                    Description = PlantDescription,
                    Price = "$45.00"
                },
                new Plant()
                {
                    PlantImage = "Plant2",
                    Title = "Turf Pot Plant",
                    Description = PlantDescription,
                    Price = "$45.00"
                }
            };
        }


        async Task ExecuteNavigateCommand(Plant plant)
        {
            await App.Current.MainPage.Navigation.PushAsync(new DetailsPage(plant));
        }
    }
}
