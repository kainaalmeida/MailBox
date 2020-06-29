using MailBox.Customs;
using MailBox.UWP.Renderer;
using System;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace MailBox.UWP.Renderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                this.Control.CornerRadius = new Windows.UI.Xaml.CornerRadius(30);
                this.Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
                this.Control.BorderBrush = new SolidColorBrush(GetSolidColorBrush("#ffffff").Color);

            }

            SolidColorBrush GetSolidColorBrush(string hex)
            {
                hex = hex.Replace("#", string.Empty);
                byte r = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
                byte g = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
                byte b = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));

                SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(255, r, g, b));
                return myBrush;
            }
        }
    }
}
