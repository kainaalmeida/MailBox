using System;

namespace MailBox.Models
{
    public class Menu
    {
        public int Id { get; }
        public string ImageIcon { get; }
        public string Name { get; }
        public Type TargetType { get; }

        public Menu(int id, string imageIcon, string name, Type targetType)
        {
            Id = id;
            ImageIcon = imageIcon;
            Name = name;
            TargetType = targetType;
        }
    }
}
