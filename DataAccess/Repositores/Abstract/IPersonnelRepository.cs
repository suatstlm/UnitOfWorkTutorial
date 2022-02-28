using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPersonnelRepository : IRepository<Personnel>
    {
        IEnumerable<Personnel> GetPersonnelsDepartmens();
    }
}
