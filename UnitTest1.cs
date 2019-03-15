using NUnit.Framework;
using NUnitTestProject2;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddNum()
        {
            Add a = new Add();
            int op = a.AddNum(1, 2);
            Assert.AreEqual(3, op);
        }
    }
}