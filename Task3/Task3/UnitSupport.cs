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
       
        public override void Print()
        {
            Console.Write($"Heal = {Heal}, ");
            base.Print();

        }
    }
}
