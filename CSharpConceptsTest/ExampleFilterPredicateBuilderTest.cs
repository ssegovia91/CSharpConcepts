using CSharpConcepts.Examples;
using System;
using Xunit;

namespace CSharpConceptsTest
{
    public class ExampleFilterPredicateBuilderTest : ExampleFilterPredicateBuilder
    {
        [Fact]
        public async void GetFilteredEmployeesById_ReturnsEmployeeList_Test()
        {
            var result = await GetFilteredEmployees("12", "", "", "");

            Assert.NotNull(result);
        }

        [Fact]
        public async void GetFilteredEmployeesByFirstName_ReturnsEmployeeList_Test()
        {
            var result = await GetFilteredEmployees("", "Rozanne", "", "");

            Assert.NotNull(result);
        }

        [Fact]
        public async void GetFilteredEmployeesByLastName_ReturnsEmployeeList_Test()
        {
            var result = await GetFilteredEmployees("", "", "Emeney", "");

            Assert.NotNull(result);
        }

        [Fact]
        public async void GetFilteredEmployeesByState_ReturnsEmployeeList_Test()
        {
            var result = await GetFilteredEmployees("", "", "", "Kansas");

            Assert.NotNull(result);
        }
        
        [Fact]
        public async void GetFilteredEmployeesByStateAndLastName_ReturnsEmployeeList_Test()
        {
            var result = await GetFilteredEmployees("", "", "Chamberlain", "Kansas");

            Assert.NotNull(result);
        }
    }
}
