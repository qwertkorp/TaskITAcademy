using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task4
{
    public class WordsInAlphabeticalOrder
    {
        public void WordSorting(List<string> file)
        {
            for (int i = 0; i < file.Count; i++)
            {
                file[i] = file[i].ToLower();
            }
            string path = @"Documents\TextWordSorting.txt";
            var files = file.GroupBy(x => x).Select(x => new { Word = x.Key, Count = x.Count() }).OrderBy(x => x.Word);
            using (var sw2 = new StreamWriter(path, false))
            {
                foreach (var str in files)
                {
                    sw2.WriteLine(str.Word + "---" + str.Count);
                }
            }
        }        
    }
}
