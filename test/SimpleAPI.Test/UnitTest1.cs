using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Linq;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsValues()
        {
            var returnValue = controller.Get().ToList();
            Assert.NotNull(returnValue);
            Assert.DoesNotContain("Freezing", returnValue[0].Summary);
        }

        [Fact]
        public void Test1()
        {
            
        }
    }
}
