using Order.Application.Repository;

namespace Order.Infrastucture.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public Task<int> SaveChangeAsync()
        {
            return Task.FromResult(1);
        }
    }
}
