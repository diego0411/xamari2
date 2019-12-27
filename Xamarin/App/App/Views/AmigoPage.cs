using System;
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
        public ObservableCollection<string> Amigos { get; set; }

        public ProductPage()
        {
            InitializeComponent();

            Amigos = new ObservableCollection<string>
            {
                "Amigo 1",
                "Amigo 2",
                "Amigo 3",
                "Amigo 4",
                "Amigo 5"
            };

            MyListView.ItemsSource = Amigos;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}