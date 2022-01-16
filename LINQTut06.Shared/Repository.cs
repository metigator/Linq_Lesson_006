
using System;
using System.Collections.Generic; 

namespace LINQTut06.Shared
{
    public static class Repository
    {

        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                     Index = 1,
                     EmployeeNo = "2017-FI-8516",
                     Name = "Cochran Cole",
                     Email = "Cole.Cochran@example.com",
                     Salary = 103200,
                     Skills = new() {"Javascript" , "NodeJS"  }
                },
                new Employee
                {
                     Index = 2,
                     EmployeeNo = "2018-FI-4815",
                     Name = "Jaclyn Wolfe",
                     Email = "Wolfe.Jaclyn@example.com",
                     Salary = 192400,
                     Skills = new() {"C++" , "Javascript" , "Oracle"  }
                },
                new Employee
                {
                     Index = 3,
                     EmployeeNo = "2016-IT-1329",
                     Name = "Warner Jones",
                     Email = "Jones.Warner@example.com",
                     Salary = 172800,
                     Skills = new() {"NodeJS" , "C++"  }
                },
                new Employee
                {
                     Index = 4,
                     EmployeeNo = "2016-FI-8336",
                     Name = "Hester Evans",
                     Email = "Evans.Hester@example.com",
                     Salary = 155500,
                     Skills = new() {"C++" , "SQL Server"  }
                },
                new Employee
                {
                     Index = 5,
                     EmployeeNo = "2014-IT-3129",
                     Name = "Wallace Buck",
                     Email = "Buck.Wallace@example.com",
                     Salary = 315800,
                     Skills = new() {"HTML" , "ASP.NET" , "NodeJS"  }
                },
                new Employee
                {
                     Index = 6,
                     EmployeeNo = "2020-IT-6518",
                     Name = "Acevedo Wall",
                     Email = "Wall.Acevedo@example.com",
                     Salary = 343700,
                     Skills = new() {"Oracle" , "Javascript" , "C++" , "NodeJS"  }
                },
                new Employee
                {
                     Index = 7,
                     EmployeeNo = "2021-IT-8443",
                     Name = "Jacqueline Pickett",
                     Email = "Pickett.Jacqueline@example.com",
                     Salary = 370000,
                     Skills = new() {"CSS" , "NodeJS" , "HTML"  }
                },
                new Employee
                {
                     Index = 8,
                     EmployeeNo = "2017-HR-1202",
                     Name = "Oconnor Espinoza",
                     Email = "Espinoza.Oconnor@example.com",
                     Salary = 155600,
                     Skills = new() {"Oracle" , "C++" , "SQL Server" , "HTML" , "CSS"  }
                },
                new Employee
                {
                     Index = 9,
                     EmployeeNo = "2020-AC-1097",
                     Name = "Allie Elliott",
                     Email = "Elliott.Allie@example.com",
                     Salary = 315400,
                     Skills = new() {"C++"  }
                },
                new Employee
                {
                     Index = 10,
                     EmployeeNo = "2016-HR-3735",
                     Name = "Elva Decker",
                     Email = "Decker.Elva@example.com",
                     Salary = 345900,
                     Skills = new() {"CSS"  }
                },
                new Employee
                {
                     Index = 11,
                     EmployeeNo = "2020-HR-1618",
                     Name = "Hayes Beasley",
                     Email = "Beasley.Hayes@example.com",
                     Salary = 372700,
                     Skills = new() {"Javascript" , "C++"  }
                },
                new Employee
                {
                     Index = 12,
                     EmployeeNo = "2015-FI-4476",
                     Name = "Florine Cervantes",
                     Email = "Cervantes.Florine@example.com",
                     Salary = 338700,
                     Skills = new() {"NodeJS" , "C++" , "CSS" , "HTML" , "SQL Server"  }
                },
                new Employee
                {
                     Index = 13,
                     EmployeeNo = "2017-AC-6435",
                     Name = "Bullock Carney",
                     Email = "Carney.Bullock@example.com",
                     Salary = 214400,
                     Skills = new() {"ASP.NET" , "CSS" , "HTML"  }
                },
                new Employee
                {
                     Index = 14,
                     EmployeeNo = "2021-FI-5719",
                     Name = "Carroll Cantu",
                     Email = "Cantu.Carroll@example.com",
                     Salary = 343200,
                     Skills = new() {"NodeJS" , "C++" , "Oracle"  }
                },
                new Employee
                {
                     Index = 15,
                     EmployeeNo = "2019-IT-9095",
                     Name = "Debra Hogan",
                     Email = "Hogan.Debra@example.com",
                     Salary = 249100,
                     Skills = new() {"CSS" , "C#" , "C++" , "NodeJS" , "SQL Server"  }
                },
                new Employee
                {
                     Index = 16,
                     EmployeeNo = "2019-IT-5252",
                     Name = "Winnie Mccall",
                     Email = "Mccall.Winnie@example.com",
                     Salary = 287300,
                     Skills = new() {"NodeJS"  }
                },
                new Employee
                {
                     Index = 17,
                     EmployeeNo = "2015-IT-3783",
                     Name = "Manuela Berger",
                     Email = "Berger.Manuela@example.com",
                     Salary = 172500,
                     Skills = new() {"ASP.NET" , "Javascript" , "SQL Server"  }
                },
                new Employee
                {
                     Index = 18,
                     EmployeeNo = "2017-IT-2332",
                     Name = "Lakeisha Lowe",
                     Email = "Lowe.Lakeisha@example.com",
                     Salary = 314300,
                     Skills = new() {"ASP.NET" , "Oracle" , "C#" , "CSS" , "HTML"  }
                },
                new Employee
                {
                     Index = 19,
                     EmployeeNo = "2016-FI-4247",
                     Name = "Stewart Lott",
                     Email = "Lott.Stewart@example.com",
                     Salary = 146600,
                     Skills = new() {"Javascript"  }
                },
                new Employee
                {
                     Index = 20,
                     EmployeeNo = "2014-IT-4977",
                     Name = "Stafford Peck",
                     Email = "Peck.Stafford@example.com",
                     Salary = 320700,
                     Skills = new() {"Javascript" , "CSS" , "HTML" , "SQL Server"  }
                },
                new Employee
                {
                     Index = 21,
                     EmployeeNo = "2020-HR-9364",
                     Name = "Barron Bird",
                     Email = "Bird.Barron@example.com",
                     Salary = 151200,
                     Skills = new() {"SQL Server" , "ASP.NET"  }
                },
                new Employee
                {
                     Index = 22,
                     EmployeeNo = "2015-IT-3776",
                     Name = "Nona Brooks",
                     Email = "Brooks.Nona@example.com",
                     Salary = 136500,
                     Skills = new() {"Oracle" , "NodeJS" , "Javascript" , "CSS"  }
                },
                new Employee
                {
                     Index = 23,
                     EmployeeNo = "2014-IT-5660",
                     Name = "Clara Reeves",
                     Email = "Reeves.Clara@example.com",
                     Salary = 245800,
                     Skills = new() {"ASP.NET" , "HTML" , "C#"  }
                },
                new Employee
                {
                     Index = 24,
                     EmployeeNo = "2018-IT-3051",
                     Name = "Karin Blanchard",
                     Email = "Blanchard.Karin@example.com",
                     Salary = 341200,
                     Skills = new() {"Oracle" , "Javascript" , "CSS" , "ASP.NET" , "HTML"  }
                },
                new Employee
                {
                     Index = 25,
                     EmployeeNo = "2019-AC-8619",
                     Name = "Burris Morgan",
                     Email = "Morgan.Burris@example.com",
                     Salary = 360300,
                     Skills = new() {"HTML" , "CSS" , "Javascript"  }
                },
                new Employee
                {
                     Index = 26,
                     EmployeeNo = "2021-IT-7779",
                     Name = "Owen Cortez",
                     Email = "Cortez.Owen@example.com",
                     Salary = 193700,
                     Skills = new() {"Oracle" , "NodeJS" , "C++"  }
                },
                new Employee
                {
                     Index = 27,
                     EmployeeNo = "2016-AC-6545",
                     Name = "Letha Finch",
                     Email = "Finch.Letha@example.com",
                     Salary = 357200,
                     Skills = new() {"NodeJS" , "Javascript" , "CSS" , "C#" , "HTML"  }
                },
                new Employee
                {
                     Index = 28,
                     EmployeeNo = "2016-AC-4450",
                     Name = "Sondra Rojas",
                     Email = "Rojas.Sondra@example.com",
                     Salary = 309700,
                     Skills = new() {"CSS"  }
                },
                new Employee
                {
                     Index = 29,
                     EmployeeNo = "2020-HR-5396",
                     Name = "Hoover Cook",
                     Email = "Cook.Hoover@example.com",
                     Salary = 282200,
                     Skills = new() {"C++" , "C#" , "Javascript"  }
                },
                new Employee
                {
                     Index = 30,
                     EmployeeNo = "2021-AC-7859",
                     Name = "Wanda Bender",
                     Email = "Bender.Wanda@example.com",
                     Salary = 294200,
                     Skills = new() {"ASP.NET" , "SQL Server"  }
                },
                new Employee
                {
                     Index = 31,
                     EmployeeNo = "2020-AC-4905",
                     Name = "Sanford Craig",
                     Email = "Craig.Sanford@example.com",
                     Salary = 278200,
                     Skills = new() {"C++" , "ASP.NET"  }
                },
                new Employee
                {
                     Index = 32,
                     EmployeeNo = "2021-FI-4586",
                     Name = "Christy Middleton",
                     Email = "Middleton.Christy@example.com",
                     Salary = 377400,
                     Skills = new() {"Javascript" , "SQL Server" , "Oracle"  }
                },
                new Employee
                {
                     Index = 33,
                     EmployeeNo = "2019-HR-4126",
                     Name = "Day Brady",
                     Email = "Brady.Day@example.com",
                     Salary = 142600,
                     Skills = new() {"C#"  }
                },
                new Employee
                {
                     Index = 34,
                     EmployeeNo = "2014-FI-5651",
                     Name = "Powers Beard",
                     Email = "Beard.Powers@example.com",
                     Salary = 224000,
                     Skills = new() {"CSS" , "Oracle"  }
                },
                new Employee
                {
                     Index = 35,
                     EmployeeNo = "2017-FI-3279",
                     Name = "Arline Pratt",
                     Email = "Pratt.Arline@example.com",
                     Salary = 360300,
                     Skills = new() {"Oracle"  }
                },
                new Employee
                {
                     Index = 36,
                     EmployeeNo = "2017-AC-7841",
                     Name = "Sharpe Cardenas",
                     Email = "Cardenas.Sharpe@example.com",
                     Salary = 266100,
                     Skills = new() {"HTML" , "C++" , "NodeJS" , "CSS" , "C#"  }
                },
                new Employee
                {
                     Index = 37,
                     EmployeeNo = "2020-AC-4489",
                     Name = "Madeleine Stanton",
                     Email = "Stanton.Madeleine@example.com",
                     Salary = 198300,
                     Skills = new() {"HTML" , "Javascript" , "SQL Server"  }
                },
                new Employee
                {
                     Index = 38,
                     EmployeeNo = "2014-FI-5748",
                     Name = "Spears Noble",
                     Email = "Noble.Spears@example.com",
                     Salary = 176300,
                     Skills = new() {"ASP.NET" , "C++"  }
                },
                new Employee
                {
                     Index = 39,
                     EmployeeNo = "2021-IT-6984",
                     Name = "Gonzalez Gilliam",
                     Email = "Gilliam.Gonzalez@example.com",
                     Salary = 394300,
                     Skills = new() {"SQL Server" , "C++" , "CSS" , "C#"  }
                },
                new Employee
                {
                     Index = 40,
                     EmployeeNo = "2018-FI-4000",
                     Name = "Abigail Bradford",
                     Email = "Bradford.Abigail@example.com",
                     Salary = 296100,
                     Skills = new() {"C#" , "ASP.NET" , "SQL Server" , "C++"  }
                },
                new Employee
                {
                     Index = 41,
                     EmployeeNo = "2020-IT-3146",
                     Name = "Ashlee Farmer",
                     Email = "Farmer.Ashlee@example.com",
                     Salary = 125300,
                     Skills = new() {"ASP.NET" , "C++"  }
                },
                new Employee
                {
                     Index = 42,
                     EmployeeNo = "2014-IT-7834",
                     Name = "Glover Lloyd",
                     Email = "Lloyd.Glover@example.com",
                     Salary = 123000,
                     Skills = new() {"HTML" , "Oracle"  }
                },
                new Employee
                {
                     Index = 43,
                     EmployeeNo = "2018-IT-9589",
                     Name = "Cleo Mays",
                     Email = "Mays.Cleo@example.com",
                     Salary = 214900,
                     Skills = new() {"HTML" , "CSS"  }
                },
                new Employee
                {
                     Index = 44,
                     EmployeeNo = "2021-IT-4204",
                     Name = "Patrice House",
                     Email = "House.Patrice@example.com",
                     Salary = 124500,
                     Skills = new() {"C++"  }
                },
                new Employee
                {
                     Index = 45,
                     EmployeeNo = "2015-AC-3311",
                     Name = "Atkins Shannon",
                     Email = "Shannon.Atkins@example.com",
                     Salary = 136600,
                     Skills = new() {"SQL Server" , "HTML" , "Oracle"  }
                },
                new Employee
                {
                     Index = 46,
                     EmployeeNo = "2016-AC-4280",
                     Name = "Luisa Hopkins",
                     Email = "Hopkins.Luisa@example.com",
                     Salary = 192900,
                     Skills = new() {"C++" , "ASP.NET"  }
                },
                new Employee
                {
                     Index = 47,
                     EmployeeNo = "2016-IT-6226",
                     Name = "Kaufman Gross",
                     Email = "Gross.Kaufman@example.com",
                     Salary = 223600,
                     Skills = new() {"C++"  }
                },
                new Employee
                {
                     Index = 48,
                     EmployeeNo = "2014-HR-6441",
                     Name = "William Clay",
                     Email = "Clay.William@example.com",
                     Salary = 237500,
                     Skills = new() {"Oracle" , "C++" , "Javascript"  }
                },
                new Employee
                {
                     Index = 49,
                     EmployeeNo = "2014-IT-9876",
                     Name = "Alison Kirby",
                     Email = "Kirby.Alison@example.com",
                     Salary = 354800,
                     Skills = new() {"ASP.NET"  }
                },
                new Employee
                {
                     Index = 50,
                     EmployeeNo = "2014-AC-1273",
                     Name = "Morrow Lynch",
                     Email = "Lynch.Morrow@example.com",
                     Salary = 281400,
                     Skills = new() {"NodeJS" , "C++"  }
                }
            };
        } 
    }
}
