using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCTutorial.Repository.Infrastructure;
using Jilebi.Repository.Infrastructure.Contract;

namespace Jilebi.Repository.Repositories
{
    public class EmployeeRepository: BaseRepository<Employee>
    {
        public EmployeeRepository(IUnitOfWork unitOfWork ):base(unitOfWork) { }
    }
}
