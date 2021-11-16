using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FibesApp.CustomControls;
using FibesApp.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]

namespace FibesApp.Droid.Renders
{
    class CustomEntryRenderer : EntryRenderer
    {
        #region Constructor
        public CustomEntryRenderer(Context context) : base(context)
        { }
        #endregion

        #region Overrides Methods 
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
            }
            #endregion
        }
    }
}