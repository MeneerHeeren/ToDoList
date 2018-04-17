using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ToDoV3.Data;


namespace ToDoV3
{
    public partial class AddPage : ContentPage
    {
        Button addBtn;
        Entry entry;
        DatePicker datePicker;
        TimePicker timePicker;
        public AddPage()
        {
            InitializeComponent();

            // focus op entry bij openen pagina
            this.Appearing += (object sender, EventArgs e) => entry.Focus();

            // add button toevoegen
            addBtn = new Button()
            {
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 400,
                Text = "Click here to add."
            };

            // entrybox toevoegen
            entry = new Entry()
            {
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 400,
                Placeholder = "Please enter a list item."
            };

            // datepicker toevoegen
            datePicker = new DatePicker()
            {
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 400
            };

            // timepicker toevoegen
            timePicker = new TimePicker()
            {
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 400,
                Time = DateTime.Now.TimeOfDay
            };

            // onderdelen toevoegen aan de Stack
            AddPageStack.Children.Add(entry);
            AddPageStack.Children.Add(datePicker);
            AddPageStack.Children.Add(timePicker);
            AddPageStack.Children.Add(addBtn);

            // focus op entry
            entry.Focus();

            // toevoegen items met muisklik
            addBtn.Clicked += addBtn_Clicked;

            // toevoegen items met Enter
            entry.Completed += addBtn_Clicked;
        }

        private void addBtn_Clicked(object sender, EventArgs e)
        {
            // variabelen maken
            string textEntry;
            string listItem;

            // focus op entry
            entry.Focus();

            // label text to string => verkorte If/Else-statement gebruikt: statement ? true : false. Rekening houden met null
            textEntry = entry.Text != null ? entry.Text.ToString() : "";

            // entry leegmaken na invoer
            entry.Text = string.Empty;

            // Object maken voor items uit item class
            //Item addItem = new Item();

            //addItem.Title = textEntry;
            //addItem.Date = datePicker.Date;
            //addItem.Time = timePicker.Time;

            // combine elements to label text
            //listItem = String.Format("- {0}\n   do this {1} at {2}", addItem.Title, addItem.Date.ToString("dd/MM/yyyy"), addItem.Time.ToString());

            // nu items toevoegen aan een lijst

            // popupje geven input complete
            //DisplayAlert("You have added an item:", listItem, "OK");
        }
    }
}