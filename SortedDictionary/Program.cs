using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

            sortedDictionary.Add(2, "2. değer");
            sortedDictionary.Add(5, "5. değer");
            sortedDictionary.Add(1, "1. değer");
            sortedDictionary.Add(4, "4. değer");
            sortedDictionary.Add(3, "3. değer");

            foreach (var item in sortedDictionary)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
