using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Urutransporte.DataAccess.Interface;
using Urutransporte.Domain;

namespace Urutransporte.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext dbContext;

        public UnitOfWork (DbContext _dbContext) {
            dbContext = _dbContext;
        }
        
        private IRepository<Transporter> transporterRepository;

        public IRepository<Transporter> TransporterRepository
        {
            get
            {
                if (transporterRepository == null)
                {
                    transporterRepository = new TransporterRepository(dbContext);
                }
                return transporterRepository;
            }
        }
    }
}
