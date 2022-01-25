using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;

        public Airplane()
        {
            StartCity = "none";
            FinishCity = "none";
            StartDate = new Date();
            FinishDate = new Date();
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }

        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public Airplane(Airplane flight)
        {
            StartCity = flight.StartCity;
            FinishCity = flight.FinishCity;
            StartDate = new Date(flight.StartDate);
            FinishDate = new Date(flight.FinishDate);
        }

        public void SetStartCity(string startCity)
        {
            StartCity = startCity;
        }

        public void SetFinishCity(string finishCity)
        {
            FinishCity = finishCity;
        }

        public void SetStartDate(Date startDate)
        {
            StartDate = new Date(startDate);
        }

        public void SetFinishDate(Date finishDate)
        {
            FinishDate = new Date(finishDate);
        }

        public string GetStartCity()
        {
            return StartCity;
        }

        public string GetFinishCity()
        {
            return FinishCity;
        }

        public Date GetStartDate()
        {
            return StartDate;
        }

        public Date GetFinishDate()
        {
            return FinishDate;
        }

        public int GetTotalTime()
        {
            if (FinishDate.GetHours() < StartDate.GetHours()) return (24 - StartDate.GetHours()) * 60 + StartDate.GetMinutes() + FinishDate.GetHours() * 60 + FinishDate.GetMinutes();
            return FinishDate.GetHours() * 60 + FinishDate.GetMinutes() - (StartDate.GetHours() * 60 + StartDate.GetMinutes());
        }

        public bool IsArrivingToday()
        {
            return StartDate.GetDay() == FinishDate.GetDay();
        }
    }
}
