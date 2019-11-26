using Microsoft.EntityFrameworkCore;
using MOD.UserService.Context;
using MOD.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Repository
{
    public class MentorRepository : IMentorRepository
    {
        private readonly UserContext _context;
        public MentorRepository(UserContext context)
        {
            _context = context;
        }
        public void AddMentor(Mentor item)
        {
            try
            {
                _context.Mentor.Add(item);
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
         
        }

        public void DeleteMentor(long id)
        {
            try
            { 
            var item = _context.Mentor.Find(id);
            _context.Mentor.Remove(item);
            _context.SaveChanges();
        }
            catch(Exception)
            {
                throw;
            }


}

public List<Mentor> GetAll()
        {
            try
            {

            
            return _context.Mentor.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Mentor GetById(long id)
        {
            try
            { 
            return _context.Mentor.Find(id);
        }
            catch(Exception)
            {
                throw;
            }


}

        public void UpdateMentor(Mentor item)
        {
            try
            {
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }

            catch(Exception)
            {
                throw;
            }
       

        }
        public void UpdateMentorPassword(User item)
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
        ////To Search for mentor by user
        //public List<Mentor> SearchMentor(string MentorSkills)
        //{
        //    //return _context.Mentors.Find(MentorSkills);

        //    return _context.Mentor.Where(i => i.MentorSkills == MentorSkills).ToList();

        //}

        public void BlockMentor(long Id)
        {
            try
            {
                var item = _context.Mentor.Find(Id);
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

        public void UnBlockMentor(long Id)
        {
            try
            {
                var item = _context.Mentor.Find(Id);
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
