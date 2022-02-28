using DataAccess;
using DataAccess.Abstract;
using Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class PersonnelRepository : Repository<Personnel>, IPersonnelRepository
    {
        public PersonnelRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Personnel> GetPersonnelsDepartmens()
        {
            return PersonnelContext.Personnels.Include("Department").ToList();
        }
        public PersonnelContext PersonnelContext { get { return _context as PersonnelContext; } }
    }
}
