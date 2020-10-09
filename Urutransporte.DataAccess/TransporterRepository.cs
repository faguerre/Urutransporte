using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Urutransporte.DataAccess.Interface;
using Urutransporte.Domain;

namespace Urutransporte.DataAccess
{
    public class TransporterRepository : IRepository<Transporter>
    {
        private DbContext dbContext;

        public TransporterRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(Transporter entity)
        {
            dbContext.Set<Transporter>().Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Func<Transporter, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Transporter Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transporter> GetAll()
        {
           IEnumerable<Transporter> transporters = dbContext.Set<Transporter>().ToList();
           return transporters;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Transporter entity)
        {
            throw new NotImplementedException();
        }
    }
}
