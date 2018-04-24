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
	public partial class DeleteItemPage : ContentPage
	{
		public DeleteItemPage ()
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
            bool accepted = await DisplayAlert("Confirm", "Are you Sure ?", "Yes", "No");
            if (accepted)
            {
                var listItem = (Item)BindingContext;
                await App.Database.DeleteItemAsync(listItem);
                await Navigation.PopAsync();
            }
            //await Navigation.PushAsync(new ItemPage());
        }


        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}