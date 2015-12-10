using System;
using System.Threading.Tasks;

namespace TestDemo1.Better
{
    public class PaymentManager
    {
        private readonly IPaymentService _paymentService;
        private readonly ICampaignManager _campaignManager;
        private readonly IConfigurationRepository _configurationRepository;

        public PaymentManager(IPaymentService paymentService, ICampaignManager campaignManager, IConfigurationRepository configurationRepository)
        {
            _paymentService = paymentService;
            _campaignManager = campaignManager;
            _configurationRepository = configurationRepository;
        }

        public async Task<bool> DoPayment()
        {
            var result = Task.Run(() => _paymentService.ExternalPaymentCall(100));
            
            var millisecondsTimeout = _configurationRepository.Get("PaymentTimeOut");
            
            var wait = result.Wait(millisecondsTimeout);
            if (wait)
            {
                return await result;
            }
            else
                return false;
        }


        public async Task<bool> IsInCampaign(Product p)
        {
            return await _campaignManager.GetCurrentCampaign().CalculateDiscount() > 0;
        }
    }
}
