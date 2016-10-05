using CodeReviewDemo.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeReviewDemo.Tests
{
    [TestClass]
    public class ContentTests
    {
        private const string Hello = "Goodbye 1";

        [TestMethod]
        public void CotentGet_Success()
        {
            Assert.AreEqual(Hello, new Content().Get());

        }
    }
}
