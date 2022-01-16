using LINQTut06.Shared;
using System;
using System.Linq;

namespace LINQTut06.Chunck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();

            var chuncks = emps.Chunk(10).ToList();

            for (int i = 0; i < chuncks.Count; i++)
            {
                chuncks[i].Print($"Chunk #{i + 1}");
            }

            Console.ReadKey();
        }
    }
}
