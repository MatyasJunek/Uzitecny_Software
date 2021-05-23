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
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace WpfProject
{
    /// <summary>
    /// Interakční logika pro CarAdd.xaml
    /// </summary>
    public partial class CarAdd : Window
    {
        private string oldValuePrize = string.Empty;
        private string oldValueSpeed = string.Empty;
        public Cars newCar = new Cars("Nová značka", "Nový model", DateTime.Now.Year, 0, "Combi", "Manuál", "Benzín", 0, "1.5 TSI 110kW", "odkaz");
        private static readonly Regex _regex = new Regex("[^0-9]+");

        public CarAdd()
        {
            InitializeComponent();
            for (int i = 1950; i <= DateTime.Now.Year; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = i;
                Year_Combo.Items.Add(item);
            }
            DataContext = newCar;

        }

        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }
        //private bool IsBrandOK()
        //{
        //    if (newCar.Brand.Length > 0)
        //    {
        //        pass = true;              
        //        return true;
        //    }
        //    else
        //    {
        //        pass = false;               
        //        return false;
        //    }
        //}


        private void AddCar_Click(object sender, RoutedEventArgs e)
        {

            Cars.AllCars.Add((Cars)DataContext);
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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






      

        

        private void tb_brand_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_brand.Text))
            {
                AddCar.IsEnabled = false;
            }
            else
            {

                AddCar.IsEnabled = true;
            }
        }

        private void tb_model_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_model.Text))
            {
                AddCar.IsEnabled = false;
            }
            else
            {

                AddCar.IsEnabled = true;
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
                AddCar.IsEnabled = false;
            }
            else
            {

                AddCar.IsEnabled = true;
            }
        }

        private void tb_url_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_url.Text))
            {
                AddCar.IsEnabled = false;
            }
            else
            {

                AddCar.IsEnabled = true;
            }
        }
    }
}
