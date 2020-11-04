using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;
namespace MaximumNumberTest
{
    [TestClass]
    public class MaximumNumberTest
    {
        /// <summary>
        /// T.C-1.1
        /// Gives the maximum number at first position and returns the same number
        /// </summary>
        [TestMethod]
        public void MaxNumberAtFirstPosition_ReturnsSameNumber()
        {
            //Arrange
            int expectedValue = 10000;
            //Act
            int actualValue =FindMaximumInteger.MaximumIntegerNumber(10000,100,10);
            //Assert
            Assert.AreEqual(expectedValue,actualValue);
        }
        /// <summary>
        /// T.C-1.2
        /// Gives the maximum number at second position and returns the same number
        /// </summary>
        [TestMethod]
        public void MaxNumberAtSecondPosition_ReturnsSameNumber()
        {
            //Arrange
            int expectedValue = 10001;
            //Act
            int actualValue = FindMaximumInteger.MaximumIntegerNumber(10000, 10001, 10);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// T.C-1.3
        /// Gives the maximum number at second position and returns the same number
        /// </summary>
        [TestMethod]
        public void MaxNumberAtThirdPosition_ReturnsSameNumber()
        {
            //Arrange
            int expectedValue = 10101;
            //Act
            int actualValue = FindMaximumInteger.MaximumIntegerNumber(10000, 10001, 10101);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// T.C-2.1
        /// Gives the maximum float value at first position and returns the same number
        /// </summary>
        [TestMethod]
        public void MaxFloatAtFirstPosition_ReturnsSameNumber()
        {
            //Arrange
            float expectedValue = 1000.1f;
            //Act
            float actualValue = FindMaximumFloat.MaximumFloatNumber(1000.1f, 100.1f, 10.1f);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// T.C-2.2
        /// Gives the maximum float at second position and returns the same number
        /// </summary>
        [TestMethod]
        public void MaxFloatAtSecondPosition_ReturnsSameNumber()
        {
            //Arrange
            float expectedValue = 1000.1f;
            //Act
            float actualValue = FindMaximumFloat.MaximumFloatNumber(100.1f, 1000.1f, 10.1f);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// T.C-2.3
        /// Gives the maximum float at second position and returns the same number
        /// </summary>
        [TestMethod]
        public void MaxFloatAtThirdPosition_ReturnsSameNumber()
        {
            //Arrange
            float expectedValue = 100.1f;
            //Act
            float actualValue = FindMaximumFloat.MaximumFloatNumber(1.1f, 10.1f, 100.1f);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// T.C-3.1
        /// Given maximum string value at first position return expected value.
        /// </summary>
        [TestMethod]
        public void GivenMaximumStringValueAtFirstPosition_ShouldReturnExpectedValue()
        {
            //Arrange
            string expectedValue = "cat";
            //Act
            string actualValue = FindMaximumString.MaximumOfGivenStrings("cat", "apple", "bat");
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// T.C--3.2
        /// Given maximum string value at second position return expected value.
        /// </summary>
        [TestMethod]
        public void GivenMaximumStringValueAtSecondPosition_ShouldReturnExpectedValue()
        {
            //Arrange
            string expectedValue = "monkey";
            //Act
            string actualValue = FindMaximumString.MaximumOfGivenStrings("cat", "monkey", "goat");
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// T.C--3.3
        /// Givens the String  values to find maximum  ,given maximum string value at third position return expected value.
        /// </summary>
        [TestMethod]
        public void GivenMaximumStringValueAtThirdPosition_ShouldReturnExpectedValue()
        {
            //Arrange
            string expectedValue = "kiwi";
            //Act
            string actualValue = FindMaximumString.MaximumOfGivenStrings("apple", "guava", "kiwi");
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}
