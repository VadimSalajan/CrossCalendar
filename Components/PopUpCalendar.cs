﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Shapes;
using Xamarin.Forms;

namespace CrossCalendar.Components
{
    public class PopUpCalendar: ContentPage
    {
        private ScrollView screen;
        public Path pathClose; // Set Color Stroke and Fill
        public Calendar calendar;

        public PopUpCalendar()
        {
            BackgroundColor = Color.Transparent;
            PathGeometry pathGeometry = new PathGeometry();
            PathFigureCollectionConverter.ParseStringToPathFigureCollection(pathGeometry.Figures, "M249,753L207,711L438,480L207,249L249,207L480,438L711,207L753,249L522,480L753,711L711,753L480,522L249,753Z");

            pathClose = new Xamarin.Forms.Shapes.Path
            {
                Data = pathGeometry,
                HeightRequest = 28,
                WidthRequest = 28,
                Scale = 1,
                Stroke = Brush.Gray,
                Fill = Brush.Gray,
                Aspect = Stretch.Uniform,
                HorizontalOptions = LayoutOptions.End,
            };

            calendar = new CrossCalendar.Calendar
            {
                Padding = new Thickness(30, 10, 30, 30),
                Margin = 3,
                CalIsInPopUp = true,
            };

            var btnClose = new Button
            {
                WidthRequest = 40,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                BackgroundColor = Color.Transparent
            };
            btnClose.Clicked += BtnClose_Clicked;
            Grid.SetRow(calendar, 1);
            screen = new ScrollView
            {
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Grid
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        pathClose,
                        btnClose,
                        calendar
                    },
                    RowDefinitions =
                    {
                        new RowDefinition { Height = 40 },
                        new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                    }
                }
            };

            Content = screen;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async Task ShowCalendar(ContentPage pageContext)
        {
            await pageContext.Navigation.PushModalAsync(this);
        }

        public async Task CloseCalendar()
        {
            await Navigation.PopModalAsync();
        }

        private async void BtnClose_Clicked(object sender, EventArgs e)
        {
            await CloseCalendar();
        }
    }
}
