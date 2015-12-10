using Autofac;
using Autofac.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo1.Better;

namespace TestDemo1Tests.Better
{
    [TestClass()]
    public class PaymentManagerTests
    {

        private static IContainer Container { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ConfigurationRepository>().As<IConfigurationRepository>();
            builder.RegisterType<FakePaymentService>().As<IPaymentService>();
            builder.RegisterType<CampaignManager>().As<ICampaignManager>();
            builder.RegisterType<FakeCampaignRepository>().As<ICampaignRepository>();
            builder.RegisterType<PaymentManager>().AsSelf();
            Container = builder.Build();
        }

        [TestMethod()]
        public void DoPaymentTest()
        {
            var scope = Container.BeginLifetimeScope();
            var paymentManager = scope.Resolve<PaymentManager>();

            var x = paymentManager.DoPayment();
            Assert.IsTrue(x.Result);
        }

        [TestMethod()]
        public void IsInCampaignTest()
        {
        }

        [TestMethod()]
        public void PaymentManagerTest()
        {
        }
    }

    public class FakeCampaignRepository : ICampaignRepository
    {
        public Campaign GetCampaigns()
        {
            return new FakeCampaign();
        }
    }

    public class ConfigurationRepository : IConfigurationRepository
    {
        public int Get(string key)
        {
            return 1;
        }
    }
}