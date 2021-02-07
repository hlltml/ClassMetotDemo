using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added!" + "\n"
                + "Customer Name: " + customer.FirstName + " " + customer.LastName + "\n"
                + "Identity Number: " + customer.IdentityNumber + "\n"
                + "Id: " + customer.CustomerId + "\n");
        }
        public void Update(Customer customer, Customer updateCustomer)
        {
            Console.WriteLine("Customer updated!" + "\n"
                + "Customer Name: " + updateCustomer.FirstName + " " + updateCustomer.LastName + "\n"
                + "Identity Number: " + updateCustomer.IdentityNumber + "\n"
                + "Id: " + updateCustomer.CustomerId + "\n");
            customer.CustomerId = updateCustomer.CustomerId;
            customer.IdentityNumber = updateCustomer.IdentityNumber;
            customer.FirstName = updateCustomer.FirstName;
            customer.LastName = updateCustomer.LastName;

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted!. The deleted customer is " + customer.FirstName + " " + customer.LastName);
        }
    }
}
