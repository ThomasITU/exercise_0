using System;

namespace lecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n\n");
            
            
            // Commented because it breaks tests by freezing terminal because missing console input -- Deadlock?
            /*
            Console.WriteLine("Type in a year and hit enter:\n");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsLeapYearPromt(input));
            */
        }
      
        public static bool IsLeapYear(int year)
        {
            if(year % 400 == 0) return true;
            else if(year % 100 == 0) return false;
            return year % 4 == 0 ? true : false;
        }

        public static string IsLeapYearPromt(int year)
        {
            return IsLeapYear(year) ? "yay" : "nay";
            
        }
    }
}
