using MailBox.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace MailBox.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel ViewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new MainPageViewModel();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var items = new List<MailBox.Models.EmailBox>();

            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                ViewModel?.Emails.ForEach(x=> 
                {
                    if (x.Name.ToLower().Contains(e.NewTextValue))
                        items.Add(x);
                });

                if (items.Any())
                    emails.ItemsSource = items;
                else
                    ViewModel?.DisplayAlert("MailBox", "Email not found", "OK");

            }
            else
            {
                emails.ItemsSource = ViewModel?.Emails;
            }
        }
    }
}
