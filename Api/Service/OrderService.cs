using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Common;
using Api.Data;
using Api.Model;
using Api.ModelDto;

namespace Api.Service
{

    public class OrderService
    {
        private readonly AppDbContext dbContext;
        public OrderService(AppDbContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<OrderHeader> CreateOrderAsync(OrderHeaderCreateDto orderHeaderCreateDto)
        {
            var order = new OrderHeader
            {
                AppUserId = orderHeaderCreateDto.AppUserId,
                CustomerName = orderHeaderCreateDto.CustomerName,
                CustomerEmail = orderHeaderCreateDto.CustomerEmail,
                OrderTotalAmount = orderHeaderCreateDto.OrderTotalAmount,
                TotalCount = orderHeaderCreateDto.TotalCount,
                Status = string.IsNullOrEmpty(orderHeaderCreateDto.Status)
                ? SharedData.OrderStatus.Pending
                : orderHeaderCreateDto.Status
            };

            await dbContext.OrderHeaders.AddAsync(order);
            await dbContext.SaveChangesAsync();

            foreach (var OrderDetailsDto in orderHeaderCreateDto.OrderDetailsDto)
            {
                var orderDetails = new OrderDetails
                {
                    OrderHeaderId = order.OrderHeaderId,
                    ItemName = OrderDetailsDto.ItemName,
                    ProductId = OrderDetailsDto.ProductId,
                    Price = OrderDetailsDto.Price,
                    Quantity = OrderDetailsDto.Quantity
                };
                await dbContext.OrderDetails.AddAsync(orderDetails);
            }
            await dbContext.SaveChangesAsync();
            return order;
        }
    }
}
