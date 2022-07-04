using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitCreation creation = new UnitCreation();
            List<Unit> army =  creation.CreatingUnits();

            foreach (var item in army)
            {
                item.Print();
            }

            CostArmy(army);
            Console.WriteLine("\n");
            SortArmy(army);
            Console.WriteLine("\n");
            Search(army);

        }        
        static void CostArmy(List<Unit> army)
        {
            int result = 0;
            foreach (var item in army)
            {
                result += item.Cost;
            }
            Console.WriteLine($"\nCost Army: {result}");
        }
        static void SortArmy(List<Unit> army)
        {
            Console.WriteLine("Army sorting by damage and heal:");
            List<Unit> sortArmy = army;
            
            sortArmy.Sort();


            foreach (var item in sortArmy)
            {
                item.Print();
            }
        }
        static void Search(List<Unit> units)
        {
            UserInput userInput = new UserInput();
            Console.WriteLine("Enter the search range in the army for health");
            Console.WriteLine("enter the starting value:");
            int first = userInput.InputNumber();
            Console.WriteLine("enter and value:");
            int last = userInput.InputNumber();

            List<Unit> searchesUnit;
            searchesUnit = units.FindAll(x => (x.Health < last && x.Health > first));
            foreach (var unit in searchesUnit)
            {
                unit.Print();
            }
        }
    }
}