using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;

namespace WpfProject
{
    public class Cars : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string brand;
        public string Brand
        {
            get => brand;
            set { brand = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Brand")); }
        }

        private string model;
        public string Model
        {
            get => model;
            set { model = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Model")); }
        }

        private int year;
        public int Year
        {
            get => year;
            set { year = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Year")); }
        }

        private int prize;
        public int Prize
        {
            get => prize;
            set { prize = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize")); }
        }
        private string body;
        public string Body
        {
            get => body;
            set { body = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Body")); }
        }
        private string transmission;
        public string Transmission
        {
            get => transmission;
            set { transmission = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Transmission")); }
        }

        private string fuel;
        public string Fuel
        {
            get => fuel;
            set { fuel = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fuel")); }
        }
        private int speedometer;
        public int Speedometer
        {
            get => speedometer;
            set { speedometer = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Speedometer")); }
        }
        private string engine;
        public string Engine
        {
            get => engine;
            set { engine = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Engine")); }
        }
        private string url;
        public string Url
        {
            get => url;
            set { url = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Url")); }
        }
        public static ObservableCollection<Cars> AllCars { get; set; } = new ObservableCollection<Cars>();

       
        public Cars()
        {

        }
        public Cars(string brand, string model, int year, int prize, string body, string transmission, string fuel, int speedometer, string engine, string url)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Prize = prize;
            Body = body;
            Transmission = transmission;
            Fuel = fuel;
            Speedometer = speedometer;
            Engine = engine;
            Url = url;
        }
        public static void InitCars()
        {
            string line;
            try
            {
                using (StreamReader file = new StreamReader("cars.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] words = line.Split(',');
                        AllCars.Add(new Cars { Brand = words[0], Model = words[1], Year = Convert.ToInt32(words[2]), Prize = Convert.ToInt32(words[3]), Body = words[4], Transmission = words[5], Fuel = words[6], Speedometer = Convert.ToInt32(words[7]), Engine = words[8], Url = words[9] }
                            );
                    }
                }
            }
            catch (IOException)
            {
                AllCars.Add(new Cars
                {
                    Brand = "Škoda",
                    Model = "Octavia",
                    Year = 2020,
                    Prize = 530000,
                    Body = "Hatchback",
                    Transmission = "Automat",
                    Fuel = "Benzín",
                    Speedometer = 22635,
                    Engine = "1.5 TSI 110kW",
                    Url = "https://www.aaaauto.cz/cz/skoda-octavia/car.html?id=393042078#make=109&model=261&ymin=2020&promo=b"
                });
                AllCars.Add(new Cars
                {
                    Brand = "Volkswagen",
                    Model = "Passat",
                    Year = 2018,
                    Prize = 440000,
                    Body = "Combi",
                    Transmission = "Automat",
                    Fuel = "Diesel",
                    Speedometer = 33158,
                    Engine = "2.0 TDI 110kW",
                    Url = "https://www.aaaauto.cz/cz/vw-passat/car.html?id=395673047#make=131&model=268&ymin=2018&promo=gm"
                });
                AllCars.Add(new Cars
                {
                    Brand = "BMW",
                    Model = "5GT",
                    Year = 2015,
                    Prize = 620000,
                    Body = "Sedan",
                    Transmission = "Automat",
                    Fuel = "Diesel",
                    Speedometer = 83579,
                    Engine = "530d GT, 190kW 4x4",
                    Url = "https://www.aaaauto.cz/cz/bmw-5gt/car.html?id=392944336#make=15&model=20033&ymin=2015&promo=gm"
                });
                AllCars.Add(new Cars
                {
                    Brand = "Nissan",
                    Model = "GT-R",
                    Year = 2020,
                    Prize = 2780000,
                    Body = "Kupé",
                    Transmission = "Automat",
                    Fuel = "Benzín",
                    Speedometer = 3354,
                    Engine = "3.8 V6, 419kW 4x4",
                    Url = "https://www.aaaauto.cz/cz/nissan-gt-r/car.html?id=392785695#promo=b"
                });
                AllCars.Add(new Cars
                {
                    Brand = "Volvo",
                    Model = "XC90",
                    Year = 2013,
                    Prize = 430000,
                    Body = "SUV",
                    Transmission = "Automat",
                    Fuel = "Diesel",
                    Speedometer = 168269,
                    Engine = "D5, 147kW 4x4",
                    Url = "https://www.aaaauto.cz/cz/volvo-xc90/car.html?id=382823123#make=130&promo=gm"
                });
                AllCars.Add(new Cars
                {
                    Brand = "Alfa Romeo",
                    Model = "Giulietta",
                    Year = 2011,
                    Prize = 100000,
                    Body = "Hatchback",
                    Transmission = "Manuál",
                    Fuel = "Benzín",
                    Speedometer = 156646,
                    Engine = "1.4 T 88kW",
                    Url = "https://www.aaaauto.cz/cz/alfa-romeo-giulietta/car.html?id=394347607#make%5B0%5D=2&make%5B1%5D=130"
                });
                AllCars.Add(new Cars
                {
                    Brand = "Ford",
                    Model = "Mustang",
                    Year = 2015,
                    Prize = 595000,
                    Body = "Coupe",
                    Transmission = "Manuál",
                    Fuel = "Benzín",
                    Speedometer = 55000,
                    Engine = "280 kW (381 koní)",
                    Url = "https://www.sauto.cz/osobni/detail/ford/mustang/19136021?goFrom=list"
                });
                AllCars.Add(new Cars
                {
                    Brand = "Hyundai",
                    Model = "i30",
                    Year = 2019,
                    Prize = 350000,
                    Body = "Combi",
                    Transmission = "Manuál",
                    Fuel = "Diesel",
                    Speedometer = 17532,
                    Engine = "85 kW (116 koní)",
                    Url = "https://www.sauto.cz/osobni/detail/hyundai/i30/19117905?goFrom=list"
                });
                using (StreamWriter sw = new StreamWriter("cars.txt"))
                {
                    foreach (var item in Cars.AllCars)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", item.Brand, item.Model, item.Year, item.Prize, item.Body, item.Transmission, item.Fuel, item.Speedometer, item.Engine, item.Url));
                    }
                }
            }

        }
    }
}
