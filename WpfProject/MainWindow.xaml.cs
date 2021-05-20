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
using System.IO;

namespace WpfProject
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public Cars currentCar = new Cars();
        public static Cars car1 = new Cars();
        public static Cars car2 = new Cars();

        int index = 1;
        public MainWindow()
        {
            InitializeComponent();
            Cars.InitCars();
            Cars c = new Cars();
            CarsL.DataContext = c;

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarsL.SelectedIndex = 0;
          
        }
        private void Cars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cars ca = (Cars)((sender as ListBox).SelectedItem);
            currentCar = ca;
            DataContext = ca;
        }

        private void Cars_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            
            Cars cs = (Cars)((sender as ListBox).SelectedItem);
            if (index == 1)
            {
                car1 = cs;
                index++;
            }
            else if (index == 2)
            {
                car2 = cs;
                index = 1;
                CarProportions carProportions = new CarProportions(car1, car2);
                carProportions.ShowDialog();
            }

        }

        private void CopyUrl_Click(object sender, RoutedEventArgs e)
        {    
            Clipboard.SetDataObject(currentCar.Url.ToString());        
        }

        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            CarAdd ca = new CarAdd();
            ca.ShowDialog();
        }
    }
}
