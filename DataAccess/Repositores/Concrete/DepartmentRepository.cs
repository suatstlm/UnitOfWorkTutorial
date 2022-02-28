using DataAccess;
using DataAccess.Abstract;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PersonnelContext context) : base(context)
        {

        }

        public IEnumerable<Department> GetDepartmensWithPersonnels(int count)
        {
            return PersonnelContext.Departmentts.Include("Personnels").ToList();
        }

        public IEnumerable<Department> GetTopDepartmens(int count)
        {
            return PersonnelContext.Departmentts.Take(count).ToList();
        }

        public PersonnelContext PersonnelContext { get { return _context as PersonnelContext; } }
    }
}
