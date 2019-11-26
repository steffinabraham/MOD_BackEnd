using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TrainingService.Models;
using MOD.TrainingService.Repository;

namespace MOD.TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _repository;

        public TrainingController(ITrainingRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Training
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public OkResult Put(Training item)
        {
            throw new NotImplementedException();
        }

        //// GET: api/Training/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Training
        [HttpPost]
        [Route("Add")]
        public IActionResult Post(Training item)
        {
            _repository.AddTraining(item);
            return Ok();
        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public IActionResult Put(int id, [FromBody] Training item)
        {
            _repository.UpdateTraining(item);
            return Ok("Record Added");
        }
        [HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingByUser/{id}")]
        public List<Training> Get(long id)
        {
            return _repository.GetTrainingByUserId(id);
        }

        [HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingByMentor/{id}")]
        public List<Training> GetbyMentor(int id)
        {
            return _repository.GetTrainingByMentorId(id);

        }

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //[Route("DeleteTraining/{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
