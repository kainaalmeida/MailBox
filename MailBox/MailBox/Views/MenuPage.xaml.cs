
using MailBox.ViewModels;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MailBox.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = new MenuPageViewModel(Navigation);
            Detail = new NavigationPage(new MenuDetailPage());
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is MailBox.Models.Menu menu)
            {
                var page = Activator.CreateInstance(menu.TargetType) as ContentPage;
                Detail.Navigation.PushAsync(page);
            }
        }
    }
}