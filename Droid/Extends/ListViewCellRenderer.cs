using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinSample.Droid.Extends;
using XamarinSample.Extend;

[assembly: ExportRenderer(typeof(ListViewCell), typeof(ListViewCellRenderer))]
namespace XamarinSample.Droid.Extends
{
    public class ListViewCellRenderer : ViewCellRenderer
    {
        private Android.Views.View cellCore;
        private Drawable unselectedBackground;
        private bool selected;

		protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
		{
            cellCore = base.GetCellCore(item, convertView, parent, context);

            selected = false;
            unselectedBackground = cellCore.Background;

            return cellCore;
		}


		protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            base.OnCellPropertyChanged(sender, e);

            if(e.PropertyName == "IsSelected")
            {
                selected = !selected;

                if(selected)
                {
                    var customeCell = sender as ListViewCell;
                    cellCore.SetBackgroundColor(customeCell.SelectedBackgroundColor.ToAndroid());
                }
                else{
                    cellCore.SetBackground(unselectedBackground);
                }
            }
		}
	}
}
