using System;
using System.IO;
using System.Windows;
using Xunit;


namespace lecture.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_Prints_Hello_World()
        {   
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            var actual = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Hello, World!", actual);
        }

        [Fact]
        public void IsLeapYear_Abides_The_4Year_Rule()
        {
            bool ActualIsLeapYear = Program.IsLeapYear(1596);
            bool ActualIsNotLeapYear = Program.IsLeapYear(1597);
        
            Assert.True(ActualIsLeapYear);
            Assert.False(ActualIsNotLeapYear);
        }

        [Fact]
        public void IsLeapYear_Abides_The_100Year_rule()
        {
            bool ActualIsNotLeapYear = Program.IsLeapYear(1900);

            Assert.False(ActualIsNotLeapYear);
        }
        
        [Fact]
        public void IsLeapYear_Abides_The_Centurial_Rule()
        {
            bool ActualIsLeapYear = Program.IsLeapYear(1600);
        
            Assert.True(ActualIsLeapYear);
        }

        [Fact]
        public void IsLeapYearPromt_prints_yay()
        {
            /*
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            Console.WriteLine(4);
            SendKeys.Send("{ENTER}");
            var actual = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("yay", actual);
            */

            string actualString = Program.IsLeapYearPromt(2000);

            Assert.Equal("yay", actualString);
        }

        [Fact]
        public void IsLeapYearPromt_prints_nay()
        {
            string actual = Program.IsLeapYearPromt(1900);

            Assert.Equal("nay", actual);
        }

        [Fact]
        public void IsLeapYear_does_not_apply_before_1582()
        {
            bool actual = Program.IsLeapYear(1580);
            
            Assert.False(actual);
        }
        [Fact]
        public void IsLeapYearPromt_handle_StringInput()
        {
            // same problem as further above, do not know how to handle the console input yet
            /*
            
            string actual = Program.IsLeapYearPromt("asdasd");

            Assert.Equal("The given input is not a year, try something like \"2000\"", actual);
            */
        }
        

    }
}
