using System;
using System.Collections.Generic;
using System.IO;

namespace ImportLibrary
{

   public class CustomerImport : ICustomerImport
    {
        private readonly AffinitySoftwarePracticalContext _context;

        public CustomerImport(AffinitySoftwarePracticalContext context)
        {
            _context = context;
        }

        public List<Customer> customers = new List<Customer>();


        public void ImportCustomer()
        {
            if(customers.Count != 0)
            {
                foreach(var customer in customers)
                {

                    _context.Customer.Add(customer);
                    _context.SaveChanges();
                }
            }
        }

        public void LoadCustomers()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\xboxl\Downloads\NameList.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                customers.Add(new Customer()
                {
                    Id = Convert.ToInt32(values[0]),
                    Name = values[1]
                });
            }

            ImportCustomer();

        }
    }
}
