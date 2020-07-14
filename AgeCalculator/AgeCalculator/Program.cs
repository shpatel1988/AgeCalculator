using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter date(dd/mm/yyyy)");
            string str = Console.ReadLine();
            DateTime dt=  Convert.ToDateTime(str);
            TimeSpan v =DateTime.Now - dt;

            Console.WriteLine($"days {v.Days}");
            if(v.Days/365 !=0)
                Console.Write($"You  are   {v.Days/365} years and  ");
            int fractDays = (v.Days / 365) * 365;
            Console.Write($" {(v.Days - fractDays)/30}  Months and ");
            int days = v.Days%365;
            days = days % 30;
            Console.WriteLine($" {days} year old");

            //Console.WriteLine($"You are {v.Days/365} days {(v.Days - v.Days/365)/30} months year old");
            Console.ReadLine();

        }
    }
}
