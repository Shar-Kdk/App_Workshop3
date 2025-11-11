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

            Console.WriteLine("\n=== Task 3: If-Else ===");
            AgeChecker ageChecker = new AgeChecker();
            ageChecker.CheckAge();
            Console.WriteLine();

            Console.WriteLine("\n=== Task 4: Switch ===");
            DayFinder dayFinder = new DayFinder();
            dayFinder.FindDay();
            Console.WriteLine();

            Console.WriteLine("\n=== Task 5: Loops ===");
            Loops loops = new Loops();
            loops.RunLoops();
            Console.WriteLine();

            Console.WriteLine("\n=== Task 6: Try Catch Finally ===");
            ExceptionHandling exceptionHandling = new ExceptionHandling();
            exceptionHandling.RunExceptionTasks();
        }
    }
}
