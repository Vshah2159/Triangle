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
        public void AnalyzeTriangle_Input5and5and5_OutputValidEquilateralTriangle()
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
        public void AnalyzeTriangle_Input5and7and7_OutputValidIsoscelesTriangle1()
        {
            // Arrange
            int side1 = 5;
            int side2 = 7;
            int side3 = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("An isosceles triangle is formed", result);
        }

        [Test]
        public void AnalyzeTriangle_Input180and100and180_OutputValidIsoscelesTriangle2()
        {
            // Arrange
            int side1 = 180;
            int side2 = 100;
            int side3 = 180;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("An isosceles triangle is formed", result);
        }

        [Test]
        public void AnalyzeTriangle_Input180and100and180_OutputValidIsoscelesTriangle3()
        {
            // Arrange
            int side1 = 98;
            int side2 = 65;
            int side3 = 65;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("An isosceles triangle is formed", result);
        }

        // Valid Scalene Triangle Tests
        [Test]
        public void AnalyzeTriangle_Input20and7and15_OutputValidScaleneTriangle1()
        {
            // Arrange
            int side1 = 20;
            int side2 = 7;
            int side3 = 15;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A scalene triangle is formed", result);
        }

        [Test]
        public void AnalyzeTriangle_Input50and80and120_OutputValidScaleneTriangle2()
        {
            // Arrange
            int side1 = 50;
            int side2 = 80;
            int side3 = 120;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A scalene triangle is formed", result);
        }

        [Test]
        public void AnalyzeTriangle_Input8and10and12_OutputValidScaleneTriangle3()
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
        public void AnalyzeTriangle_Input5and12and13_OutputValidScaleneTriangle4()
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
        public void AnalyzeTriangle_Input7and15and20_OutputValidScaleneTriangle5()
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
        public void AnalyzeTriangle_Input0and55and56_OutputZeroLengthSide1()
        {
            // Arrange
            int side1 = 0;
            int side2 = 55;
            int side3 = 56;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("At least one side entered had a zero - invalid triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_Input130and0and64_OutputZeroLengthSide2()
        {
            // Arrange
            int side1 = 130;
            int side2 = 0;
            int side3 = 64;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("At least one side entered had a zero - invalid triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_Input45and80and0_OutputZeroLengthSide3()
        {
            // Arrange
            int side1 = 45;
            int side2 = 80;
            int side3 = 0;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("At least one side entered had a zero - invalid triangle", result);
        }

        // Invalid Response Tests
        [Test]
        public void AnalyzeTriangle_Input1and1and10_OutputInvalidResponse1()
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
        public void AnalyzeTriangle_Input24and35and111_OutputInvalidResponse2()
        {
            // Arrange
            int side1 = 24;
            int side2 = 35;
            int side3 = 111;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A triangle cannot be formed", result);
        }

        [Test]
        public void AnalyzeTriangle_Input85and150and32_OutputInvalidResponse3()
        {
            // Arrange
            int side1 = 85;
            int side2 = 150;
            int side3 = 32;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual("A triangle cannot be formed", result);
        }
    }
}
