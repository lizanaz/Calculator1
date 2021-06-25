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

namespace Calculator1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double a;
        public double b;
        public double c;


        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "7";
        }

        private void btnErase_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Clear();
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "4";
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "1";
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "0";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "2";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "5";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "8";
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = Convert.ToString(Math.Sqrt(a));
        }

        private void btsnPercent_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = Convert.ToString(a / 100);

        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "9";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "6";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "3";
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += ".";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "";
            switch (c)
            {
                case '+':
                    txtOutput.Text = Convert.ToString(a + b);
                    break;
                case '-':
                    txtOutput.Text = Convert.ToString(a - b);
                    break;
                case '*':
                    txtOutput.Text = Convert.ToString(a * b);
                    break;
                case '/':
                    txtOutput.Text = Convert.ToString(a / b);
                    break;
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txtOutput.Text);
                c = '+';
                txtOutput.Text = "";
            }
            catch (Exception)
            {

            }

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txtOutput.Text);
                c = '-';
                txtOutput.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txtOutput.Text);
                c = '*';
                txtOutput.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txtOutput.Text);
                c = '/';
                txtOutput.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void btnDoubleZero_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "00";
        }
    }
}

