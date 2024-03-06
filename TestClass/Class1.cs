using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestClass
{
    public class Class1
    {

        // Valid Equilateral Triangle Test
        [Test]
        public void AnalyzeTriangle_ValidEquilateralTriangle_ReturnsEquilateral()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("An equilateral triangle is formed", result);
        }

        // Valid Isosceles Triangle Tests
        [Test]
        public void AnalyzeTriangle_ValidIsoscelesTriangle1_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("An isosceles triangle is formed", result);
        }

        [Test]
        public void AnalyzeTriangle_ValidIsoscelesTriangle2_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 5;
            int side2 = 6;
            int side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("An isosceles triangle is formed", result);
        }

        [Test]
        public void AnalyzeTriangle_ValidIsoscelesTriangle3_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 6;
            int side2 = 5;
            int side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("An isosceles triangle is formed", result);
        }

        // Valid Scalene Triangle Tests
        [Test]
        public void AnalyzeTriangle_ValidScaleneTriangle1_ReturnsScalene()
        {
            // Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A scalene triangle is formed", result);
        }

        [Test]
        public void AnalyzeTriangle_ValidScaleneTriangle2_ReturnsScalene()
        {
            // Arrange
            int side1 = 5;
            int side2 = 6;
            int side3 = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A scalene triangle is formed", result);
        }

        [Test]
        public void AnalyzeTriangle_ValidScaleneTriangle3_ReturnsScalene()
        {
            // Arrange
            int side1 = 8;
            int side2 = 10;
            int side3 = 12;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A scalene triangle is formed", result);
        }

        [Test]
        public void AnalyzeTriangle_ValidScaleneTriangle4_ReturnsScalene()
        {
            // Arrange
            int side1 = 5;
            int side2 = 12;
            int side3 = 13;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A scalene triangle is formed", result);
        }

        [Test]
        public void AnalyzeTriangle_ValidScaleneTriangle5_ReturnsScalene()
        {
            // Arrange
            int side1 = 7;
            int side2 = 15;
            int side3 = 20;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A scalene triangle is formed", result);
        }

        // Zero Length For One or More Side Tests
        [Test]
        public void AnalyzeTriangle_ZeroLengthSide_ReturnsInvalid()
        {
            // Arrange
            int side1 = 0;
            int side2 = 4;
            int side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("At least one side entered had a zero - invalid triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthSide2_ReturnsInvalid()
        {
            // Arrange
            int side1 = 3;
            int side2 = 0;
            int side3 = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("At least one side entered had a zero - invalid triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthSide3_ReturnsInvalid()
        {
            // Arrange
            int side1 = 4;
            int side2 = 5;
            int side3 = 0;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("At least one side entered had a zero - invalid triangle", result);
        }

        // Invalid Response Tests
        [Test]
        public void AnalyzeTriangle_InvalidResponse1_ReturnsInvalid()
        {
            // Arrange
            int side1 = 1;
            int side2 = 1;
            int side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A triangle cannot be formed", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse2_ReturnsInvalid()
        {
            // Arrange
            int side1 = 2;
            int side2 = 3;
            int side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A triangle cannot be formed", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse3_ReturnsInvalid()
        {
            // Arrange
            int side1 = 7;
            int side2 = 2;
            int side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A triangle cannot be formed", result);
        }
    }
}
