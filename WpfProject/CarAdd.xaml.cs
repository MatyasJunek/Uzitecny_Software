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
    /// Interakční logika pro CarAdd.xaml
    /// </summary>
    public partial class CarAdd : Window
    {
        public CarAdd()
        {
            InitializeComponent();
            DataContext = new Cars();
        }

        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            Cars.AllCars.Add((Cars)DataContext);
            this.Close();
        }
    }
}
