using System;
using Xamarin.Forms;

namespace XamarinSample.Extend
{
    public class ListViewCell : ViewCell
    {
        public static readonly BindableProperty SelectedBackgroundColorProperty =
            BindableProperty.Create("SelectedBackgroundColor",
                                    typeof(Color),
                                    typeof(ListViewCell),
                                    Color.Default);

        public Color SelectedBackgroundColor
        {
            get
            {
                return (Color)GetValue(SelectedBackgroundColorProperty);
            }
            set
            {
                SetValue(SelectedBackgroundColorProperty, value);
            }
        }
    }
}
