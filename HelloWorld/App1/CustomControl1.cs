using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace App1
{
    public sealed class CustomControl1 : Control
    {
        public CustomControl1()
        {
            this.DefaultStyleKey = typeof(CustomControl1);
            PointerEntered += CustomControl1_PointerEntered;
            PointerExited += CustomControl1_PointerExited;
            VisualStateManager.GoToState(this, "Normal", true);
            
        }

        private void CustomControl1_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CustomControl1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(CustomControl1), new PropertyMetadata(""));


    }
}
