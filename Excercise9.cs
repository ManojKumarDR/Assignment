using System;
namespace Exercises
{
    class Words
    {
        public static string reverseByWords(string Input)
        {
            char[] charArray = Input.ToCharArray();
            string word = String.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                word += charArray[i];
            }


            return word;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(reverseByWords("Code done by ManojKumar D R"));
            Console.WriteLine(reverseByWords("This allows the software developer to implement the constraint propagation code and the decision-making code independently of one another."));
            Console.WriteLine(reverseByWords("My name is Manoj and i live in bangalore"));
        }
    }
}
