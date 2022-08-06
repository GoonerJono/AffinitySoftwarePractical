using AffinitySoftwarePractical.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AffinitySoftwarePractical.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _customerService.GetCustomers());
        }
    }
}
