using System;
using System.Collections.Generic;
using System.Text;

namespace ImportLibrary
{
    public interface ICustomerImport
    {
        void ImportCustomer();
        void LoadCustomers();
    }
}
