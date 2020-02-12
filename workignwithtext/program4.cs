using System;

namespace CSharpFundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Whats your name?");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for(var i = name.Length; i > 0; i--)
            array[name.Length - 1] = name[i - 1];

            var reversed = new string(array);

            Console.WriteLine("Reversed name: " + reversed);
        }
        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            array[name.length - 1] = name[i - 1];

            return new string(array);

        }
    }
}