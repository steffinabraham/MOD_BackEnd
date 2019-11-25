using MOD.TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Repository
{
    public interface ITechnologyRepository
    {
        void AddTechnology(Technology item);
        List<Technology> GetAll();
        Technology GetById(long id);
        void UpdateTechnology(Technology item);
        void DeleteTechnology(long id);
        void BlockTechnology(long id);

    }
}
