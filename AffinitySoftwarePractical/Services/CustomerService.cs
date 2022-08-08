using AffinitySoftwarePractical.Interfaces;
using ImportLibrary;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AffinitySoftwarePractical.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly AffinitySoftwarePracticalContext _context;
        private readonly ICustomerImport _customerImport;

        public CustomerService(AffinitySoftwarePracticalContext context, ICustomerImport customerImport)
        {
            _context = context;
            _customerImport = customerImport;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customer.ToListAsync();
        }

        public async Task<Customer> GetCustomerName(int id)
        {
            return await _context.Customer.FirstOrDefaultAsync( c => c.Id == id);
        }

        public async Task CreateCutomer(Customer customer)
        {
            var exsitingCustomer = await _context.Customer.FirstOrDefaultAsync(c => c.Id == customer.Id);
            if (exsitingCustomer != null)
            {
                exsitingCustomer.Name = customer.Name;
                _context.Customer.Update(exsitingCustomer);
                await _context.SaveChangesAsync();
            } 
            else
            {
                _context.Customer.Update(customer);
                await _context.SaveChangesAsync();
            }
        }


    }
}
