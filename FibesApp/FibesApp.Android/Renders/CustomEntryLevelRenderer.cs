using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using FibesApp.CustomControls;
using FibesApp.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntryLevel), typeof(CustomEntryLevelRenderer))]
namespace FibesApp.Droid.Renders
{
    public class CustomEntryLevelRenderer : EntryRenderer
    {
        CustomEntryLevel element;
        public CustomEntryLevelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            try
            {
                base.OnElementChanged(e);

                if (Control == null || e.NewElement == null) return;

                if (e.NewElement != null)
                {
                    element = (CustomEntryLevel)Element;

                    UpdateBorders(element);


                    Control.CompoundDrawablePadding = 10;

                    //Define a distancia entre o texto interno da borda
                    Control.SetPadding(
                        (int)DpToPixels(this.Context, Convert.ToSingle(10)), Control.PaddingTop,
                        (int)DpToPixels(this.Context, Convert.ToSingle(10)), Control.PaddingBottom);
                }
            }
            catch (Exception ex)
            { }
        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            try
            {
                base.OnElementPropertyChanged(sender, e);

                if (Control == null) return;

                if (e.PropertyName == CustomEntryLevel.IsEntrySelectedProperty.PropertyName)
                    UpdateBorders(element);
            }
            catch (Exception ex)
            { }
        }

        void UpdateBorders(CustomEntryLevel element)
        {
            try
            {
                GradientDrawable shape = new GradientDrawable();
                shape.SetShape(ShapeType.Rectangle);
                shape.SetCornerRadius(20);
                shape.SetPadding(50, 0, 150, 0);

                if (element.IsEntrySelected)
                    shape.SetStroke(6, element.SeletectedBorderColor.ToAndroid());
                else
                    shape.SetStroke(2, Android.Graphics.Color.ParseColor("#808080"));//shape.SetStroke(2, element.EntryBorderColor.ToAndroid());

                this.Control.SetBackground(shape);
            }
            catch (Exception ex)
            {
            }
        }
    }
}