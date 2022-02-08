using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from the Mongo database.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine($"Saving data to your {GetType().Name} database");
        }
    }
}
