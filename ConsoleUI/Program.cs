using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            unitOfWork.DepartmentRepository.Add(new Domains.Department() { Name = "Bilgi işlem", IsActive = true, CreatedDate = DateTime.Now });
            unitOfWork.DepartmentRepository.Add(new Domains.Department() { Name = "Muhasebe", IsActive = true, CreatedDate = DateTime.Now });
            unitOfWork.Save();
        }
    }
}
