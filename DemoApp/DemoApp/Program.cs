using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Priority_Queue

            //var pq = new PriorityQueue<string, int>();

            //pq.Enqueue("A", 3);
            //pq.Enqueue("B", 1);
            //pq.Enqueue("C", 2);
            //pq.Enqueue("D", 3);

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Remove Element is : {0}", pq.Dequeue());
            //}

            //Console.ReadLine();

            #endregion

            #region UnionBy

            //var first = new (string Name, int Age)[]
            //{
            //    ("John", 20),
            //    ("Rose", 30),
            //    ("Mark", 40)
            //};

            //var second = new (string Name, int Age)[]
            //{
            //    ("Jack", 30),
            //    ("Harry", 30),
            //    ("Joy", 33)
            //};

            //var result = first.UnionBy(second, person => person.Name);

            //foreach (var item in result)
            //{
            //    Console.WriteLine("Name : {0} , Age : {1}", item.Name, item.Age);
            //}

            //Console.ReadLine();

            #endregion

            #region DistinctBy

            //var result = Enumerable.Range(1, 20).DistinctBy(x => x % 3);

            //Console.Write("Output is :");
            //foreach (var item in result)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.ReadLine();

            #endregion

            #region MaxBy / MinBy

            var people = new (string name, int age)[]
            {
                ("jack", 20),
                ("john", 20),
                ("rose", 30),
                ("mark", 40)
            };
            var result = people.MinBy(person => person.age);

            Console.WriteLine("output is :" + result.name);
            Console.ReadLine();

            #endregion

        }
    }
}
