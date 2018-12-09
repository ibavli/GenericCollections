using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //First in first out => ilk giren ilk çıkar mantığı

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("ali");
            queue.Enqueue("veli");
            queue.Enqueue("hasan");
            queue.Enqueue("hüseyin");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Peek metodu en üstteki elemanı verir
            Console.WriteLine("En üstteki eleman => " + queue.Peek());


            //En üstteki elemanı siler
            queue.Dequeue();

            Console.WriteLine("En üstteki eleman => " + queue.Peek());

            Console.ReadLine();
        }
    }
}
