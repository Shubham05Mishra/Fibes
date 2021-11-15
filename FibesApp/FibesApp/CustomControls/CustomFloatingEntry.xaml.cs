using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FibesApp.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomFloatingEntry : ContentView
    {
        int _fontSizePlaceholder = 15;
        int _fontSizeTitle = 13;
        int _marginTop = -8;
        private int tapCount;

        public event EventHandler ImagePassowordClicked;
        public CustomFloatingEntry()
        {
            InitializeComponent();
            LabelFloating.TranslationX = 10;
            LabelFloating.TranslationY = 10;
            LabelFloating.FontSize = _fontSizePlaceholder;
        }
        public string EntryText
        {
            get => (string)GetValue(EntryTextProperty);
            set => SetValue(EntryTextProperty, value);
        }

        public static readonly BindableProperty EntryTextProperty = BindableProperty.Create(nameof(EntryText), typeof(string), typeof(string), string.Empty, BindingMode.TwoWay, null, HandleBindingPropertyChangedDelegate);

        public string EntryImage
        {
            get { return (string)GetValue(EntryImageProperty); }
            set { SetValue(EntryImageProperty, value); }
        }

        public static readonly BindableProperty EntryImageProperty = BindableProperty.Create(nameof(EntryImage), typeof(string), typeof(string), string.Empty, BindingMode.TwoWay, null, HandleBindingImagemPropertyChangedDelegate);

        static void HandleBindingImagemPropertyChangedDelegate(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as CustomFloatingEntry;
            if (control.EntryImage != null)
            {
                control.customEntry.EntryImage = control.EntryImage;
            }
        }


        public string lblTextTitle
        {
            get => (string)GetValue(lblTextTitleProperty);
            set => SetValue(lblTextTitleProperty, value);
        }

        public static readonly BindableProperty lblTextTitleProperty = BindableProperty.Create(nameof(lblTextTitle), typeof(string), typeof(string), string.Empty, BindingMode.TwoWay, null);


        public Color SeletectedBorderColor
        {
            get => (Color)GetValue(SeletectedBorderColorProperty);
            set => SetValue(SeletectedBorderColorProperty, value);
        }

        public static readonly BindableProperty SeletectedBorderColorProperty = BindableProperty.Create(nameof(SeletectedBorderColor), typeof(Color), typeof(Color), Color.Gray, BindingMode.TwoWay, null);


        static async void HandleBindingPropertyChangedDelegate(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as CustomFloatingEntry;
            if (!control.customEntry.IsFocused)
            {
                if (!string.IsNullOrEmpty((string)newValue))
                {
                    await control.LabelFloatingToTransition(false);
                }
                else
                {
                    await control.LabelFloatingPlaceholderTransitionTo(false);
                }
            }
        }

        public static readonly BindableProperty EntryReturnTypeProperty =
            BindableProperty.Create(nameof(EntryReturnType), typeof(ReturnType), typeof(CustomFloatingEntry), ReturnType.Default);
        public ReturnType EntryReturnType
        {
            get => (ReturnType)GetValue(EntryReturnTypeProperty);
            set => SetValue(EntryReturnTypeProperty, value);
        }

        public static readonly BindableProperty EntryIsPasswordProperty =
            BindableProperty.Create(nameof(EntryIsPassword), typeof(bool), typeof(CustomFloatingEntry), default(bool));
        public bool EntryIsPassword
        {
            get { return (bool)GetValue(EntryIsPasswordProperty); }
            set { SetValue(EntryIsPasswordProperty, value); }
        }

        public static readonly BindableProperty EntryIsEnabledProperty =
            BindableProperty.Create(nameof(EntryIsEnabled), typeof(bool), typeof(CustomFloatingEntry), true, BindingMode.TwoWay, null, HandleBindingEntryEnabledPropertyChangedDelegate);
        public bool EntryIsEnabled
        {
            get { return (bool)GetValue(EntryIsEnabledProperty); }
            set { SetValue(EntryIsEnabledProperty, value); }
        }

        static void HandleBindingEntryEnabledPropertyChangedDelegate(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as CustomFloatingEntry;
            if (control.EntryIsEnabled != null)
            {
                control.customEntry.IsEnabled = control.EntryIsEnabled;
            }
        }
        public static readonly BindableProperty EntryMaxLengthProperty =
            BindableProperty.Create(nameof(EntryMaxLength), typeof(int), typeof(int), 1000000, BindingMode.TwoWay, null, HandleBindingEntryMaxLengthPropertyChangedDelegate);
        //BindableProperty.Create(nameof(EntryMaxLength), typeof(int), typeof(CustomFloatingEntry), default(int));
        //public static readonly BindableProperty EntryTextProperty = BindableProperty.Create(nameof(EntryText), typeof(string), typeof(string), string.Empty, BindingMode.TwoWay, null, HandleBindingPropertyChangedDelegate);

        public int EntryMaxLength
        {
            get { return (int)GetValue(EntryMaxLengthProperty); }
            set { SetValue(EntryMaxLengthProperty, value); }
        }
        static void HandleBindingEntryMaxLengthPropertyChangedDelegate(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as CustomFloatingEntry;
            if (control.EntryMaxLength != null)
            {
                control.customEntry.MaxLength = control.EntryMaxLength;
            }
        }

        public static readonly BindableProperty EntryKeyboardProperty =
            BindableProperty.Create(nameof(EntryKeyboard), typeof(Keyboard), typeof(CustomFloatingEntry), Keyboard.Default, coerceValue: (o, v) => (Keyboard)v ?? Keyboard.Default);
        public Keyboard EntryKeyboard
        {
            get { return (Keyboard)GetValue(EntryKeyboardProperty); }
            set { SetValue(EntryKeyboardProperty, value); }
        }

        public async new void Focus()
        {
            if (IsEnabled)
            {
                customEntry.Focus();
                if (string.IsNullOrEmpty(EntryText))
                {
                    customEntry.IsEntrySelected = true;
                    LabelFloating.Text = $" {LabelFloating.Text} ";
                    LabelFloating.TextColor = customEntry.SeletectedBorderColor;
                    await LabelFloatingToTransition(true);
                }
            }
        }

        async void CustomEntry_Focused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(EntryText))
            {
                customEntry.IsEntrySelected = true;
                LabelFloating.Text = $" {LabelFloating.Text} ";
                LabelFloating.TextColor = customEntry.SeletectedBorderColor;
                await LabelFloatingToTransition(true);
            }
        }

        async void CustomEntry_Unfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(EntryText))
            {
                customEntry.IsEntrySelected = false;
                LabelFloating.Text = LabelFloating.Text.Trim();
                LabelFloating.TextColor = Color.FromHex("#9e9e9e");
                await LabelFloatingPlaceholderTransitionTo(true);
            }
            if (!string.IsNullOrEmpty(EntryText) && LabelFloating.Text == " E-mail Address ")
            {
                Xamarin.Forms.MessagingCenter.Send<string>("", "ValidateEmail");
            }
            if (Device.RuntimePlatform == Device.iOS)
            {
                //string email = Helpers.Settings.GeneralUserEmail;
                //if (email == EntryText)
                //{
                //    customEntry.TextColor = Color.LightGray;

                //}
            }
        }

        async Task LabelFloatingToTransition(bool animated)
        {
            if (animated)
            {
                var t1 = LabelFloating.TranslateTo(10, _marginTop, 100);
                LabelFloating.BackgroundColor = Color.FromHex("#ffffff");
                var t2 = SizeTo(_fontSizeTitle);

                await Task.WhenAll(t1, t2);
            }
            else
            {
                LabelFloating.TranslationX = 0;
                LabelFloating.TranslationY = -35;
                LabelFloating.FontSize = 14;
            }

        }

        async Task LabelFloatingPlaceholderTransitionTo(bool animated)
        {
            if (animated)
            {
                var t1 = LabelFloating.TranslateTo(10, 10, 100);
                var t2 = SizeTo(_fontSizePlaceholder);
                await Task.WhenAll(t1, t2);
            }
            else
            {
                LabelFloating.TranslationX = 10;
                LabelFloating.TranslationY = 13;
                LabelFloating.FontSize = _fontSizePlaceholder;
            }
        }

        void LabelFloating_Tapped(object sender, EventArgs e)
        {
            if (IsEnabled)
            {
                customEntry.Focus();
            }
        }

        Task SizeTo(int fontSize)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();

            Action<double> callback = input => { LabelFloating.FontSize = input; };
            double startingHeight = LabelFloating.FontSize;
            double endingHeight = fontSize;
            uint rate = 5;
            uint length = 100;
            Easing easing = Easing.Linear;

            LabelFloating.Animate("invis", callback, startingHeight, endingHeight, rate, length, easing, (v, c) => taskCompletionSource.SetResult(c));

            return taskCompletionSource.Task;
        }

        public event EventHandler Completed;
        void CustomEntry_Completed(object sender, EventArgs e)
        {
            Completed?.Invoke(this, e);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == nameof(IsEnabled))
            {
                customEntry.IsEnabled = IsEnabled;
            }
            //string entryText = EntryText;
            //if (EntryText.Contains(".."))
            //{
            //    // Stop more than one dot Char
            //    EntryText = customEntry.Text;
            //}
        }
    }
}