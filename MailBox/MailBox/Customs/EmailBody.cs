using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace MailBox.Customs
{
    public class EmailBody : Label
    {
        public static readonly BindableProperty MaxLengthProperty = 
            BindableProperty.Create(
                nameof(MaxLength), 
                typeof(int), 
                typeof(EmailBody), 
                defaultValue: 200);

        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if(propertyName == TextProperty.PropertyName)
            {
                if (Text?.Length > MaxLength)
                    Text = $"{Text.Substring(0, MaxLength - 15)} ...";
            }
        }
    }
}
