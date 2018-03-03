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
            var total = numberAdder.AddNumbers(number);

            //Assert
            Assert.AreEqual(0, total);
        }

        [Test]
        public void Entering_one_number_results_in_returning_the_same_number()
        {

        }
    }
}

        


  



