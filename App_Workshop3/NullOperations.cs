using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop3
{
    internal class NullOperations
    {
        public void PerformNullChecks()
        {
            string username = null;

            Console.WriteLine(username == null ? "Username is not available" : username);

            string result = username ?? "DefaultUser";
            Console.WriteLine($"Using ?? operator: {result}");

            username ??= "NewUser";
            Console.WriteLine($"After ??= assignment: {username}");
        }
    }
}
