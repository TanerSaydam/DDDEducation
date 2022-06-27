using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.BuyerModels
{
    public class Buyer : BaseEntity
    {
        public Buyer(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }

        public string UserName { get; private set; }
    }
}
