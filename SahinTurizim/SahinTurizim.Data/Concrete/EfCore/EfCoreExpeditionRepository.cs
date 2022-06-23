using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SahinTurizim.Data.Abstract;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Concrete.EfCore
{
    public class EfCoreExpeditionRepository : EfCoreGenericRepository<Expedition, SahinTurizimContext>, IExpeditionRepository
    {
        public Expedition GetExpeditionDetails(int id)
        {
            using (var context=new SahinTurizimContext())
            {
                return context.Expeditions.Where(i => i.ExpeditionId == id).AsNoTracking().FirstOrDefault();
            }

        }
        public List<Expedition> GetExpeditionRoute(string startTerminal, string endTerminal, string date)
        {
            using (var contex = new SahinTurizimContext())
            {
                return contex.Expeditions
                    .Where(x => x.StartTerminal == startTerminal && x.EndTerminal == endTerminal&&x.Date==date).ToList();
            }

        }

      
    }
}
