
using MailBox.ViewModels;
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
    }
}