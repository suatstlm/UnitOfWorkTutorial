using Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PersonnelContext : DbContext
    {
        public PersonnelContext() : base("PersonnelContext")
        {

        }
        public DbSet<Department> Departmentts { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
    }
}
