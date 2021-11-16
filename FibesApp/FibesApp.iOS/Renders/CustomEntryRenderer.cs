using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using FibesApp.CustomControls;
using FibesApp.iOS.Renders;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]

namespace FibesApp.iOS.Renders
{
    class CustomEntryRenderer : EntryRenderer
    {
        #region Override Method
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            try
            {
                base.OnElementPropertyChanged(sender, e);
                if (Control != null)
                {
                    Control.BorderStyle = UITextBorderStyle.None;
                    Control.TintColor = UIColor.White;
                }
            }
            catch (Exception ex)
            { }
        }

        #endregion
    }
}