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
    }
}
