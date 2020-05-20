using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PetDiary.Converters
{
    public static class RadioButtonHelper
    {
        [AttachedPropertyBrowsableForType(typeof(RadioButton))]
        public static object GetRadioValue(DependencyObject obj) => obj.GetValue(RadioValueProperty);
        public static void SetRadioValue(DependencyObject obj, object value) => obj.SetValue(RadioValueProperty, value);
        public static readonly DependencyProperty RadioValueProperty =
            DependencyProperty.RegisterAttached("RadioValue", typeof(object), typeof(RadioButtonHelper), new PropertyMetadata(new PropertyChangedCallback(OnRadioValueChanged)));

        private static void OnRadioValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RadioButton rb)
            {
                rb.Checked -= OnChecked;
                rb.Checked += OnChecked;
            }
        }

        public static void OnChecked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rb)
            {
                rb.SetCurrentValue(RadioBindingProperty, rb.GetValue(RadioValueProperty));
            }
        }

        [AttachedPropertyBrowsableForType(typeof(RadioButton))]
        public static object GetRadioBinding(DependencyObject obj) => obj.GetValue(RadioBindingProperty);
        public static void SetRadioBinding(DependencyObject obj, object value) => obj.SetValue(RadioBindingProperty, value);

        public static readonly DependencyProperty RadioBindingProperty =
            DependencyProperty.RegisterAttached("RadioBinding", typeof(object), typeof(RadioButtonHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnRadioBindingChanged)));

        private static void OnRadioBindingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RadioButton rb && rb.GetValue(RadioValueProperty).Equals(e.NewValue))
            {
                rb.SetCurrentValue(RadioButton.IsCheckedProperty, true);
            }
        }
    }
}
