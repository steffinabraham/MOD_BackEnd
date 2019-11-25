using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.UserService.Models;
using MOD.UserService.Repository;

namespace MOD.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        [Route("GetAll")]
        public List<Mentor> Get()
        {
            return _repository.GetAll();
        }






        [HttpGet("{id}", Name = "Get")]
        [Route("GetById/{id}")]
        public Mentor Get(long id)
        {
            return _repository.GetById(id);
        }


        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Mentor item)
        {
            _repository.AddMentor(item);
            return Ok("Record Added");
        }


        [HttpPut("{id}")]
        [Route("Update")]

        public void Put(Mentor item)
        {
            _repository.UpdateMentor(item);
        }


        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(long id)
        {
            _repository.DeleteMentor(id);
        }

        [HttpPut("{id}")]
        [Route("BlockMentor/{id}")]
        public void Block(long id)
        {
            _repository.BlockMentor(id);
        }

        [HttpPut("{id}")]
        [Route("UnBlockMentor/{id}")]
        public void UnBlock(long id)
        {
            _repository.UnBlockMentor(id);
        }

    }
}

