using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Anday";
            customer1.CustomerSurname = "Aktaş";
            customer1.CustomerId = 1;
            customer1.Money = 80000;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Begüm";
            customer2.CustomerSurname = "Güner";
            customer2.CustomerId = 2;
            customer2.Money = 35000;

            Customer[] customers = new Customer[] {customer1,customer2 };

            CustomerManager customerManager = new CustomerManager();

            int Id;

            while (true)
            {
                Console.WriteLine("Eklemek istediğiniz müşterinin Id numarasını giriniz(0=Exit): ");
                Id = Convert.ToInt32(Console.ReadLine());

                if (Id==0)
                {
                    break;
                }
                else
                {
                    foreach (Customer customer in customers)
                    {
                        if (customer.CustomerId == Id)
                        {
                            customerManager.Add(customer);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            Console.WriteLine("Silmek istediğiniz müşterinin Id numarasını giriniz: ");
            Id = Convert.ToInt32(Console.ReadLine());

            foreach (Customer customer in customers)
            {
                if (customer.CustomerId == Id)
                {
                    customerManager.Delete(customer);
                }
                else
                {
                    continue;
                }
            }
            customerManager.BankRate();
            Console.WriteLine("\n----------------Müşteri Listesi---------------");
            customerManager.List();



        }
    }
}
