using CoreGraphics;
using FibesApp.CustomControls;
using FibesApp.iOS.Renders;
using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]

namespace FibesApp.iOS.Renders
{
  public  class CustomPickerRenderer : PickerRenderer
    {
        public static void Init() { }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            try
            {
                base.OnElementPropertyChanged(sender, e);
                if (Control != null)
                {
                    Control.Layer.BorderWidth = 0;
                    Control.Font = UIFont.SystemFontOfSize(16);
                    Control.BorderStyle = UITextBorderStyle.None;
                    Control.LeftView = new UIView(new CGRect(0, 0, 5, 0));
                    Control.LeftViewMode = UITextFieldViewMode.Always;
                }
            }
            catch (Exception ex) { }
        }
    }
}