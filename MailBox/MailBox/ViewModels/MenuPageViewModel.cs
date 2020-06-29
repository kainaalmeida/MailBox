using MailBox.Helpers;
using MailBox.Views;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MailBox.ViewModels
{
    public class MenuPageViewModel : BaseViewModel
    {
        private MailBox.Models.Menu _menuSelected;
        public MailBox.Models.Menu MenuSelected
        {
            get { return _menuSelected; }
            set { SetProperty(ref _menuSelected, value); }
        }


        public ObservableCollection<MailBox.Models.Menu> Menus { get; } = new ObservableCollection<MailBox.Models.Menu>();

        public Command<MailBox.Models.Menu> MenuCommand { get; }

        public MenuPageViewModel(INavigation navigation) : base(navigation)
        {
            MenuCommand = new Command<Models.Menu>(async (menu) => await ExecuteMenuCommand(menu));
            LoadMenus();
        }

        private async Task ExecuteMenuCommand(Models.Menu menu)
        {
            var item = menu;

            await Navigation.PushAsync(new MainPage());
        }

        public void LoadMenus()
        {
            Menus.Add(new MailBox.Models.Menu(1, FontAwesomeIcons.Envelope, "Inbox", typeof(MainPage)));
            Menus.Add(new MailBox.Models.Menu(2, FontAwesomeIcons.Star, "Flagged", typeof(MenuDetailPage)));
            Menus.Add(new MailBox.Models.Menu(3, FontAwesomeIcons.EnvelopeOpenText, "Draft", typeof(MenuDetailPage)));
            Menus.Add(new MailBox.Models.Menu(4, FontAwesomeIcons.PaperPlane, "Sent", typeof(MenuDetailPage)));
            Menus.Add(new MailBox.Models.Menu(5, FontAwesomeIcons.Trash, "Trash", typeof(MenuDetailPage)));
            Menus.Add(new MailBox.Models.Menu(6, FontAwesomeIcons.EllipsisH, "More", typeof(MenuDetailPage)));
        }
    }
}
