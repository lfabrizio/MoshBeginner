using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
                var name = "John Smith";

                for (var i = 0; i < name.length; i++)
                {
                    Console.WriteLine(name[i])
                }

                foreach (var character in name)
                {
                    Console.WriteLine(character);
                }
                }
            }
        }
    }
}