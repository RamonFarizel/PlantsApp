using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFTeste.Models;
using XFTeste.ViewModels;

namespace XFTeste.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Plant plant)
        {
            InitializeComponent();

            var viewModel = new DetailsPageViewModel(plant);
            BindingContext = viewModel;

            LikeButton.TranslateTo(500, 0, 0);
            FooterElements.TranslateTo(0, 500, 0);
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.WhenAny(FooterElements.TranslateTo(0, 0, 250),
                               LikeButton.TranslateTo(0, 0, 250));

        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();

            await Task.WhenAny(FooterElements.TranslateTo(500, 0, 250),
                               LikeButton.TranslateTo(0, 500, 250));

        }
    }
}
