﻿using System;
using System.Linq;
using Xamarin.Forms;
using HaruhiSuzumiya.APP.Data;

namespace HaruhiSuzumiya.APP.Views
{
    [QueryProperty("Name", "name")]
    public partial class CatDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = CatData.Cats.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public CatDetailPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
