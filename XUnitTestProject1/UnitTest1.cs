using System;
using WebApplication1.Controllers;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            WeatherForecastController obj = new WeatherForecastController();
            var result = obj.checkWeather("Chilly");
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            WeatherForecastController obj = new WeatherForecastController();
            var result = obj.checkWeather("Breeze");
            Assert.True(result);
        }
    }
}
