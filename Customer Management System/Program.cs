using System;

namespace Customer_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerInfo customer1 = new CustomerInfo();
            customer1.Id = 121212121212;
            customer1.Name = "Fakir";
            customer1.Surname = "Gülermi";
            customer1.Money = 15.25f;


           CustomerInfo customer2 = new CustomerInfo();
           customer2.Id = 232323232323;
           customer2.Name = "Mert";
           customer2.Surname = "Ortahal";
           customer2.Money = 302.5f;


            CustomerInfo customer3 = new CustomerInfo();
           customer3.Id = 343434343434;
           customer3.Name = "Banu";
           customer3.Surname = "Durumuiyi";
           customer3.Money = 10578.25f;


            CustomerInfo customer4 = new CustomerInfo();
           customer4.Id = 545454545454;
           customer4.Name = "Cemil";
           customer4.Surname = "Zengingilleroğulları";
           customer4.Money = 522250.05f;

            CustomerInfo[] customers = new CustomerInfo[] { customer1, customer2, customer3, customer4 };

            {

                Console.WriteLine(" -------------- Welcome to FalanFilan Banks --------------");

                foreach (var customer in customers)
                {
                    Console.WriteLine("Customer Id:  " + customer.Id  + " => " + customer.Name + " " + customer.Surname + " : "+ " Money = " + " ******* ");
                }

                Console.WriteLine("-------------------------------------");
            }

            //-------------------------------------Operations--------------------------------------------//

            CustomerManager customerManager = new CustomerManager();

            //add new customer
            customerManager.Add(customer3);

            // delete customer 
            customerManager.Delete(customer4);

            // show customer Money
            Console.WriteLine(" -------/ Customer Panel /------- ");

            customerManager.Money(customer1);

            customerManager.Money(customer2);

            customerManager.Money(customer3);

            customerManager.Money(customer4);

        }



    }
}
