using AffinitySoftwarePractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AffinitySoftwarePractical.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> GetCustomerName(int id);

        Task CreateCutomer(Customer customer);
    }
}
