using System;
using System.IO;
using Xunit;


namespace lecture.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_Prints_Hello_World()
        {   
            //arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            //act
            Program.Main(new string[0]);
            var actual = writer.GetStringBuilder().ToString().Trim();

            //assert
            Assert.Equal("Hello, World!", actual);
        }

        [Fact]
        public void IsLeapYear_Abides_The_4Year_Rule()
        {
            bool ActualIsLeapYear = Program.IsLeapYear(4);
            bool ActualIsNotLeapYear = Program.IsLeapYear(77);
        
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

    }
}
