using NUnit.Framework;
using AgeCalculator;
using System;


namespace AgeCalculatorTest
{
    [TestFixture]
    public class AgeCalculateTest
    {
        [TestFixture]
        public class ReturnAge
        {
            [TestCase("03/09/2010", "03/09/2020", "10")]
            [TestCase("03/09/2010", "03/09/2022", "12")]
            [TestCase("30/09/1978", "30/09/2018", "40")]
            [TestCase("30/09/1982", "05/10/2001", "19")]
 
            public void ShouldReturnAge(string startDate, string endDate, string age)
            {
                //Arrange
                var sut = new AgeCalculate();

                //Act
                var actual = sut.calculate(startDate, endDate);

                //Assert
                Assert.AreEqual(age, actual);
                //Assert.That(actual, Is.EqualTo(age));
            }
        }
    }
}