using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class Personnel : BaseEntitty
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
    }
}
