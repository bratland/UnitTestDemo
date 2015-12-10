using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo1.Bad;

namespace TestDemo1Tests.Bad
{
    [TestClass()]
    public class PaymentManagerTests
    {
        [TestMethod()]
        public void DoPaymentTest()
        {
            var paymentManager = new PaymentManager();
            var x = paymentManager.DoPayment();
            Assert.IsTrue(x.Result);
        }
    }
}