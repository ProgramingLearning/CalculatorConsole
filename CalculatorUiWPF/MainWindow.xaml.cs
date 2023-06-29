using CalculatorLogic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorUiWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Operation _operation = Operation.None;

        private Operation operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(LabelText)));
            }
        }

        private string _number1;

        private string number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(LabelText)));
            }
        }

        private string OutputTextBlockP
        {
            get
            {
                if (this.OutputTextBlock != null)
                {
                    return this.OutputTextBlock.Text;
                }

                return string.Empty;
            }
            set
            {
                this.OutputTextBlock.Text = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(LabelText)));
            }
        }


        private bool hasOperationBeenPressed;
        private bool hasResultBeenPressed;
        private bool canShowResult;

        public event PropertyChangedEventHandler PropertyChanged;

        public string LabelText
        {
            get
            {
                return $"{number1} {ConvertEnum()} {this.OutputTextBlockP}";
            }
        }

        private string ConvertEnum()
        {
            switch (operation)
            {
                case Operation.Sum:
                    return "+";
                case Operation.Sub:
                    return "-";
                case Operation.Mult:
                    return "*";
                case Operation.Div:
                    return "/";
                default:
                    return string.Empty;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowNumber_Click(object sender, RoutedEventArgs e)
        {
            SetFlagsAfterShowNumberClick();

            string content = (string)((Button)sender).Content;
            SetContentToOutputText(content);
        }

        private void SetFlagsAfterShowNumberClick()
        {
            if (hasOperationBeenPressed || hasResultBeenPressed)
            {
                this.OutputTextBlockP = "0";

                if (hasOperationBeenPressed)
                {
                    canShowResult = true;
                }
            }

            hasOperationBeenPressed = false;
            hasResultBeenPressed = false;
        }

        private void SetContentToOutputText(string content)
        {
            if (this.OutputTextBlockP == "0")
            {
                if (content == ".")
                {
                    this.OutputTextBlockP += content;
                }
                else
                {
                    this.OutputTextBlockP = content;
                }
            }
            else
            {
                this.OutputTextBlockP += content;
            }

        }

        public void DeleteNumber_Click(object sender, RoutedEventArgs e)
        {
            this.OutputTextBlockP = "0";
            canShowResult = false;
        }

        public void Division_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.OutputTextBlockP))
            {
                TryCalculate();
                operation = Operation.Div;
                number1 = this.OutputTextBlockP;
                hasOperationBeenPressed = true;
            }
        }

        public void Substraction_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.OutputTextBlockP))
            {
                TryCalculate();
                operation = Operation.Sub;
                number1 = this.OutputTextBlockP;
                hasOperationBeenPressed = true;
            }
        }

        public void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.OutputTextBlockP))
            {
                TryCalculate();
                operation = Operation.Mult;
                number1 = this.OutputTextBlockP;
                hasOperationBeenPressed = true;
            }
        }

        public void Sum_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.OutputTextBlockP))
            {
                TryCalculate();
                operation = Operation.Sum;
                number1 = this.OutputTextBlockP;
                hasOperationBeenPressed = true;
            }
        }

        public void Result_Click(object sender, RoutedEventArgs e)
        {
            TryCalculate();
        }

        private void TryCalculate()
        {
            if (canShowResult)
            {
                if (!hasResultBeenPressed)
                {
                    var numberD1 = double.Parse(number1);
                    var numberD2 = double.Parse(this.OutputTextBlockP);
                    DoCalculation(numberD1, numberD2);
                }

                hasResultBeenPressed = true;
                canShowResult = false;
            }
        }

        private void DoCalculation(double numberD1, double numberD2)
        {
            switch (operation)
            {
                case Operation.Sum:
                    {
                        this.OutputTextBlockP = CalculatorLogic.MathematicalOperations.GetSumResult(numberD1, numberD2).ToString();
                        break;
                    }
                case Operation.Sub:
                    {
                        this.OutputTextBlockP = CalculatorLogic.MathematicalOperations.GetSubResult(numberD1, numberD2).ToString();
                        break;
                    }
                case Operation.Mult:
                    {
                        this.OutputTextBlockP = CalculatorLogic.MathematicalOperations.GetMultiplicantionResult(numberD1, numberD2).ToString();
                        break;
                    }
                case Operation.Div:
                    {
                        if (numberD2 != 0)
                        {
                            this.OutputTextBlockP = CalculatorLogic.MathematicalOperations.GetDivResult(numberD1, numberD2).ToString();
                        }
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
