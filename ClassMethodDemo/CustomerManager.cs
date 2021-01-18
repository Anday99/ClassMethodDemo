using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer) 
        {
            customers.Add(customer);
            Console.WriteLine("{0} {1} isimli müşteri eklendi.\n", customer.CustomerName, customer.CustomerSurname);
        }

        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("{0} {1} isimli müşteri silindi.\n", customer.CustomerName, customer.CustomerSurname);
        }

        public void BankRate()
        {
            foreach (var customer in customers)
            {
                if (customer.Money>=0 && customer.Money<=40000)
                {
                    customer.BankRate=14.4;
                }
                else if (customer.Money >= 40001 && customer.Money <= 100000)
                {
                    customer.BankRate = 16.4;
                }
                else if (customer.Money >= 100001)
                {
                    customer.BankRate = 18.4;
                }
                else
                {
                    customer.BankRate = 0;
                }
            }
        }
        public void List()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerName+" "+customer.CustomerSurname+"\nHesabındaki para:"+customer.Money+"\nÖzel banka faizi:"+"%"+customer.BankRate+"\n");
            }
        }
    }
}
