using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Management_System
{
    class CustomerManager
    {
        public void Add(CustomerInfo customer)
        {
            Console.WriteLine(customer.Id + " : "+ customer.name + " " + customer.surname + " " + "Successfully added!");

            Console.WriteLine("-------------------------------------");
        }
        public void Delete(CustomerInfo customer)
        {
            Console.WriteLine(customer.Id + " : "+ customer.name + " " + customer.surname + " " + " Successfully deleted!");

            Console.WriteLine("-------------------------------------");
        }

        public void Money(CustomerInfo customer)
        {
            Console.WriteLine( "Your Id: "+ customer.Id + " : " + customer.name+ " "+ "Your Money: => " + customer.money + "TL" );

            Console.WriteLine("-------------------------------------");
        }
    }
}
