using System;
using System.Threading.Tasks;

namespace TestDemo1.Better
{
    public class PaymentService
    {
        public async Task<bool> ExternalPaymentCall(int amount)
        {
            int waitTime = new Random().Next(5000, 9000);
            await Task.Delay(waitTime);

            return new Random().Next(1) == 0;
        }
    }
}
