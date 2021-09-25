using System;
using System.Linq;

namespace DataStructureAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            // Array numbers = new Array(3);

            // numbers.Insert(10);
            // numbers.Insert(20);
            // numbers.Insert(30);
            // numbers.Insert(40);

            // numbers.RemoveAt(1);

            // numbers.Print();

            // Console.WriteLine(numbers.IndexOf(30));

            // Console.WriteLine("The max number is "+numbers.Max());

            // numbers.InsertAt(15, 1);
            
            // numbers.Reverse();
            #endregion
            
            #region LinkedList
            var list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            // Console.WriteLine(list.IndexOf(20));W
            // Console.WriteLine(list.Contains(10));
            // list.RemoveFirst();
            // list.RemoveLast();
            // Console.WriteLine(list.Size());
            list.Reverse();
            var array = list.ToArray();
            Console.WriteLine(string.Join(",",
                          array.Select(x => x.ToString()).ToArray()));
            #endregion
        }
    }
}
    