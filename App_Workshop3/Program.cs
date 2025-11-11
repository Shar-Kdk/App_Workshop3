namespace App_Workshop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 1: Operators ===");
            Operators op = new Operators();
            op.Add(5, 3);
            op.Subtract(5, 3);
            op.Multiply(5, 3);
            op.Divide(8, 4);
            op.OddEvenFinder(7);
            Console.WriteLine();

            Console.WriteLine("\n=== Task 2: Null Operations ===");
            NullOperations nullOps = new NullOperations();
            nullOps.PerformNullChecks();
            Console.WriteLine();


        }
    }
}
