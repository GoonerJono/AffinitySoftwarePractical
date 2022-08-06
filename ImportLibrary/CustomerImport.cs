using AffinitySoftwarePractical.Interfaces;
using AffinitySoftwarePractical.Models;
using System;
using System.IO;

namespace ImportLibrary
{

    // My understanding here instead of creating a new conext you should use the customer service to do the final creating of the customer
   public class CustomerImport : ICustomerImport
    {
        public Customer customer = new Customer();
        private readonly ICustomerService _customerService;

        public CustomerImport(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public void ImportCustomer()
        {
            if(customer != null)
            {
                _customerService.CreateCutomer(customer);
            }
        }

        public void LoadCustomers()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\xboxl\Downloads\NameList.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                customer.Id = Convert.ToInt32(values[0]);
                customer.Name = values[1];
                ImportCustomer();
            }

        }
    }
}
