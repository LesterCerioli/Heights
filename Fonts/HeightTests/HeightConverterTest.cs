using System;
using Xunit;

namespace HeightTests
{
    public class HeightConverterTest
    {
        [Theory]
        [InlineData(1, 0.3048)]
        [InlineData(10, 3.048)]
        public void HeightConvertTest1(double foot, double meters)
        {
            double result = HeightConverter.FootParameters(foot);
            resultad.Should().Be(meters,
                $"Height in meters does not correspond to the expected value ({meters})");

        }
    }
}
