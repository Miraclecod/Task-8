using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SquareLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDoesNotNull()
        {

            Assert.IsNotNull(SquareLibrary.Square.SquareOfCircle(0));
            Assert.IsNotNull(SquareLibrary.Square.SquareOfTriangle(0, 0, 0));
        }

        [TestMethod]
        public void TestRightTriangle()
        {
            double x = SquareLibrary.Square.SquareOfTriangle(5, 4, 3);
            Assert.IsTrue(x == 6,
                       String.Format("Expected for '{0}': true; Actual: {1}",
                                     6, x));
        }

    }
}
