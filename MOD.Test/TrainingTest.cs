
using MOD.TrainingService.Models;
using MOD.TrainingService.Controllers;
using MOD.TrainingService.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MOD.Test
{
    public class TrainingTest
    {
        private readonly Mock<ITrainingRepository> _repo;
        private readonly TrainingController _controller;

        public TrainingTest()
        {
            _repo = new Mock<ITrainingRepository>();
            _controller = new TrainingController(_repo.Object);

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

  


        private List<Training> GetTechnologies()
        {
            return new List<Training>()
            {
                new Training(){SkillId=1, TrainingId = 1},
                new Training(){SkillId=2, TrainingId = 2},
                new Training(){SkillId=3, TrainingId = 3}

            };
        }
    }
}
