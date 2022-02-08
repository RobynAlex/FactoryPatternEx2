using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
        }

        public static List<Product> products = new List<Product>()
       {
           new Product() {Name = "Monopoly Game", Price = 25.99},
           new Product() {Name = "Teddy Bear", Price = 7.99}
       };

      
        public List<Product> LoadData()
        {
            Console.WriteLine("Reading Your List.");
            return products;
        }


        public void SaveData()
        {
            Console.WriteLine($"Saving Data to {GetType().Name}");
        }
    }
}
