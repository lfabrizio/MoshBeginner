using System;

namespace CSharpFundamentals
{
    class Program2
    {
        static void Main(string[] args)
       {
           var sentence = "This is going to ve really really long text";
           var summary = StringUtility.SummerizeText(sentence, 25);
           Console.WriteLine(summary);
        }

       
    }

}