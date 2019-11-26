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
            try
            {
                _context.User.Add(item);
                _context.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
    
        }

        public void DeleteUser(long id)
        {
            try
            {
                var item = _context.User.Find(id);
                _context.User.Remove(item);
                _context.SaveChanges();

            }

            catch (Exception)
            {
                throw;
            }

        }

        public List<User> GetAll()
        {
            try
            {
                return _context.User.ToList();
            }

            catch (Exception)
            {
                throw;
            }
        
        }

        public User GetById(long id)
        {
            try
            {
                return _context.User.Find(id);
            }

            catch (Exception)
            {
                throw;
            }
       

        }

        public void UpdateUser(User item)
        {
            try
            {
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
        
        }

        public void UpdateUserPassword(User item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
       
        }


        //------------------SEARCH MENTOR

        public List<Mentor> SearchMentor(string Skill)
        {
            try
            {
                //return _context.Mentors.Find(MentorSkills);
                return _context.Mentor.Where(i => i.MentorSkills == Skill).ToList();
            }

            catch (Exception)
            {
                throw;
            }


        }

        //------------------BLOCK USER

        public void BlockUser(long Id)
        {
            try
            {
                var item = _context.User.Find(Id);
                if (item.Active == true)
                {
                    item.Active = !(item.Active);

                }
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }

        }

        public void UnBlockUser(long Id)
        {
            try
            {
                var item = _context.User.Find(Id);
                if (item.Active == false)
                {
                    item.Active = !(item.Active);

                }
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
  
        }
    }
}
