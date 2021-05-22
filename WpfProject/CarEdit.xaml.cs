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
using System.IO;

namespace WpfProject
{
    /// <summary>
    /// Interakční logika pro CarEdit.xaml
    /// </summary>
    public partial class CarEdit : Window
    {
        public Cars currentCar;
        public CarEdit(Cars car)
        {
            InitializeComponent();
            DataContext = car;
            currentCar = car;           
        }

        private void EditCar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DeleteCar_Click(object sender, RoutedEventArgs e)
        {
            Cars.AllCars.Remove(currentCar);
            using (StreamWriter tw = new StreamWriter("cars.txt"))
            {
                foreach (var item in Cars.AllCars)
                {
                    tw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", item.Brand, item.Model, item.Year, item.Prize, item.Body, item.Transmission, item.Fuel, item.Speedometer, item.Engine, item.Url));
                }
                tw.Close();
            }
            this.Close();
        }
    }
}
