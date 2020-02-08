namespace CSharpFundamentals
{
    class Program 
    {
        static void Main(string[] args
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);

            var tommorow = now.AddDays(1);

            Console.WriteLine(now.ToLongDateString());
        })
    }

}