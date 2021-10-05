using System;
using System.Collections.Generic;

namespace PracticeExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<int> list = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Append(i);
            }

            Console.WriteLine(list);

            list.Remove(0);

            Console.WriteLine(list);

            list.Remove(4);

            Console.WriteLine(list);

            list.Remove(3);

            Console.WriteLine(list);

            list.Remove(3);

            Console.WriteLine(list);

            list.Remove(2);

            Console.WriteLine(list);

            list.Remove(1);

            Console.WriteLine(list);

            Console.ReadKey();

        }
    }
}
