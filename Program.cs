using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            // var list = new LinkedList();
            // list.AddLast(10);
            // list.AddLast(20);
            // list.AddLast(30);
            // list.AddLast(40);
            // list.AddLast(50);
            // list.AddLast(60);
            // // Console.WriteLine(list.IndexOf(20));W
            // // Console.WriteLine(list.Contains(10));
            // // list.RemoveFirst();
            // // list.RemoveLast();
            // // Console.WriteLine(list.Size());
            // // list.Reverse();
            // // var array = list.ToArray();
            // // Console.WriteLine(string.Join(",",
            // //               array.Select(x => x.ToString()).ToArray()));
            // Console.WriteLine(list.GetKthFromTheEnd(6));
            #endregion

            #region Stack

            // Reversing a string
            // var reverser = new StringReverser();
            // var reversedText = reverser.Reverse("ABCD");
            // Console.WriteLine(reversedText);

            var expression = new Expression();
            var result = expression.IsBalanced("{(1+5)-(5-3)/[5-3]}");
            Console.WriteLine(result);
            #endregion
        }
    }
}
