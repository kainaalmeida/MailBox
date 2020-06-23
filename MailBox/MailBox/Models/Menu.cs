namespace MailBox.Models
{
    public class Menu
    {
        public int Id { get; }
        public string ImageIcon { get; }
        public string Name { get; }

        public Menu(int id, string imageIcon, string name)
        {
            Id = id;
            ImageIcon = imageIcon;
            Name = name;
        }
    }
}
