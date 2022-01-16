
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut06.Shared
{
    public class Employee
    { 
        public int Index { get; set; }
        public string  EmployeeNo { get; set; }

        public string Name { get; set; } 
         
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public List<string> Skills { get; set; } = new List<string>();

         
        public override string ToString()
        {

            return
                    $"" +
                    $" {Index.ToString().PadLeft(3, '0')}\t" +
                    $" {EmployeeNo.PadRight(13, ' ')}\t" +
                    $" {Name.PadRight(20, ' ')}\t" +
                    $" {Email.PadRight(32, ' ')}\t" +
                    $" {String.Format("{0:C0}", Salary)}";

        }
    }

    
}
