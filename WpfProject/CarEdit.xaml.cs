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
using System.Text.RegularExpressions;

namespace WpfProject
{
    /// <summary>
    /// Interakční logika pro CarEdit.xaml
    /// </summary>
    public partial class CarEdit : Window
    {
        private string oldValuePrize = string.Empty;
        private string oldValueSpeed = string.Empty;
        public Cars currentCar;
        private static readonly Regex _regex = new Regex("[^0-9]+");
        public CarEdit(Cars car)
        {
            InitializeComponent();
            for (int i = 1950; i <= DateTime.Now.Year; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = i;
                Combo_Year.Items.Add(item);
            }
            
            DataContext = car;
            currentCar = car;
            
        }
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void EditCar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DeleteCar_Click(object sender, RoutedEventArgs e)
        {
            Cars.AllCars.Remove(currentCar);
            using (StreamWriter sw = new StreamWriter("cars.txt"))
            {
                foreach (var item in Cars.AllCars)
                {
                    sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", item.Brand, item.Model, item.Year, item.Prize, item.Body, item.Transmission, item.Fuel, item.Speedometer, item.Engine, item.Url));
                }
            }
            this.Close();
        }

        private void tb_prize_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void tb_prize_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsTextAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private void tb_speed_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void tb_speed_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsTextAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private void tb_brand_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_brand.Text))
            {
                EditCar.IsEnabled = false;
            }
            else
            {

                EditCar.IsEnabled = true;
            }
        }

        private void tb_model_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_model.Text))
            {
                EditCar.IsEnabled = false;
            }
            else
            {

                EditCar.IsEnabled = true;
            }
        }

        private void tb_prize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_prize.Text))
            {
                tb_prize.Text = oldValuePrize;
            }
            else
            {
                oldValuePrize = tb_prize.Text;
            }
        }

        private void tb_speed_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_speed.Text))
            {
                tb_speed.Text = oldValueSpeed;
            }
            else
            {
                oldValueSpeed = tb_speed.Text;
            }
        }

        private void tb_engine_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_engine.Text))
            {
                EditCar.IsEnabled = false;
            }
            else
            {

                EditCar.IsEnabled = true;
            }
        }

        private void tb_url_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_url.Text))
            {
                EditCar.IsEnabled = false;
            }
            else
            {

                EditCar.IsEnabled = true;
            }
        }
    }
}
