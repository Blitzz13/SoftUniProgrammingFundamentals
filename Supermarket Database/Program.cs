using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            string productName = "";
            double price;
            double quantity;
            var list = new List<double>(); ;
            var dict = new Dictionary<string, List<double>>();
            while (productName != "stocked")
            {
                var products = Console.ReadLine().Split().ToList();
                if (products.Count == 1)
                {
                    break;
                }

                productName = products[0];
                price = double.Parse(products[1]);
                quantity = double.Parse(products[2]);

                list = new List<double>();

                if (!dict.ContainsKey(productName))
                {
                    dict.Add(productName, new List<double>());
                }
                else if (dict.ContainsKey(productName))
                {
                    foreach (var product in dict)
                    {
                        if (product.Key == productName)
                        {
                            quantity += product.Value[1];

                        }
                    }
                }

                list.Add(price);
                list.Add(quantity);
                dict[productName] = list;

            }
            double grandTotal = 0;
            foreach (var product in dict)
            {
                var sum = product.Value[0] * product.Value[1];
                grandTotal += sum;
                Console.WriteLine($"{product.Key}: ${product.Value[0]:F2} * {product.Value[1]} = ${sum:F2}");
            }
            Console.WriteLine(new string('-', 30));

            Console.WriteLine($"Grand Total: ${grandTotal:F2}");

        }
    }
}
