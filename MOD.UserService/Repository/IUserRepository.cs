using MOD.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Repository
{
    public interface IUserRepository
    {

        void AddUser(User item);
        List<User> GetAll();
        User GetById(long id);
        void UpdateUser(User item);
        void DeleteUser(long id);

        //------------------SEARCH MENTOR

        List<Mentor> SearchMentor(string Skill);

        void BlockUser(long id);
        void UnBlockUser(long id);



    }
}
