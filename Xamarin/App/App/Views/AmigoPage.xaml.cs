﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        public ObservableCollection<string> Friends { get; set; }

        public ProductPage()
        {
            InitializeComponent();

            Friends = new ObservableCollection<string>
            {
                "Amigo 1",
                "Amigo 2",
                "Amigo 3",
                "Amigo 4",
                "Amigo 5"
            };

            MyListView.ItemsSource = Friends;
        }

        async void Handle_FriendTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Friends == null)
                return;

            await DisplayAlert("Friend Tapped", "An friend was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
