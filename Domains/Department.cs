using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class Department : BaseEntitty
    {
        public Department()
        {
            Personnel = new List<Personnel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Personnel> Personnel { get; set; }
    }
}
