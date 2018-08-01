using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int a = 0, b = 0 , c = 0;
        string sign = "";

        private void Click_0(object sender, RoutedEventArgs e)
        {
            Display.Text += "0";
        }

        private void Click_1(object sender, RoutedEventArgs e)
        {
            Display.Text += "1";
        }

        private void Click_2(object sender, RoutedEventArgs e)
        {
            Display.Text += "2";
        }

        private void Click_3(object sender, RoutedEventArgs e)
        {
            Display.Text += "3";
        }

        private void Click_4(object sender, RoutedEventArgs e)
        {
            Display.Text += "4";
        }

        private void Click_5(object sender, RoutedEventArgs e)
        {
            Display.Text += "5";
        }

        private void Click_6(object sender, RoutedEventArgs e)
        {
            Display.Text += "6";
        }

        private void Click_7(object sender, RoutedEventArgs e)
        {
            Display.Text += "7";
        }

        private void Click_8(object sender, RoutedEventArgs e)
        {
            Display.Text += "8";
        }

        private void Click_9(object sender, RoutedEventArgs e)
        {
            Display.Text += "9";
        }

        private void Click_C(object sender, RoutedEventArgs e)
        {
            a = 0; b = 0; c = 0;
            sign = "";
            Display.Text = "";
        }

        private void Click_Plus(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(Display.Text);
            sign = "+";
            Display.Text = "";
        }

        private void Click_Minus(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(Display.Text);
            sign = "-";
            Display.Text = "";
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            b = Convert.ToInt32(Display.Text);
            switch (sign)
            {
                case "+": c = a + b;
                    break;
                case "-": c = a - b;
                    break;
            }
            Display.Text = c.ToString();
        }
    }
}
