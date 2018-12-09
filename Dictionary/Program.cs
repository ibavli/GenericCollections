using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "ali");
            dictionary.Add(2, "veli");
            dictionary.Add(3, "hasan");
            dictionary.Add(4, "hüseyin");

            //anahtara göre ekrana yazdırma
            Console.WriteLine("2 key'e ait değer => " + dictionary[2]);

            foreach (var item in dictionary)
            {
                Console.WriteLine("key => " + item.Key + " --- " + " value => " + item.Value);
            }

            //3 nolu keyi silelim
            dictionary.Remove(3);
            Console.WriteLine("3 nolu keyi sildikten sonra");


            foreach (var item in dictionary)
            {
                Console.WriteLine("key => " + item.Key + " --- " + " value => " + item.Value);
            }

            //1 keyli elemanı değiştirdik
            dictionary[1] = "yeni isim";
            Console.WriteLine("1 nolu keyi değiştirdikten sonra");

            foreach (var item in dictionary)
            {
                Console.WriteLine("key => " + item.Key + " --- " + " value => " + item.Value);
            }



            Dictionary<int, string> dictionary2 = new Dictionary<int, string>();

            dictionary2.Add(1, "1. değer");
            dictionary2.Add(3, "3. değer");
            dictionary2.Add(5, "5. değer");
            dictionary2.Add(4, "4. değer");
            dictionary2.Add(2, "2. değer");

            Console.WriteLine("dictionary2 orjinal");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("dictionary2 sıralandıktan sonra");
            var sirala = from eleman in dictionary2 orderby eleman.Key select eleman;
            foreach (var item in sirala)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
