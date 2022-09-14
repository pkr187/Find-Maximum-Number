using NUnit.Framework;
using FindMaximumNumberTest;

namespace FindMaximumNumberTest
{
    // Using Generics
    public class Tests
    {
        //TC 1.1
        [Test]
        public void GivenMaxFirstPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<int> max = new FindMaxGenerics<int>(3, 1, 2);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }
        //TC 1.2
        [Test]
        public void GivenMaxSecondPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<int> max = new FindMaxGenerics<int>(1, 3, 2);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }
        //TC 1.3
        [Test]
        public void GivenMaxThirdPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<int> max = new FindMaxGenerics<int>(1, 2, 3);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }
        //TC 2.1
        [Test]
        public void GivenMaxFirstPositionFloatNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<float> max = new FindMaxGenerics<float>(3.1f, 1.2f, 2.4f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        //TC 2.2
        [Test]
        public void GivenMaxSecondPositionFloatNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<float> max = new FindMaxGenerics<float>(1.2f, 3.1f, 2.4f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        //TC 2.3
        [Test]
        public void GivenMaxThirdPositionFloatNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<float> max = new FindMaxGenerics<float>(1.2f, 2.4f, 3.1f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        //TC 3.1
        [Test]
        public void GivenMaxFirstPositionString_WhenAnalized_ShouldReturnMaxString()
        {
            FindMaxGenerics<string> max = new FindMaxGenerics<string>("Peach", "Banana", "Apple");
            string num = max.FindMax();
            Assert.AreEqual(num, "Peach");
        }
        //TC 3.2
        [Test]
        public void GivenMaxSecondPositionString_WhenAnalized_ShouldReturnMaxString()
        {
            FindMaxGenerics<string> max = new FindMaxGenerics<string>("Banana", "Peach", "Apple");
            string num = max.FindMax();
            Assert.AreEqual(num, "Peach");
        }
        //TC 3.3
        [Test]
        public void GivenMaxThirdPositionString_WhenAnalized_ShouldReturnMaxString()
        {
            FindMaxGenerics<string> max = new FindMaxGenerics<string>("Banana", "Apple", "Peach");
            string num = max.FindMax();
            Assert.AreEqual(num, "Peach");
        }
    }
}