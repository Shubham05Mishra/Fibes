using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.CustomControls
{
    public class CustomEntryLevel : Entry
    {
        public static readonly BindableProperty EntryBorderColorProperty =
        BindableProperty.Create(
            nameof(EntryBorderColor),
            typeof(Color),
            typeof(CustomEntryLevel),
            Color.Gray
            );

        public static readonly BindableProperty EntryBorderCornerProperty =
        BindableProperty.Create(
            nameof(CornerRadius),
            typeof(double),
            typeof(CustomEntryLevel)
            );

        public double CornerRadius
        {
            get { return (double)GetValue(EntryCornerRadiusProperty); }
            set { SetValue(EntryCornerRadiusProperty, value); }
        }

        public Color EntryBorderColor
        {
            get { return (Color)GetValue(EntryBorderColorProperty); }
            set { SetValue(EntryBorderColorProperty, value); }
        }

        public static readonly BindableProperty EntryCornerRadiusProperty =
        BindableProperty.Create(
            nameof(EntryCornerRadius),
            typeof(double),
            typeof(CustomEntryLevel));

        public Color SeletectedBorderColor
        {
            get => (Color)GetValue(SeletectedBorderColorProperty);
            set => SetValue(SeletectedBorderColorProperty, value);
        }

        public static readonly BindableProperty SeletectedBorderColorProperty = BindableProperty.Create(nameof(SeletectedBorderColor), typeof(Color), typeof(Color), Color.Gray, BindingMode.TwoWay, null);

        public double EntryCornerRadius
        {
            get { return (double)GetValue(EntryCornerRadiusProperty); }
            set { SetValue(EntryCornerRadiusProperty, value); }
        }

        public static readonly BindableProperty IsEntrySelectedProperty =
            BindableProperty.Create(nameof(IsEntrySelected), typeof(bool), typeof(CustomEntryLevel), false, BindingMode.TwoWay);

        public bool IsEntrySelected
        {
            get { return (bool)GetValue(IsEntrySelectedProperty); }
            set
            {
                SetValue(IsEntrySelectedProperty, value);
            }
        }

        public static readonly BindableProperty EntryErrorBorderColorProperty =
            BindableProperty.Create(nameof(EntryErrorBorderColor), typeof(Color), typeof(CustomEntryLevel), Xamarin.Forms.Color.Transparent, BindingMode.TwoWay);

        public Color EntryErrorBorderColor
        {
            get { return (Color)GetValue(EntryErrorBorderColorProperty); }
            set
            {
                SetValue(EntryErrorBorderColorProperty, value);
            }
        }

        public static readonly BindableProperty EntryErrorTextProperty =
        BindableProperty.Create(nameof(EntryErrorText), typeof(string), typeof(CustomEntryLevel), string.Empty);

        public string EntryErrorText
        {
            get { return (string)GetValue(EntryErrorTextProperty); }
            set
            {
                SetValue(EntryErrorTextProperty, value);
            }
        }

        public static readonly BindableProperty EntryIsValidProperty =
        BindableProperty.Create(nameof(EntryIsValid), typeof(bool), typeof(CustomEntryLevel), null);

        public bool EntryIsValid
        {
            get => (bool)base.GetValue(EntryIsValidProperty);
            set => base.SetValue(EntryIsValidProperty, value);
        }

        public string EntryImage
        {
            get { return (string)GetValue(EntryImageProperty); }
            set { SetValue(EntryImageProperty, value); }
        }

        public static readonly BindableProperty EntryImageProperty =
            BindableProperty.Create(nameof(EntryImage), typeof(string), typeof(CustomEntryLevel), string.Empty);

        public string EntryImagePassword
        {
            get { return (string)GetValue(EntryImagePasswordProperty); }
            set { SetValue(EntryImagePasswordProperty, value); }
        }

        public static readonly BindableProperty EntryImagePasswordProperty =
            BindableProperty.Create(nameof(EntryImagePassword), typeof(string), typeof(CustomEntryLevel), string.Empty);

        public static readonly BindableProperty EntryLineColorProperty =
            BindableProperty.Create(nameof(EntryLineColor), typeof(Color), typeof(CustomEntryLevel), Color.White);
        public Color EntryLineColor
        {
            get { return (Color)GetValue(EntryLineColorProperty); }
            set { SetValue(EntryLineColorProperty, value); }
        }

        public static readonly BindableProperty EntryImageWidthProperty =
            BindableProperty.Create(nameof(EntryImageWidth), typeof(int), typeof(CustomEntryLevel), 12);
        public int EntryImageWidth
        {
            get { return (int)GetValue(EntryImageWidthProperty); }
            set { SetValue(EntryImageWidthProperty, value); }
        }

        public static readonly BindableProperty EntryImageHeightProperty =
            BindableProperty.Create(nameof(EntryImageHeight), typeof(int), typeof(CustomEntryLevel), 12);

        public int EntryImageHeight
        {
            get { return (int)GetValue(EntryImageHeightProperty); }
            set { SetValue(EntryImageHeightProperty, value); }
        }

        public static readonly BindableProperty EntryImageAlignmentProperty =
            BindableProperty.Create(nameof(EntryImageAlignment), typeof(ImageAlignment), typeof(CustomEntryLevel), ImageAlignment.Left);

        public ImageAlignment EntryImageAlignment
        {
            get { return (ImageAlignment)GetValue(EntryImageAlignmentProperty); }
            set { SetValue(EntryImageAlignmentProperty, value); }
        }
    }
    public enum ImageAlignment
    {
        Left,
        Right
    }
}
