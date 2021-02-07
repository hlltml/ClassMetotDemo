using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerId = 1;
            customer.IdentityNumber = "12345678910";
            customer.FirstName = "Halil";
            customer.LastName = "Temel";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Update(customer,
                new Customer {CustomerId=customer.CustomerId, IdentityNumber = "12345", FirstName ="Hasan", LastName=customer.LastName });
            customerManager.Delete(customer);
        }
    }
}
