using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Urutransporte.BusinessLogic.Interface;
using Urutransporte.Domain;
using Urutransporte.Utils;

namespace Urutransporte.WebApi.Controllers
{
    [ApiController]
    [Route("api/transporters")]
    public class TransporterController : ControllerBase
    {
        private readonly IBusinessLogic<Transporter> _transporterLogic;

        public TransporterController(IBusinessLogic<Transporter> _logicTranporter)
        {
            _transporterLogic = _logicTranporter;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           Result<Transporter> transporterReturned = _transporterLogic.Get(id);
           if (transporterReturned != null) 
           {
               return Ok(transporterReturned.ResultObject);
           }else {
               return BadRequest(transporterReturned);
           } 
        }

        [HttpGet]
        public IActionResult GetAll()
        {
           IEnumerable<Transporter> transportersReturned = _transporterLogic.GetAll();
           if (transportersReturned != null) 
           {
               return Ok(transportersReturned);
           }else {
               return BadRequest("There are not transporters availables in the system.");
           } 
        }
    }
}
