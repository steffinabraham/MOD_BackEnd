using MOD.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Repository
{
    public interface ITrainingRepository
    {
        void AddTraining(Training item);

        void UpdateTraining(Training item);

        List<Training> GetTrainingByUserId(long id);
        List<Training> GetTrainingByMentorId(long id);
    }
}
