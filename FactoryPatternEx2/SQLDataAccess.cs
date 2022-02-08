using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class SQLDataAccess : IDataAccess
    {
       
        public List<Product> LoadData()
        {
            Console.WriteLine("Reading your data from the SQL Database.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine($"Saving data to your {GetType().Name} database");
        }
    }
}
