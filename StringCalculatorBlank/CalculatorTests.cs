using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StringCalculatorBlank
{
    public class CalculatorTests
    {
        StringCalculator _calculator;
        public CalculatorTests()
        {
            _calculator = new StringCalculator();
        }
        [Fact]
        public void EmptyStringReturnsZero()
        {
            var calculator = new StringCalculator();
            int answer = calculator.Add("");
            Assert.Equal(0, answer);

        }

        [Theory]
        [InlineData ("2",2)]
        [InlineData("24", 24)]
        public void StringNumber(string numbers, int expected)
        {
            int answer = _calculator.Add(numbers);

            Assert.Equal(expected, answer);
        }
        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("3,4", 7)]
        public void StringWithCommas(string numbers, int expected)
        {
            int answer = _calculator.Add(numbers);
            Assert.Equal(expected, answer);
        }
        [Theory]
        [InlineData("1,2,3,4,5,6,7,8,9,10,11,12", 78)]
        public void MuchasNumbres(string numbers, int expected)
        {
            int answer = _calculator.Add(numbers);
            Assert.Equal(expected, answer);
        }
        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("3\n4\n5\n6",18)]
        public void LineReturn(string numbers, int expected)
        {
            int answer = _calculator.Add(numbers);
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData("//;1;3",4)]
        public void NewSeporator(string numbers, int expected)
        {
            int answer = _calculator.Add(numbers);
            Assert.Equal(expected, answer);
        }
    }
}
