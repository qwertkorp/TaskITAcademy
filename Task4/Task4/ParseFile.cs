using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task4
{
    public class ParseFile
    {
        public List<string> ParseTextSentences(string sample)
        {
            string path = @"Documents\TextSentences.txt";
            string regex = @"(?<=[\.!\?])\s+|(,\s\d)";
            string sampleReplace = sample.Replace("\n", " ");
            var file = Regex.Split(sampleReplace, regex, RegexOptions.None).ToList();
            using (var sw = new StreamWriter(path, false))
            {
                foreach (var str in file)
                {
                    sw.WriteLine(str);
                }
            }
            return file;
        }
        public List<string> ParseTextWords(string sample)
        {
            string path = @"Documents\TextWords.txt";
            string regex = @"[^a-zA-Z]+";
            var file = Regex.Split(sample, regex).ToList();
            using (var sw = new StreamWriter(path, false))
            {
                foreach (var str in file)
                {
                    sw.WriteLine(str);
                }
            }
            return file;
        }
        public void ParseTextPunctuationMarks(string sample)
        {
            string path = @"Documents\TextPunctuationMarks.txt";
            string regex = @"\p{P}";
            var file = Regex.Matches(sample, regex);
            using (var sw3 = new StreamWriter(path, false))
            {
                foreach (var str in file)
                {
                    sw3.WriteLine(str);
                }
            }
            
        }
    }
}
