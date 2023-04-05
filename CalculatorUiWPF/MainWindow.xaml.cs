﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowNumber_Click(object sender, RoutedEventArgs e)
        {
            string content = (string)((Button)sender).Content;
            this.OutputTextBlock.Text += content;
        }

        public void DeleteNumber_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBlock.Text = string.Empty;
        }
        
        public void Division_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
