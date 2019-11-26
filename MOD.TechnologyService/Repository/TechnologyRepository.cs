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
            try
            {
                _context.Technology.Add(item);
                _context.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
       
        }

        public void DeleteTechnology(long id)
        {
            try
            {
                var item = _context.Technology.Find(id);
                _context.Technology.Remove(item);
                _context.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
 

        }

        public List<Technology> GetAll()
        {
            try
            {
                return _context.Technology.ToList();
            }

            catch (Exception)
            {
                throw;
            }
        
        }

        public Technology GetById(long id)
        {
            try
            {
                return _context.Technology.Find(id);
            }

            catch (Exception)
            {
                throw;
            }
           

        }

        public void UpdateTechnology(Technology item)
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
      

        public void BlockTechnology(long Id)
        {

        }


    }
}
