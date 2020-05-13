using System;
using Xunit;

namespace TestProject1
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var i = 1;
            var t = 3 / i;
        }

        [Theory]
        [InlineData(2,3)]
        [InlineData(4,0)]
        [InlineData(2,9)]
        public void Test2(int i,int t)
        {
            var result = i / t;
        }
    }
}