using BookApp.Models.Employee;
using BookApp.Models.Sales;
using System.Collections.Generic;

namespace BookApp.Data
{
    public interface IDataService
    {
        List<Employee> GetEmployees();
        IEnumerable<Sale> GetSales();
        List<Team> GetTeams();
    }
}
