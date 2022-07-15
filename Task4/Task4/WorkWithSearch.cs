using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task4
{
    public class WorkWithSearch
    {
        private string path = @"Documents\DataFile.txt";
        
        public void LongestSentenceByNumberOfCharacters(List<string> file)
        {            
            var st = file.OrderBy(x => x.Length).ThenBy(x => x).LastOrDefault();
            using (var sw = new StreamWriter(path, false))
            {
                sw.WriteLine(st+"\n\n\n");
            }
        }
        public void ShortestSentenceByNumberOfWords(List<string> file)
        {
            string regex = @"[^a-zA-Z]+";
            var listOfList = new List<List<string>>();
            for (int i = 0; i < file.Count; i++)
            {
                listOfList.Add(Regex.Split(file[i], regex).ToList());
            }

            int minCount = listOfList.Min(x => x.Count);
            var files = listOfList.Find(x => x.Count == minCount);            
            using (var sw = new StreamWriter(path, true))
            {               
                sw.WriteLine(files.FirstOrDefault() + "\n\n\n");
            }
        }
        public void MostCommonLetter(List<string> file)
        {
            for(int i = 0; i < file.Count; i++)
            {
                file[i] = file[i].ToLower();
            }
                        
            var simbol = String.Join("", file).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count()).OrderBy(x => x.Value).LastOrDefault();
            using (var sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"{simbol.Key}---{simbol.Value}");
            }
            
            
        }
    }
}
