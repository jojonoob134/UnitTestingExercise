using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            var calc = new Calculator();
            //Arrange
            // create a Calculator object


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var answer = calc.Add(num1, num2, num3);
            //Assert
            Assert.Equal(answer, expected);
        }

        [Theory]
        [InlineData(8, 4, 4)]//Add test data <-------
        [InlineData(784, 45, 739)]
        [InlineData(100, 31, 69)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calc = new Calculator();
            //Act
            var answer = calc.sub(minuend, subtrhend);
            //Assert
            Assert.Equal(answer, expected);
        }

        [Theory]
        [InlineData(2,2,4)]//Add test data <-------
        [InlineData(6, 6, 36)]
        [InlineData(10, 9, 90)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calc = new Calculator();
            //Act
            var answer = calc.mult(num1, num2);
            //Assert
            Assert.Equal(answer, expected);
        }

        [Theory]
        [InlineData(4,2,2)]//Add test data <-------
        [InlineData(36, 6, 6)]
        [InlineData(90, 9, 10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();
            //Act
            var answer = calc.div(num1, num2);
            //Assert
            Assert.Equal(answer, expected);
        }

    }
}
