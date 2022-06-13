using System;
using System.Windows;

namespace WpfBMI
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            double height, weight;

            try
            {
                if (!string.IsNullOrEmpty(inHeight.Text) &&
                    !string.IsNullOrEmpty(inWeight.Text) &&
                    double.TryParse(inHeight.Text, out height) &&
                    double.TryParse(inWeight.Text, out weight))
                {
                    calResult.Text = (weight / Math.Pow(height / 100, 2)).ToString();
                }
                else
                {
                    calResult.Text = "輸入有誤";
                }
            }
            catch (Exception ex)
            {
                calResult.Text = $"錯誤:{ex}";
            }
        }
    }
}
