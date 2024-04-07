using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Set : Product
    {
        public List<Product> Products { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Название: {Name} Цена: {Price} Продукты:");
            foreach (var product in Products)
            {
                Console.WriteLine($"- {product.Name}");
            }
        }

        public override bool IsExpired(DateTime currentDate)
        {
            foreach (var product in Products)
            {
                if (product.IsExpired(currentDate))
                    return true;
            }
            return false;
        }
    }
}
