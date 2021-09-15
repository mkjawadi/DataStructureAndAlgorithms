using System;

namespace DataStructureAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Array numbers = new Array(3);

            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Insert(40);

            numbers.RemoveAt(1);

            numbers.Print();

            Console.WriteLine(numbers.IndexOf(30));

            Console.WriteLine("The max number is "+numbers.Max());

            Array numbers2 = new Array(3);
            numbers2.Insert(20);
            numbers2.Insert(40);
            numbers2.Insert(80);
            numbers.Intersect(numbers2);

            numbers.InsertAt(15, 1);
            
            numbers.Reverse();
        }
    }
}
    