using System.Threading.Tasks;

namespace TestDemo1.Better
{
    public interface IPaymentService
    {
        bool ExternalPaymentCall(int i);
    }
}