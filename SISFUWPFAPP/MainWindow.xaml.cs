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

namespace SISFUWPFAPP
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Window1.Title = "Hello Students!";
            //MessageBox.Show("Hello from the button!");
            //MessageBox.Show("I'm warning you!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);

            if (tb_one.Text.Length > 0)
            {
                Window1.Title = $"Hello {tb_one.Text}! I am the Window!";
                MessageBox.Show($"Hello {tb_one.Text}! I popped up!", "Hello!",
                     MessageBoxButton.OK, MessageBoxImage.Information);
                tb_one.Text = "";
            }
            else
            {
                MessageBox.Show($"Hello friend! What is your name?", "Hello!",
                    MessageBoxButton.OK, MessageBoxImage.Question);
                LablWarning.Content = "Hint: Put your name in the text box above!...";
            }


        }

        private void buton1_Click(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString().Length < 6)
            { lblPIN.Content += "1"; }

        }

        private void buton2_Click(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString().Length < 6)
            { lblPIN.Content += "2"; }
        }

        private void buton3_Click(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString().Length < 6)
            { lblPIN.Content += "3"; }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString().Length < 6)
            { lblPIN.Content += "4"; }
        }

        private void buton4_Click(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString().Length < 6)
            { lblPIN.Content += "5"; }
        }

        private void buton6_Click(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString().Length < 6)
            { lblPIN.Content += "6"; }
        }

        private void buton7_Click(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString().Length < 6)
            { lblPIN.Content += "7"; }
        }

        private void buton8_Click(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString().Length < 6)
            { lblPIN.Content += "8"; }
        }

        private void buton9_Click(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString().Length < 6)
            { lblPIN.Content += "9"; }
        }

        private void buton0_Click_1(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString().Length < 6)
            { lblPIN.Content += "0"; }
        }

        private void clearnumb_Click(object sender, RoutedEventArgs e)
        {
            { lblPIN.Content = ""; }
        }

        private void EnterButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (lblPIN.Content.ToString() == "123456")
            {
                MessageBox.Show("Correct PIN!", "Access Granted. Welcome!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Incorrect PIN!", "Access Denied. Try Again.", MessageBoxButton.OK, MessageBoxImage.Error);
                clearnumb_Click(null, null);
            }
        }
    }
}

