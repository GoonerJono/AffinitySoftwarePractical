using AffinitySoftwarePractical.Interfaces;
using ImportLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace AffinitySoftwarePractical.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;

        public OrderController(IOrderService orderService, ICustomerService customerService)
        {
            _orderService = orderService;
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _orderService.GetAllOrders();
            foreach(var order in orders)
            {
                await PopulateCustomerDropDownList(order.CustomerId);
            }
            return View(orders);
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await _orderService.OrderDetails(id));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var order = await _orderService.OrderDetails(id);
            var orderViewModel = new OrderViewModel()
            {
                Order = order,
                OrderDetail = order.OrderDetail
            };
            if (order == null)
            {
                return NotFound();
            }
            await PopulateCustomerDropDownList(order.CustomerId);
            return View(orderViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(OrderViewModel orderViewModel)
        {
            
            await _orderService.Edit(orderViewModel);
            return RedirectToAction(nameof(OrderController.Index));
        }

        private async Task PopulateCustomerDropDownList(object selectedStudent = null)
        {
            var customers = await _customerService.GetCustomers();
            ViewBag.CustomerId = new SelectList(customers, "Id", "Name", selectedStudent);
        }

        public async Task<IActionResult> Create()
        {
            await PopulateCustomerDropDownList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrderViewModel orderViewModel)
        {
            await _orderService.Create(orderViewModel);
            return RedirectToAction(nameof(OrderController.Index));
        }

        // GET: TVShows/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var order = await _orderService.OrderDetails(id);
            var orderViewModel = new OrderViewModel()
            {
                Order = order,
                OrderDetail = order.OrderDetail
            };
            if (order == null)
            {
                return NotFound();
            }
            await PopulateCustomerDropDownList(order.CustomerId);
            return View(orderViewModel);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _orderService.Delete(id);
            return RedirectToAction(nameof(OrderController.Index));
        }
    }
}
