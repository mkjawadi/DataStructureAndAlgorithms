
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms
{
    public class StringReverser
    {
        public string Reverse(string input)
        {
            if (input == null)
                throw new ArgumentException();

            var stack = new Stack<Char>();
            var characters = input.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                stack.Push(characters[i]);
            }

            var reversed = new StringBuilder();

            while (stack.Count > 0)
            {
                reversed.Append(stack.Pop());
            }
            return reversed.ToString();
        }

    }
}