using MailBox.Helpers;
using MailBox.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MailBox.ViewModels
{
    public class MenuPageViewModel : BaseViewModel
    {
        public ObservableCollection<MailBox.Models.Menu> Menus { get; } = new ObservableCollection<MailBox.Models.Menu>();
        public MenuPageViewModel(INavigation navigation) : base(navigation)
        {
            LoadMenus();
        }

        void LoadMenus()
        {
            Menus.Add(new MailBox.Models.Menu(1, FontAwesomeIcons.Envelope, "Inbox"));
            Menus.Add(new MailBox.Models.Menu(2, FontAwesomeIcons.Star, "Flagged"));
            Menus.Add(new MailBox.Models.Menu(3, FontAwesomeIcons.EnvelopeOpenText, "Draft"));
            Menus.Add(new MailBox.Models.Menu(4, FontAwesomeIcons.PaperPlane, "Sent"));
            Menus.Add(new MailBox.Models.Menu(5, FontAwesomeIcons.Trash, "Trash"));
            Menus.Add(new MailBox.Models.Menu(6, FontAwesomeIcons.EllipsisH, "More"));
        }
    }
}
