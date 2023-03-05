using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherForecastingProject
{
    public class Place
    {
        public string Name { get; private set; }
        public string Region { get; private set; }
        public string Latitude { get; private set; }
        public string Longtitude { get; private set; }

        public Place(string Name, string Region, string Latitude, string Longtitude)
        {
            this.Name = Name;
            this.Region = Region;
            this.Latitude = Latitude;
            this.Longtitude = Longtitude;
        }

        public override string ToString()
        {
            return base.ToString() + "\nCity: " + Name.ToString() + "\nRegion: " + Region.ToString() + "\nLatitude: " + Latitude.ToString() + "\nLongtitude: " + Longtitude.ToString();
        }
    }
public class WeatherForecasting
    {
        static void Main(string[] args)
        {
            char Answer;
            string Ans;

            Console.WriteLine("WEATHER FORECAST SAMPLE PROGRAM\n\n");
            Console.WriteLine("Do you wish to proceed and see the latest weather forecast?\n[Y]es     [N]o\n");
            Ans = Console.ReadLine();
            Answer = char.Parse(Ans);
            Console.Clear();
            if(Answer == 'Y')
            {
                Console.WriteLine("Which city do you want to have weather infos?");
               
            
            Console.WriteLine("\n1. Baybay City");
            Console.WriteLine("2. Hindang City");
            Console.WriteLine("3. Inopacan City");
            Console.WriteLine("4. Maasin City");
            Console.WriteLine("5. Kananga City");
            Console.WriteLine("6. Tacloban City\n");

            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
            {
                case "1":
                        Console.WriteLine("\nBAYBAY CITY WEATHER INFORMATION");
                        Place Baybay = new Place("Baybay", "8", "10.6521° N", "124.8526° E");
                        Console.WriteLine(Baybay.ToString());
                        break;
                case "2":
                        Console.WriteLine("\nHINDANG CITY WEATHER INFORMATION");
                        Place Hindang = new Place("Hindang", "8", "10.4305° N", "124.7442° E");
                        Console.WriteLine(Hindang.ToString());
                        break;
                case "3":
                        Console.WriteLine("\nINOPACAN CITY WEATHER INFORMATION");
                        Place Inopacan = new Place("Inopacan", "8", "10.4995° N", "124.7414° E");
                        Console.WriteLine(Inopacan.ToString());
                        break;
                case "4":
                        Console.WriteLine("\nMAASIN CITY WEATHER INFORMATION");
                        Place Maasin = new Place("Maasin", "8", "10.1654° N", "124.8403° E");
                        Console.WriteLine(Maasin.ToString());
                        break;
                case "5":
                        Console.WriteLine("\nKANANGA CITY WEATHER INFORMATION");
                        Place Kananga = new Place("Kananga", "8", "11.1648° N", "124.5588° E");
                        Console.WriteLine(Kananga.ToString());
                        break;
                case "6":
                        Console.WriteLine("\nTACLOBAN CITY WEATHER INFORMATION");
                        Place Tacloban = new Place("Tacloban", "8", "11.2543° N", "124.9617° E");
                        Console.WriteLine(Tacloban.ToString());
                        break;
                default:
                    Console.WriteLine("Invalid Option. Try Again");
                    break;
                }

            }
            else if (Answer == 'N')
            {
                Console.WriteLine("No Information To Show.\n");
            }
            else
            {
                Console.WriteLine("Invalid Option!");
            }

        }
    }
}