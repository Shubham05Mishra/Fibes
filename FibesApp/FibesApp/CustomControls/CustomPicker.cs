﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.CustomControls
{
   public class CustomPicker : Picker
    {
        public CustomPicker()
        { }
        public static readonly BindableProperty FontSizeProperty =
       BindableProperty.Create(nameof(FontSize), typeof(Int32), typeof(CustomPicker), 16, BindingMode.TwoWay);

        public Int32 FontSize
        {
            set { SetValue(FontSizeProperty, value); }
            get { return (Int32)GetValue(FontSizeProperty); }
        }

        public static BindableProperty PlaceholderColorProperty =
            BindableProperty.Create(nameof(PlaceholderColor), typeof(string), typeof(CustomPicker), "#000000", BindingMode.TwoWay);

        public string PlaceholderColor
        {
            get { return (string)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }

        public static BindableProperty TitleColorProperty =
           BindableProperty.Create(nameof(TitleColor), typeof(string), typeof(CustomPicker), "#000000", BindingMode.TwoWay);
        public string TitleColor
        {

            get { return (string)GetValue(TitleColorProperty); }
            set { SetValue(TitleColorProperty, value); }
        }


    }
}
