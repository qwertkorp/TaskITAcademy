namespace Task3
{
    public class Warrior : Unit, IComparable<Warrior>
    {
        public int Damage { get; set; }
        public Warrior(string name, int damage, int health, int cost) : base(name, health, cost)
        {
            Damage = damage;
        }
        public int CompareTo(Warrior? warrior)
        {
            return Damage.CompareTo(warrior.Damage);
        }
        
        public override void Print()
        {
            Console.Write($"Damage = {Damage}, ");
            base.Print();

        }
    }
    



}
