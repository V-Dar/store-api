using Api.Data;
using Api.Service;

namespace Api.Controller
{
    public class OrderController : StoreController
    {
        public readonly OrderService orderService;
        public OrderController(AppDbContext dbContext, OrderService orderService) : base(dbContext)
        {
            this.orderService = orderService;
        }
    }
}