using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestDemo1.Better;

namespace TestDemo1Tests.Better
{
    [TestClass()]
    public class CampaignManagerTests
    {
        [TestMethod()]
        public void GetCurrentCampaignTest()
        {
            
            var campaignManagerMock = new Mock<ICampaignManager>();
            var fakeCampaign = new FakeCampaign();
            campaignManagerMock.Setup(cm => cm.GetCurrentCampaign()).Returns(fakeCampaign);

            var campaign = campaignManagerMock.Object.GetCurrentCampaign();
            var y = campaign.CalculateDiscount().Result;
            Assert.IsTrue(y > 0);
        }
    }

    public class FakeCampaign : Campaign
    {
        public override Task<int> CalculateDiscount()
        {
            return Task.Run(() => 20);
        }
    }
}