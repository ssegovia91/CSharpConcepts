using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.MockedData
{
    public class EmployeeData
    {
        public async Task<List<EmployeeDTO>> EmployeeList()
        {
            return await Task.Run(() =>
            {
                var employees = new List<EmployeeDTO>()
                {
                    new EmployeeDTO
                    { 
                        IdEmployee = 1,
                        EmployeeName ="Janel",
                        EmployeeLastName ="Lockner",
                        EmployeeState = "Oklahoma"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 2,
                        EmployeeName = "Marsha",
                        EmployeeLastName ="Stretton",
                        EmployeeState = "Florida"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 3,
                        EmployeeName = "Lulu",
                        EmployeeLastName ="Pruvost",
                        EmployeeState = "Texas"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 4,
                        EmployeeName = "Nikita",
                        EmployeeLastName ="Emeney",
                        EmployeeState = "California"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 5,
                        EmployeeName = "Robinet",
                        EmployeeLastName ="Huccaby",
                        EmployeeState = "Georgia"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 6,
                        EmployeeName = "Nichole",
                        EmployeeLastName ="Baiyle",
                        EmployeeState = "Ohio"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 7,
                        EmployeeName = "Odette",
                        EmployeeLastName ="Lawrinson",
                        EmployeeState = "Oklahoma"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 8,
                        EmployeeName = "Nil",
                        EmployeeLastName ="Stihl",
                        EmployeeState = "Kansas"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 9,
                        EmployeeName = "Rozanne",
                        EmployeeLastName ="Favell",
                        EmployeeState = "Washington"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 10,
                        EmployeeName = "Aubrette",
                        EmployeeLastName ="Emeney",
                        EmployeeState = "Florida"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 11,
                        EmployeeName = "Bartie",
                        EmployeeLastName ="Chamberlain",
                        EmployeeState = "Kansas"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 12,
                        EmployeeName = "Celisse",
                        EmployeeLastName ="Highton",
                        EmployeeState = "New Jersey"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 13,
                        EmployeeName = "Isahella",
                        EmployeeLastName ="Harbison",
                        EmployeeState = "Florida"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 14,
                        EmployeeName = "Cornie",
                        EmployeeLastName ="Chamberlain",
                        EmployeeState = "Kansas"
                    },
                    new EmployeeDTO
                    {
                        IdEmployee = 15,
                        EmployeeName = "Marylin",
                        EmployeeLastName ="Pendleton",
                        EmployeeState = "Tennessee"
                    }
                };

                return employees;

            });
        }
    }
}
