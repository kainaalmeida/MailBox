using MailBox.Views;
using Xamarin.Forms;

namespace MailBox
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new MenuPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
