using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    public class Program
    {
        public static Airplane[] ReadAirplaneArray(int n)
        {
            Airplane[] airplanes = new Airplane[n];
            for (int i = 0; i< n; i++)
            {
                airplanes[i] = new Airplane();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\tAirplane-{i}");
                Console.Write("Enter START city: ");
                airplanes[i].SetStartCity(Console.ReadLine());
                Console.Write("Enter FINISH city: ");
                airplanes[i].SetFinishCity(Console.ReadLine());

                Console.WriteLine("Enter START date: ");
                Console.Write("   Day: ");
                airplanes[i].GetStartDate().SetDay(Int32.Parse(Console.ReadLine()));
                Console.Write("   Month: ");
                airplanes[i].GetStartDate().SetMonth(Int32.Parse(Console.ReadLine()));
                Console.Write("   Year: ");
                airplanes[i].GetStartDate().SetYear(Int32.Parse(Console.ReadLine()));
                Console.Write("   Hours: ");
                airplanes[i].GetStartDate().SetHours(Int32.Parse(Console.ReadLine()));
                Console.Write("   Minutes: ");
                airplanes[i].GetStartDate().SetMinutes(Int32.Parse(Console.ReadLine()));

                Console.WriteLine("Enter FINISH date: ");
                Console.Write("   Day: ");
                airplanes[i].GetFinishDate().SetDay(Int32.Parse(Console.ReadLine()));
                Console.Write("   Month: ");
                airplanes[i].GetFinishDate().SetMonth(Int32.Parse(Console.ReadLine()));
                Console.Write("   Year: ");
                airplanes[i].GetFinishDate().SetYear(Int32.Parse(Console.ReadLine()));
                Console.Write("   Hours: ");
                airplanes[i].GetFinishDate().SetHours(Int32.Parse(Console.ReadLine()));
                Console.Write("   Minutes: ");
                airplanes[i].GetFinishDate().SetMinutes(Int32.Parse(Console.ReadLine()));

                Console.WriteLine("");
            }
                return airplanes;
        }

        public static void PrintDate(Date date)
        {
            Console.WriteLine($"{date.GetDay(),2}-{date.GetMonth(),2}-{date.GetYear(),4} {date.GetHours(),2}:{date.GetMinutes(),2}");
        }
        public static void PrintAirplane(Airplane airplane)
        {
            Console.WriteLine("\tAirplane info");
            Console.WriteLine($"Start city: {airplane.GetStartCity()}");
            Console.WriteLine($"Finish city: {airplane.GetFinishCity()}");
            Console.Write("Start date:  ");
            PrintDate(airplane.GetStartDate());
            Console.Write("Finish date: ");
            PrintDate(airplane.GetFinishDate());
            Console.WriteLine("");
        }

        public static void PrintAirplanes(Airplane[] airplanes)
        {
            for (int i = 0; i < airplanes.Length; i++)
            {
                Console.WriteLine($"\tAirplane-{i} info");
                Console.WriteLine($"Start city: {airplanes[i].GetStartCity()}");
                Console.WriteLine($"Finish city: {airplanes[i].GetFinishCity()}");
                Console.Write("Start date:  ");
                PrintDate(airplanes[i].GetStartDate());
                Console.Write("Finish date: ");
                PrintDate(airplanes[i].GetFinishDate());
                Console.WriteLine("");
            }
        }

        public static void GetAirplaneInfo(Airplane[] airplanes, out int minLength, out int maxLength)
        {
            int min = airplanes[0].GetTotalTime(), max = airplanes[0].GetTotalTime();
            for (int i = 1; i < airplanes.Length; i++)
            {
                if (airplanes[i].GetTotalTime() < min) min = airplanes[i].GetTotalTime();
                if (airplanes[i].GetTotalTime() > max) max = airplanes[i].GetTotalTime();
            }
            minLength = min;
            maxLength = max;
        }

        protected static long DateIntoDays(Airplane airplane)
        {
            return airplane.GetStartDate().GetYear() * 365 + airplane.GetStartDate().GetMonth() * 30 + airplane.GetStartDate().GetDay();
        }
        public static void SortAirplanesByDate(ref Airplane[] airplanes)
        {
            for (int i = 0; i < airplanes.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (DateIntoDays(airplanes[j - 1]) < DateIntoDays(airplanes[j]))
                    {
                        Airplane temp = airplanes[j - 1];
                        airplanes[j - 1] = airplanes[j];
                        airplanes[j] = temp;
                    }

                }
            }
        }

        public static void SortAirplanesByTotalTime(ref Airplane[] airplanes)
        {
            for (int i = 0; i < airplanes.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (airplanes[j - 1].GetTotalTime() > airplanes[j].GetTotalTime())
                    {
                        Airplane temp = airplanes[j - 1];
                        airplanes[j - 1] = airplanes[j];
                        airplanes[j] = temp;
                    }

                }
            }
        }

    }
}
