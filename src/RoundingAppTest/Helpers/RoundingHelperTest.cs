using RoundingApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RoundingAppTest.Helpers
{
    public class RoundingHelperTest
    {
        [Fact]
        public void RoundTest()
        {
            //arrange
            var value = 169.5658m;

            //act
            var roundedValue = RoundingHelper.Round(value);

            //assert
            Assert.Equal(169.5658m, roundedValue);
        }

        [Fact]
        public void Round2Test()
        {
            //arrange
            var value = 169.56585m;

            //act
            var roundedValue = RoundingHelper.Round(value);

            //assert
            Assert.Equal(169.5659m, roundedValue);
        }

        [Fact]
        public void Round3Test()
        {
            //arrange
            var value = 169.56585m;

            //act
            var roundedValue = RoundingHelper.Round(value, 2);

            //assert
            Assert.Equal(169.57m, roundedValue);
        }

        [Theory]
        [InlineData(12.555, 12.56)]
        [InlineData(12.565, 12.57)]
        [InlineData(12.554, 12.55)]
        [InlineData(12.558, 12.56)]
        public void RoundingsTest(decimal value, decimal rounded)
        {
            //arrange & act
            var result = RoundingHelper.Round(value, 2);

            //assert
            Assert.Equal(rounded, result);
        }
    }
}
