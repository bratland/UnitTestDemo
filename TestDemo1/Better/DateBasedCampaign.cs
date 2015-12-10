using System;
using System.Threading.Tasks;

namespace TestDemo1.Better
{
    public class DateBasedCampaign : Campaign
    {
        private readonly int _discountPercentage;
        private readonly DateTime _endTime;
        private readonly DateTime _startTime;

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