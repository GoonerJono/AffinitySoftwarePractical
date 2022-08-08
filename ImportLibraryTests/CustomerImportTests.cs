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
        private ICustomerImport _customerImport;
        private readonly AffinitySoftwarePracticalContext _context;

        [TestInitialize]
        public void SetUp()
        {
            _customerImport = new CustomerImport(_context);
        }
        [TestMethod()]
        public void LoadCustomers()
        {
            _customerImport.LoadCustomers();
            Assert.Fail();
        }
    }
}