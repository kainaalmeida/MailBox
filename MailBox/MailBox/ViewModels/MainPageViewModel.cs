using MailBox.Helpers;
using MailBox.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Essentials;

namespace MailBox.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Menu> Menus { get; } = new ObservableCollection<Menu>();
        public ObservableCollection<EmailBox> Emails { get; } = new ObservableCollection<EmailBox>();

        public MainPageViewModel()
        {
            LoadMenus();
            LoadEmails();
        }

        void LoadMenus()
        {
            Menus.Add(new Menu(1, FontAwesomeIcons.Envelope, "Inbox"));
            Menus.Add(new Menu(2, FontAwesomeIcons.Star, "Flagged"));
            Menus.Add(new Menu(3, FontAwesomeIcons.EnvelopeOpenText, "Draft"));
            Menus.Add(new Menu(4, FontAwesomeIcons.PaperPlane, "Sent"));
            Menus.Add(new Menu(5, FontAwesomeIcons.Trash, "Trash"));
            Menus.Add(new Menu(6, FontAwesomeIcons.EllipsisH, "More"));
        }

        void LoadEmails()
        {
            var content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum fermentum facilisis libero, venenatis mattis orci hendrerit eget. Etiam ultrices mollis justo, nec fermentum elit viverra eu. Cras at cursus turpis. Nullam magna sem, vulputate quis massa nec, mollis sollicitudin dui. Sed eu massa in arcu pharetra posuere. Phasellus maximus neque non ex dapibus fringilla. Praesent nec lacinia enim. Curabitur a dui nisl.";
            Emails.Add(new EmailBox { Img = "Assets/user02.png", Name = "Sam Miller", Subject = "Portifolio", EmailDate = "Today", EmailHour = "08:45 PM", Attachments = 4, AttachmentsItems = LoadAttachments(), Content = content });
            Emails.Add(new EmailBox { Img = "Assets/user03.png", Name = "Lily Jones", Subject = "Invitations", EmailDate = "Yesterday", EmailHour = "01:11 PM", Attachments = 0, Content = content });
            Emails.Add(new EmailBox { Img = "Assets/user04.png", Name = "Smith", Subject = "Assigment Submission", EmailDate = "Monday", EmailHour = "06:45 PM", Attachments = 0, Content = content });
            Emails.Add(new EmailBox { Img = "Assets/user05.png", Name = "Patrick", Subject = "Interview Scheduled", EmailDate = "Monday", EmailHour = "05:15 PM", Attachments = 0, Content = content });
        }

        List<string> LoadAttachments()
        {
            return new List<string> { "Assets/img01.png", "Assets/img02.png", "Assets/img03.png", "Assets/img04.png" };
        }
    }
}
