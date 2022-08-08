using ImportLibrary;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AffinitySoftwarePractical.Interfaces
{
    public interface IOrderService 
    {
        Task<List<Order>> GetAllOrders();
        Task<Order> OrderDetails(int? id);
        Task Create(OrderViewModel orderViewModel);
        Task Edit(OrderViewModel orderViewModel);
        Task Delete(int id);

    }
}
