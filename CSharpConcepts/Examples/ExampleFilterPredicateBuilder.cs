using CSharpConcepts.ExtensionClasses;
using CSharpConcepts.MockedData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharpConcepts.Examples
{
    public class ExampleFilterPredicateBuilder : EmployeeData
    {
        private Func<EmployeeDTO, bool> BuildEmployeeFilterPredicate(string id, string firstName, string lastName, string state)
        {
            var pr = PredicateBuilder.True<EmployeeDTO>();

            if (!string.IsNullOrEmpty(id))
            {
                var employeeId = int.Parse(id);
                var innerId = PredicateBuilder.False<EmployeeDTO>();
                innerId = innerId.Or(p => p.IdEmployee == employeeId);
                pr = pr.And(innerId);
            }
            if (!string.IsNullOrEmpty(firstName))
            {
                var innerFirstName = PredicateBuilder.False<EmployeeDTO>();
                innerFirstName = innerFirstName.Or(p => p.EmployeeName == firstName);
                pr = pr.And(innerFirstName);
            }
            if (!string.IsNullOrEmpty(lastName))
            {
                var innerLastName = PredicateBuilder.False<EmployeeDTO>();
                innerLastName = innerLastName.Or(p => p.EmployeeLastName == lastName);
                pr = pr.And(innerLastName);
            }
            if (!string.IsNullOrEmpty(state))
            {
                var innerState = PredicateBuilder.False<EmployeeDTO>();
                innerState = innerState.Or(p => p.EmployeeState == state);
                pr = pr.And(innerState);
            }

            return pr.Compile();
        }

        public async Task<List<EmployeeDTO>> GetFilteredEmployees(string id, string firstName, string lastName, string state)
        {
            var filters = BuildEmployeeFilterPredicate(id, firstName, lastName, state);
            var employees = await EmployeeList();
            return employees.AsQueryable().Where(filters).ToList();

        }
    }
}
