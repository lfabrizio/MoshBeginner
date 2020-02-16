using system;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals, "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            Console.WriteLine(directory);

    var directoryInfo = new directoryInfo("...");
    directoryInfo.GetFiles();
    directoryInfo.GetDirectories();

        }
    }
}