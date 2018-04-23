using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoV3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();

            this.Title = "Item List";

            ToolbarItem toolbarItem = new ToolbarItem
            {
                Text = "+"
            };

            toolbarItem.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ItemPage() { BindingContext = new Item() });
            };

            ToolbarItems.Add(toolbarItem);
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            ItemListView.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ItemPage() { BindingContext = e.SelectedItem as Item });
            }
        }
	}
}