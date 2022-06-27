,
using MediatR;

namespace Order.Domain.AggregateModels.Events
{
    public class OrderStartedDomainEvent : INotification
    {
        public OrderStartedDomainEvent(string userName, OrderModels.Order order)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Order = order ?? throw new ArgumentNullException(nameof(order));
        }

        public string UserName { get; set; }
        public AggregateModels.OrderModels.Order Order { get; set; }
    }
}
