using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFTeste
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        protected override void OnAppearing()
        {
            SetEllipseMarkupPosition();
            base.OnAppearing();
        }

        void SetEllipseMarkupPosition()
        {
            EllipseMarkup.TranslateTo(MenuItem1.X, MenuItem1.Y,0);
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            var selectedMenuItem = (Label)sender;

            var menuItem = MenuFlexlayout.Children.Where(child =>
            {
                var item = (Label)child;
                return item == selectedMenuItem;

            }).FirstOrDefault();


            EllipseMarkup.TranslateTo(menuItem.X, menuItem.Y);
            
        }
    }
}
