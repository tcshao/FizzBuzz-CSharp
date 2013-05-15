using System;
using FizzBuzz.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void three_is_a_factor_of_three()
        {
            var expected = true;
            var actual = 3.IsAFactorOf(3);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void three_is_a_factor_of_six()
        {
            var expected = true;
            var actual = 3.IsAFactorOf(6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void four_is_not_a_factor_of_three()
        {
            var expected = false;
            var actual = 4.IsAFactorOf(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void five_is_a_factor_of_five()
        {
            var expected = true;
            var actual = 5.IsAFactorOf(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void five_is_a_factor_of_fifteen()
        {
            var expected = true;
            var actual = 5.IsAFactorOf(15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void three_is_a_factor_of_fifteen()
        {
            var expected = true;
            var actual = 3.IsAFactorOf(15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void any_number_that_is_a_factor_of_fifteen_is_a_factor_of_three_and_five()
        {
            var expected = true;
            int randomNum = 1;

            while (!15.IsAFactorOf(randomNum))
            {
                randomNum = new Random().Next();
            }

            var actual = 3.IsAFactorOf(randomNum) && 5.IsAFactorOf(randomNum);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void the_number_will_be_returned_as_string_if_it_is_not_a_multiple_of_three_or_five()
        {
            int number = 17;

            var expected = number.ToString();
            var actual = Program.GetFizzBuzz(number);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void a_factor_of_three_will_return_the_number_and_Fizz()
        {
            int number = 9;

            var expected = "9 - Fizz";
            var actual = Program.GetFizzBuzz(number);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void a_factor_of_five_will_return_the_number_and_Buzz()
        {
            int number = 20;

            var expected = "20 - Buzz";
            var actual = Program.GetFizzBuzz(number);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void a_factor_of_fifteen_will_return_the_number_and_FizzBuzz()
        {
            int number = 45;

            var expected = "45 - FizzBuzz";
            var actual = Program.GetFizzBuzz(number);

            Assert.AreEqual(actual, expected);
        }


    }
}
