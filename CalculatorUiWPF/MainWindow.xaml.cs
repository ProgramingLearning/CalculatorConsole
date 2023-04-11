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

namespace CalculatorUiWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string operation;
        private string number1;
        private bool hasOperationBeenPressed;
        private bool hasResultBeenPressed;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowNumber_Click(object sender, RoutedEventArgs e)
        {
            if (hasOperationBeenPressed)
            {
                OutputTextBlock.Text = string.Empty;
            }

            string content = (string)((Button)sender).Content;
            this.OutputTextBlock.Text += content;

            hasOperationBeenPressed = false;
            hasResultBeenPressed = false;
        }

        public void DeleteNumber_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBlock.Text = string.Empty;
        }

        public void Division_Click(object sender, RoutedEventArgs e)
        {
            operation = "division";
            number1 = OutputTextBlock.Text;
            hasOperationBeenPressed = true;
        }

        public void Substraction_Click(object sender, RoutedEventArgs e)
        {
            operation = "substraction";
            number1 = OutputTextBlock.Text;
            hasOperationBeenPressed = true;
        }

        public void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            operation = "multiplication";
            number1 = OutputTextBlock.Text;
            hasOperationBeenPressed = true;
        }

        public void Sum_Click(object sender, RoutedEventArgs e)
        {
            operation = "sum";
            number1 = OutputTextBlock.Text;
            hasOperationBeenPressed = true;
        }

        public void Result_Click(object sender, RoutedEventArgs e)
        {
            hasOperationBeenPressed = true;
            if (!hasResultBeenPressed)
            {
                var numberD1 = double.Parse(number1);
                var numberD2 = double.Parse(OutputTextBlock.Text);
                switch (operation)
                {
                    case "division":
                        {
                            if (numberD2 != 0)
                            {
                                OutputTextBlock.Text = CalculatorLogic.MathematicalOperations.GetDivResult(numberD1, numberD2).ToString();
                            }
                            break;
                        }
                    case "sum":
                        {
                            OutputTextBlock.Text = CalculatorLogic.MathematicalOperations.GetSumResult(numberD1, numberD2).ToString();
                            break;
                        }
                    case "substraction":
                        {
                            OutputTextBlock.Text = CalculatorLogic.MathematicalOperations.GetSubResult(numberD1, numberD2).ToString();
                            break;
                        }

                    case "multiplication":
                        {
                            OutputTextBlock.Text = CalculatorLogic.MathematicalOperations.GetMultiplicantionResult(numberD1, numberD2).ToString();
                            break;
                        }
                    default:
                        break;
                }
            }
            hasResultBeenPressed = true;
        }
    }
}
