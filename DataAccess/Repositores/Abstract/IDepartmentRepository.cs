using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        IEnumerable<Department> GetTopDepartmens(int count);
        IEnumerable<Department> GetDepartmensWithPersonnels(int count);
    }
}
