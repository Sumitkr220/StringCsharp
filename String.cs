using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sumit";
            Console.WriteLine("Hey " + name);
            string check = "Assumed not be Coder";
            Console.WriteLine(check.Contains("not"));

        }
    }
}
