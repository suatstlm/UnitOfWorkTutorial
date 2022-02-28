using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private PersonnelContext _personnelContext;
        public UnitOfWork(PersonnelContext context)
        {
            _personnelContext = context;

            DepartmentRepository = new DepartmentRepository(_personnelContext);
            PersonnelRepository = new PersonnelRepository(_personnelContext);
        }
        public IDepartmentRepository DepartmentRepository { get; private set; }

        public IPersonnelRepository PersonnelRepository {get; private set;}

        public void Dispose()
        {
            _personnelContext.Dispose();
        }

        public int Save()
        {
            return _personnelContext.SaveChanges();
        }
    }
}
