using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Last in first out yöntemine göre çalışır. En son eklenen ilk erişilir.

            Stack<string> myStack = new Stack<string>();

            myStack.Push("ali");
            myStack.Push("veli");
            myStack.Push("hasan");
            myStack.Push("hüseyin");
            myStack.Push("ahmet");
            myStack.Push("mehmet");

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            //ElemanAt metodu
            Console.WriteLine("1. indexli eleman => " + myStack.ElementAt(1));

            //Peek metodu en üst sırada bulunan elemanı verir.
            Console.WriteLine("Peek metodu (En üstte yer alan eleman) => " + myStack.Peek());

            //Pop
            Console.WriteLine("Pook ile en üstte bulunan elemanı siliyoruz");
            myStack.Pop();

            Console.WriteLine("Peek metodu (En üstte yer alan eleman) => " + myStack.Peek());
            Console.ReadKey();
        }
    }
}
