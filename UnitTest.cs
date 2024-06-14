using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class Calculation
    {
        [TestMethod]
        public void Addition_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            var result = Addition(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Addition_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = -3;
            int expected = 2;

            // Act
            var result = Addition(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Addition_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = -3;
            int expected = -8;

            // Act
            var result = Addition(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Addition_ZeroAndPositiveNumber_ReturnsCorrectSum()
        {
            // Arrange
            int a = 0;
            int b = 3;
            int expected = 3;

            // Act
            var result = Addition(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        private int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
