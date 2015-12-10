using System.Threading.Tasks;
using TestDemo1.Better;

namespace TestDemo1Tests.Better
{
    public class FakePaymentService : IPaymentService
    {
        public bool ExternalPaymentCall(int i)
        {
            return true;
        }
    }
}