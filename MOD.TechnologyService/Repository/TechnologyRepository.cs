using MOD.TechnologyService.Context;
using MOD.TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Repository
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private readonly TechnologyContext _context;
        public TechnologyRepository(TechnologyContext context)
        {
            _context = context;
        }
        public void AddTechnology(Technology item)
        {
            _context.Technology.Add(item);
            _context.SaveChanges();
        }

        public void DeleteTechnology(long id)
        {
            var item = _context.Technology.Find(id);
            _context.Technology.Remove(item);
            _context.SaveChanges();

        }

        public List<Technology> GetAll()
        {
            return _context.Technology.ToList();
        }

        public Technology GetById(long id)
        {
            return _context.Technology.Find(id);

        }

        public void UpdateTechnology(Technology item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        //public void UpdateTechnologyPassword(User item)
        //{
        //    _context.Entry(item).State = EntityState.Modified;
        //    _context.SaveChanges();
        //}
        ////To Search for Technology by user
        //public List<Technology> SearchTechnology(string TechnologySkills)
        //{
        //    //return _context.Technologys.Find(TechnologySkills);

        //    return _context.Technology.Where(i => i.TechnologySkills == TechnologySkills).ToList();

        //}

        public void BlockTechnology(long Id)
        {

        }


    }
}
