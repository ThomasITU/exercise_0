using System;

namespace lecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static bool IsLeapYear(int year)
        {
            if(year % 400 == 0) return true;
            else if(year % 100 == 0) return false;
            return year % 4 == 0 ? true : false;
        }
    }
}
