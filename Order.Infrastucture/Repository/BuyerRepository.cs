using Order.Application.Repository;

namespace Order.Infrastucture.Repository
{
    public class BuyerRepository : IBuyerRepository
    {
        public Task<int> SaveChangeAsync()
        {
            return Task.FromResult(1);
        }
    }
}
