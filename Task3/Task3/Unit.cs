using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Unit
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Health { get; set; }
        public Unit(string name, int health, int cost)
        {
            Cost = cost;
            Name = name;
            Health = health;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name = {Name}, Cost = {Cost}, Health = {Health}");
        } 

    }
}
