using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.PaymentService.Models;
using MOD.PaymentService.Repository;

namespace MOD.PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _repository;

        public PaymentController(IPaymentRepository repository)
        {
            _repository = repository;
        }

        //// GET: api/Payment
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Payment/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Payment
        [HttpPost]
        [Route("Add")]
        public IActionResult Post(Payment item)
        {
            _repository.AddPayment(item);
            return Ok("Record Added");
        }

        //// PUT: api/Payment/5
        //[HttpPut("{id}")]
        //[Route("Update/{id}")]
        //public IActionResult Put(int id, [FromBody] Payment item)
        //{
        //    _repository.UpdatePayment(item);
        //    return Ok("Record Added");
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //[Route("DeletePayment/{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

