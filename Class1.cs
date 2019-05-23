using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalcAppTest

{
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void GetAddition_Input5point0and6point0_Returns11point0()
        {

            //Arrange
            double number1 = 5;
            double number2 = 6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input3point0and6point0_Returns9point0()
        {

            //Arrange
            double number1 = 3;
            double number2 = 6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input4point0and6point0_Returns10point0()
        {

            //Arrange
            double number1 = 4;
            double number2 = 6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input8point0and6point0_Returns2point0()
        {

            //Arrange
            double number1 = 8;
            double number2 = 6;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input8point0and2point0_Returns6point0()
        {

            //Arrange
            double number1 = 8;
            double number2 = 2;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input9point0and6point0_Returns3point0()
        {

            //Arrange
            double number1 = 9;
            double number2 = 6;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }

}
