using System;
using Course.entites.Enums;
using Course.entites;

namespace Course.entites
{
    class HoursContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public HoursContract()
        {
        }
        public HoursContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }   
    }
}
