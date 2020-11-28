using System;
using Xunit;
using Kata;

namespace KataTests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ReturnFizz_WhenDivisibleBy3()
        {
            string expected = "Fizz";
            Assert.Equal(expected, FizzBuzzKata.FizzBuzz(9));
        }

        [Fact]
        public void ReturnBuzz_WhenDivisibleBy5()
        {
            string expected = "Buzz";
            Assert.Equal(expected, FizzBuzzKata.FizzBuzz(10));
        }

        [Fact]
        public void ReturnFizzBuzz_WhenDivisibleBy3AndBy5()
        {
            string expected = "FizzBuzz";
            Assert.Equal(expected, FizzBuzzKata.FizzBuzz(15));
        }

        [Fact]
        public void ReturnParamNumberToString_WhenNotDivisibleBy3Or5()
        {
            string expected = "2";
            Assert.Equal(expected, FizzBuzzKata.FizzBuzz(2));
        }

        [Fact]
        public void ReturnString0_When0()
        {
            string expected = "0";
            Assert.Equal(expected, FizzBuzzKata.FizzBuzz(0));
        }

        [Fact]
        public void ReturnFizz_WhenDivisibleBy3Negative()
        {
            string expected = "Fizz";
            Assert.Equal(expected, FizzBuzzKata.FizzBuzz(-9));
        }

        [Fact]
        public void ReturnBuzz_WhenDivisibleBy5Negative()
        {
            string expected = "Buzz";
            Assert.Equal(expected, FizzBuzzKata.FizzBuzz(-10));
        }

        [Fact]
        public void ReturnFizzBuzz_WhenDivisibleNegativeBy3AndBy5()
        {
            string expected = "FizzBuzz";
            Assert.Equal(expected, FizzBuzzKata.FizzBuzz(-15));
        }
    }
}
