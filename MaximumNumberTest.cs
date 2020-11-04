using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;
namespace MaximumNumberTest
{
    [TestClass]
    public class MaximumNumberTest
    {
        /// <summary>
        /// T.C-4.1
        /// Gives the maximum number at first position and returns the same number
        /// </summary>
        [TestMethod]
        public void MaxNumberAtFirstPosition_ReturnsSameNumber()
        {
            //Arrange
            int expectedValue = 10000;
            //Act
            int actualValue = new FindMaximumValue.GenricMaximum<int>(10000,100,10).MaxMethod();
            //Assert
            Assert.AreEqual(expectedValue,actualValue);
        }
        /// <summary>
        /// T.C-4.2
        /// Gives the maximum float at first position and returns the same value
        /// </summary>
        [TestMethod]
        public void MaxFloatValueAtFirstPosition_ReturnsSame()
        {
            //Arrange
            float expectedValue = 100.1f;
            //Act
            float actualValue = new FindMaximumValue.GenricMaximum<float>(100.1f, 10.1f, 1.1f).MaxMethod();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// T.C-4.3
        /// Gives the maximum string at first position and returns the same value
        /// </summary>
        [TestMethod]
        public void MaxStringAtFirstPosition_ReturnsSame()
        {
            //Arrange
            string expectedValue = "peach";
            //Act
            string actualValue = new FindMaximumValue.GenricMaximum<string>("peach", "apple", "banana").MaxMethod();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
