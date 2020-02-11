using system;

namespace CSharpFundamentals
{
    public class StringUtility
    {
         publie static string SummerizeText(string text, int maxLength = 20)
        {
 
            if(text.Length < maxLength)
             return text;
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    totalCharacters += word.length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }
                String.Join(" ", summaryWords) + "...";
                return summary;
            }
        }
    }
}