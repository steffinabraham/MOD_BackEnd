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
            _context.Mentor.Add(item);
            _context.SaveChanges();
        }

        public void DeleteMentor(long id)
        {
            var item = _context.Mentor.Find(id);
            _context.Mentor.Remove(item);
            _context.SaveChanges();

        }

        public List<Mentor> GetAll()
        {
            return _context.Mentor.ToList();
        }

        public Mentor GetById(long id)
        {
            return _context.Mentor.Find(id);

        }

        public void UpdateMentor(Mentor item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void UpdateMentorPassword(User item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        ////To Search for mentor by user
        //public List<Mentor> SearchMentor(string MentorSkills)
        //{
        //    //return _context.Mentors.Find(MentorSkills);

        //    return _context.Mentor.Where(i => i.MentorSkills == MentorSkills).ToList();

        //}

        public void BlockMentor(long Id)
        {
            var item = _context.Mentor.Find(Id);
            if (item.Active == true)
            {
                item.Active = !(item.Active);

            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UnBlockMentor(long Id)
        {
            var item = _context.Mentor.Find(Id);
            if (item.Active == false)
            {
                item.Active = !(item.Active);

            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}
