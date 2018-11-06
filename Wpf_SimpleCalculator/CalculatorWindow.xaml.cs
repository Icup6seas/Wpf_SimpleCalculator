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

namespace Wpf_SimpleCalculator
{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        //
        //Variables
        int num1 = 0;
        int num2 = 0;
        string Operator = "";

        public CalculatorWindow()
        {
            InitializeComponent();
        }

        //
        //When clicked, sets the Text Box to "0"
        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            txtBox_Main.Text = "0";
            Operator = "";
        }

        //
        //A Switch Statement to tell what math to do when Equals is clicked
        private void btn_Equal_Click(object sender, RoutedEventArgs e)
        {
            num2 = int.Parse(txtBox_Main.Text);

            switch (Operator)
            {
                case "+":
                    txtBox_Main.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtBox_Main.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    txtBox_Main.Text = (num1 * num2).ToString();
                    break;
            }
        }

        //
        //Not sure what this is exactly, it forced me to put this or the 
        //application would not run
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //
        //Reads whats in the text box
        private void input(string a)
        {
            if (txtBox_Main.Text == "0")
                txtBox_Main.Text = a;
            else
                txtBox_Main.Text += a;
        }

        //
        //Acts like a lister for when a number is clicked
        private void btn_Number_Click(object sender, RoutedEventArgs e)
        {
            Button btn_Number = (Button)sender;
            input(btn_Number.Content.ToString());
        }

        //
        //Defines the Operator functions: -, *, +
        private void btn_Operator_Click(object sender, RoutedEventArgs e)
        {
            Button btn_Operator = (Button)sender;
            Operator = btn_Operator.Content.ToString();
            num1 = int.Parse(txtBox_Main.Text);
            txtBox_Main.Text = "0";
        }
    }
}

