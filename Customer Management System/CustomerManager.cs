using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Management_System
{
    class CustomerManager
    {
        public void Add(CustomerInfo customer)
        {
            Console.WriteLine(customer.Id + " : "+ customer.Name + " " + customer.Surname + " " + "Successfully added!");

            Console.WriteLine("-------------------------------------");
        }
        public void Delete(CustomerInfo customer)
        {
            Console.WriteLine(customer.Id + " : "+ customer.Name + " " + customer.Surname + " " + " Successfully deleted!");

            Console.WriteLine("-------------------------------------");
        }

        public void Money(CustomerInfo customer)
        {
            Console.WriteLine( "Your Id: "+ customer.Id + " : " + customer.Name+ " "+ "Your Money: => " + customer.Money + "TL" );

            Console.WriteLine("-------------------------------------");
        }

        
    }
}
