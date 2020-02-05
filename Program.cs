using System;

namespace CSharpFundamentals
{
    class Progam 
    {
        static void Main(string[] args)
        {
         var firstName = "Mosh";
         var lastName = "Howard";

         var fullName = firstName + " " + lastName;

         var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);

         var names = new string [3] { "John", "Jack", "Mary"};
         var formattedNames = string.Join(",", names);

         var text = @"Hi John
         Look into the folowing paths
         c:\folder1\folder2
         c:\folder3\folder4";
         Console.WriteLine(text);
        }

    }
}