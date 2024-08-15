using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            List<Product> products = new List<Product>();
            Console.WriteLine("Reading data from SQLDataAccess....\n");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to SQLDataAccess....\n");
        }
    }
}
