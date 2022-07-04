using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Support : Unit, IComparable<Support>
    {
        public int Heal { get; set; }
        public Support(string name, int heal, int health, int cost) : base(name, health, cost)
        {
            Heal = heal;
        }
        public int CompareTo(Support? support)
        {
            return Heal.CompareTo(support.Heal);
        }
        public override int CompareTo(Unit unit)
        {
            if (unit is Support support)
            {
                return CompareTo(support);
            }
            else if(unit is Warrior warrior)
            {
                return warrior.CompareTo(warrior);
            }
            else
            {
                return base.CompareTo(unit);
            }
            
        }
        public override void Print()
        {
            Console.Write($"Heal = {Heal}, ");
            base.Print();

        }
    }
}
