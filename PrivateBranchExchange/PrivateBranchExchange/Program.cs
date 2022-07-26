namespace PrivateBranchExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operator oper = new Operator();            
            oper.RunOperator();
            oper.AddClient();

        }
    }
}