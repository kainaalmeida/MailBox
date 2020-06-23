using System.Collections.Generic;

namespace MailBox.Models
{
    public class EmailBox
    {
        public string Img { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string EmailDate { get; set; }
        public string EmailHour { get; set; }
        public string Content { get; set; }
        public int Attachments { get; set; }
        public List<string> AttachmentsItems { get; set; }

    }
}
