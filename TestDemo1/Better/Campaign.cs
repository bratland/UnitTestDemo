using System.Threading.Tasks;

namespace TestDemo1.Better
{
    public abstract class Campaign
    {
        public abstract Task<int> CalculateDiscount();
    }
}