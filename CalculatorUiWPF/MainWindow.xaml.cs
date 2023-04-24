using System.Windows;
using System.Windows.Controls;

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
        private bool canShowResult;

        public string LabelText
        {
            get
            {
                return $"{number1} {operation} {this.OutputTextBlock.Text}";
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowNumber_Click(object sender, RoutedEventArgs e)
        {
            if (hasOperationBeenPressed || hasResultBeenPressed)
            {
                OutputTextBlock.Text = string.Empty;

                if (hasOperationBeenPressed)
                {
                    canShowResult = true;
                }
            }

            string content = (string)((Button)sender).Content;
            this.OutputTextBlock.Text += content;

            hasOperationBeenPressed = false;
            hasResultBeenPressed = false;
        }

        public void DeleteNumber_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBlock.Text = string.Empty;
            canShowResult = false;
        }

        public void Division_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputTextBlock.Text))
            {
                operation = "division";
                number1 = OutputTextBlock.Text;
                hasOperationBeenPressed = true;
            }
        }

        public void Substraction_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputTextBlock.Text))
            {
                operation = "substraction";
                number1 = OutputTextBlock.Text;
                hasOperationBeenPressed = true;
            }
        }

        public void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputTextBlock.Text))
            {
                operation = "multiplication";
                number1 = OutputTextBlock.Text;
                hasOperationBeenPressed = true;
            }
        }

        public void Sum_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputTextBlock.Text))
            {
                operation = "sum";
                number1 = OutputTextBlock.Text;
                hasOperationBeenPressed = true;
            }
        }

        public void Result_Click(object sender, RoutedEventArgs e)
        {
            if (canShowResult)
            {
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
                canShowResult = false;
            }
        }
    }
}
