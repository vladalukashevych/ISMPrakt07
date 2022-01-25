using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public Date() 
        {
            Year = 2022;
            Month = 1;
            Day = 1;
            Hours = 0;
            Minutes = 0;
        }

        public Date(int day, int month, int year, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public Date(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = 0;
            Minutes = 0;
        }

        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }

        public void SetYear(int year)
        {
            Year = year;
        }

        public void SetMonth(int month)
        {
            Month = month;
        }

        public void SetDay(int day)
        {
            Day = day;
        }

        public void SetHours(int hours)
        {
            Hours = hours;
        }

        public void SetMinutes(int minutes)
        {
            Minutes = minutes;
        }

        public int GetYear()
        {
            return Year;
        }

        public int GetMonth()
        {
            return Month;
        }
        public int GetDay()
        {
            return Day;
        }

        public int GetHours()
        {
            return Hours;
        }
        public int GetMinutes()
        {
            return Minutes;
        }
    }
}
