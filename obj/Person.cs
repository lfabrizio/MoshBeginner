using System;

namespace CSharpFundamentals
{
    public class Person 
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          var John = new Person();
          John.FirstName = "John";
          John.LastName = "Smith";
          John.Introduce();
            
        }
    }
}