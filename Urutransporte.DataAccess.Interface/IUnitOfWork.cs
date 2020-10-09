using System;
using Urutransporte.Domain;

namespace Urutransporte.DataAccess.Interface
{
    public interface IUnitOfWork
    {
        IRepository<Transporter> TransporterRepository {get;}

    }
}
