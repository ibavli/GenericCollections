using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("değer 2");//Sona ekledik
            linkedList.AddLast("değer 3");//Sona ekledik
            linkedList.AddLast("değer 4");//Sona ekledik
            linkedList.AddFirst("değer 1");//Başa ekledik

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            //Listenin ilk elemanı
            Console.WriteLine("Listenin ilk elemanı => " + linkedList.First.Value);

            //Listenin son elemanı
            Console.WriteLine("Listenin son elemanı => " + linkedList.Last.Value);


            //Belirtilen değeri silmek 
            linkedList.Remove("değer 3");
            Console.WriteLine("değer 3 silindikten sonra;");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            //İlk elemanı silmek
            //linkedList.RemoveFirst();

            //Son elemanı silmek
            //linkedList.RemoveLast();

            Console.WriteLine("-----");

            LinkedList<string> linkedList2 = new LinkedList<string>();

            linkedList2.AddLast("1. değer");
            linkedList2.AddLast("2. değer");
            linkedList2.AddLast("3. değer");
            linkedList2.AddLast("4. değer");
            linkedList2.AddLast("5. değer");


            LinkedListNode<string> bulunan = linkedList2.Find("3. değer");
            Console.WriteLine("Bulunan değer => " + bulunan.Value);
            Console.WriteLine("Bulunan değerin bir önceki => " + bulunan.Previous.Value);
            Console.WriteLine("Bulunan değerin bir sonrası => " + bulunan.Next.Value);

            Console.WriteLine("---");
            //Bulunan değerin öncesine ekle
            linkedList2.AddBefore(linkedList2.Find("3. değer"), "2.5 değer");

            //Bulunan değerin sonrasına ekle
            linkedList2.AddAfter(linkedList2.Find("3. değer"), "3.5 değer");

            Console.WriteLine("Eklemeler sonrası linkedlist2");
            foreach (var item in linkedList2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
