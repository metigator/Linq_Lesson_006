using LINQTut06.Shared;
using System;
using System.Linq;

namespace LINQTut06.Take
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();

            var q1 = emps.Take(10);

            q1.Print("take First 10 employees");


            var q2 = emps.TakeWhile(x => x.Salary != 214400);
            q2.Print("take while salary does not equal 214,400");

            var q3 = emps.TakeLast(10);
            q3.Print("take last 10 elements");

            Console.ReadKey();
        }
    }
}
