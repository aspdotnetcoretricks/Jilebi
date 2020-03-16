using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jilebi.Domain;

namespace Jilebi.Business
{
    public interface IEmployee
    {
        string GetEmployeeName(int EmpId);
        List<EmployeeDomainModel> getAllEmployeesList();
        string AddEditEmp(EmployeeDomainModel emp);
    }
}
