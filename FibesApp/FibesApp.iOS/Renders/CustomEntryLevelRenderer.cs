using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using FibesApp.CustomControls;
using FibesApp.iOS.Renders;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntryLevel), typeof(CustomEntryLevelRenderer))]
namespace FibesApp.iOS.Renders
{
    public class CustomEntryLevelRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            try
            {
                base.OnElementChanged(e);
                if (Control != null)
                {
                    Control.BorderStyle = UITextBorderStyle.None;
                    Control.Layer.CornerRadius = 10;
                    Control.TextColor = UIColor.Black;
                    Control.LeftView = new UIView(new CGRect(0, 0, 10, 0));
                    Control.LeftViewMode = UITextFieldViewMode.Always;
                    Control.RightView = new UIView(new CGRect(0, 0, 10, 0));
                    Control.RightViewMode = UITextFieldViewMode.Always;
                }
            }
            catch (Exception ex)
            { }
        }
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            try
            {
                base.OnElementPropertyChanged(sender, e);

                if (Control == null || this.Element == null) return;

                var element = (CustomEntryLevel)this.Element;
                var textField = this.Control;

                //textField.TextContainerInset = new UIEdgeInsets(10, 10, 10, 10);
                textField.Layer.BorderWidth = 1;

                //textField.BorderStyle = UITextBorderStyle.None;
                CALayer bottomBorder = new CALayer
                {
                    Frame = new CGRect(0.0f, element.HeightRequest - 1, this.Frame.Width, 1.0f),
                    BorderWidth = 2.0f,
                    BorderColor = element.EntryLineColor.ToCGColor()
                };

                textField.Layer.AddSublayer(bottomBorder);
                textField.Layer.MasksToBounds = true;

                if (e.PropertyName == CustomEntryLevel.IsEntrySelectedProperty.PropertyName)
                {
                    this.Control.Layer.BorderWidth = new nfloat(0.8);
                    this.Control.Layer.CornerRadius = 5;

                    if (element.IsEntrySelected)
                        this.Control.Layer.BorderColor = element.SeletectedBorderColor.ToCGColor();
                    else
                        this.Control.Layer.BorderColor = UIColor.LightGray.CGColor;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}