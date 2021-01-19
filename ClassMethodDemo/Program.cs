using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.Age = 18;

            Customer customer2 = new Customer();
            customer2.Name = "Gökhan";
            customer2.Surname = "Çam";
            customer2.Age = 25;

            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerDelete(customer1);
            customerManager.CustomerDelete(customer2);

            Customer[] customers = new Customer[] { customer1,customer2 };
            customerManager.ListCustomer(customers);





        }
    }
}
