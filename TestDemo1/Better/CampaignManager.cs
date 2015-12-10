namespace TestDemo1.Better
{
    public class CampaignManager : ICampaignManager
    {
        private readonly ICampaignRepository _campaignRepo;

        public CampaignManager(ICampaignRepository campaignRepo)
        {
            _campaignRepo = campaignRepo;
        }

        public Campaign GetCurrentCampaign()
        {
            return _campaignRepo.GetCampaigns();
        }
    }
}