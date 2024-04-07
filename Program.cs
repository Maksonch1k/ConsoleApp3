using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
        {
            new Item { Name = "Молоко", Price = 100, ProductionDate = new DateTime(2024, 2, 14), ExpiryDate = new DateTime(2024, 2, 21) },
            new Item { Name = "Яблоки", Price = 200, ProductionDate = new DateTime(2024, 2, 9), ExpiryDate = new DateTime(2024, 3, 10) },
            new Set
            {
                Name = "Подарочный набор",
                Price = 500,
                Products = new List<Product>
                {
                    new Item { Name = "Шоколад" },
                    new Item { Name = "Печенье" }
                }
            }
        };

            foreach (var product in products)
            {
                product.PrintInfo();
            }

            DateTime currentDate = DateTime.Now;
            bool expiredFound = false; // флаг для обнаружения просроченных товаров

            foreach (var product in products)
            {
                if (product.IsExpired(currentDate))
                {
                    if (!expiredFound) // проверка, были ли уже найдены просроченные товары
                    {
                        Console.WriteLine("\nПросроченные товары:");
                        expiredFound = true; // устанавливаем флаг в true, чтобы не выводить заголовок второй раз
                    }
                    Console.WriteLine($"Название: {product.Name}"); // выводим только название просроченного товара
                }
                Console.ReadKey();
            }
        }
    }
}
