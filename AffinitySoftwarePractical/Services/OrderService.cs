using AffinitySoftwarePractical.Interfaces;
using ImportLibrary;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AffinitySoftwarePractical.Services
{
    public class OrderService : IOrderService 
    {

        private readonly AffinitySoftwarePracticalContext _context;

        public OrderService(AffinitySoftwarePracticalContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _context.Order.Include(o => o.OrderDetail).ToListAsync();
        }

        public async Task<Order> OrderDetails(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var order = await _context.Order.Include(or => or.OrderDetail)
                .FirstOrDefaultAsync(o => o.Id == id);
            if (order == null)
            {
                return null;
            }

            return order;
        }

        public async Task Create(OrderViewModel orderViewModel)
        {
            if (orderViewModel != null)
            {
                var order = orderViewModel.Order;
                order.OrderDetail = orderViewModel.OrderDetail;
                _context.Order.Add(order);
                await _context.SaveChangesAsync();


            }
        }

        public async Task Edit(OrderViewModel orderViewModel)
        {
            
            if (orderViewModel != null)
            {
                
                    var order = orderViewModel.Order;
                    order.OrderDetail = orderViewModel.OrderDetail;
                    _context.Update(order);
                    await _context.SaveChangesAsync();

            }
        }

        public async Task Delete(int id)
        {
            var order = await _context.Order.Include(o => o.OrderDetail).FirstOrDefaultAsync(or => or.Id == id);

            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
        }

    }
}
