using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestFixture]
    public class AddNumbersTests
    {
        [Test]
        public void Entering_an_empty_string_results_in_the_sum_of_0()
        {
            //Arrange
            var number = "";
            var numberAdder = new NumberAdder();

            //Act
            var sum = numberAdder.AddNumbers(number);

            //Assert
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Entering_one_number_results_in_returning_the_same_number()
        {
            //Arrange
            var number = "3";
            var numberAdder = new NumberAdder();

            //Act
            var sum = numberAdder.AddNumbers(number);

            //Assert
            Assert.AreEqual(3, sum);
        }

        [Test]
        public void Entering_two_numbers_results_in_returning_the_sum_of_both_numbers()
        {
            //Arrange
            var number = "4, 7";
            var numberAdder = new NumberAdder();

            //Act
            var sum = numberAdder.AddNumbers(number);

            //Assert
            Assert.AreEqual(11, sum);
        }
    }
}

        


  



