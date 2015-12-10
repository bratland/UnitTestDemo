using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo1.Bad;

namespace TestDemo1Tests.Bad
{
    [TestClass()]
    public class DateBasedCampaignTests
    {
        [TestMethod()]
        public void CalculateDiscountTest()
        {
            var campaign = new DateBasedCampaign(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1), 50);
            var discount = campaign.CalculateDiscount().Result;
            Assert.IsTrue(discount > 0);
        }
    }
}