﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndbilliard
{
    class Program
    {
        static void Main(string[] args)
        {

            int productsCount = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> shopProducts = new Dictionary<string, decimal>();

            //adding products to shop
            for (int i = 0; i < productsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split('-').ToArray();
                string name = tokens.First();
                decimal price = decimal.Parse(tokens[1]);

                if (shopProducts.ContainsKey(tokens.First()))
                {
                    shopProducts[name] = price;
                }
                else
                {
                    shopProducts.Add(tokens.First(), tokens.Skip(1).Select(decimal.Parse).First());
                }

            }
            Dictionary<string, Customer> dict = new Dictionary<string, Customer>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split('-', ',').ToArray();

                string name = tokens[0];
                if (name == "end of clients")
                {
                    break;
                }
                string product = tokens[1];
                if (shopProducts.ContainsKey(product))
                {
                    int quantity = int.Parse(tokens[2]);
                    decimal price = shopProducts[product];
                    if (dict.ContainsKey(name))
                    {
                        dict[name].Bill += quantity * price;
                        if (dict[name].ItemsInfo.ContainsKey(product))
                        {
                            dict[name].ItemsInfo[product] += quantity;
                        }
                        else
                        {
                            dict[name].ItemsInfo.Add(product, quantity);
                        }
                    }
                    else
                    {
                        dict.Add(name, new Customer());
                        dict[name].ItemsInfo = new Dictionary<string, int>();
                        dict[name].ItemsInfo.Add(product, quantity);
                        dict[name].Bill = price * quantity;
                    }
                }
            }


            foreach (var customer in dict.OrderBy(a => a.Key))
            {
                Console.WriteLine(customer.Key);
                foreach (var v in customer.Value.ItemsInfo)
                {
                    Console.WriteLine($"-- {v.Key} - {v.Value}");
                }

                Console.WriteLine($"Bill: {customer.Value.Bill:F2}");
            }
            Console.WriteLine("Total bill: {0:f2}", dict.Sum(v => v.Value.Bill));
        }

        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ItemsInfo { get; set; }
            public decimal Bill { get; set; }
        }
        class CustomerInfo
        {
            public string Name { get; set; }
            public List<Dictionary<string, int>> Products { get; set; }
            public decimal Bill { get; set; }
        }
    }
}

