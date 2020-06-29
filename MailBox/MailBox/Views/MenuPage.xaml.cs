
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
        private readonly MenuPageViewModel ViewModel;
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new MenuPageViewModel(Navigation);
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is MailBox.Models.Menu menu)
            {
                menu.IsChecked = true;
                var page = Activator.CreateInstance(menu.TargetType) as ContentPage;
                Detail.Navigation.PushAsync(page);
            }

            if (e.PreviousSelection.FirstOrDefault() is MailBox.Models.Menu menuPrevious)
            {
                menuPrevious.IsChecked = false;
            }

        }

    }
}