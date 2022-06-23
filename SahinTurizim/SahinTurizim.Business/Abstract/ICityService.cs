using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.Business.Abstract
{
    public interface ICityService
    {
        City GetById(int id);
        List<City> GetAll();
        void Create(City entity);
        void Update(City entity);
        void Delete(City entity);

    }
}
