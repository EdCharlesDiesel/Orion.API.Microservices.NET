using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orion.Admin.Models.Employees
{
    public class EmployeesListViewModel
    {
        public IEnumerable<EmployeeInfosViewModel> Items { get; set; }
    }
}
