using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Rekenmachine
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double number1;
        private double number2;
        private double answer;

        public MainPage()
        {
            this.InitializeComponent();
            number1 = 0;
            number2 = 0;
            answer = 0;
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(inputBox1.Text, out number1);
            Double.TryParse(inputBox2.Text, out number2);
            answer = number1 + number2;
            answerBox.Text = answer.ToString();
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(inputBox1.Text, out number1);
            Double.TryParse(inputBox2.Text, out number2);
            answer = number1 - number2;
            answerBox.Text = answer.ToString();
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(inputBox1.Text, out number1);
            Double.TryParse(inputBox2.Text, out number2);
            answer = number1 * number2;
            answerBox.Text = answer.ToString();
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(inputBox1.Text, out number1);
            Double.TryParse(inputBox2.Text, out number2);
            answer = number1 / number2;
            answerBox.Text = answer.ToString();
        }
    }
}
