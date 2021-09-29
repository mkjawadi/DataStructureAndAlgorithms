using System;
using System.Collections.Generic;

namespace DataStructureAndAlgorithms
{
    public class Expression
    {
        private List<Char> leftBrackets = new List<char> { '(', '<', '[', '{' };
        private List<Char> rightBrackets = new List<char> { ')', '>', ']', '}' };
        public bool IsBalanced(string input)
        {
            // {(1+5)-(5-3)/[5-3]}
            var characters = input.ToCharArray();
            var stack = new Stack<Char>();
            for (int i = 0; i < characters.Length; i++)
            {
                if (IsLeftBracket(characters[i]))
                    stack.Push(characters[i]);

                if (IsRightBracket(characters[i]))
                {
                    if (stack.Count == 0) return false;

                    var top = stack.Pop();
                    if (!BracketsMatch(top, characters[i])) return false;
                }
            }
            return stack.Count == 0;
        }

        private bool IsLeftBracket(Char ch)
        {
            return leftBrackets.Contains(ch);
        }

        private bool IsRightBracket(Char ch)
        {
            return rightBrackets.Contains(ch);
        }

        private bool BracketsMatch(Char left, Char right)
        {
            return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);
        }
    }
}