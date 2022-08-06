using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImportLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using AffinitySoftwarePractical.Interfaces;

namespace ImportLibrary.Tests
{
    [TestClass()]
    public class CustomerImportTests
    {
        // I understand the better way to create this is to use the servie but I'm not 100% sure how to implement a Unit test project from scratch I have just added new tests to exsiting solutions
        private readonly ICustomerService _customerService;
        [TestMethod()]
        public void LoadCustomers()
        {
            var customerImport = new CustomerImport(_customerService);
            customerImport.LoadCustomers();
            Assert.Fail();
        }
    }
}