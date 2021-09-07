using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    
    public class Clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }

        public Clovek()
        {
            Jmeno = "Nezname";
            Prijmeni = "Nezname";
        }
        public Clovek(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
        public override string ToString()
        {
            return "Jméno: "+Prijmeni+", "+ "Prijmení: " + Prijmeni;
        }
    }
    public class Obcan:Clovek
    {
        string rodnecislo;
        public Regex rodc = new Regex(@"\d{6}/\d{4}");
        public string RodneCislo
        {
            get { return rodnecislo; }
            set { if (rodc.IsMatch(value)) { rodnecislo = value; } else { throw new FormatException("Zadán špatný formát rodného čísla"); } }
        }

        public Obcan()
        {
            Jmeno = "Nezname";
            Prijmeni = "Nezname";
            RodneCislo = "000000/0000";
        }

        public Obcan(string jmeno, string prijmeni, string rodnecislo):base(jmeno, prijmeni)
        {
            RodneCislo = rodnecislo;
        }
        public override string ToString()
        {
            return "Jméno: " + Prijmeni + ", " + "Prijmení: " + Prijmeni + ", " + "Rodné číslo: " + RodneCislo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Clovek c = new Clovek();
            Console.WriteLine(c.ToString());
            Clovek c2 = new Clovek("Josef", "Horák");
            Console.WriteLine(c2.ToString());

            Obcan o = new Obcan();
            Console.WriteLine(o.ToString());
            Obcan o2 = new Obcan("Milada", "Platanová", "091002/0001");
            Console.WriteLine(o2.ToString());
        }
    }
}
