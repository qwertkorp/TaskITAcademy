using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class UserInput
    {
        public ConsoleKey Keystroke()
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey();
            return key.Key;
        }
        public int InputNumber()
        {
            int enteredNamber;
            while (!int.TryParse(Console.ReadLine(), out enteredNamber) || enteredNamber < 0 || enteredNamber > int.MaxValue)
            {
                Console.WriteLine("An invalid character or a negative number has been entered. Enter again");
            }
            return enteredNamber;
        }
        public string InputString()
        {
            string enteredString;
            enteredString = Console.ReadLine();
            if (enteredString.Replace(" ", "") == "")
            {
                enteredString = "NO NAME";
            }

            return enteredString;

        }
    }
}
