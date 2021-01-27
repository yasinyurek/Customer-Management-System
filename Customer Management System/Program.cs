using System;

namespace Customer_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerInfo customer1 = new CustomerInfo();
            customer1.Id = 121212121212;
            customer1.name = "Fakir";
            customer1.surname = "Gülermi";
            customer1.money = 15.25f;


           CustomerInfo customer2 = new CustomerInfo();
           customer2.Id = 232323232323;
           customer2.name = "Mert";
           customer2.surname = "Ortahal";
           customer2.money = 302.5f;


            CustomerInfo customer3 = new CustomerInfo();
           customer3.Id = 343434343434;
           customer3.name = "Banu";
           customer3.surname = "Durumuiyi";
           customer3.money = 10578.25f;


            CustomerInfo customer4 = new CustomerInfo();
           customer4.Id = 545454545454;
           customer4.name = "Cemil";
           customer4.surname = "Zengingilleroğulları";
           customer4.money = 522250.05f;

            CustomerInfo[] customers = new CustomerInfo[] { customer1, customer2, customer3, customer4 };

            {

                Console.WriteLine(" -------------- Welcome to FalanFilan Banks --------------");
                foreach (var customer in customers)
                {
                    Console.WriteLine("Customer Id:  " + customer.Id  + " => " + customer.name + " " + customer.surname + " : "+ " Money = " + " ******* ");
                }

                Console.WriteLine("-------------------------------------");
            }

            //-------------------------------------Operations--------------------------------------------//

            CustomerManager customerManager = new CustomerManager();

            //add new customer
            customerManager.Add(customer3);

            // delete customer 
            customerManager.Delete(customer4);

            // show customer money
            Console.WriteLine(" -------/ Customer Panel /------- ");

            customerManager.Money(customer1);

            customerManager.Money(customer2);

            customerManager.Money(customer3);

            customerManager.Money(customer4);

        }



    }
}
