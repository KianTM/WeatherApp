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
using WeatherApp.BIZ;

namespace WeatherApp.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ biz = new ClassBIZ();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SetTemperature();
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            SetTemperature();
        }

        private void SetTemperature()
        {
            double temp = biz.GetTemperature(cityInputTextBox.Text);

            if (temp == -404)
            {
                temperatureLabel.Content = "! error !";
            }
            else
            {
                temperatureLabel.Content = $"{temp}°C";
            }
        }
    }
}
