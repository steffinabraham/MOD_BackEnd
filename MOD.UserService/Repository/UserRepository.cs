using Microsoft.EntityFrameworkCore;
using MOD.UserService.Context;
using MOD.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void AddUser(User item)
        {
            _context.User.Add(item);
            _context.SaveChanges();
        }

        public void DeleteUser(long id)
        {
            var item = _context.User.Find(id);
            _context.User.Remove(item);
            _context.SaveChanges();

        }

        public List<User> GetAll()
        {
            return _context.User.ToList();
        }

        public User GetById(long id)
        {
            return _context.User.Find(id);

        }

        public void UpdateUser(User item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateUserPassword(User item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }


        //------------------SEARCH MENTOR

        public List<Mentor> SearchMentor(string Skill)
        {
            //return _context.Mentors.Find(MentorSkills);
            return _context.Mentor.Where(i => i.MentorSkills == Skill).ToList();

        }

        //------------------BLOCK USER

        public void BlockUser(long Id)
        {
            var item = _context.User.Find(Id);
            if (item.Active == true)
            {
                item.Active = !(item.Active);

            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UnBlockUser(long Id)
        {
            var item = _context.User.Find(Id);
            if (item.Active == false)
            {
                item.Active =!(item.Active);

            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
