using CodeReviewDemo.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeReviewDemo.Tests
{
    [TestClass]
    public class ContentTests
    {
        private const string Hello = "Test change";

        [TestMethod]
        public void CotentGet_Success()
        {
            Assert.AreEqual(Hello, new Content().Get());

        }
    }
}
