using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoV3.Data;
using ToDoV3;
using Xamarin.Forms;

namespace ToDoV3
{
	public partial class App : Application
	{
        static ItemDatabase database;

        public App ()
		{
			InitializeComponent();

            //MainPage = new NavigationPage(new ToDoV3.MainPage());

            // just a test, straks kijken of het werkt om mainpage hiernaar toe te veranderen
            //MainPage = new ListPage(); // doet niks
            MainPage = new NavigationPage(new ToDoV3.ListPage()); // works somewhat, check it out later
        }

        public static ItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ItemDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("Item.db3"));
                }
                return database;
            }
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
