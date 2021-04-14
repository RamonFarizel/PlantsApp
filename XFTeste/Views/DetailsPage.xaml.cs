using System;
using System.Collections.Generic;

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
        }
    }
}
