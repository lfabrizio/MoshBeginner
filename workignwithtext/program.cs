using system;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mosh Hamedi";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim.ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = firstName.Substring(0, index);
            var lastName = fullName.substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);

            var names = fullName.split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Mosh", "Mosher"));

            if (String.IsNullOrEmpty(null))
            Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            price.ToString("C");
            
        }
    }
}