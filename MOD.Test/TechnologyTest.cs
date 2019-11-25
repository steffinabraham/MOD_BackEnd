using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MOD.TechnologyService.Repository;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MOD.Test
{
    public class TechnologyTest
    {
        private readonly Mock<ITechnologyRepository> _repo;
        private readonly TechnologyController _controller;

        public TechnologyTest()
        {
            _repo = new Mock<ITechnologyRepository>();
            _controller = new TechnologyController(_repo.Object);

        }

        [Fact]

        public void GetAllTest()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetTechnologies());
            var result = _controller.Get() as List<Technology>;
            Assert.Equal(3, result.Count);
        }
        [Fact]
        public void GetByIdTest()
        {
            _repo.Setup(m => m.GetById(1)).Returns(GetTechnologies()[0]);
            var result = _controller.Get(1) as Technology;
            Assert.Equal(1, result.SkillId);
            Assert.NotNull(result); 
        }

        [Fact]
        public void Post()
        {
            var item = GetTechnologies()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void Put()
        {
            var item = GetTechnologies()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.DeleteTechnology(It.IsAny<long>()));
            var result = _controller.Delete(2) as OkResult;
            Assert.NotNull(result);
        }

        [Fact]

   

        private List<Technology> GetTechnologies()
        {
            return new List<Technology>()
            {
                new Technology(){SkillId=1, SkillName = "Java"},
                new Technology(){SkillId=2, SkillName = "C++"},
                new Technology(){SkillId=3, SkillName = "Python"}

            };
        }
    }
}
