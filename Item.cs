using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Item : Product
    {
        public override void PrintInfo()
        {
            Console.WriteLine($"Название: {Name} Цена: {Price} Дата производства: {ProductionDate.ToString("dd.MM.yyyy")} Срок Годности: {(ExpiryDate - ProductionDate).Days}");
        }

        public override bool IsExpired(DateTime currentDate)
        {
            return currentDate > ExpiryDate;
        }
    }
}
