using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            Console.WriteLine("Input the number of values to store");

            int stSize = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("type a value to store and hit enter");

            for (int i = 0; i < stSize; i++)
            {
                Console.WriteLine("type a value to store and hit enter");
                st.Push(Console.ReadLine());
            }

            Console.WriteLine("The stored values in reverse order is: ");

            foreach (object obj in st)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
