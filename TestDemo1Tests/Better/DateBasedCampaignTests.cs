using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo1.Better;

namespace TestDemo1Tests.Better
{
    [TestClass()]
    public class DateBasedCampaignTests
    {
        [TestMethod()]
        public void DateBasedCampaignTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CalculateDiscountTest()
        {
            var campaign = new DateBasedCampaign(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1), 50);
            var discount = campaign.CalculateDiscount().Result;
            Assert.IsTrue(discount > 0);
        }
    }
}