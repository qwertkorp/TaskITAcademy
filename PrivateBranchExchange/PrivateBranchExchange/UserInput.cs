using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateBranchExchange
{
    internal class UserInput
    {
        public string InputName()
        {
            Console.WriteLine("Enter your name");
            string inputName;
            inputName = Console.ReadLine();
            if(inputName == null && inputName.Replace(" ", "") == "")
            {
                inputName = "No name";
            }
            return inputName;
        }
        public int InputTariff()
        {
            Console.WriteLine("Сhoose a tariff{Light = clic(1),Medium = clic(2),Max = clic(3)}");
            TariffPlan plan = new TariffPlan();            
            ConsoleKeyInfo inputKey;
            inputKey = Console.ReadKey();
            bool repeat = true;
            int result = 0;
            while (repeat)
            {
                ConsoleKey key = inputKey.Key;

                if (key == ConsoleKey.D1)
                {
                    result = plan.TariffLight;
                    repeat = false;
                }
                else if (key == ConsoleKey.D2)
                {
                    result = plan.TariffMedium;
                    repeat = false;
                }
                else if(key == ConsoleKey.D3)
                {
                    result = plan.TariffMax;
                    repeat = false;
                }
                else
                {
                    repeat = true;
                }
            }
            return result;
        }
        
        
    }
}
