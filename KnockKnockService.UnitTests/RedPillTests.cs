using KnockKnockService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KnockKnockWCFService.UnitTests
{
    [TestClass]
    public class RedPillTests
    {
        // Boundary case
        [TestMethod]
        public void FibonacciSeries_Of_0_Returns_0()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var result = redPillService.FibonacciNumber(0);

            // Assert
            Assert.AreEqual(0, result);
        }

        // Boundary case
        [TestMethod]
        public void FibonacciSeries_Of_2_Returns_1()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var result = redPillService.FibonacciNumber(2);

            // Assert
            Assert.AreEqual(1, result);
        }

        // Normal case for negative index
        [TestMethod]
        public void FibonacciSeries_Of_Minus10_ReturnsMinus55()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var result = redPillService.FibonacciNumber(-10);

            // Assert
            Assert.AreEqual(-55, result);
        }

        // Normal case positive index
        [TestMethod]
        public void FibonacciSeries_Of_10_Returns_55()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var result = redPillService.FibonacciNumber(10);

            // Assert
            Assert.AreEqual(55, result);
        }


        // Negative case - Argument is null 
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWords_NULL_Throws_ArgumentNullException()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var reversedString = redPillService.ReverseWords(null);

            // Assert
            Assert.AreEqual("iH", reversedString);
        }

        // Normal case - simple one word string
        [TestMethod]
        public void ReverseWords_Hi_Returns_iH()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var reversedString = redPillService.ReverseWords("Hi");

            // Assert
            Assert.AreEqual("iH", reversedString);

        }

        // Normal case with 2 words in a string but with multiple spaces in between
        [TestMethod]
        public void ReverseWords_HiThere_WithSpaces_PreservesSpaces()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var reversedString = redPillService.ReverseWords("Hi  there");

            // Assert
            Assert.AreEqual("iH  ereht", reversedString);
        }

        // Normal case
        [TestMethod]
        public void WhatIsYourToken_Returns_My_Token()
        {
            // Arrange
            var myToken = new Guid("339d7ee0-0b07-4748-b8d9-2b8826775390");

            IRedPill redPillService = new RedPill();

            // Act
            var token = redPillService.WhatIsYourToken();

            // Assert
            Assert.AreEqual(myToken, token);
        }


        // Normal case - test for equilateral 
        [TestMethod]
        public void DetermineTriangleShape_For_2_2_2_Returns_Equilateral()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var triangleType = redPillService.WhatShapeIsThis(2, 2, 2);

            //Assert
            Assert.AreEqual(TriangleType.Equilateral, triangleType);
        }

        // Normal case - test for isosceles
        [TestMethod]
        public void DetermineTriangleShape_For_2_2_3_Returns_Isosceles()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var triangleType = redPillService.WhatShapeIsThis(2, 2, 3);

            //Assert
            Assert.AreEqual(TriangleType.Isosceles, triangleType);
        }

        // Normal case - test for scalene
        [TestMethod]
        public void DetermineTriangleShape_For_3_4_5_Returns_Scalene()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var triangleType = redPillService.WhatShapeIsThis(3, 4, 5);

            //Assert
            Assert.AreEqual(TriangleType.Scalene, triangleType);
        }

        // Negative case - a triangle cannot be formed 
        [TestMethod]
        public void DetermineTriangleShape_For_0_0_0_Returns_Error()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var triangleType = redPillService.WhatShapeIsThis(0, 0, 0);

            //Assert
            Assert.AreEqual(TriangleType.Error, triangleType);
        }

        // Negative case - a triangle cannot be formed with the given lengths
        [TestMethod]
        public void DetermineTriangleShape_For_1_2_3_Returns_Error()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var triangleType = redPillService.WhatShapeIsThis(1, 2, 3);

            //Assert
            Assert.AreEqual(TriangleType.Error, triangleType);
        }

        // Negative case - test with negative numbers
        [TestMethod]
        public void DetermineTriangleShape_For_Minus1_2_3_Returns_Error()
        {
            // Arrange
            IRedPill redPillService = new RedPill();

            // Act
            var triangleType = redPillService.WhatShapeIsThis(-11, 2, 3);

            //Assert
            Assert.AreEqual(TriangleType.Error, triangleType);
        }
    }
}
