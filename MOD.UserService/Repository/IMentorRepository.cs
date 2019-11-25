using MOD.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Repository
{
    public interface IMentorRepository
    {

        void AddMentor(Mentor item);
        List<Mentor> GetAll();
        Mentor GetById(long id);
        void UpdateMentor(Mentor item);
        void DeleteMentor(long id);
        void BlockMentor(long id);
        void UnBlockMentor(long id);


    }
}
