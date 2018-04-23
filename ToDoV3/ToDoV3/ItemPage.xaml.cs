using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoV3
{
	public partial class ItemPage : ContentPage
	{
		public ItemPage ()
		{
			InitializeComponent ();
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            var listItem = (Item)BindingContext;
            await App.Database.SaveItemAsync(listItem);
            await Navigation.PopAsync();
        }

        async void Delete_Clicked(object sender, EventArgs e)
        {
            //
        }


        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}