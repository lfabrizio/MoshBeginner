using System;
using System.Text;
[
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World ");
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);

            Console.WriteLine("first char" + builder[0]);

        }
    }
]