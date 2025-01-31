using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class UnitOfWork : IDisposable
    {
        private HRDbContext context = new HRDbContext();

        private GenericRepository<Employee> employeeRepository;
        private GenericRepository<Position> positionRepository;
        private GenericRepository<Contract> contractRepository;




        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {

                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new GenericRepository<Employee>(context);
                }
                return employeeRepository;
            }
        }

        public GenericRepository<Position> PositionRepository
        {
            get
            {

                if (this.positionRepository == null)
                {
                    this.positionRepository = new GenericRepository<Position>(context);
                }
                return positionRepository;
            }
        }


        public GenericRepository<Contract> ContractRepository
        {
            get
            {

                if (this.contractRepository == null)
                {
                    this.contractRepository = new GenericRepository<Contract>(context);
                }
                return contractRepository;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
