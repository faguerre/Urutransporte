using System;
using System.Collections.Generic;
using Urutransporte.BusinessLogic.Interface;
using Urutransporte.DataAccess.Interface;
using Urutransporte.Domain;
using Urutransporte.Utils;

namespace Urutransporte.BusinessLogic
{
    public class TransporterLogic : IBusinessLogic<Transporter>
    {

        private readonly IUnitOfWork _unitOfWork;

        public TransporterLogic(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public Result<Transporter> Add(Transporter entity)
        {
            throw new NotImplementedException();
        }

        public Result<Transporter> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Func<Transporter, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Result<Transporter> Get(int id)
        {
            Transporter ret = _unitOfWork.TransporterRepository.Get(id);
            if(ret != null) {
                return new Result<Transporter> () {
                    ResultObject = ret
                };
            }else{
                return new Result<Transporter> () {
                    Message = "There is no Transporter related to the id " + id
                };
            }
        }

        public IEnumerable<Transporter> GetAll()
        {
            IEnumerable<Transporter> ret = _unitOfWork.TransporterRepository.GetAll();
            return ret;
        }

        public Result<Transporter> Update(int id, Transporter entity)
        {
            throw new NotImplementedException();
        }
    }
}
