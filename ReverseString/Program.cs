using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me string");
            string givenString = Console.ReadLine();
            string reversedString = "";
            for (int i = givenString.Length-1; i>=0 ;i--)
            {
                reversedString = reversedString+givenString[i];
            }
            Console.WriteLine(reversedString);
        }
    }
}
