using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Abstract
{
    public interface IExpeditionRepository : IRepository<Expedition>
    {
        List<Expedition> GetExpeditionRoute(string startTerminal, string endTerminal, string date);
        Expedition GetExpeditionDetails(int id);
    }
}
