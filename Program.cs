using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_3_
{
    class Program
    {
        static void Main(string[] args)
        {   //a
            int[][] mas = new int[3][];
            mas[0] = new int[] { 1, 2, 3, 4 };
            mas[1] = new int[] { 5, 6, 7, 8 };
            mas[2] = new int[] { 9, 10, 11, 12 };
            Console.WriteLine("Mass : ");

            foreach (int[] x in mas)
            {
                foreach (int mas1 in x)
                {
                    Console.Write($"{mas1} \0");
                }
                Console.WriteLine();
            }


            //b

            String[] oneB = new String[] { "Nastya", "Alex", "Poule" };

            foreach (String element in oneB)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(oneB.Length);

            string a = oneB[0];
            oneB[0] = oneB[1];
            oneB[1] = a;

            foreach(string elem2 in oneB)
            {
                Console.WriteLine(elem2);
            }

            //c


            
        }
    }
}

