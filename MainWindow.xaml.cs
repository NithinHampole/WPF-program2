using System;
using System.Linq;
using System.Windows;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Output.Clear();
            var numbers = ParseInput();
            var result = numbers.Where(num => num > 50);
            Output.Text = string.Join(" ", result);
        }

        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Output.Clear();
            var numbers = ParseInput();
            var result = numbers.OrderBy(num => num);
            Output.Text = string.Join(" ", result);
        }

        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Output.Clear();
            var numbers = ParseInput();
            var result = numbers.Select(num => num * num);
            Output.Text = string.Join(" ", result);
        }

        
        private int[] ParseInput()
        {
            return input1.Text
                .Split(new[] { ' ' })
                .Select(s => int.Parse(s.Trim()))
                .ToArray();
        }

    }
}
