using System;
using System.Collections.Generic;

namespace FactoryPatternEx2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to create? List, SQL, Mongo?");
            var response = Console.ReadLine();

            var database = DataAccessFactory.GetDataAccessType(response);

            List<Product> products = database.LoadData();

            Console.WriteLine("Here are the items in your database");

            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name}");
                Console.WriteLine($"Price: ${product.Price}");
                database.SaveData();
            }

            

        }
    }
}
