using MailBox.ViewModels;
using System;

namespace MailBox.Models
{
    public class Menu : BaseViewModel
    {
        public int Id { get; }
        public string ImageIcon { get; }
        public string Name { get; }
        public Type TargetType { get; }

        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set { SetProperty(ref _isChecked, value); }
        }


        public Menu(int id, string imageIcon, string name, Type targetType)
        {
            Id = id;
            ImageIcon = imageIcon;
            Name = name;
            TargetType = targetType;
        }
    }
}
