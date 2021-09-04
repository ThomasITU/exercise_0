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
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(IsLeapYearPromt(input));                 
            }
            catch (System.Exception e)
            {
                Console.WriteLine("The given input is not a year, try something like \"2000\"");
            }
            */
            
        }
      
        public static bool IsLeapYear(int year)
        {
            if (year < 1582) return false;
            else if (year % 400 == 0) return true;
            else if(year % 100 == 0) return false;
            return year % 4 == 0 ? true : false;
        }

        public static string IsLeapYearPromt(int year)
        {
            return IsLeapYear(year) ? "yay" : "nay";
        }
    }
}
