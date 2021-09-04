using System;
using System.IO;
using Xunit;

namespace lecture.Tests
{
    public class ProgramTest
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
    }
}
