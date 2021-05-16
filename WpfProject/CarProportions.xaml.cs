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
using System.Windows.Shapes;

namespace WpfProject
{
    /// <summary>
    /// Interakční logika pro CarProportions.xaml
    /// </summary>
    public partial class CarProportions : Window
    {
        public static Cars car1 = new Cars();
        public static Cars car2 = new Cars();
        public CarProportions(Cars c1, Cars c2)
        {
            InitializeComponent();
            car1 = c1;
            car2 = c2;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            c1_Brand.Text = car1.Brand;
            c1_Model.Text = car1.Model;
            c1_Year.Text = car1.Year.ToString();
            c1_Prize.Text = car1.Prize.ToString();
            c1_Body.Text = car1.Body;
            c1_Transmission.Text = car1.Transmission;
            c1_Fuel.Text = car1.Fuel;
            c1_Speedometer.Text = car1.Speedometer.ToString();
            c1_Engine.Text = car1.Engine;

            c2_Brand.Text = car2.Brand;
            c2_Model.Text = car2.Model;
            c2_Year.Text = car2.Year.ToString();
            c2_Prize.Text = car2.Prize.ToString();
            c2_Body.Text = car2.Body;
            c2_Transmission.Text = car2.Transmission;
            c2_Fuel.Text = car2.Fuel;
            c2_Speedometer.Text = car2.Speedometer.ToString();
            c2_Engine.Text = car2.Engine;

            if (car1.Prize < car2.Prize)
            {
                c1_Prize.Foreground = new SolidColorBrush(Colors.Green);
                c2_Prize.Foreground = new SolidColorBrush(Colors.Red);
            }
            else if(car1.Prize == car2.Prize)
            {
                c1_Prize.Foreground = new SolidColorBrush(Colors.Yellow);
                c2_Prize.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else
            {
                c2_Prize.Foreground = new SolidColorBrush(Colors.Green);
                c1_Prize.Foreground = new SolidColorBrush(Colors.Red);
            }
            if (car1.Year > car2.Year)
            {
                c1_Year.Foreground = new SolidColorBrush(Colors.Green);
                c2_Year.Foreground = new SolidColorBrush(Colors.Red);
            }
            else if (car1.Year == car2.Year)
            {
                c1_Year.Foreground = new SolidColorBrush(Colors.Yellow);
                c2_Year.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else
            {
                c2_Year.Foreground = new SolidColorBrush(Colors.Green);
                c1_Year.Foreground = new SolidColorBrush(Colors.Red);
            }
            if (car1.Speedometer < car2.Speedometer)
            {
                c1_Speedometer.Foreground = new SolidColorBrush(Colors.Green);
                c2_Speedometer.Foreground = new SolidColorBrush(Colors.Red);
            }
            else if (car1.Speedometer == car2.Speedometer)
            {
                c1_Speedometer.Foreground = new SolidColorBrush(Colors.Yellow);
                c2_Speedometer.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else
            {
                c2_Speedometer.Foreground = new SolidColorBrush(Colors.Green);
                c1_Speedometer.Foreground = new SolidColorBrush(Colors.Red);
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
