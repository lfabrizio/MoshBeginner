using system;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText

            var fileInfo = new fileInfo(path);
            fileInfo.CopyTo("...");
            fileInfoDelete();
            if (fileInfo.Exists)
            {
                //
            }
            
        }
    }
}