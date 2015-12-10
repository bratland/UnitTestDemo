using System;
using System.Threading.Tasks;

namespace TestDemo1.Bad
{
    public class CampaignManager
    {
        public Campaign GetCurrentCampaign()
        {
            return new DateBasedCampaign(DateTime.Now, DateTime.Now.AddDays(1), 20);
        }

        

       
    }

    public abstract class Campaign
    {
        public abstract Task<int> CalculateDiscount();
    }

    public class DateBasedCampaign : Campaign
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private int _discountPercentage;

        public DateBasedCampaign(DateTime startTime, DateTime endTime, int discountPercentage)
        {
            _startTime = startTime;
            _endTime = endTime;
            _discountPercentage = discountPercentage;
        }

        public override async Task<int> CalculateDiscount()
        {
            if (DateTime.Now > _startTime && DateTime.Now < _endTime)
                return _discountPercentage;

            return 0;
        }
    }
}
