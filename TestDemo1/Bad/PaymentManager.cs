using System.Threading.Tasks;

namespace TestDemo1.Bad
{
    public class PaymentManager
    {

        public async Task<bool> DoPayment()
        {
            var paymentService = new PaymentService();
            var result = paymentService.ExternalPaymentCall(100);

            if (result.Wait(7000))
            {
                return result.Result;
            }
            else
                return false;
        }


        public async Task<bool> IsInCampaign(Product p)
        {
            var campaignManager = new CampaignManager();
            return await campaignManager.GetCurrentCampaign().CalculateDiscount() > 0;
        }
    }
}
