using System;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Given        
            int x = 1;
            int y = 2;

            //When        
            var result = x + y;

            //Then
            Assert.Equal(3, result);
        }
    }
}
