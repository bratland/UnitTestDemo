using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo1.Bad;

namespace TestDemo1Tests.Bad
{
    [TestClass()]
    public class CampaignManagerTests
    {
        [TestMethod()]
        public void GetCurrentCampaignTest()
        {
            var campaignManager = new CampaignManager();
            var campaign = campaignManager.GetCurrentCampaign();
            var y = campaign.CalculateDiscount().Result;
            Assert.IsTrue(y > 0);
        }
    }
}