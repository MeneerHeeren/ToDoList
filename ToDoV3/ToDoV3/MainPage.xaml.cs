using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Threading;
using ToDoV3.Data;

namespace ToDoV3
{
    public partial class MainPage : ContentPage
    {
        // integer voor counter items
        //int counter = 0;

        // button aanmaken
        Button addPageBtn;


        public MainPage()
        {
            // toevoeging van Sietse: localization in de code ipv in appmanifest
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("NL-nl");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("NL-nl");
            // maar dit werkt niet

            // initialiseren pagina
            InitializeComponent();

            // verwijzing naar MainPage_Appearing
            this.Appearing += MainPage_Appearing;

            // button initialiseren voor AddPage
            addPageBtn = new Button()
            {
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 400,
                Text = "Click here to add a To Do item."
            };


            // button op de stack
            ControlStack.Children.Add(addPageBtn);

            // add page button clickyclicks
            addPageBtn.Clicked += addPageBtn_Clicked;
        }

        // event handler voor verschijnen MainPage
        private void MainPage_Appearing(object sender, EventArgs e)
        {
            // stack leeggooien
            ToDoStack.Children.Clear();

            // hieronder code voor het aanroepen van de lijst
        }

        // Koppeling addpageBtn
        private void addPageBtn_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new NavigationPage(new AddPage()));

            // met deze heb ik wel een back button
            Navigation.PushAsync(new AddPage());
        }































        // obsolete code

        //// Koppeling button via C#
        //private void AddBtn_Clicked(object sender, EventArgs e)
        //{
        //    // lijst vullen met items
        //    // constructor aanroepen
        //    // on click gebeurd het volgende:
        //    // constructor wordt aangeroepen
        //    // parameters worden gevuld met de tekst uit de velden
        //    // eerst dan denk ik de to-strings maken
        //    // die zijn dan de parameters
        //    // jaaaaaaaaaa
        //    // dan vinden we een manier om die lijst te printen
        //    // misschien eerst clearen omdat anders dubbel? zien we dan wel weer
        //    // daarna kijk ik wel weer of ik überhaupt die methodes in AddItem nodig heb
        //    // go!

        //    // label maken
        //    Label label;


        //    // button counter aanmaken 
        //    if (counter == 0)
        //    {
        //        AddBtn.Text = string.Format("You have 1 item in your list.");
        //        counter++;
        //    }
        //    else
        //    {
        //        AddBtn.Text = string.Format("You have {0} items in your list.", (++counter).ToString());
        //    }


        //    //label text to string => verkorte If/Else-statement gebruikt:      statement ? true : false 
        //    // in dit geval: string textEntry = wanneer niet Null dan entry.Text.ToString(), anders vullen met ""
        //    // dit moet hier en niet boven, want het is netter om er rekening mee te houden dat dingen null kunnen zijn ipv er omheen te werken
        //    string textEntry = entry.Text != null ? entry.Text.ToString() : "";

        //    //dagkeuzeding to string
        //    //string textDay = picker.SelectedItem.ToString();

        //    //datepicker to string
        //    string textDate = datePicker.Date.ToString("dd/MM/yyyy");

        //    //timepicker to string
        //    string textTime = timePicker.Time.ToString();

        //    //combine elements to label text
        //    string itemAndDate = String.Format("- {0}, do this {1} at {2}", textEntry, textDate, textTime);

        //    //schrijf naar label => hier moet die list van AddItem in worden geschreven
        //    label = new Label();
        //    label.Text = itemAndDate;

        //    //label naar Stacky
        //    Stacky.Children.Add(label); // dit kan je niet zien als hij geen tekst bevat

        //    //Clearing entry after pressing button
        //    entry.Text = string.Empty;

        //    //Focus op entry
        //    entry.Focus();

        //}

        // koppeling via XAML
        //private void OnAdding(object sender, EventArgs e)
        //{
        //    //AddBtn.Text += 1;
        //}




        // dropdown toevoegen aan Stacky

        //List<string> dayPicker = new List<string>
        //{
        //    {"Yesterday"},
        //    {"Today"},
        //    {"Tomorrow"}
        //};

        //picker = new Picker
        //{
        //    Title = "When?",
        //    VerticalOptions = LayoutOptions.Center
        //};

        //foreach (string date in dayPicker)
        //{
        //    picker.Items.Add(date);
        //}

        //Stacky.Children.Add(picker);

        //Dit werkt iig niet om de tijd weer te geven
        //String.Format("{0:d/M/yyyy}", datePicker);


        //Toevoegen items met Enter
        //entry.Completed += AddBtn_Clicked; //dit hoeft niet apart, kan ik dus gelijk zetten aan de Method AddBtn_Clicked!

        //entry.Completed += (sender, e) =>
        //{
        //    //Counter zetten
        //    AddBtn.Text = (++counter).ToString();

        //    // label maken
        //    Label label = new Label();

        //    //label text to string
        //    string textEntry = entry.Text.ToString();

        //    //dagkeuzeding to string
        //            //string textDay = picker.SelectedItem.ToString();

        //    //datepicker to string
        //    string textDate = datePicker.Date.ToString("dd/MM/yyyy");

        //    //timepicker to string
        //    string textTime = timePicker.Time.ToString();

        //    //combine elements to label text
        //    string itemAndDate = String.Format("- {0}, do this {1} at {2}", textEntry, textDate, textTime);

        //    //schrijf naar label
        //    label.Text = itemAndDate;

        //    //label naar Stacky
        //    Stacky.Children.Add(label); // dit kan je niet zien als hij geen tekst bevat

        //    //Clearing entry after pressing button
        //    entry.Text = string.Empty;

        //    //focus op entry
        //    entry.Focus();

        //};


        //oude counter
        //int btnValue = int.Parse(AddBtn.Text);

        //btnValue += 1;

        //AddBtn.Text = btnValue.ToString();

    }
}


