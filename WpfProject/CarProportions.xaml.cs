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
            DataContext = car1;
            c1_Brand.DataContext = DataContext;
            c1_Model.DataContext = DataContext;
            c1_Year.DataContext = DataContext;
            c1_Prize.DataContext = DataContext;
            c1_Body.DataContext = DataContext;
            c1_Transmission.DataContext = DataContext;
            c1_Fuel.DataContext = DataContext;
            c1_Speedometer.DataContext = DataContext;
            c1_Engine.DataContext = DataContext;

            DataContext = car2;
            c2_Brand.DataContext = DataContext;
            c2_Model.DataContext = DataContext;
            c2_Year.DataContext = DataContext;
            c2_Prize.DataContext = DataContext;
            c2_Body.DataContext = DataContext;
            c2_Transmission.DataContext = DataContext;
            c2_Fuel.DataContext = DataContext;
            c2_Speedometer.DataContext = DataContext;
            c2_Engine.DataContext = DataContext;

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
