using System;
using FormsPlugin.Iconize;
using Xamarin.Forms;
using XamarinSample.Views.Tabbed;

namespace XamarinSample.Views
{
    public class MainIconTabbedPage : IconTabbedPage
    {
        
        public MainIconTabbedPage()
        {
            Title = "Sample";

            BarBackgroundColor = Color.FromHex("#2E8B57");

            Children.Add(new TabHomeView
            {
                Title = "Home",
                Icon = "fa-home",
            });

            Children.Add(new TabVideoView
            {
                Title = "Video",
                Icon = "fa-vimeo",
            });
        }
    }
}
