using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Customer Adding : " + customer.Name + " " + customer.Surname);
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Customer Deleted : " + customer.Name + " " + customer.Surname);
        }
        public void ListCustomer(Customer[] customers)
        {
            Console.WriteLine("Customer List");
            foreach (var Customer in customers)
            {
                Console.WriteLine(Customer.Name + " " + Customer.Surname);
            }


        }
    }
}
