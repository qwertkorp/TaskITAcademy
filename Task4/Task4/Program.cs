using System.Text.RegularExpressions;
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            ParseFile parseFile = new ParseFile();
            WordsInAlphabeticalOrder sortWords = new WordsInAlphabeticalOrder();
            WorkWithSearch workWithSearch = new WorkWithSearch();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Documents\sample.txt");
            StreamReader sr = new StreamReader(path);
            string sample = sr.ReadToEnd();
            

            List<string> parseTextSentences = parseFile.ParseTextSentences(sample);
            List<string> parseTextWords = parseFile.ParseTextWords(sample);
            parseFile.ParseTextPunctuationMarks(sample);
            sortWords.WordSorting(parseTextWords);
            workWithSearch.LongestSentenceByNumberOfCharacters(parseTextSentences);
            workWithSearch.ShortestSentenceByNumberOfWords(parseTextSentences);
            workWithSearch.MostCommonLetter(parseTextWords);


        }

    }
}