using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class Product : IDataAccess
    {
        public Product()
        {

        }

        public string Name { get; set; }
        public double Price { get; set; }

        public List<Product> LoadData()
        {
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
