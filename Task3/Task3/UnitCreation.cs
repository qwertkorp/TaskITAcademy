using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class UnitCreation
    {
       private UserInput userInput = new UserInput();
        public List<Unit> CreatingUnits()
        {            
            List<Unit> army = new List<Unit>();
            Console.WriteLine("Сreate units manually(Enter - 1),Load units from file(Enter - 2)\n");
            bool repeat = true;

            while (repeat)
            {
                ConsoleKey key = userInput.Keystroke();

                if (key == ConsoleKey.D1)
                {
                    army = CreatingUnitsYourself(army);
                    repeat = false;
                }
                else if (key == ConsoleKey.D2)
                {
                    LoadingUnitsFromFile(army);
                    repeat = false;
                }
                else
                {
                    repeat = true;
                }
            }
            return army;
        }
        private List<Unit> LoadingUnitsFromFile(List<Unit> units)
        {
            try
            {
                string[] lineSplit;
                string line;
                string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"FileUnits\UnitsWarrior.txt");
                string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"FileUnits\UnitsSupport.txt");

                StreamReader str1 = new StreamReader(path1);

                while ((line = str1.ReadLine()) != null)
                {
                    lineSplit = line.Split(',');
                    units.Add(new Warrior(lineSplit[0], int.Parse(lineSplit[1]), int.Parse(lineSplit[2]), int.Parse(lineSplit[3])));
                }

                var str2 = new StreamReader(path2);

                while ((line = str2.ReadLine()) != null)
                {
                    lineSplit = line.Split(',');
                    units.Add(new Support(lineSplit[0], int.Parse(lineSplit[1]), int.Parse(lineSplit[2]), int.Parse(lineSplit[3])));
                }
            }
            catch
            {
                Console.WriteLine("Oops something went wrong");
            }
            return units;
        }
        private List<Unit> CreatingUnitsYourself(List<Unit> army)
        {
            bool repeat = true;
            ConsoleKey key;

            while (repeat)
            {
                Console.WriteLine("\nSelect unit class: Warrior (click - 1), Support (click - 2)");

                while (repeat)
                {
                    key = userInput.Keystroke();

                    if (key == ConsoleKey.D1)
                    {
                        army.Add(CreatingWarrior());
                        repeat = false;
                    }
                    else if (key == ConsoleKey.D2)
                    {
                        army.Add(CreatingSupport());
                        repeat = false;
                    }
                    else
                    {
                        repeat = true;
                    }
                }

                Console.WriteLine("Want to create another?(Yes - Y)(NO - N)");

                while (!repeat)
                {
                    key = userInput.Keystroke();

                    if (key == ConsoleKey.Y)
                    {
                        repeat = true;
                    }
                    else if (key == ConsoleKey.N)
                    {
                        return army;
                    }
                    else
                    {
                        repeat = false;
                    }
                }


            }
            return army;

        }
        private Warrior CreatingWarrior()
        {
            Console.WriteLine("\nEnter name warrior: ");
            string name = userInput.InputString();
            Console.WriteLine("Enter his damage: ");
            int damage = userInput.InputNumber();
            Console.WriteLine("Enter his health: ");
            int health = userInput.InputNumber();
            Console.WriteLine("Enter his cost: ");
            int cost = userInput.InputNumber();
            Warrior warrior = new Warrior(name, damage, health, cost);


            return warrior;
        }
        private Support CreatingSupport()
        {

            Console.WriteLine("\nEnter name support: ");
            string name = userInput.InputString();
            Console.WriteLine("Enter his heal: ");
            int heal = userInput.InputNumber();
            Console.WriteLine("Enter his health: ");
            int health = userInput.InputNumber();
            Console.WriteLine("Enter his cost: ");
            int cost = userInput.InputNumber();
            Support support = new Support(name, heal, health, cost);


            return support;
        }        
    }
}
