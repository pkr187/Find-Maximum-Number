using NUnit.Framework;
using FindMaximumNumberTest;

namespace FindMaximumNumberTest
{
    //A - Arrange
    //A - Act
    //A - Assert
    public class Tests
    {
        //TC 1.1
        [Test]
        public void GivenMaxFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            int num = max.FindMaxIntNumber(3, 1, 2);
            Assert.AreEqual(num, 3);
        }
        //TC 1.2
        [Test]
        public void GivenMaxSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            int num = max.FindMaxIntNumber(1, 3, 2);
            Assert.AreEqual(num, 3);
        }
        //TC 1.3
        [Test]
        public void GivenMaxThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            int num = max.FindMaxIntNumber(1, 2, 3);
            Assert.AreEqual(num, 3);
        }
        //TC 2.1
        [Test]
        public void GivenMaxFirsFloatNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            float num = max.FindMaxFloatNumber(3.1f, 1.2f, 2.4f);
            Assert.AreEqual(num, 3.1f);
        }
        //TC 2.2
        [Test]
        public void GivenMaxSecondFloatNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            float num = max.FindMaxFloatNumber(1.2f, 3.1f, 2.4f);
            Assert.AreEqual(num, 3.1f);
        }
        //TC 2.3
        [Test]
        public void GivenMaxThirdFloatNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            float num = max.FindMaxFloatNumber(1.2f, 2.4f, 3.1f);
            Assert.AreEqual(num, 3.1f);
        }
    }
}